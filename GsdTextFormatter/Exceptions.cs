using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsdTextFormatter
{
    class SynqFormattingException : Exception
    {
        public SynqFormattingException(string message) :
            base(message)
        { }
    }

    class EmptyInputException : SynqFormattingException
    {
        public EmptyInputException() :
            base("Error: the input is empty")
        { }
    }

    class EmptyResultException : SynqFormattingException
    {
        public EmptyResultException() :
            base("Error: formatting produced an empty result")
        { }
    }

    class UnknownFormattingException : SynqFormattingException
    {
        public UnknownFormattingException() :
            base("unknown formatting exception" +
                Environment.NewLine + "Please send a screenshot to Jacob West")
        { }
    }
}
