using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishingHouse.Abstractions.Exception
{
    public class AccessException : System.Exception
    {
        public AccessException()
            : base("Access error.")
        {
        }

        public AccessException(string message)
            : base(message)
        {
        }
    }
}
