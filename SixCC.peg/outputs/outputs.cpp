#include "outputs.h"
#include "../ast.h"

#include <string>
#include <functional>

using namespace std;

namespace sixpeg
{
	namespace output
	{
		void ast_output(ast::grammar* grammar);
		void wsn_output(ast::grammar* grammar);

		struct out_info
		{
			string format_name;
			function<void(ast::grammar*)> formatter;
		};

		static out_info infos[] =
		{
			{ "ast", output::ast_output },
			{ "wsn", output::wsn_output },
		};

		static bool find(string format_name, out_info& info)
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

		bool output(string format_name, ast::grammar* grammar)
		{
			out_info info;

			if (find(format_name, info))
			{
				info.formatter(grammar);

				return true;
			}
			return false;
		}
	}
}
