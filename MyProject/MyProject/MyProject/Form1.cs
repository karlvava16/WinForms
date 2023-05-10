using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib.MyStudent;
using static System.Windows.Forms.ListView;

namespace MyProject
{
    public partial class Form1 : Form
    {
        List<Student> students;

        Regex validName = new Regex(@"^[A-Za-zа-яА-Я]+(?:\s+[A-Za-z]+)*$");
        Regex validAge = new Regex(@"^(?:[1-9][0-9]?|1[01][0-9]|120)$");
        Regex validAcademy = new Regex(@"^[A-Za-z0-9\s&\.,'\(\)-]+(?:\s+[A-Za-z0-9\s&\.,'\(\)-]+)*$");

        public Form1()
        {
            InitializeComponent();
            students = new List<Student>();
            students.Add(new Student("Ivan",20,"ItStep"));
            students.Add(new Student("Oleg", 23, "Politex"));
            students.Add(new Student("Irina", 22, "ItStep"));

            listView1.Columns.Add("Имя");
            listView1.Columns.Add("Возраст");
            listView1.Columns.Add("Университет");
            listView1.View = View.Details;
            foreach (var a in students)
            {
                ListViewItem rez = listView1.Items.Add(a.Name);
                rez.SubItems.Add(a.Age.ToString());
                rez.SubItems.Add(a.Academy);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "";
            if (textBox1.Text.Length == 0)
            {
                message += "Имя не введено.\n";
            }
            else
            {
                if (!validName.IsMatch(textBox1.Text))
                {
                    message += "Не верный ввод имени.\n";
                }
            }

            if (textBox2.Text.Length == 0)
            {
                message += "Возраст не введен.\n";
            }
            else
            {
                if (!validAge.IsMatch(textBox2.Text))
                {
                    message += "Не верный ввод возраста.\n";
                }
            }

            if (textBox3.Text.Length == 0)
            {
                message += "Университет не введен.\n";
            }
            else
            {
                if (!validAcademy.IsMatch(textBox3.Text))
                {
                    message += "Не верный ввод университета.\n";
                }
            }


            if (message.Length == 0)
            {
                students.Add(new Student(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text));
                ListViewItem rez = listView1.Items.Add(students[students.Count - 1].Name);
                rez.SubItems.Add(students[students.Count - 1].Age.ToString());
                rez.SubItems.Add(students[students.Count - 1].Academy);
            }
            else
            {
                MessageBox.Show(message, "Не верный ввод");
            }
        }
    }
}
