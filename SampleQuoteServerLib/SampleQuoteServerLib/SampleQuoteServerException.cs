using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuoteServerLib
{
    [Serializable]
    public class SampleQuoteServerException : Exception
    {
        public SampleQuoteServerException() { }
        public SampleQuoteServerException(string message) : base(message) { }
        public SampleQuoteServerException(string message, Exception inner) : base(message, inner) { }
        protected SampleQuoteServerException(System.Runtime.Serialization.SerializationInfo info, 
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
