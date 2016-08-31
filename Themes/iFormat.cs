using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GSThemes
{
    public interface iFormat
    {
        string DocType();
        string Head();
        string Body();
    }
}
