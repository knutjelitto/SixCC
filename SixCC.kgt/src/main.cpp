/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */
#define _CRT_SECURE_NO_WARNINGS

#if !defined(__cplusplus) || __cplusplus < 201703L
#error "Requires complete C++17 support"
#endif

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

#include "iospec/iospec.h"

int fakeptr = 1;
int debug = 0;
int prettify = 1;
int allow_undefined = 1;
const char *css_file;

static void xusage(void)
{
    printf("usage: kgt [-gnu] [-c <css-file>] [-l <language>] [ -e <language> ]\n");
    err_exit();
}

static int kgt_fgetc(void *opaque)
{
    FILE *f;

    f = (FILE*)opaque;

    assert(f != nullptr);

    return fgetc(f);
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
            auto inputfile = exin(sample);
            tester(inable, inputfile);
        }
    }

    ok_exit();
}

void tester(const in_able& in, std::string inputfile)
{
    ast_grammar grammar;
    
    read_grammar(grammar, in, inputfile);

    std::string new_out = kout(inputfile + "." + in.name + ".new-out.txt");
    std::string old_out = kout(inputfile + "." + in.name + ".old-out.txt");

    FILE* outfile = fopen(new_out.c_str(), "w");
    assert(outfile != nullptr);
    writer = new iwriter(outfile);

    printf("%s:\n", inputfile.c_str());

    bool more = false;
    for (auto out : outputable)
    {
        assert(out.out != nullptr);

        if (more)
        {
            printf(" ");
        }
        else
        {
            more = true;
        }
        printf("%s", out.name.c_str());

        if (out.name == "bnf")
        {
            printf("(skip)");
            continue;
        }

        writer->puts("===============\n");
        writer->puts(out.name);
        writer->puts("\n");
        writer->puts("===============\n");
        out.out(grammar);
    }
    printf("\n");

    fclose(outfile);

    printf("%d nodes created, %d nodes deleted\n", node::ccount, node::dcount);

    std::ifstream newf(new_out);
    std::string news((std::istreambuf_iterator<char>(newf)), (std::istreambuf_iterator<char>()));

    std::ifstream oldf(old_out);
    std::string olds((std::istreambuf_iterator<char>(oldf)), (std::istreambuf_iterator<char>()));

    printf("#news: %lld, #olds: %lld\n", news.size(), olds.size());

    assert(news.size() > 0);
    assert(olds.size() == 0 || news == olds);
}

void testsoles(const in_able& in, std::string inputfile, iwriter* writer)
{
    ast_grammar grammar;
    read_grammar(grammar, in, inputfile);

    ::writer = writer;

    for (auto& out : outputable)
    {
        if (out.name != "bnf")
        {
            out.out(grammar);
        }
    }
}

int main(int argc, char* argv[])
{
    tester();

    ast_grammar grammar;
    parsing_errors errors;

    auto in = inlang("bnf");
    auto out = outlang("bnf");

    writer = new struct iwriter(stdout);

    {
        int c;

        while (c = getopt(argc, argv, "hc:gnl:e:u"), c != -1)
        {
            switch (c)
            {
                case 'l': in = inlang(optarg); break;
                case 'e': out = outlang(optarg); break;

                case 'c': css_file = optarg; break;

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

    assert(in.in != nullptr);
    assert(out.out != nullptr);

    in.in(grammar, kgt_fgetc, stdin, &errors);

    if (report_parsing_errors(&errors))
    {
        err_exit();
    }

    {
        unsigned v;

        for (v = out.ast_unsupported; v != 0; v &= v - 1)
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

    if (!out.out(grammar))
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

