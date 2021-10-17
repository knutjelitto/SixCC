#include <stdexcept>
#include <iostream>
#include <fstream>
#include <filesystem>

#include "files.h"

using namespace std;

string read_file_content(string name)
{
    name = "../SixCC.peg/" + name;

    std::ifstream ifs(name);
    if (ifs.is_open())
    {
        std::string content((std::istreambuf_iterator<char>(ifs)), (std::istreambuf_iterator<char>()));

        return content;
    }

    throw std::runtime_error("could not open file");
}

string read_sample(string format, string name)
{
    string filename = "inputs/" + format + "/samples/" + name;

    return read_file_content(filename);
}
