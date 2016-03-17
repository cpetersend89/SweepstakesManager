using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManagement
{
    class SystemString : ICustomString
    {
        public static string EmptyString;

        public SystemString()
        {
            EmptyString = string.Empty;
        }

        public new string ToString()
        {
            return EmptyString;
        }

        public void Insert(int startIndex, string stringToInsert)
        {
            EmptyString = EmptyString.Insert(startIndex, stringToInsert);
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            EmptyString = EmptyString.Remove(startIndex, numCharsToRemove);
        }

        public int Lenght()
        {
            return EmptyString.Length;
        }


    }
}
