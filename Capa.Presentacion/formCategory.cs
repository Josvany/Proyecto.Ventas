using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capa.Presentacion
{
    public partial class formCategory : Form
    {
        int count = 0;
        public formCategory()
        {
            InitializeComponent();
            tm.Stop();
        }

        private void formCategory_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tm.Start();
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            btnSearch.BackColor = SystemColors.Control;
            count += 1;
            if (count.Equals(3))
            {
                btnSearch.BackColor = SystemColors.ButtonHighlight;
                tm.Stop();
                tm.Dispose();
                count = 0;
            }
        }
    }
}