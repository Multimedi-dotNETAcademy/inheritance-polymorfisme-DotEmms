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
            Random rnd = new Random();
            int rndSentence = rnd.Next(1, 5);
            if (rndSentence == 1)
            {
                return "Koko scratch head!";
            }
            else
            {
                return "Koko";
            }
        }
        public override string Petting()
        {
            return "Argh, thanks matey";
        }
    }
}
