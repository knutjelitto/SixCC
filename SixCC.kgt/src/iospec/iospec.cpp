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
#include <deque>
#include <string>
#include <filesystem>

#include <assert.h>
#include <stdio.h>

#include "../txt.h"
#include "../ast.h"
#include "../parsing-error.h"

#include "../bnf/io.h"
#include "../blab/io.h"
#include "../ebnfhtml5/io.h"
#include "../wsn/io.h"
#include "../abnf/io.h"
#include "../iso-ebnf/io.h"
#include "../sid/io.h"
#include "../dot/io.h"
#include "../rrdot/io.h"
#include "../rrdump/io.h"
#include "../rrtdump/io.h"
#include "../rrparcon/io.h"
#include "../rrll/io.h"
#include "../rrta/io.h"
#include "../rrtext/io.h"
#include "../svg/io.h"
#include "../svghtml5/io.h"
#include "../json/io.h"
#include "../rbnf/io.h"

#include "iospec.h"


const std::vector<in_able> inputable =
{
    { "iso-ebnf",   true,   iso_ebnf_input, { "c99-grammar.iso-ebnf", "iso-ebnf.iso-ebnf", "json.iso-ebnf", "expr.iso-ebnf", "expr-minus.iso-ebnf"} },
    { "bnf",        true,   bnf_input,      { "bnf.bnf", "expr.bnf", "postal.bnf" } },
    { "rbnf",       true,   rbnf_input,     { "expr.rbnf", "expr-minus.rbnf", "gmpls.rbnf" } },
    { "wsn",        true,   wsn_input,      { "bnf.wsn", "c_syntax.wsn", "wsn.wsn" } },
    { "abnf",       false,  abnf_input,     { "abnf.abnf", "datetime.abnf", "irc.abnf", "postal.abnf", "utf8.abnf" } },
};

const std::vector<out_able> outputable =
{
    { "abnf",       abnf_output,        ".abnf",        (ast_features)0,                            (rrd_features)0},
    { "blab",       blab_output,        ".blab",        (ast_features)blab_ast_unsupported,         (rrd_features)0 },
    { "bnf",        bnf_output,         ".bnf",         (ast_features)bnf_ast_unsupported,          (rrd_features)0 },
    { "dot",        dot_output,         ".dot",         (ast_features)0,                            (rrd_features)0 },
    { "ebnf-html5", ebnf_html5_output,  "-ebnf.html",   (ast_features)ebnf_html5_ast_unsupported,   (rrd_features)0 },
    { "ebnf-xhtml5",ebnf_xhtml5_output, "-ebnf-x.html", (ast_features)ebnf_html5_ast_unsupported,   (rrd_features)0 },
    { "svg-html5",  svg_html5_output,   "-svg.html",    (ast_features)0,                            (rrd_features)0 },
    { "svg-xhtml5", svg_xhtml5_output,  "-svg-x.html",  (ast_features)0,                            (rrd_features)0 },
    { "iso-ebnf",   iso_ebnf_output,    "-iso.ebnf",    (ast_features)iso_ebnf_ast_unsupported,     (rrd_features)0 },
    { "json",       json_output,        ".json",        (ast_features)json_ast_unsupported,         (rrd_features)0 },
    { "rbnf",       rbnf_output,        ".rbnf",        (ast_features)rbnf_ast_unsupported,         (rrd_features)0 },
    { "sid",        sid_output,         ".sid",         (ast_features)sid_ast_unsupported,          (rrd_features)0 },
    { "svg",        svg_output,         ".svg",         (ast_features)0,                            (rrd_features)0 },
    { "wsn",        wsn_output,         ".wsn",         (ast_features)wsn_ast_unsupported,          (rrd_features)0 },
    { "rrdot",      rrdot_output,       "-rr.dot",      (ast_features)0,                            (rrd_features)0 },
    { "rrdump",     rrdump_output,      "-rr.dump",     (ast_features)0,                            (rrd_features)0 },
    { "rrll",       rrll_output,        "-rr.ll",       (ast_features)rrll_ast_unsupported,         (rrd_features)rrll_rrd_unsupported     },
    { "rrparcon",   rrparcon_output,    "-rr.parcon",   (ast_features)rrparcon_ast_unsupported,     (rrd_features)rrparcon_rrd_unsupported },
    { "rrta",       rrta_output,        "-rr.ta",       (ast_features)rrta_ast_unsupported,         (rrd_features)rrta_rrd_unsupported     },
    { "rrtdump",    rrtdump_output,     "-rr.tdump",    (ast_features)0,                            (rrd_features)0 },
    { "rrtext",     rrtext_output,      "-rr.text",     (ast_features)0,                            (rrd_features)0 },
    { "rrutf8",     rrutf8_output,      "-rr.utf8",     (ast_features)0,                            (rrd_features)0 },
};

const in_able& inlang(std::string name)
{
    for (const in_able& inp : inputable)
    {
        if (inp.name == name)
        {
            return inp;
        }
    }

    fprintf(stderr, "Unrecognised input language \"%s\"; supported languages are:", name.c_str());

    for (auto inp : inputable)
    {
        fprintf(stderr, " %s", inp.name.c_str());
    }

    fprintf(stderr, "\n");

    err_exit();
}

const out_able& outlang(const std::string name)
{
    for (const out_able& out : outputable)
    {
        if (out.name == name)
        {
            return out;
        }
    }

    fprintf(stderr, "Unrecognised output language \"%s\"; supported languages are:", name.c_str());

    for (auto out : outputable)
    {
        fprintf(stderr, " %s", out.name.c_str());
    }

    fprintf(stderr, "\n");

    err_exit();
}

static int kgt_fgetc(void* opaque)
{
    FILE* f;

    f = (FILE*)opaque;

    assert(f != nullptr);

    return fgetc(f);
}

static bool report_parsing_errors(const std::string filename, parsing_errors* errors)
{
    int error_count = 0;
    parsing_error error;

    while (errors->pop(&error))
    {
        fprintf(stderr, "%s(%u,%u): %s\n", filename.c_str(), error.line, error.col, error.description);
        error_count += 1;
    }

    if (error_count != 0)
    {
        fprintf(stderr, "KGT: Exiting. %d errors reported\n", error_count);
        return true;
    }

    return false;
}

bool read_grammar(ast_grammar& grammar, const in_able& in, const std::string filename)
{
    parsing_errors errors;

    assert(in.in != nullptr);

    FILE* input = fopen(filename.c_str(), "r");
    assert(input != nullptr);
    try
    {
        in.in(grammar, kgt_fgetc, input, &errors);
    }
    catch (std::logic_error& e)
    {
        printf("%s\n", e.what());
        report_parsing_errors(filename, &errors);
        err_exit();
    }
    fclose(input);

    return true;
}
