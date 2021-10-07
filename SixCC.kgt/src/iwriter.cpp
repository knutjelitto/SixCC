#include <assert.h>
#include <stdarg.h>
#include <stdio.h>

#include "txt.h"

struct iwriter* writer;

int iwriter::printf(const char* fmt, ...)
{
	assert(fmt != NULL);

	va_list ap{};

	va_start(ap, fmt);

	int n = vfprintf(file, fmt, ap);

	va_end(ap);

	return n;
}

int iwriter::vprintf(const char* fmt, va_list ap)
{
	assert(fmt != NULL);

	return vfprintf(file, fmt, ap);
}

int iwriter::puts(const char* text)
{
	return fputs(text, file);
}

int iwriter::puts(const text& text)
{
	return fputs(text.chars(), file);
}

int iwriter::putc(int character)
{
	return fputc(character, file);
}

int iwriter::escape(const text& text, int (*esc)(int, iwriter*))
{
	int n = 0;
	int r;

	for (int i = 0; i < text.length(); i++)
	{
		r = esc(text[i], this);
		if (r < 0)
		{
			return -1;
		}
		n += r;
	}

	return n;
}
