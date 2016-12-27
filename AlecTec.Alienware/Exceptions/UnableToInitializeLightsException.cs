using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AlecTec.Alienware
{
    [Serializable]
    public class UnableToInitializeLightsException : Exception
    {
      
        public UnableToInitializeLightsException()
        {
        }

        public UnableToInitializeLightsException(string message) : base(message)
        {
        }

        public UnableToInitializeLightsException(string message, Exception inner) : base(message, inner)
        {
        }

        protected UnableToInitializeLightsException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
