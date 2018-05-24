using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_FINAL_PROJECT
{
    public partial class probar : Form
    {
        public probar()
        {
            InitializeComponent();
        }

        private void probar_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            label1.Text = progressBar1.Value.ToString() + "%";
            if(progressBar1.Value==100)
            {
                this.Hide();
            }
        
           
        }
       
    }
}
