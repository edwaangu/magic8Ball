using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magic8Ball
{
    public partial class Form1 : Form
    {
        // Random number generator

        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void ballButton_Click(object sender, EventArgs e)
        {
            int answer = randGen.Next(1, 7);
            switch (answer) {
                case 1:
                    outputAnswer.Text = "Don't count on it.";
                    break;
                case 2:
                    outputAnswer.Text = "Very doubtful.";
                    break;
                case 3:
                    outputAnswer.Text = "Cannot predict now.";
                    break;
                case 4:
                    outputAnswer.Text = "Most likely.";
                    break;
                case 5:
                    outputAnswer.Text = "It is certain.";
                    break;
                case 6:
                    outputAnswer.Text = "You may rely on it.";
                    break;
            }
        }
    }
}
