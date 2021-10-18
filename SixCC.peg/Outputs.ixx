export module Outputs;

export import :Ast;
export import :Wsn;

import <string>;
import <functional>;
import <sstream>;
import <filesystem>;

import Ast;
import Indenter;
import Files;

namespace sixpeg::output
{
	using namespace std;
	using namespace std::filesystem;

	struct out_info
	{
		std::string format_name;
		std::function<void(ast::grammar*, sixpeg::indenter&)> formatter;
	};

	static out_info infos[] =
	{
		{ "ast", output::ast_output },
		{ "wsn", output::wsn_output },
	};

	static bool find(std::string format_name, out_info& info)
	{
		for (auto& find : infos)
		{
			if (find.format_name == format_name)
			{
				info = find;
				return true;
			}
		}
		return false;
	}

	export bool output(std::string format_name, ast::grammar* grammar)
	{
		out_info info;

		if (find(format_name, info))
		{
			std::stringstream str;
			indenter ind(str);
			info.formatter(grammar, ind);
			std::cout << str.str();

			return true;
		}
		return false;
	}

	export bool output(std::string format_name, ast::grammar* grammar, std::string file)
	{
		out_info info;

		if (find(format_name, info))
		{
			std::stringstream str;
			indenter ind(str);
			info.formatter(grammar, ind);

			write_file_content(file, str.str());

			return true;
		}
		return false;
	}
}