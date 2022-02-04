using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ind
{
    class Ind
    {
        public string Name { get; set; }
        public string Book { get; set; }


        private Ind[] arr;

         public Ind()
        {
            
            arr = new Ind[2];
        } 
        public Ind this [int index]
        {
            get { return arr[index]; }

            set { arr[index] = value; }
        }


    }
}
