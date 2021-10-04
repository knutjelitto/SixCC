/* Generated by lx */

#include <assert.h>
#include <stdio.h>
#include <stddef.h>
#include <stdlib.h>
#include <errno.h>

#include "lexer.h"

static enum lx_rbnf_token z0(struct lx_rbnf_lx *lx);
static enum lx_rbnf_token z1(struct lx_rbnf_lx *lx);

#if __STDC_VERSION__ >= 199901L
inline
#endif
static int
lx_getc(struct lx_rbnf_lx *lx)
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
lx_rbnf_ungetc(struct lx_rbnf_lx *lx, int c)
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
lx_rbnf_dynpush(void *buf_opaque, char c)
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
lx_rbnf_dynclear(void *buf_opaque)
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
lx_rbnf_dynfree(void *buf_opaque)
{
	struct lx_dynbuf *t = (struct lx_dynbuf*)buf_opaque;

	assert(t != NULL);

	free(t->a);
}
static enum lx_rbnf_token
z0(struct lx_rbnf_lx *lx)
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
			case '>': state = S2; break;
			case '\t':
			case '\n':
			case '\v':
			case '\f':
			case '\r': lx->lgetc = NULL; return TOK_UNKNOWN;
			default: state = S1; break;
			}
			break;

		case S1: /* e.g. "a" */
			lx_rbnf_ungetc(lx, c); return TOK_CHAR;

		case S2: /* e.g. ">" */
			lx_rbnf_ungetc(lx, c); return lx->z = z1, TOK_NAME;

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
	case S2: return TOK_NAME;
	default: errno = EINVAL; return TOK_ERROR;
	}
}

static enum lx_rbnf_token
z1(struct lx_rbnf_lx *lx)
{
	int c;

	enum {
		S0, S1, S2, S3, S4, S5, S6, S7, S8, S9, 
		S10, S11, S12, S13, S14, S15, NONE
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
			case '\t':
			case '\v':
			case '\f':
			case '\r':
			case ' ': state = S1; break;
			case '\n': state = S2; break;
			case '(': state = S3; break;
			case ')': state = S4; break;
			case '.': state = S5; break;
			case ':': state = S6; break;
			case '<': state = S7; break;
			case '[': state = S8; break;
			case ']': state = S9; break;
			case '|': state = S10; break;
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
			default:  lx_rbnf_ungetc(lx, c); return lx->z(lx);
			}
			break;

		case S2: /* e.g. "\n" */
			switch ((unsigned char) c) {
			case '\n': state = S15; break;
			default:  lx_rbnf_ungetc(lx, c); return lx->z(lx);
			}
			break;

		case S3: /* e.g. "(" */
			lx_rbnf_ungetc(lx, c); return TOK_STARTGROUP;

		case S4: /* e.g. ")" */
			lx_rbnf_ungetc(lx, c); return TOK_ENDGROUP;

		case S5: /* e.g. "." */
			switch ((unsigned char) c) {
			case '.': state = S11; break;
			default:  lx->lgetc = NULL; return TOK_UNKNOWN;
			}
			break;

		case S6: /* e.g. ":" */
			switch ((unsigned char) c) {
			case ':': state = S12; break;
			default:  lx->lgetc = NULL; return TOK_UNKNOWN;
			}
			break;

		case S7: /* e.g. "<" */
			lx_rbnf_ungetc(lx, c); return lx->z = z0, lx->z(lx);

		case S8: /* e.g. "[" */
			lx_rbnf_ungetc(lx, c); return TOK_STARTOPT;

		case S9: /* e.g. "]" */
			lx_rbnf_ungetc(lx, c); return TOK_ENDOPT;

		case S10: /* e.g. "|" */
			lx_rbnf_ungetc(lx, c); return TOK_ALT;

		case S11: /* e.g. ".." */
			switch ((unsigned char) c) {
			case '.': state = S14; break;
			default:  lx->lgetc = NULL; return TOK_UNKNOWN;
			}
			break;

		case S12: /* e.g. "::" */
			switch ((unsigned char) c) {
			case '=': state = S13; break;
			default:  lx->lgetc = NULL; return TOK_UNKNOWN;
			}
			break;

		case S13: /* e.g. "::=" */
			lx_rbnf_ungetc(lx, c); return TOK_EQUALS;

		case S14: /* e.g. "..." */
			lx_rbnf_ungetc(lx, c); return TOK_REP;

		case S15: /* e.g. "\n\n" */
			lx_rbnf_ungetc(lx, c); return TOK_SEP;

		default:
			; /* unreached */
		}

		switch (state) {
		case S1:
		case S7:
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
	case S3: return TOK_STARTGROUP;
	case S4: return TOK_ENDGROUP;
	case S7: return TOK_EOF;
	case S8: return TOK_STARTOPT;
	case S9: return TOK_ENDOPT;
	case S10: return TOK_ALT;
	case S13: return TOK_EQUALS;
	case S14: return TOK_REP;
	case S15: return TOK_SEP;
	default: errno = EINVAL; return TOK_ERROR;
	}
}

const char *
lx_rbnf_name(enum lx_rbnf_token t)
{
	switch (t) {
	case TOK_ENDGROUP: return "ENDGROUP";
	case TOK_STARTGROUP: return "STARTGROUP";
	case TOK_REP: return "REP";
	case TOK_ALT: return "ALT";
	case TOK_ENDOPT: return "ENDOPT";
	case TOK_STARTOPT: return "STARTOPT";
	case TOK_SEP: return "SEP";
	case TOK_CHAR: return "CHAR";
	case TOK_NAME: return "NAME";
	case TOK_EQUALS: return "EQUALS";
	case TOK_EOF:     return "EOF";
	case TOK_ERROR:   return "ERROR";
	case TOK_UNKNOWN: return "UNKNOWN";
	default: return "?";
	}
}

const char *
lx_rbnf_example(enum lx_rbnf_token (*z)(struct lx_rbnf_lx *), enum lx_rbnf_token t)
{
	assert(z != NULL);

	if (z == z0) {
		switch (t) {
		case TOK_CHAR: return "a";
		case TOK_NAME: return ">";
		default: goto error;
		}
	} else
	if (z == z1) {
		switch (t) {
		case TOK_ENDGROUP: return ")";
		case TOK_STARTGROUP: return "(";
		case TOK_REP: return "...";
		case TOK_ALT: return "|";
		case TOK_ENDOPT: return "]";
		case TOK_STARTOPT: return "[";
		case TOK_SEP: return "\n\n";
		case TOK_EQUALS: return "::=";
		default: goto error;
		}
	}

error:

	errno = EINVAL;
	return NULL;
}

void
lx_rbnf_init(struct lx_rbnf_lx *lx)
{
	static struct lx_rbnf_lx lx_default;

	assert(lx != NULL);

	*lx = lx_default;

	lx->c = EOF;
	lx->z = z1;

	lx->end.byte = 0;
	lx->end.line = 1;
	lx->end.col  = 1;
}

enum lx_rbnf_token
lx_rbnf_next(struct lx_rbnf_lx *lx)
{
	enum lx_rbnf_token t;

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

