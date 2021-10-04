/* Generated by lx */

#ifndef LX_H
#define LX_H

enum lx_wsn_token {
	TOK_EMPTY,
	TOK_IDENT,
	TOK_ENDGROUP,
	TOK_STARTGROUP,
	TOK_ENDOPT,
	TOK_STARTOPT,
	TOK_ENDSTAR,
	TOK_STARTSTAR,
	TOK_CHAR,
	TOK_ESC,
	TOK_CS_LITERAL,
	TOK_SEP,
	TOK_ALT,
	TOK_EQUALS,
	TOK_EOF,
	TOK_ERROR,
	TOK_UNKNOWN
};

/*
 * .byte is 0-based.
 * .line, .col, and .saved_col are 1-based; 0 means unknown.
 */
struct lx_pos {
	unsigned byte;
	unsigned line;
	unsigned col;
	unsigned saved_col;
};

struct lx_wsn_lx {
	int (*lgetc)(struct lx_wsn_lx *lx);
	void *getc_opaque;

	int c; /* lx_wsn_ungetc buffer */

	struct lx_pos start;
	struct lx_pos end;

	void *buf_opaque;
	int  (*push) (void *buf_opaque, char c);
	int  (*clear)(void *buf_opaque);
	void (*free) (void *buf_opaque);

	enum lx_wsn_token (*z)(struct lx_wsn_lx *lx);
};

/*
 * The initial buffer size; this ought to be over the typical token length,
 * so as to avoid a run-up of lots of resizing.
 */
#ifndef LX_DYN_LOW
#define LX_DYN_LOW 1 << 10
#endif

/*
 * High watermark; if the buffer grows over this, it will resize back down
 * by LX_DYN_FACTOR when no longer in use.
 */
#ifndef LX_DYN_HIGH
#define LX_DYN_HIGH 1 << 13
#endif

/*
 * Andrew Koenig said the growth factor should be less than phi, (1 + sqrt(5)) / 2
 * P.J. Plauger said 1.5 works well in practice. (Perhaps because of internal
 * bookkeeping data stored by the allocator.)
 *
 * Non-integer factors here add the constraint that LX_DYN_LOW > 1 because
 * because conversion to size_t truncates, and e.g. 1 * 1.5 == 1 is no good
 * as the requirement is to *increase* a buffer.
 */
#ifndef LX_DYN_FACTOR
#define LX_DYN_FACTOR 2
#endif

/* dynamic token buffer */
struct lx_dynbuf {
	char *p;
	size_t len;
	char *a;
};

const char *lx_wsn_name(enum lx_wsn_token t);
const char *lx_wsn_example(enum lx_wsn_token (*z)(struct lx_wsn_lx *), enum lx_wsn_token t);

void lx_wsn_init(struct lx_wsn_lx *lx);
enum lx_wsn_token lx_wsn_next(struct lx_wsn_lx *lx);

int  lx_wsn_dynpush(void *buf_opaque, char c);
int  lx_wsn_dynclear(void *buf_opaque);
void lx_wsn_dynfree(void *buf_opaque);

#endif

