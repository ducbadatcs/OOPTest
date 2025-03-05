using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    public class File : Thing
    {
        private string _extension;
        private int _size;

        public File(string name, string extension, int size) : base(name)
        {
            this._extension = extension;
            this._size = size;
        }

        public override int Size()
        {
            return this._size;
        }

        public override void Print()
        {
            Console.WriteLine($"File '{this.Name}.{this._extension} Size: {this.Size} bytes");
        }


    }
}
