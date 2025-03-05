using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    public class Folder : Thing
    {
        private List<Thing> _contents;
        public Folder(string name) : base(name)
        {
            this._contents = new List<Thing>();
        }

        public void Add(Thing toAdd)
        {
            this._contents.Add(toAdd);
        }

        public override int Size()
        {
            int size = 0;
            foreach (Thing thing in this._contents)
            {
                size += thing.Size();
            }
            return size;
        }

        public override void Print()
        {
            Console.WriteLine($"The folder {this.Name} contains {this._contents.Count} items totalling {this.Size()} bytes:");
            foreach (Thing thing in this._contents)
            {
                thing.Print();
            }
        }
    }
}
