using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract_Project
{
    public abstract class Media
    {
        public Media()
        {
            Print();
        }
        public abstract void Print();
    }
}