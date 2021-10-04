/*
 * Copyright 2008-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef BITMAP_H
#define BITMAP_H

#include <limits.h>

struct bm
{
    static constexpr int map_size = UCHAR_MAX / CHAR_BIT + 1;

    bm()
    {
        for (int i = 0; i < map_size; ++i)
        {
            map[i] = 0;
        }
    }

    unsigned char map[map_size];
};

int bm_get(const struct bm *bm, size_t i);

void bm_set(struct bm *bm, size_t i);

void bm_unset(struct bm *bm, size_t i);

size_t bm_next(const struct bm *bm, int i, int value);

unsigned int bm_count(const struct bm *bm);

void bm_clear(struct bm *bm);

void bm_invert(struct bm *bm);

#endif

