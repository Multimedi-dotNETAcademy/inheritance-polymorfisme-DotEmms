using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    class Cat : Animal
    {
        int counter;
        public Cat(string name)
            :base(name)
        {

        }
        public override string Talking(string sentence)
        {
            counter++;
            if (counter % 3 == 0)
            {
                return "Miauw!";
            }
            return base.Talking(sentence);
        }
        public override string Petting()
        {
            return "Purrrrr";
        }
    }
}
