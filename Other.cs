using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Other
    {
        private int numFilms;

        public Other(int numFilms)
        {
            this.numFilms = numFilms;
        }

        public int getNumFilms() => numFilms;
        public void setNumFilms(int numFilms) => this.numFilms = numFilms;


    }
}
