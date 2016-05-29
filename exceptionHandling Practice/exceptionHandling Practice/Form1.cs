using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exceptionHandling_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int Result = Convert.ToInt32(tbInput1.Text) / Convert.ToInt32(tbInput2.Text);
                tbResult.Text = Convert.ToString(Result);
            }
            catch (DivideByZeroException DBZE)
            {
                MessageBox.Show(DBZE.Message, "Error", MessageBoxButtons.RetryCancel);
                
            }
           


        }
    }
}
