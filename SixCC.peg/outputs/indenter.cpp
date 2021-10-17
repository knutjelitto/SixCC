#include "indenter.h"

namespace sixpeg
{
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
}