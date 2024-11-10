using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class Vehicle
        {
            public virtual void Drive()
            {

            }
        }
        public class Car : Vehicle
        {
            public override void Drive()
            {

            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car mycar = new Car();
            mycar.Drive();
        }
    }
}
