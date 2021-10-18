export module Files;

import <stdexcept>;
import <iostream>;
import <fstream>;
import <filesystem>;

namespace sixpeg
{
    using namespace std;

    export void write_file_content(std::string name, const std::string& content)
    {
        std::ofstream ofs(name);
        if (ofs.is_open())
        {
            ofs.write(content.c_str(), content.size());
            return;
        }

        throw std::runtime_error("could not open file");
    }

    export string read_file_content(string name)
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

    export string read_sample(string format, string name)
    {
        string filename = "inputs/" + format + "/samples/" + name;

        return read_file_content(filename);
    }
}