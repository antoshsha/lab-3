using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Errors
    {
        public class LateDateError : Exception{
            public string message = "the date of birth is invalid, because it is in the future";
        }
        public class EarlyDateError : Exception
        {
            public string message = "the date of birth is invalid, because people can't be that old";
        }
        public class EmailFormat : Exception
        {
            public string message = "the email format is invalid";
        }
        public class LastNameFormat : Exception
        {
            public string message = "the lastname format is invalid";
        }
        public class NameFormat : Exception
        {
            public string message = "the name format is invalid";
        }
    }
}
