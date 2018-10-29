using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckCodeWindowsForms
{
    public partial class Form1 : Form
    {
        CheckCodeClass ccc = new CheckCodeClass();
        string checkCode;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckCodePictureBox.Image = ccc.CheckCodeImage();
            checkCode = ccc.CheckCode;
            
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
           
            CheckCodePictureBox.Image = ccc.CheckCodeImage();
            checkCode = ccc.CheckCode;
            CheckCodeTextBox.Clear();
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            //string checkCode = ccc.CheckCode();
            string checkCodeTxt = CheckCodeTextBox.Text.Trim().ToUpper();
            if (checkCodeTxt == checkCode)
            {
                MessageBox.Show("验证成功");
            }
        }
    }
}
