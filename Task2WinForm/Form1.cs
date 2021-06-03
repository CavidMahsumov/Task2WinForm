using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button bt)
            {
                bt.Dispose();
                Button button = new Button()
                {
                    AutoSize = true,
                    Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    Location = new System.Drawing.Point(271, 166),
                    Name = "button1",
                    Size = new System.Drawing.Size(150, 48),
                    TabIndex = 1,
                    UseVisualStyleBackColor = true,
                };
                button.Size = new Size(180, 48);
                button.ForeColor = Color.Black;
                button.BackColor = Color.Transparent;
                Random random = new Random();
                int randomX = random.Next(this.Size.Width - 100);
                int randomY = random.Next(this.Size.Height - 100);



                button.Location = new Point(randomX, randomY);
                button.Text = "Catch Me";
                button.MouseHover += button1_Click;
                this.Controls.Add(button);
            }
        }
    }
}
