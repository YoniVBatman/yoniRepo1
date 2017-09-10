using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Actor
    {
        private string id;
        private char gender;

        private int numFilms;

        public Actor(string id, char gender, int numFilms)
        {
            this.id = id;
            this.gender = gender;
            this.numFilms = numFilms;
        }

        public string getId() => id;
        public void setId(string id) => this.id = id;

        public char getGender() => gender;
        public void setGender(char gender) => this.gender = gender;

        public int getNumFilms() => numFilms;
        public void setNumFilms(int numFilms) => this.numFilms = numFilms;

        public void addFilm()
        {
            numFilms++;
        }

        public int Compare(Actor other)
        {
            if (this.getNumFilms() > other.getNumFilms())
                return 1;
            else if (this.getNumFilms() < other.getNumFilms())
                return 2;
            else 
                return 3;

        }


    }
}
