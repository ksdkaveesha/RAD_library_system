using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class view_book : Form
    {
        private dashboard dashboard;
        public view_book(dashboard das)
        {
            InitializeComponent();
            this.dashboard = das;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            dashboard.panel4.BackColor = Color.LightSalmon;
        }
    }
}
