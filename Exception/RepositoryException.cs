using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishingHouse.Abstractions.Exception
{
    public class RepositoryException : System.Exception
    {
        public RepositoryException()
            : base("Something went wrong with the repository.")
        {
        }

        public RepositoryException(string message)
            : base(message)
        {
        }
    }
}
