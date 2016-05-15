using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecoveryDB
{
    public partial class Form1 : Form
    {
        List<string> transactions = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            listBufferLog.DataSource = null;
            Transaction transaction = new Transaction();
            transaction.transaction = "<inicio TA>\n" + 
                                      "<fim TA>";

            transactions.Add(transaction.transaction);
            listBufferLog.DataSource = transactions;
            
        }
    }
}
