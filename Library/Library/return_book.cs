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
    public partial class return_book : Form
    {
        private dashboard dashboard;
        public return_book(dashboard das)
        {
            InitializeComponent();
            this.dashboard = das;
        }

        private void return_book_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            dashboard.panel4.BackColor = Color.LightSalmon;
            this.Close();
        }
    }
}
