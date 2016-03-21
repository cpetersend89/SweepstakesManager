using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManagement
{
    class Contestant
    {
        private readonly string _name;
        private readonly string _phonenumber;

        public Contestant(string name, string phonenumber)
        {
            _name = name;
            _phonenumber = phonenumber;
        }

        public override string ToString()
        {
            return _name + " " + _phonenumber;
        }
    }
}
