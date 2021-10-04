#include <assert.h>
#include <string.h>
#include <ctype.h>

#include "strings.h"

const char* ltrim(const char* s)
{
	while (isspace((unsigned char)*s))
	{
		s++;
	}

	return s;
}

void rtrim(char* s)
{
	char* p = s + strlen(s) - 1;

	assert(strlen(s) > 0);

	while (p >= s && isspace((unsigned char)*p))
	{
		*p-- = '\0';
	}
}

const char* trim(char* s)
{
	rtrim(s);
	return ltrim(s);
}

