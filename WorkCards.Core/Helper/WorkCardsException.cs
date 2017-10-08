using System;
using System.Collections.Generic;
using System.Text;

namespace WorkCards.Core.Helper
{
    public abstract class WorkCardsException : Exception
    {
        public string Code { get; }

        protected WorkCardsException()
        {
        }

        protected WorkCardsException(string code)
        {
            Code = code;
        }

        protected WorkCardsException(string message, params object[] args) : this(string.Empty, message, args)
        {
        }

        protected WorkCardsException(string code, string message, params object[] args) : this(null, code, message, args)
        {
        }

        protected WorkCardsException(Exception innerException, string message, params object[] args)
            : this(innerException, string.Empty, message, args)
        {
        }

        protected WorkCardsException(Exception innerException, string code, string message, params object[] args)
            : base(string.Format(message, args), innerException)
        {
            Code = code;
        }
    }
}
