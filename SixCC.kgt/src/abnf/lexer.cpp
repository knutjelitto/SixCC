/* Generated by lx */

#include <assert.h>
#include <stdio.h>
#include <stddef.h>
#include <stdlib.h>
#include <errno.h>

#include "lexer.h"

static enum lx_abnf_token z0(struct lx_abnf_lx *lx);
static enum lx_abnf_token z1(struct lx_abnf_lx *lx);
static enum lx_abnf_token z2(struct lx_abnf_lx *lx);
static enum lx_abnf_token z3(struct lx_abnf_lx *lx);
static enum lx_abnf_token z4(struct lx_abnf_lx *lx);

#if __STDC_VERSION__ >= 199901L
inline
#endif
static int
lx_getc(struct lx_abnf_lx *lx)
{
	int c;

	assert(lx != NULL);
	assert(lx->lgetc != NULL);

	if (lx->c != EOF) {
		c = lx->c, lx->c = EOF;
	} else {
		c = lx->lgetc(lx);
		if (c == EOF) {
			return EOF;
		}
	}

	lx->end.byte++;
	lx->end.col++;

	if (c == '\n') {
		lx->end.line++;
		lx->end.saved_col = lx->end.col - 1;
		lx->end.col = 1;
	}

	return c;
}

#if __STDC_VERSION__ >= 199901L
inline
#endif
static void
lx_abnf_ungetc(struct lx_abnf_lx *lx, int c)
{
	assert(lx != NULL);
	assert(lx->c == EOF);

	lx->c = c;


	lx->end.byte--;
	lx->end.col--;

	if (c == '\n') {
		lx->end.line--;
		lx->end.col = lx->end.saved_col;
	}
}

int
lx_abnf_dynpush(void *buf_opaque, char c)
{
	struct lx_dynbuf *t = (struct lx_dynbuf*)buf_opaque;

	assert(t != NULL);

	if (t->p == t->a + t->len) {
		size_t len;
		ptrdiff_t off;
		char *tmp;

		if (t->len == 0) {
			assert(LX_DYN_LOW > 0);
			len = LX_DYN_LOW;
		} else {
			len = t->len * LX_DYN_FACTOR;
			if (len < t->len) {
				errno = ERANGE;
				return -1;
			}
		}

		off = t->p - t->a;
		tmp = (char*)realloc(t->a, len);
		if (tmp == NULL) {
			return -1;
		}

		t->p   = tmp + off;
		t->a   = tmp;
		t->len = len;
	}

	assert(t->p != NULL);
	assert(t->a != NULL);

	*t->p++ = c;

	return 0;
}

int
lx_abnf_dynclear(void *buf_opaque)
{
	struct lx_dynbuf *t = (struct lx_dynbuf*)buf_opaque;

	assert(t != NULL);

	if (t->len > LX_DYN_HIGH) {
		size_t len;
		char *tmp;

		len = t->len / LX_DYN_FACTOR;

		tmp = (char*)realloc(t->a, len);
		if (tmp == NULL) {
			return -1;
		}

		t->a   = tmp;
		t->len = len;
	}

	t->p = t->a;

	return 0;
}

