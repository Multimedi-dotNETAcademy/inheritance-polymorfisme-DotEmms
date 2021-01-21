using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    class Human : Animal
    {
        public Human(string name)
            :base(name)
        {
        }
        public override string Eating()
        {
            return base.Eating() + $"Tasty!";
        }
        public override string Talking(string sentence)
        {
            switch (switch_on)
            {
                default:
            }
            return base.Talking(sentence);
        }
        public override string Petting()
        {
            return base.Petting() + $"Keep your hands off!";
        }
    }
}
