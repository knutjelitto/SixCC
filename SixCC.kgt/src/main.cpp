/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */
#define _CRT_SECURE_NO_WARNINGS

#define _POSIX_C_SOURCE 2
#define _XOPEN_SOURCE 500

#include <stdexcept>
#include <fstream>
#include <vector>

#include <assert.h>
#include <string.h>
#include <stdlib.h>
#include <stdio.h>

#include "getopt.h"

#include "txt.h"
#include "ast.h"
#include "parsing-error.h"
#include "rewrite.h"
#include "xalloc.h"
#include "rrd/node.h"

#include "bnf/io.h"
#include "blab/io.h"
#include "ebnfhtml5/io.h"
#include "wsn/io.h"
#include "abnf/io.h"
#include "iso-ebnf/io.h"
#include "rbnf/io.h"
#include "sid/io.h"
#include "dot/io.h"
#include "rrdot/io.h"
#include "rrdump/io.h"
#include "rrtdump/io.h"
#include "rrparcon/io.h"
#include "rrll/io.h"
#include "rrta/io.h"
#include "rrtext/io.h"
#include "svg/io.h"
#include "svghtml5/io.h"
#include "json/io.h"

int debug = 0;
int prettify = 1;
int allow_undefined = 1;
const char *css_file;

/*
 * emscripten's musl will call __wait from getopt() (via getopt_msg and
 * then flockfile), which is not present for standalone wasm because that
 * has no pthread support, and so a definition for __wait is not included.
 */
#ifdef __EMSCRIPTEN__
void __wait(int a, int b, int c, int d) { }
#endif

struct in_able
{
    std::string name;
    bool enabled;
    ast_rule* (*in)(int (*f)(void*), void*, parsing_errors*);
    std::vector<std::string> samples;
};

struct in_able inputable[] =
{
    { "bnf",        true,   bnf_input,      { "bnf.bnf", "expr.bnf", "postal.bnf" } },
    { "iso-ebnf",   true,   iso_ebnf_input, { "c99-grammar.iso-ebnf", "expr.iso-ebnf", "expr-minus.iso-ebnf", "iso-ebnf.iso-ebnf", "json.iso-ebnf" } },
    { "rbnf",       true,   rbnf_input,     { "expr.rbnf", "expr-minus.rbnf", "gmpls.rbnf" } },
    { "wsn",        true,   wsn_input,      { "bnf.wsn", "c_syntax.wsn", "wsn.wsn" } },
    { "abnf",       false,  abnf_input,     { "abnf.abnf", "datetime.abnf", "irc.abnf", "postal.abnf", "utf8.abnf" } },
};

struct out_able
{
    const char* name;
    int (*out)(const struct ast_rule*);
    ast_features ast_unsupported;
    rrd_features rrd_unsupported;
};

struct out_able outputable[] =
{
    { "abnf",       abnf_output,        (ast_features)0,                            (rrd_features)0 },
    { "blab",       blab_output,        (ast_features)blab_ast_unsupported,         (rrd_features)0 },
    { "bnf",        bnf_output,         (ast_features)bnf_ast_unsupported,          (rrd_features)0 },
    { "dot",        dot_output,         (ast_features)0,                            (rrd_features)0 },
    { "ebnf-html5", ebnf_html5_output,  (ast_features)ebnf_html5_ast_unsupported,   (rrd_features)0 },
    { "ebnf-xhtml5",ebnf_xhtml5_output, (ast_features)ebnf_html5_ast_unsupported,   (rrd_features)0 },
    { "svg-html5",  svg_html5_output,   (ast_features)0,                            (rrd_features)0 },
    { "svg-xhtml5", svg_xhtml5_output,  (ast_features)0,                            (rrd_features)0 },
    { "iso-ebnf",   iso_ebnf_output,    (ast_features)iso_ebnf_ast_unsupported,     (rrd_features)0 },
    { "json",       json_output,        (ast_features)json_ast_unsupported,         (rrd_features)0 },
    { "rbnf",       rbnf_output,        (ast_features)rbnf_ast_unsupported,         (rrd_features)0 },
    { "sid",        sid_output,         (ast_features)sid_ast_unsupported,          (rrd_features)0 },
    { "svg",        svg_output,         (ast_features)0,                            (rrd_features)0 },
    { "wsn",        wsn_output,         (ast_features)wsn_ast_unsupported,          (rrd_features)0 },
    { "rrdot",      rrdot_output,       (ast_features)0,                            (rrd_features)0 },
    { "rrdump",     rrdump_output,      (ast_features)0,                            (rrd_features)0 },
    { "rrll",       rrll_output,        (ast_features)rrll_ast_unsupported,         (rrd_features)rrll_rrd_unsupported     },
    { "rrparcon",   rrparcon_output,    (ast_features)rrparcon_ast_unsupported,     (rrd_features)rrparcon_rrd_unsupported },
    { "rrta",       rrta_output,        (ast_features)rrta_ast_unsupported,         (rrd_features)rrta_rrd_unsupported     },
    { "rrtdump",    rrtdump_output,     (ast_features)0,                            (rrd_features)0 },
    { "rrtext",     rrtext_output,      (ast_features)0,                            (rrd_features)0 },
    { "rrutf8",     rrutf8_output,      (ast_features)0,                            (rrd_features)0 },
};