void
lx_abnf_dynfree(void *buf_opaque)
{
	struct lx_dynbuf *t = (struct lx_dynbuf*)buf_opaque;

	assert(t != NULL);

	free(t->a);
}
static enum lx_abnf_token
z0(struct lx_abnf_lx *lx)
{
	int c;

	enum {
		S0, S1, S2, NONE
	} state;

	assert(lx != NULL);

	if (lx->clear != NULL) {
		lx->clear(lx->buf_opaque);
	}

	state = NONE;

	lx->start = lx->end;

	while (c = lx_getc(lx), c != EOF) {
		if (state == NONE) {
			state = S0;
		}

		switch (state) {
		case S0: /* start */
			switch ((unsigned char) c) {
			case '"': state = S2; break;
			default: state = S1; break;
			}
			break;

		case S1: /* e.g. "a" */
			lx_abnf_ungetc(lx, c); return TOK_CHAR;

		case S2: /* e.g. "\"" */
			lx_abnf_ungetc(lx, c); return lx->z = z4, TOK_CS_LITERAL;

		default:
			; /* unreached */
		}

		if (lx->push != NULL) {
			if (-1 == lx->push(lx->buf_opaque, c)) {
				return TOK_ERROR;
			}
		}
	}

	lx->lgetc = NULL;

	switch (state) {
	case NONE: return TOK_EOF;
	case S1: return TOK_CHAR;
	case S2: return TOK_CS_LITERAL;
	default: errno = EINVAL; return TOK_ERROR;
	}
}

static enum lx_abnf_token
z1(struct lx_abnf_lx *lx)
{
	int c;

	enum {
		S0, S1, S2, NONE
	} state;

	assert(lx != NULL);

	if (lx->clear != NULL) {
		lx->clear(lx->buf_opaque);
	}

	state = NONE;

	lx->start = lx->end;

	while (c = lx_getc(lx), c != EOF) {
		if (state == NONE) {
			state = S0;
		}

		switch (state) {
		case S0: /* start */
			switch ((unsigned char) c) {
			case '"': state = S2; break;
			default: state = S1; break;
			}
			break;

		case S1: /* e.g. "a" */
			lx_abnf_ungetc(lx, c); return TOK_CHAR;

		case S2: /* e.g. "\"" */
			lx_abnf_ungetc(lx, c); return lx->z = z4, TOK_CI_LITERAL;

		default:
			; /* unreached */
		}

		if (lx->push != NULL) {
			if (-1 == lx->push(lx->buf_opaque, c)) {
				return TOK_ERROR;
			}
		}
	}

	lx->lgetc = NULL;

	switch (state) {
	case NONE: return TOK_EOF;
	case S1: return TOK_CHAR;
	case S2: return TOK_CI_LITERAL;
	default: errno = EINVAL; return TOK_ERROR;
	}
}

