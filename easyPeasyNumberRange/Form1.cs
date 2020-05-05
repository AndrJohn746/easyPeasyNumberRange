using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace easyPeasyNumberRange
{
    public partial class Form1 : Form
    {
        int start = 0;
        int end = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ansButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                start = Convert.ToInt16(startNum.Text);
                end = Convert.ToInt16(endNum.Text);
                answerText.Text = "";
                for (start = Convert.ToInt16(startNum.Text); start <= end; start++)
                {
                    answerText.Text += start + ", ";
                }
            }
            catch
            {
                answerText.Text = "There was an error, please input your values again";
            }

        }
        
    }
}
