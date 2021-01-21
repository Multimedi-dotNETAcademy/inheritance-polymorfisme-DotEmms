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
            switch ()
            {
                case "Hello":
                    break;
                case "Good Morning?":
                    break;
                case "How are you?":
                    break;
                case "I'm hungry, have food?":
                    break;
                case "Boo!":
                    break;
                case "Tell me something interesting pls?":
                    break;
                case "If you add 10 + 12, how many fishes do you get?":
                    break;
                case "What color is your hair?":
                    break;
                case "What time is it?":
                    break;
                case "Allright, allright, allright...":
                    break;
                default:
                    break;
            }
            return base.Talking(sentence);
        }
        public override string Petting()
        {
            return base.Petting() + $"Keep your hands off!";
        }
    }
}