static enum lx_abnf_token
z2(struct lx_abnf_lx *lx)
{
	int c;

	enum {
		S0, S1, S2, NONE
	} state;

	assert(lx != NULL);

	if (lx->clear != NULL) {
		lx->clear(lx->buf_opaque);
	}

	state = NONE;

	lx->start = lx->end;

	while (c = lx_getc(lx), c != EOF) {
		if (state == NONE) {
			state = S0;
		}

		switch (state) {
		case S0: /* start */
			switch ((unsigned char) c) {
			case '\x00':
			case '\x01':
			case '\x02':
			case '\x03':
			case '\x04':
			case '\x05':
			case '\x06':
			case '\a':
			case '\b':
			case '\t':
			case '\n':
			case '\v':
			case '\f':
			case '\r':
			case '\x0e':
			case '\x0f':
			case '\x10':
			case '\x11':
			case '\x12':
			case '\x13':
			case '\x14':
			case '\x15':
			case '\x16':
			case '\x17':
			case '\x18':
			case '\x19':
			case '\x1a':
			case '\x1b':
			case '\x1c':
			case '\x1d':
			case '\x1e':
			case '\x1f':
			case ' ':
			case '!':
			case '"':
			case '#':
			case '$':
			case '%':
			case '&':
			case '\'':
			case '(':
			case ')':
			case '*':
			case '+':
			case ',':
			case '-':
			case '.':
			case '/':
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
			case ':':
			case ';':
			case '<':
			case '=':
			case '@':
			case 'A':
			case 'B':
			case 'C':
			case 'D':
			case 'E':
			case 'F':
			case 'G':
			case 'H':
			case 'I':
			case 'J':
			case 'K':
			case 'L':
			case 'M':
			case 'N':
			case 'O':
			case 'P':
			case 'Q':
			case 'R':
			case 'S':
			case 'T':
			case 'U':
			case 'V':
			case 'W':
			case 'X':
			case 'Y':
			case 'Z':
			case '[':
			case '\\':
			case ']':
			case '^':
			case '_':
			case '`':
			case 'a':
			case 'b':
			case 'c':
			case 'd':
			case 'e':
			case 'f':
			case 'g':
			case 'h':
			case 'i':
			case 'j':
			case 'k':
			case 'l':
			case 'm':
			case 'n':
			case 'o':
			case 'p':
			case 'q':
			case 'r':
			case 's':
			case 't':
			case 'u':
			case 'v':
			case 'w':
			case 'x':
			case 'y':
			case 'z':
			case '{':
			case '|':
			case '}':
			case '~':
			case '\x7f':
			case 0x80:
			case 0x81:
			case 0x82:
			case 0x83:
			case 0x84:
			case 0x85:
			case 0x86:
			case 0x87:
			case 0x88:
			case 0x89:
			case 0x8a:
			case 0x8b:
			case 0x8c:
			case 0x8d:
			case 0x8e:
			case 0x8f:
			case 0x90:
			case 0x91:
			case 0x92:
			case 0x93:
			case 0x94:
			case 0x95:
			case 0x96:
			case 0x97:
			case 0x98:
			case 0x99:
			case 0x9a:
			case 0x9b:
			case 0x9c:
			case 0x9d:
			case 0x9e:
			case 0x9f:
			case 0xa0:
			case 0xa1:
			case 0xa2:
			case 0xa3:
			case 0xa4:
			case 0xa5:
			case 0xa6:
			case 0xa7:
			case 0xa8:
			case 0xa9:
			case 0xaa:
			case 0xab:
			case 0xac:
			case 0xad:
			case 0xae:
			case 0xaf:
			case 0xb0:
			case 0xb1:
			case 0xb2:
			case 0xb3:
			case 0xb4:
			case 0xb5:
			case 0xb6:
			case 0xb7:
			case 0xb8:
			case 0xb9:
			case 0xba:
			case 0xbb:
			case 0xbc:
			case 0xbd:
			case 0xbe:
			case 0xbf:
			case 0xc0:
			case 0xc1:
			case 0xc2:
			case 0xc3:
			case 0xc4:
			case 0xc5:
			case 0xc6:
			case 0xc7:
			case 0xc8:
			case 0xc9:
			case 0xca:
			case 0xcb:
			case 0xcc:
			case 0xcd:
			case 0xce:
			case 0xcf:
			case 0xd0:
			case 0xd1:
			case 0xd2:
			case 0xd3:
			case 0xd4:
			case 0xd5:
			case 0xd6:
			case 0xd7:
			case 0xd8:
			case 0xd9:
			case 0xda:
			case 0xdb:
			case 0xdc:
			case 0xdd:
			case 0xde:
			case 0xdf:
			case 0xe0:
			case 0xe1:
			case 0xe2:
			case 0xe3:
			case 0xe4:
			case 0xe5:
			case 0xe6:
			case 0xe7:
			case 0xe8:
			case 0xe9:
			case 0xea:
			case 0xeb:
			case 0xec:
			case 0xed:
			case 0xee:
			case 0xef:
			case 0xf0:
			case 0xf1:
			case 0xf2:
			case 0xf3:
			case 0xf4:
			case 0xf5:
			case 0xf6:
			case 0xf7:
			case 0xf8:
			case 0xf9:
			case 0xfa:
			case 0xfb:
			case 0xfc:
			case 0xfd:
			case 0xfe:
			case 0xff: state = S1; break;
			case '>': state = S2; break;
			}
			break;

		case S1: /* e.g. "a" */
			lx_abnf_ungetc(lx, c); return TOK_CHAR;

		case S2: /* e.g. ">" */
			lx_abnf_ungetc(lx, c); return lx->z = z4, TOK_PROSE;

		default:
			; /* unreached */
		}

		if (lx->push != NULL) {
			if (-1 == lx->push(lx->buf_opaque, c)) {
				return TOK_ERROR;
			}
		}
	}

	lx->lgetc = NULL;

	switch (state) {
	case NONE: return TOK_EOF;
	case S1: return TOK_CHAR;
	case S2: return TOK_PROSE;
	default: errno = EINVAL; return TOK_ERROR;
	}
}

