using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class EmailExeption : Exception
    {
        private string _message;

        public EmailExeption(string message)
        {
            this._message = message;
        }
        public EmailExeption(string message, string email) : this(message)
        {
        }

        public override string Message
        {
            get { return _message; }
        }
    }
}