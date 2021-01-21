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
            switch (sentence)
            {
                case "Hello":
                    return "Hi!";
                case "Good Morning?":
                    return "Mornin'";
                case "How are you?":
                    return "I'm good, how about you?";
                case "I'm hungry, have food?":
                    return "Not really, no..";
                case "Boo!":
                    return "Yikes!!!";
                case "Tell me something interesting pls?":
                    return "A circle is round!";
                case "If you add 10 + 12, how many fishes do you get?":
                    return "22?";
                case "What color is your hair?":
                    return "I don't know, you tell me!";
                case "What time is it?":
                    return "break-time!";
                case "Allright, allright, allright...":
                    return "Yeah, baby!";
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
