#pragma once

#include <stdio.h>

struct theout
{
	theout(FILE* file) : file(file)
	{
	}

	int printf(const char* fmt, ...);
	int puts(const char* text);
	int putc(int character);

	int escape(const char* text, int (*esc)(int, theout*));
	int escape(const struct txt* text, int (*esc)(int, theout*));

private:
	FILE* const file;
};

extern struct theout* writer;
