﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManagement
{
    public class SystemArrayString : ICustomString
    {
        public static char[] CharArray;


        public SystemArrayString()
        {
            CharArray = new char[0];
        }
        public new string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (char value in CharArray)
            {
                builder.Append(value);
                builder.Append("");
            }
            return builder.ToString();
        }
        public void Insert(int startIndex, string stringToInsert)
        {
            char[] tempCharArray = new char[CharArray.Length + stringToInsert.Length + stringToInsert.Length];
            CharArray.CopyTo(tempCharArray, 0);
            char[] stringToCharArray = stringToInsert.ToCharArray();
            for (int i = 0; i < stringToInsert.Length; i++)
            {
                tempCharArray[startIndex + stringToInsert.Length + i] = tempCharArray[startIndex + i];
            }
            stringToCharArray.CopyTo(tempCharArray, startIndex);
            Array.Resize(ref tempCharArray, CharArray.Length + stringToInsert.Length);
            CharArray = tempCharArray;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            char[] tempCharArray = new char[CharArray.Length - numCharsToRemove];
            for (int i = 0; i < numCharsToRemove; i++)
            {
                
            }
        }

        public int Lenght()
        {
            return CharArray.Length;
        }
    }
}
