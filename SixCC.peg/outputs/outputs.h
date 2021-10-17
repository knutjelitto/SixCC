#pragma once

#ifndef _outputs_h
#define _outputs_h

#include <string>
#include "../ast.h"

namespace sixpeg
{
	namespace output
	{
		bool output(std::string format_name, ast::grammar* grammar);
	}
}

#endif
