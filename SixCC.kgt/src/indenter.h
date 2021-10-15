#pragma once
#ifndef _indenter_h
#define _indenter_h

#include <string>
#include <sstream>

class indenter : private std::ostringstream
{
public:
    std::string str() const
    {
        return std::ostringstream::str();
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
                write(istring.c_str(), istring.size());
            }
            pending = false;
        }
        write(s.c_str(), s.size());
        return *this;

    }

    indenter& operator<<(const char* s)
    {
        return *this << std::string(s);
    }

private:

    friend indenter& endl(indenter& ind);
    friend indenter& indent(indenter& ind);
    friend indenter& undent(indenter& ind);

    const std::string istring = "__";
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
