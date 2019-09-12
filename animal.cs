using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    class animal
    {
        private string animalName;
        public string AnimalName
        {
            get => animalName;
            set => animalName = value;
        }

        private string category;
        public string Category
        {
            get => category;
            set => category = value;
        }

        private string tail;
        public string Tail
        {
            get => tail;
            set => tail = value;
        }
        //constructor
        public animal(string animalName, string category, string tail)
        {
            this.animalName = animalName;
            this.category = category;
            this.tail = tail;
        }

    }
}
