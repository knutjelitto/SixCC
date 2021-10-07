#pragma once

#include <stdio.h>
#include "txt.h"

struct iwriter
{
	iwriter(FILE* file) : file(file)
	{
	}

	int printf(const char* fmt, ...);
	int vprintf(const char* fmt, va_list ap);
	int puts(const char* text);
	int puts(const text& text);
	int putc(int character);

	int escape(const text& text, int (*esc)(int, iwriter*));

private:
	FILE* const file;
};

extern struct iwriter* writer;
