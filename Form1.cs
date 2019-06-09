using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoPick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path = "";
        string save = "";
        int i = 0;
        List<string> files;
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            this.Text = "PhotoPick  " + i.ToString()+" / "+files.Count.ToString();
            this.BackgroundImage.Dispose();
            this.BackgroundImage = Image.FromFile(files[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i--;
            this.Text = "PhotoPick  " + i.ToString() + " / " + files.Count.ToString();
            this.BackgroundImage.Dispose();
            this.BackgroundImage = Image.FromFile(files[i]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] t=files[i].Split('\\');
            string name= t[t.Length-1];
            this.BackgroundImage.Dispose();
            File.Move(files[i], save + "\\" + name);
            files.RemoveAt(i);
            this.Text = "PhotoPick  " + i.ToString() + " / " + files.Count.ToString();
            this.BackgroundImage = Image.FromFile(files[i]);
        }

        private void fb1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            path = textBox1.Text;
            save = textBox2.Text;
            i = int.Parse(textBox3.Text);
            files = Directory.GetFiles(path).ToList();
            this.BackgroundImage = Image.FromFile(files[i]);
            groupBox1.Visible = false ;

        }
    }
}