static enum lx_abnf_token
z3(struct lx_abnf_lx *lx)
{
	int c;

	enum {
		S0, S1, S2, NONE
	} state;

	assert(lx != NULL);

	if (lx->clear != NULL) {
		lx->clear(lx->buf_opaque);
	}

	state = NONE;

	lx->start = lx->end;

	while (c = lx_getc(lx), c != EOF) {
		if (state == NONE) {
			state = S0;
		}

		switch (state) {
		case S0: /* start */
			switch ((unsigned char) c) {
			case '\n': state = S2; break;
			default: state = S1; break;
			}
			break;

		case S1: /* e.g. "a" */
			lx_abnf_ungetc(lx, c); return lx->z(lx);

		case S2: /* e.g. "\n" */
			lx_abnf_ungetc(lx, c); return lx->z = z4, lx->z(lx);

		default:
			; /* unreached */
		}

		switch (state) {
		case S0:
		case S1:
		case S2:
			break;

		default:
			if (lx->push != NULL) {
				if (-1 == lx->push(lx->buf_opaque, c)) {
					return TOK_ERROR;
				}
			}
			break;

		}
	}

	lx->lgetc = NULL;

	switch (state) {
	case NONE: return TOK_EOF;
	case S1: return TOK_EOF;
	case S2: return TOK_EOF;
	default: errno = EINVAL; return TOK_ERROR;
	}
}