static void xusage(void)
{
    printf("usage: kgt [-gnu] [-c <css-file>] [-w <whitelist>] [-l <language>] [ -e <language> ]\n");
    err_exit();
}

static int kgt_fgetc(void *opaque)
{
    FILE *f;

    f = (FILE*)opaque;

    assert(f != nullptr);

    return fgetc(f);
}

static struct in_able* inlang(std::string s)
{
    int i;

    for (i = 0; i < sizeof(inputable) / sizeof(*inputable); i++)
    {
        if (s == inputable[i].name)
        {
            return &inputable[i];
        }
    }

    fprintf(stderr, "Unrecognised input language \"%s\"; supported languages are:", s.c_str());

    for (i = 0; i < sizeof(inputable) / sizeof(*inputable); i++)
    {
        fprintf(stderr, " %s", inputable[i].name.c_str());
    }

    fprintf(stderr, "\n");

    err_exit();

    __assume(false);
    assert(!"unreached");
}

static struct out_able* outlang(const char* s)
{
    size_t i;

    for (i = 0; i < sizeof(outputable) / sizeof(*outputable); i++)
    {
        if (0 == strcmp(s, outputable[i].name))
        {
            return &outputable[i];
        }
    }

    fprintf(stderr, "Unrecognised output language \"%s\"; supported languages are:", s);

    for (i = 0; i < sizeof(outputable) / sizeof(*outputable); i++)
    {
        fprintf(stderr, " %s", outputable[i].name);
    }

    fprintf(stderr, "\n");

    err_exit();

    __assume(false);
    assert(!"unreached");
}

static bool report_parsing_errors(parsing_errors* errors)
{
    int error_count = 0;
    parsing_error error;

    while (errors->pop(&error))
    {
        fprintf(stderr, "%u:%u: %s\n", error.line, error.col, error.description);
        error_count += 1;
    }

    if (error_count != 0)
    {
        fprintf(stderr, "KGT: Exiting. %d errors reported\n", error_count);
        return true;
    }

    return false;
}

struct ast_rule* read_grammar(const in_able& in, const std::string filename)
{
    parsing_errors errors;
    ast_rule* grammar;

    assert(in.in != nullptr);

    FILE* input = fopen(filename.c_str(), "r");
    assert(input != nullptr);
    try
    {
        grammar = in.in(kgt_fgetc, input, &errors);
    }
    catch (std::logic_error& e)
    {
        printf("%s\n", e.what());
        report_parsing_errors(&errors);
        err_exit();
    }
    fclose(input);

    return grammar;
}

std::string kout(std::string file)
{
    return "../../SixTmp/kgt/" + file;
}

std::string exin(std::string file)
{
    return "examples/" + file;
}

void tester(const in_able& in, std::string file);

void tester()
{
    for (auto &inable : inputable)
    {
        if (!inable.enabled)
        {
            continue;
        }

        for (auto &sample : inable.samples)
        {
            tester(inable, exin(sample));
        }
    }

    ok_exit();
}

