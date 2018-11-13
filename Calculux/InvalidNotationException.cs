using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux {
    class InvalidNotationException : Exception {

        public InvalidNotationException() { }
        public InvalidNotationException(string message) : base(message) { }
        public InvalidNotationException(string message, Exception inner) : base(message, inner) { }

    }
}
