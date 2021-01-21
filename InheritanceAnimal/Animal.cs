using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    public abstract class Animal
    {
        private string _name;

        protected string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        protected Animal(string name)
        {
            Name = name;
        }
        public virtual string Eating()
        {
            return "";
        }
        public virtual string Talking(string sentence)
        {
            return "";
        }
        public virtual string Petting()
        {
            return "";
        }
    }
}