static enum lx_abnf_token
z4(struct lx_abnf_lx *lx)
{
	int c;

	enum {
		S0, S1, S2, S3, S4, S5, S6, S7, S8, S9, 
		S10, S11, S12, S13, S14, S15, S16, S17, S18, S19, 
		S20, S21, S22, S23, S24, S25, S26, S27, S28, S29, 
		S30, S31, S32, S33, S34, S35, S36, S37, S38, NONE
	} state;

	assert(lx != NULL);

	if (lx->clear != NULL) {
		lx->clear(lx->buf_opaque);
	}

	state = NONE;

	lx->start = lx->end;

	while (c = lx_getc(lx), c != EOF) {
		if (state == NONE) {
			state = S0;
		}

		switch (state) {
		case S0: /* start */
			switch ((unsigned char) c) {
			case '\n': state = S2; break;
			case '\t':
			case '\v':
			case '\f':
			case '\r':
			case ' ': state = S1; break;
			case '(': state = S5; break;
			case ';': state = S10; break;
			case '<': state = S11; break;
			case '=': state = S12; break;
			case 'A':
			case 'B':
			case 'C':
			case 'D':
			case 'E':
			case 'F':
			case 'G':
			case 'H':
			case 'I':
			case 'J':
			case 'K':
			case 'L':
			case 'M':
			case 'N':
			case 'O':
			case 'P':
			case 'Q':
			case 'R':
			case 'S':
			case 'T':
			case 'U':
			case 'V':
			case 'W':
			case 'X':
			case 'Y':
			case 'Z':
			case 'a':
			case 'b':
			case 'c':
			case 'd':
			case 'e':
			case 'f':
			case 'g':
			case 'h':
			case 'i':
			case 'j':
			case 'k':
			case 'l':
			case 'm':
			case 'n':
			case 'o':
			case 'p':
			case 'q':
			case 'r':
			case 's':
			case 't':
			case 'u':
			case 'v':
			case 'w':
			case 'x':
			case 'y':
			case 'z': state = S13; break;
			case '[': state = S14; break;
			case ')': state = S6; break;
			case ']': state = S15; break;
			case '*': state = S7; break;
			case '"': state = S3; break;
			case '/': state = S8; break;
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9': state = S9; break;
			case '%': state = S4; break;
			default:  lx->lgetc = NULL; return TOK_UNKNOWN;
			}
			break;

		case S1: /* e.g. "\t" */
			switch ((unsigned char) c) {
			case '\t':
			case '\v':
			case '\f':
			case '\r':
			case ' ': break;
			default:  lx_abnf_ungetc(lx, c); return lx->z(lx);
			}
			break;

		case S2: /* e.g. "\n" */
			switch ((unsigned char) c) {
			case '\n': state = S16; break;
			default:  lx_abnf_ungetc(lx, c); return lx->z(lx);
			}
			break;

		case S3: /* e.g. "\"" */
			lx_abnf_ungetc(lx, c); return lx->z = z1, lx->z(lx);

		case S4: /* e.g. "%" */
			switch ((unsigned char) c) {
			case 's': state = S21; break;
			case 'x': state = S22; break;
			case 'b': state = S18; break;
			case 'd': state = S19; break;
			case 'i': state = S20; break;
			default:  lx->lgetc = NULL; return TOK_UNKNOWN;
			}
			break;

		case S5: /* e.g. "(" */
			lx_abnf_ungetc(lx, c); return TOK_STARTGROUP;

		case S6: /* e.g. ")" */
			lx_abnf_ungetc(lx, c); return TOK_ENDGROUP;

		case S7: /* e.g. "*" */
			lx_abnf_ungetc(lx, c); return TOK_REP;

		case S8: /* e.g. "\057" */
			lx_abnf_ungetc(lx, c); return TOK_ALT;

		case S9: /* e.g. "0" */
			switch ((unsigned char) c) {
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9': break;
			default:  lx_abnf_ungetc(lx, c); return TOK_COUNT;
			}
			break;

		case S10: /* e.g. ";" */
			lx_abnf_ungetc(lx, c); return lx->z = z3, lx->z(lx);

		case S11: /* e.g. "<" */
			lx_abnf_ungetc(lx, c); return lx->z = z2, lx->z(lx);

		case S12: /* e.g. "=" */
			switch ((unsigned char) c) {
			case '/': state = S17; break;
			default:  lx_abnf_ungetc(lx, c); return TOK_EQUALS;
			}
			break;

		case S13: /* e.g. "a" */
			switch ((unsigned char) c) {
			case '-':
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
			case 'A':
			case 'B':
			case 'C':
			case 'D':
			case 'E':
			case 'F':
			case 'G':
			case 'H':
			case 'I':
			case 'J':
			case 'K':
			case 'L':
			case 'M':
			case 'N':
			case 'O':
			case 'P':
			case 'Q':
			case 'R':
			case 'S':
			case 'T':
			case 'U':
			case 'V':
			case 'W':
			case 'X':
			case 'Y':
			case 'Z':
			case 'a':
			case 'b':
			case 'c':
			case 'd':
			case 'e':
			case 'f':
			case 'g':
			case 'h':
			case 'i':
			case 'j':
			case 'k':
			case 'l':
			case 'm':
			case 'n':
			case 'o':
			case 'p':
			case 'q':
			case 'r':
			case 's':
			case 't':
			case 'u':
			case 'v':
			case 'w':
			case 'x':
			case 'y':
			case 'z': break;
			default:  lx_abnf_ungetc(lx, c); return TOK_IDENT;
			}
			break;

		case S14: /* e.g. "[" */
			lx_abnf_ungetc(lx, c); return TOK_STARTOPT;

		case S15: /* e.g. "]" */
			lx_abnf_ungetc(lx, c); return TOK_ENDOPT;

		case S16: /* e.g. "\n\n" */
			lx_abnf_ungetc(lx, c); return TOK_SEP;

		case S17: /* e.g. "=\057" */
			lx_abnf_ungetc(lx, c); return TOK_ALTINC;

		case S18: /* e.g. "%b" */
			switch ((unsigned char) c) {
			case '0':
			case '1': state = S24; break;
			default:  lx->lgetc = NULL; return TOK_UNKNOWN;
			}
			break;

		case S19: /* e.g. "%d" */
			switch ((unsigned char) c) {
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9': state = S25; break;
			default:  lx->lgetc = NULL; return TOK_UNKNOWN;
			}
			break;

		case S20: /* e.g. "%i" */
			switch ((unsigned char) c) {
			case '"': state = S3; break;
			default:  lx->lgetc = NULL; return TOK_UNKNOWN;
			}
			break;

		case S21: /* e.g. "%s" */
			switch ((unsigned char) c) {
			case '"': state = S23; break;
			default:  lx->lgetc = NULL; return TOK_UNKNOWN;
			}
			break;

		case S22: /* e.g. "%x" */
			switch ((unsigned char) c) {
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
			case 'A':
			case 'B':
			case 'C':
			case 'D':
			case 'E':
			case 'F':
			case 'a':
			case 'b':
			case 'c':
			case 'd':
			case 'e':
			case 'f': state = S26; break;
			default:  lx->lgetc = NULL; return TOK_UNKNOWN;
			}
			break;

		case S23: /* e.g. "%s\"" */
			lx_abnf_ungetc(lx, c); return lx->z = z0, lx->z(lx);

		case S24: /* e.g. "%b0" */
			switch ((unsigned char) c) {
			case '0':
			case '1': break;
			case '-': state = S31; break;
			case '.': state = S32; break;
			default:  lx_abnf_ungetc(lx, c); return TOK_BINSTR;
			}
			break;

		case S25: /* e.g. "%d0" */
			switch ((unsigned char) c) {
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9': break;
			case '-': state = S35; break;
			case '.': state = S36; break;
			default:  lx_abnf_ungetc(lx, c); return TOK_DECSTR;
			}
			break;

		case S26: /* e.g. "%xa" */
			switch ((unsigned char) c) {
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
			case 'A':
			case 'B':
			case 'C':
			case 'D':
			case 'E':
			case 'F':
			case 'a':
			case 'b':
			case 'c':
			case 'd':
			case 'e':
			case 'f': break;
			case '-': state = S27; break;
			case '.': state = S28; break;
			default:  lx_abnf_ungetc(lx, c); return TOK_HEXSTR;
			}
			break;

		case S27: /* e.g. "%xa-" */
			switch ((unsigned char) c) {
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
			case 'A':
			case 'B':
			case 'C':
			case 'D':
			case 'E':
			case 'F':
			case 'a':
			case 'b':
			case 'c':
			case 'd':
			case 'e':
			case 'f': state = S30; break;
			default:  lx->lgetc = NULL; return TOK_UNKNOWN;
			}
			break;

		case S28: /* e.g. "%xa." */
			switch ((unsigned char) c) {
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
			case 'A':
			case 'B':
			case 'C':
			case 'D':
			case 'E':
			case 'F':
			case 'a':
			case 'b':
			case 'c':
			case 'd':
			case 'e':
			case 'f': state = S29; break;
			default:  lx->lgetc = NULL; return TOK_UNKNOWN;
			}
			break;

		case S29: /* e.g. "%xa.a" */
			switch ((unsigned char) c) {
			case '.': state = S28; break;
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
			case 'A':
			case 'B':
			case 'C':
			case 'D':
			case 'E':
			case 'F':
			case 'a':
			case 'b':
			case 'c':
			case 'd':
			case 'e':
			case 'f': break;
			default:  lx_abnf_ungetc(lx, c); return TOK_HEXSTR;
			}
			break;

		case S30: /* e.g. "%xa-a" */
			switch ((unsigned char) c) {
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
			case 'A':
			case 'B':
			case 'C':
			case 'D':
			case 'E':
			case 'F':
			case 'a':
			case 'b':
			case 'c':
			case 'd':
			case 'e':
			case 'f': break;
			default:  lx_abnf_ungetc(lx, c); return TOK_HEXRANGE;
			}
			break;

		case S31: /* e.g. "%b0-" */
			switch ((unsigned char) c) {
			case '0':
			case '1': state = S33; break;
			default:  lx->lgetc = NULL; return TOK_UNKNOWN;
			}
			break;

		case S32: /* e.g. "%b0." */
			switch ((unsigned char) c) {
			case '0':
			case '1': state = S34; break;
			default:  lx->lgetc = NULL; return TOK_UNKNOWN;
			}
			break;

		case S33: /* e.g. "%b0-0" */
			switch ((unsigned char) c) {
			case '0':
			case '1': break;
			default:  lx_abnf_ungetc(lx, c); return TOK_BINRANGE;
			}
			break;

		case S34: /* e.g. "%b0.0" */
			switch ((unsigned char) c) {
			case '0':
			case '1': break;
			case '.': state = S32; break;
			default:  lx_abnf_ungetc(lx, c); return TOK_BINSTR;
			}
			break;

		case S35: /* e.g. "%d0-" */
			switch ((unsigned char) c) {
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9': state = S37; break;
			default:  lx->lgetc = NULL; return TOK_UNKNOWN;
			}
			break;

		case S36: /* e.g. "%d0." */
			switch ((unsigned char) c) {
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9': state = S38; break;
			default:  lx->lgetc = NULL; return TOK_UNKNOWN;
			}
			break;

		case S37: /* e.g. "%d0-0" */
			switch ((unsigned char) c) {
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9': break;
			default:  lx_abnf_ungetc(lx, c); return TOK_DECRANGE;
			}
			break;

		case S38: /* e.g. "%d0.0" */
			switch ((unsigned char) c) {
			case '.': state = S36; break;
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9': break;
			default:  lx_abnf_ungetc(lx, c); return TOK_DECSTR;
			}
			break;

		default:
			; /* unreached */
		}

		switch (state) {
		case S1:
		case S3:
		case S10:
		case S11:
		case S20:
		case S21:
		case S23:
			break;

		default:
			if (lx->push != NULL) {
				if (-1 == lx->push(lx->buf_opaque, c)) {
					return TOK_ERROR;
				}
			}
			break;

		}
	}

	lx->lgetc = NULL;

	switch (state) {
	case NONE: return TOK_EOF;
	case S1: return TOK_EOF;
	case S2: return TOK_EOF;
	case S3: return TOK_EOF;
	case S5: return TOK_STARTGROUP;
	case S6: return TOK_ENDGROUP;
	case S7: return TOK_REP;
	case S8: return TOK_ALT;
	case S9: return TOK_COUNT;
	case S10: return TOK_EOF;
	case S11: return TOK_EOF;
	case S12: return TOK_EQUALS;
	case S13: return TOK_IDENT;
	case S14: return TOK_STARTOPT;
	case S15: return TOK_ENDOPT;
	case S16: return TOK_SEP;
	case S17: return TOK_ALTINC;
	case S23: return TOK_EOF;
	case S24: return TOK_BINSTR;
	case S25: return TOK_DECSTR;
	case S26: return TOK_HEXSTR;
	case S29: return TOK_HEXSTR;
	case S30: return TOK_HEXRANGE;
	case S33: return TOK_BINRANGE;
	case S34: return TOK_BINSTR;
	case S37: return TOK_DECRANGE;
	case S38: return TOK_DECSTR;
	default: errno = EINVAL; return TOK_ERROR;
	}
}

