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
    public partial class Form1 : Form
    {
        Image file;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                file = Image.FromFile(f.FileName);
                input_pic.Image = file;
                string str = f.FileName;
                path_pic.Text = str;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enc_button_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(path_pic.Text);
            for (int i=0;i<img.Width;i++)
            {
                for (int j=0;j<img.Height;j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    if(i<1 && j<10)
                    {
                        //Console.WriteLine("R = ["+ i +"][" + j +"] = "+ pixel.R);
                        //Console.WriteLine("G = [" + i + "][" + j + "] = " + pixel.G);
                        //Console.WriteLine("B = [" + i + "][" + j + "] = " + pixel.B);
                        label1.Text = ("R = [" + i + "][" + j + "] = " + pixel.R);


                    }
                }
            }
        }
    }s
}