void tester(const in_able& in, std::string file)
{
    struct out_able* out = nullptr;

    ast_rule* grammar = read_grammar(in, file);

    std::string new_out = kout(file + "." + in.name + ".new-out.txt");
    std::string old_out = kout(file + "." + in.name + ".old-out.txt");

    FILE* outfile = fopen(new_out.c_str(), "w");
    writer = new struct iwriter(outfile);

    printf("%s:\n", file.c_str());

    for (int i = 0; i < sizeof(outputable) / sizeof(*outputable); ++i)
    {
        out = &outputable[i];

        assert(out != nullptr);
        assert(out->out != nullptr);

        if (i > 0)
        {
            printf(" ");
        }
        printf("%s", out->name);

        if (strcmp(out->name, "bnf") == 0)
        {
            printf("(skip)");
            continue;
        }

        if (i < 30)
        {
            if (!out->out(grammar))
            {
                //fclose(outfile);
                //err_exit();
            }
        }
    }
    printf("\n");

    fclose(outfile);

    printf("%d nodes created, %d nodes deleted\n", node::ccount, node::dcount);

    std::ifstream newf(new_out);
    std::string news((std::istreambuf_iterator<char>(newf)), (std::istreambuf_iterator<char>()));

    std::ifstream oldf(old_out);
    std::string olds((std::istreambuf_iterator<char>(oldf)), (std::istreambuf_iterator<char>()));
    assert(news.size() > 0);
    assert(olds.size() == 0 || news == olds);
}

int main(int argc, char* argv[])
{
    tester();

    struct ast_rule* grammar;
    struct in_able* in = nullptr;
    struct out_able* out = nullptr;
    const char* filter;
    parsing_errors errors;
    filter = nullptr;

    in = inlang("bnf");
    out = outlang("bnf");

    writer = new struct iwriter(stdout);

    {
        int c;

        while (c = getopt(argc, argv, "hw:c:gnl:e:u"), c != -1)
        {
            switch (c)
            {
                case 'l': in = inlang(optarg); break;
                case 'e': out = outlang(optarg); break;

                case 'c': css_file = optarg; break;
                case 'w': filter = optarg; break; /* comma-separated whitelist of rule names */

                case 'g': debug = 1; break;
                case 'n': prettify = 0; break;
                case 'u': allow_undefined = 0; break;

                case '?':
                default:
                    xusage();
            }
        }

        argc -= optind;

        if (argc > 0)
        {
            xusage();
        }
    }

    assert(in->in != nullptr);
    assert(out->out != nullptr);

    grammar = in->in(kgt_fgetc, stdin, &errors);

    if (report_parsing_errors(&errors))
    {
        err_exit();
    }

    {
        unsigned v;

        for (v = out->ast_unsupported; v != 0; v &= v - 1)
        {
            /* TODO: expose these rewritings as CLI options too; set as bits in v */
            /* TODO: option to query if output is possible without rewriting */
            switch (v & -v)
            {
                case FEATURE_AST_CI_LITERAL:
                    if (!rewrite_ci_literals(grammar))
                    {
                        err_exit();
                    }
                    break;
                case FEATURE_AST_INVISIBLE:
                    rewrite_invisible(grammar);
                    break;

                case FEATURE_AST_BINARY:
                    if (ast_maybe_binary(grammar))
                    {
                        fprintf(stderr, "Binary strings not supported for this output language\n");
                    }
                    break;
            }
        }
    }

    if (filter != nullptr)
    {
        struct ast_rule* nuw, ** tail;
        struct ast_rule* p;
        struct ast_rule* next = nullptr;

        nuw = nullptr;
        tail = &nuw;

        for (p = grammar; p != nullptr; p = next)
        {
            char* tmp, * save;
            const char* t;

            next = p->next;

            tmp = xstrdup(filter);

            for (t = strtok_s(tmp, ",", &save); t != nullptr; t = strtok_s(nullptr, ",", &save))
            {
                if (0 == strcmp(p->name().chars(), t))
                {
                    p->next = *tail;
                    *tail = p;
                    break;
                }

                /* TODO: otherwise free *p */
            }

            free(tmp);
        }

        grammar = nuw;
    }

    if (!out->out(grammar))
    {
        err_exit();
    }

    /* TODO: free ast */
    ok_exit();
}

WARN_UNUSED_RESULT int cat(const char* in, const char* indent)
{
    FILE* f;

    char buf[BUFSIZ]{};

    f = fopen(in, "r");
    if (f == nullptr)
    {
        perror(in);
        return 0;
    }

    writer->puts(indent);

    for (;;)
    {
        buf[sizeof(buf)-1] = 'x';

        if (fgets(buf, sizeof(buf), f) == nullptr)
        {
            break;
        }

        writer->puts(buf);

        if (buf[sizeof(buf)-1] != '\0' || buf[sizeof(buf) - 2] == '\n')
        {
            writer->puts(indent);
        }
    }

    (void)fclose(f);
    return 1;
}

