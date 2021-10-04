#include <assert.h>
#include <stdarg.h>
#include <stdio.h>

#include "txt.h"

struct theout* writer;

int theout::printf(const char* fmt, ...)
{
	assert(fmt != NULL);

	va_list ap{};

	va_start(ap, fmt);

	auto n = vfprintf(file, fmt, ap);

	va_end(ap);

	return n;
}

int theout::puts(const char* text)
{
	return fputs(text, file);
}

int theout::putc(int character)
{
	return fputc(character, file);
}

int theout::escape(const char* text, int (*esc)(int, theout*))
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

int theout::escape(const struct txt* text, int (*esc)(int, theout*))
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
