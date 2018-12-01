using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux {
    class NotSupportedOperationException : Exception {

        public NotSupportedOperationException() { }
        public NotSupportedOperationException(string message) : base(message) { }
        public NotSupportedOperationException(string message, Exception inner) : base(message, inner) { }

    }
}
