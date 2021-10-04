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

int iwriter::putc(int character)
{
	return fputc(character, file);
}

int iwriter::escape(const char* text, int (*esc)(int, iwriter*))
{
	assert(text != nullptr);
	assert(esc != nullptr);

	const char* p;
	int r, n;

	n = 0;

	for (p = text; *p != '\0'; p++)
	{
		r = esc(*p, this);
		if (r < 0)
		{
			return -1;
		}

		n += r;
	}

	return n;
}

int iwriter::escape(const struct txt* text, int (*esc)(int, iwriter*))
{
	assert(text != nullptr);
	assert(text->p != nullptr);

	int r;

	for (int i = 0; i < text->n; i++)
	{
		r = esc(text->p[i], this);
		if (r < 0)
		{
			return -1;
		}
	}

	return 0;
}
