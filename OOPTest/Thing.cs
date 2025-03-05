using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    public abstract class Thing
    {
        private string _name;

        public Thing(string name)
        {
            this._name = name;
        }

        public abstract int Size();

        public abstract void Print();

        public string Name
        {
            get { return this._name; }
        }
    }
}
