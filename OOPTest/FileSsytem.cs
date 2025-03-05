using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    public class FileSsytem
    {
        private List<Thing> _contents;

        public FileSsytem()
        {

            this._contents = new List<Thing>();
        }

        public void AddThing(Thing toAdd)
        {
            this._contents.Add(toAdd);
        }
        
        public void PrintContents()
        {
            Console.WriteLine($"This File System contains:");
            foreach (Thing thing in this._contents)
            {
                thing.Print();
            }
        }
    }
}
