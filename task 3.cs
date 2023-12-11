using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_task
{
    public partial class task_3 : Form
    {
        public task_3()
        {
            InitializeComponent();
            MouseClick += Task_3_MouseClick;
            MouseMove += Task_3_MouseMove;
        }

        private void Task_3_MouseMove(object? sender, MouseEventArgs e)
        {
            this.Text = $"текущие координаты x = {e.X},y = {e.Y}";
        }

        private void Task_3_MouseClick(object? sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left&&Control.ModifierKeys == Keys.Control) Application.Exit();
            if (e.Button == MouseButtons.Left)
            {
                if (e.X > 10 && e.Y > 10 && e.X < this.Size.Width - 10 && e.Y < this.Size.Height)
                {
                    MessageBox.Show("курсор внутри вымышленного прямоугольника");
                }
                else if (e.X == 10 || e.Y == 10 || e.X == this.Size.Width - 10 || e.Y == this.Size.Height)
                {
                    MessageBox.Show("курсор на границе вымышленного прямоугольника");
                }
                else
                {
                    MessageBox.Show("курсор вне вымышленного прямоугольника");
                }
            } else if (e.Button == MouseButtons.Right)
            {
                this.Text = $"Ширина = {this.Size.Width}, Высота = {this.Size.Height}";
            }

        }
    }
}
