#pragma once

#ifdef SIXCCPEG_EXPORTS
#define IMEX __declspec(dllexport)
#else
#define IMEX __declspec(dllimport)
#endif

#include <string>

namespace sixpeg
{
    IMEX void check_all();
    IMEX void check_one();

    typedef void* ghandle;

    IMEX ghandle parse(std::string format, std::string name, std::string text);

    IMEX bool unparse(std::string format, ghandle grammar);
}
