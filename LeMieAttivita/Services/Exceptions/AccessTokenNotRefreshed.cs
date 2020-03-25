using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeMieAttivita.Services.Exceptions
{
    public class AccessTokenNotRefreshed : ApplicationException
    {
        public AccessTokenNotRefreshed(string message) : base(message) { }
    }
}