const char *
lx_abnf_name(enum lx_abnf_token t)
{
	switch (t) {
	case TOK_ENDOPT: return "ENDOPT";
	case TOK_STARTOPT: return "STARTOPT";
	case TOK_COUNT: return "COUNT";
	case TOK_REP: return "REP";
	case TOK_ENDGROUP: return "ENDGROUP";
	case TOK_STARTGROUP: return "STARTGROUP";
	case TOK_ALTINC: return "ALTINC";
	case TOK_ALT: return "ALT";
	case TOK_CS_LITERAL: return "CS_LITERAL";
	case TOK_CI_LITERAL: return "CI_LITERAL";
	case TOK_HEXRANGE: return "HEXRANGE";
	case TOK_DECRANGE: return "DECRANGE";
	case TOK_BINRANGE: return "BINRANGE";
	case TOK_HEXSTR: return "HEXSTR";
	case TOK_DECSTR: return "DECSTR";
	case TOK_BINSTR: return "BINSTR";
	case TOK_EQUALS: return "EQUALS";
	case TOK_SEP: return "SEP";
	case TOK_CHAR: return "CHAR";
	case TOK_PROSE: return "PROSE";
	case TOK_IDENT: return "IDENT";
	case TOK_EOF:     return "EOF";
	case TOK_ERROR:   return "ERROR";
	case TOK_UNKNOWN: return "UNKNOWN";
	default: return "?";
	}
}

