using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryMatchingGame
{
    public partial class Form2 : Form
    {
        private string Time;
        private string Attempts;

        public string time
        {
            get { return this.Time; }
            set { this.Time = value; }
        }

        public string attempts
        {
            get { return this.Attempts; }
            set { this.Attempts = value; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Όνομα: " +username.Text+ 
                            "\n Χρόνος: " +time+
                            "\n Προσπάθειες: " +attempts);
        }
    }
}
