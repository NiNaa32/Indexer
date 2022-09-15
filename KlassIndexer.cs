using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class KlassIndexer
    {
        private string[] array = new string[5];
        public string this [int arraysindex]
        {
            get
            {
                return array[arraysindex];
            }
            set
            {
                array[arraysindex] = value;
            }
        }
    }
    // Den föregående klassen använder denna pekare när den deklarerar en array 
}
