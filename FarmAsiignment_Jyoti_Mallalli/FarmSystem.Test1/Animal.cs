using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
    public abstract class Animal
    {
        private string _id;
        private int _noOfLegs;


        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            set
            {
                _noOfLegs = value;
            }
        }

        public abstract void Talk();
        public abstract void Run();


    }
}
