using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class PastBirthExeption : Exception
    {
        private string _message;

        public PastBirthExeption(string message)
        {
            this._message = message;
        }
        public PastBirthExeption(string message, DateTime date) : this(message)
        {
        }

        public override string Message
        {
            get { return _message; }
        }
    }
}