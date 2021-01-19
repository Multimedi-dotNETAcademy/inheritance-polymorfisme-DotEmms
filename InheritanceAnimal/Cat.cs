﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    class Cat : Animal
    {
        public Cat(string name)
            :base(name)
        {

        }
        public override string Talking(string sentence)
        {
            return base.Talking(sentence);
        }
        public override string Petting()
        {
            return base.Petting();
        }
    }
}
