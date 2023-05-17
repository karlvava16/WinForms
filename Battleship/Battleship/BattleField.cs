using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public class BattleField
    {

        // Create a new button



       

        public void FrameClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Left");
            }
            else if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Right");
            }
        }



        // Создаем обработчики событий MouseEnter и MouseLeave
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            string pattern = @"(\d+),(\d+)";
            // Код, который выполнится при наведении на кнопку
            Match match = Regex.Match((sender as Button).AccessibleDescription, pattern);

            if (match.Success)
            {
                int y = Convert.ToInt32(match.Groups[1].Value);
                int x = Convert.ToInt32(match.Groups[2].Value);

                fields[x,y].BackColor = Color.Red;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            // Код, который выполнится при наведении на кнопку
            string input = "1,2";
            Match match = Regex.Match(input, (sender as Button).AccessibleDescription);

            if (match.Success)
            {
                int y = Convert.ToInt32(match.Groups[1].Value);
                int x = Convert.ToInt32(match.Groups[2].Value);

                fields[x, y].BackColor = Color.Blue;
            }
        }

        private Button[,] fields;

        private Point fieldLocation = new Point(0, 0);
        private int fieldDistance;
        private Size fieldSize;

        //properties
        public Button[,] Fields { get { return fields; } }

        public int FieldDistance
        {
            get { return fieldDistance; }
            set
            {
                fieldDistance = value;
                Move();
            }
        }

        public Point FieldLocation
        {
            get { return fieldLocation; }
            set
            {
                fieldLocation = value;
                Move();
            }
        }

        public Size FieldSize
        {
            get { return fieldSize; }
            set 
            { 
                fieldSize = value;
                Move();
            }

        }

        
        public BattleField(Point loc, int dist, Size size)
        {
            fields = new Button[10, 10];
            for (int i = 0; i < fields.GetLength(0); i++)
            {
                for (int j = 0; j < fields.GetLength(1); j++)
                {
                    fields[i, j] = new Button
                    {
                        Location = new Point(100, 100),
                        Size = new Size(75, 23),
                        Font = new Font("Arial", 10),
                        AccessibleDescription = j.ToString()  + "," + i.ToString()
                    };
                    fields[i, j].MouseUp += new MouseEventHandler(FrameClick);
                    // Подписываемся на событие MouseEnter кнопки
                    fields[i, j].MouseEnter += Button_MouseEnter;

                    // Подписываемся на событие MouseLeave кнопки
                    fields[i, j].MouseLeave += Button_MouseLeave;
                }
            }

            fieldLocation = loc;
            fieldDistance = dist;
            fieldSize = size;

            Move();

        }


        // set pos, size, padding for fields
        public void Move()
        {
            for (int i = 0; i < fields.GetLength(0); i++)
            {
                for (int j = 0; j < fields.GetLength(1); j++)
                {
                    fields[i,j].Location = new Point
                        (
                        fieldLocation.X + fieldDistance * i + fieldSize.Width * i,

                        fieldLocation.Y + fieldDistance * j + fieldSize.Height * j
                        );
                    fields[i, j].Size = fieldSize;
                }
            }
        }

    }
}
