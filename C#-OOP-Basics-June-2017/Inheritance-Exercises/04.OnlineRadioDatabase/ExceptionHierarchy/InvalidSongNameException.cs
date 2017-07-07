using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OnlineRadioDatabase.ExceptionHierarchy
{
    class InvalidSongNameException : InvalidSongException
    {
        public override string Message => "Song name should be between 3 and 30 symbols.";
    }
}
