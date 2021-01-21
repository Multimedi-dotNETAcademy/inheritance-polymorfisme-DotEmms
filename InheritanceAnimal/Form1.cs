using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceAnimal
{
    public partial class Form1 : Form
    {
        Animal animal;
        public Form1()
        {
            InitializeComponent();
        }
        private Animal SelectAnimal()
        {
            string name = txtName.Text;
            if (rbCat.Checked)
            {
                var animal = new Cat(name);
                return animal;
            }
            else if (rbParrot.Checked)
            {
                var animal = new Parrot(name);
                return animal;
            }
            else if(rbHuman.Checked)
            {
                var animal = new Human(name);
                return animal;
            }
            else
            {
                return null;
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            animal = SelectAnimal();
        }

        private void btnPet_Click(object sender, EventArgs e)
        {
            MessageBox.Show(animal.Petting(),"Petting time!", MessageBoxButtons.OK);
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            MessageBox.Show(animal.Eating(),"Feeding time!",MessageBoxButtons.OK);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            MessageBox.Show(animal.Talking(listBox1.SelectedItem.ToString()),"Speech", MessageBoxButtons.OK);
        }
    }
}
