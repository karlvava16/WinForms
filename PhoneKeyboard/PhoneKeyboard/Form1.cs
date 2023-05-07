using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneKeyboard
{
    public partial class Form1 : Form
    {
        private bool capsLook = false;
        private List<System.Windows.Forms.Button> Characters = new List<System.Windows.Forms.Button>();
        private List<string> engDictionary = new List<string>
{
    "apple",
    "banana",
    "carrot",
    "dog",
    "elephant",
    "frog",
    "giraffe",
    "house",
    "ice cream",
    "jacket",
    "kangaroo",
    "lemon",
    "monkey",
    "nose",
    "octopus",
    "pear",
    "queen",
    "rabbit",
    "sun",
    "tiger",
    "umbrella",
    "violin",
    "watermelon",
    "xylophone",
    "yellow",
    "zebra",
    "ant",
    "bird",
    "cat",
    "deer",
    "eagle",
    "fish",
    "guitar",
    "horse",
    "iguana",
    "jellyfish",
    "kite",
    "lion",
    "mango",
    "nest",
    "ocean",
    "panda",
    "quilt",
    "rose",
    "snake",
    "tulip",
    "unicorn",
    "volcano",
    "whale",
    "xylophone",
    "yacht",
    "zeppelin"
};

        public Form1()
        {
            InitializeComponent();
            #region add buttons with alphabet
            Characters.Add(button11);
            Characters.Add(button12);
            Characters.Add(button13);
            Characters.Add(button14);
            Characters.Add(button15);
            Characters.Add(button16);
            Characters.Add(button17);
            Characters.Add(button18);
            Characters.Add(button19);
            Characters.Add(button20);
            Characters.Add(button22);
            Characters.Add(button23);
            Characters.Add(button24);
            Characters.Add(button25);
            Characters.Add(button26);
            Characters.Add(button27);
            Characters.Add(button28);
            Characters.Add(button29);
            Characters.Add(button30);
            Characters.Add(button31);
            Characters.Add(button32);
            Characters.Add(button33);
            Characters.Add(button34);
            Characters.Add(button35);
            Characters.Add(button36);
            Characters.Add(button37);
            Characters.Add(button43);
            #endregion
        }


        private void SearchForWord()
        {
            int index = richTextBox1.Text.LastIndexOf(' ');
            if (index == -1)
            {
                index = 0;
            }
            else
                index++;
            string temp = richTextBox1.Text.ToString().Substring(index);
            button44.Text = engDictionary.Find(w => w.StartsWith(temp));
        }


        private void TypeCharacter(object sender, EventArgs e)
        {
            richTextBox1.Text += ((System.Windows.Forms.Button)sender).Text.ToString();
            SearchForWord();
        }

        private void TypeSpace(object sender, EventArgs e)
        {
            richTextBox1.Text += " ";
            button44.Text = "";
        }

        private void ChangeShift(object sender, EventArgs e)
        {
            capsLook = !capsLook;
            if(capsLook)
            {
                button38.BackColor = Color.Yellow;
                foreach (var ch in Characters)
                {
                    ch.Text = ch.Text.ToUpper();
                }
            }
            else
            {
                button38.BackColor = Color.White;
                foreach (var ch in Characters)
                {
                    ch.Text = ch.Text.ToLower();
                }
            }
        }

        private void DelChar(object sender, EventArgs e)
        {
            if(richTextBox1.Text.ToString().Length != 0)
            {
                richTextBox1.Text = richTextBox1.Text.ToString().Substring(0, richTextBox1.Text.ToString().Length - 1);
                SearchForWord();
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (button44.Text.ToString().Length == 0)
                return;

            int index = richTextBox1.Text.LastIndexOf(' ');
            if (index == -1)
            {
                index = 0;
            }
            richTextBox1.Text = richTextBox1.Text.ToString().Substring(0, index) + button44.Text;
        }
    }
}
