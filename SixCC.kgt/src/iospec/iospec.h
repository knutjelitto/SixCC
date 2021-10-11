/*
 * Copyright 2021 Knut Jelitto
 *
 * See LICENCE for the full copyright terms.
 */
#pragma once
#ifndef _IOSPEC_H
#define _IOSPEC_H

#include <string>
#include <vector>

#include "../ast.h"
#include "../parsing-error.h"
#include "../rrd/node.h"

struct in_able
{
    std::string name;
    bool enabled;
    bool (*in)(ast_grammar&, int (*parse)(void*), void*, parsing_errors*);
    std::deque<std::string> samples;
};

struct out_able
{
    std::string name;
    int (*out)(const ast_grammar&);
    std::string ext;
    ast_features ast_unsupported;
    rrd_features rrd_unsupported;
};

extern const std::vector<in_able> inputable;
extern const std::vector<out_able> outputable;

const in_able& inlang(std::string name);
const out_able& outlang(std::string name);

bool read_grammar(ast_grammar& grammar, const in_able& in, const std::string filename);

#endif