const char *
lx_abnf_example(enum lx_abnf_token (*z)(struct lx_abnf_lx *), enum lx_abnf_token t)
{
	assert(z != NULL);

	if (z == z0) {
		switch (t) {
		case TOK_CS_LITERAL: return "\"";
		case TOK_CHAR: return "a";
		default: goto error;
		}
	} else
	if (z == z1) {
		switch (t) {
		case TOK_CI_LITERAL: return "\"";
		case TOK_CHAR: return "a";
		default: goto error;
		}
	} else
	if (z == z2) {
		switch (t) {
		case TOK_CHAR: return "a";
		case TOK_PROSE: return ">";
		default: goto error;
		}
	} else
	if (z == z3) {
		switch (t) {
		default: goto error;
		}
	} else
	if (z == z4) {
		switch (t) {
		case TOK_ENDOPT: return "]";
		case TOK_STARTOPT: return "[";
		case TOK_COUNT: return "0";
		case TOK_REP: return "*";
		case TOK_ENDGROUP: return ")";
		case TOK_STARTGROUP: return "(";
		case TOK_ALTINC: return "=\057";
		case TOK_ALT: return "\057";
		case TOK_HEXRANGE: return "%xa-a";
		case TOK_DECRANGE: return "%d0-0";
		case TOK_BINRANGE: return "%b0-0";
		case TOK_HEXSTR: return "%xa";
		case TOK_DECSTR: return "%d0";
		case TOK_BINSTR: return "%b0";
		case TOK_EQUALS: return "=";
		case TOK_SEP: return "\n\n";
		case TOK_IDENT: return "a";
		default: goto error;
		}
	}

error:

	errno = EINVAL;
	return NULL;
}

void
lx_abnf_init(struct lx_abnf_lx *lx)
{
	static struct lx_abnf_lx lx_default;

	assert(lx != NULL);

	*lx = lx_default;

	lx->c = EOF;
	lx->z = z4;

	lx->end.byte = 0;
	lx->end.line = 1;
	lx->end.col  = 1;
}

enum lx_abnf_token
lx_abnf_next(struct lx_abnf_lx *lx)
{
	enum lx_abnf_token t;

	assert(lx != NULL);
	assert(lx->z != NULL);

	if (lx->lgetc == NULL) {
		return TOK_EOF;
	}

	t = lx->z(lx);

	if (lx->push != NULL) {
		if (-1 == lx->push(lx->buf_opaque, '\0')) {
			return TOK_ERROR;
		}
	}

	return t;
}

