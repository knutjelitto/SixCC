/*
 * Copyright 2008-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#pragma once
#ifndef ERRORS_H
#define ERRORS_H

#include <stdexcept>

struct Error
{
    [[noreturn]] static inline void conversion() throw(std::logic_error)
    {
        throw std::logic_error("conversion failure");
    }

    [[noreturn]] static inline void range() throw(std::logic_error)
    {
        throw std::logic_error("conversion range failure");
    }

    [[noreturn]] static inline void notreached() throw(std::logic_error)
    {
        throw std::logic_error("fatal internal error: reached a not-reached");
    }

    [[noreturn]] static inline void notimplemented() throw(std::logic_error)
    {
        throw std::logic_error("fatal internal error: not implemented");
    }
};

#endif