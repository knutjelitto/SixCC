#pragma once

#ifndef _indenter_h
#define _indenter_h

#include <string>
#include <iostream>
#include <sstream>
#include <format>

class indenter
{
public:

    indenter(std::ostream& out) : out(out)
    {
    }

    inline indenter& operator<<(indenter& (*manip)(indenter&))
    {
        return (*manip)(*this);
    }

    inline indenter& operator++()
    {
        level += 1;
        return *this;
    }

    inline indenter& operator--()
    {
        if (level > 0)
        {
            level -= 1;
        }
        return *this;
    }

    inline indenter& operator<<(const std::string& s)
    {
        if (s.size() > 0 && pending)
        {
            for (int i = 0; i < level; i += 1)
            {
                out << istring;
            }
            pending = false;
        }
        out << s;
        out.flush();
        return *this;

    }

    indenter& operator<<(const char* s)
    {
        return *this << std::string(s);
    }

    indenter& operator<<(char c)
    {
        return *this << std::string(1, c);
    }

    indenter& operator<<(int i)
    {
        return *this << std::to_string(i);
    }

private:

    void put(char c)
    {
        out.put(c);
        out.flush();
    }

    friend indenter& endl(indenter& ind);
    friend indenter& indent(indenter& ind);
    friend indenter& undent(indenter& ind);

    std::ostream& out;
    const std::string istring = "  ";
    int level = 0;
    bool pending = true;
};

indenter& endl(indenter& ind)
{
    ind.put('\n');
    ind.pending = true;
    return ind;
}

indenter& indent(indenter& ind)
{
    return ++ind;
}

indenter& undent(indenter& ind)
{
    return --ind;
}

#endif
