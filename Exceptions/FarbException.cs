using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class FarbException: Exception
    {
        public FarbException(string message): base(message)
        {

        }
    }
}
