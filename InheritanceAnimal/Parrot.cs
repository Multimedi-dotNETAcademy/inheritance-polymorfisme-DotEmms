using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    class Parrot : Animal
    {
        public Parrot(string name)
            :base(name)
        {

        }
        public override string Talking(string sentence)
        {
            if (true)
            {

            }
            return base.Talking(sentence);
        }
        public override string Petting()
        {
            return "Argh, thanks matey";
        }
    }
}
