using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class FutureBirthExeption : Exception
    {
        private string _message;

        public FutureBirthExeption(string message)
        {
            this._message = message;
        }
        public FutureBirthExeption(string message, DateTime date) : this(message)
        {
        }

        public override string Message
        {
            get { return _message; }
        }
    }
}