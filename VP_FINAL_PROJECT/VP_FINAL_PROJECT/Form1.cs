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
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file = Image.FromFile(f.FileName);
                input_pic.Image = file;
                string str = f.FileName;
                path_pic.Text = str;
                input_pic.Visible = true;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enc_button_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(path_pic.Text);
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    if (i < 1 && j < enc_key.TextLength)
                    {

                        char letter = Convert.ToChar(enc_key.Text.Substring(j, 1));
                        int value = Convert.ToInt32(letter);
                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));



                    }
                    if(i==img.Width-1 && j==img.Height-1)
                    {
                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, enc_key.TextLength));

                    }
                }
            }
            probar p = new probar();
            p.ShowDialog();
            

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "image Files(*.png,*jpg)|*.png;*jpg";
            savefile.InitialDirectory = @"C:\Users\asadk\Desktop";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                path_pic.Text = savefile.FileName.ToString();
                input_pic.ImageLocation = path_pic.Text;
                img.Save(path_pic.Text);
            }
        }

        private void decry_button_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(path_pic.Text);
            string return_msg = "";
            Color lastpixel = img.GetPixel(img.Width-1,img.Height-1);
            int msg_length = lastpixel.B;

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    if (i < 1 && j <msg_length)
                    {
                        int value = pixel.B;
                        char c = Convert.ToChar(value);


                        string letter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });
                        return_msg += letter;

                    }
                }
            }
            decrypt_key.Text = return_msg;

         
        }
    }
}
