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
    public partial class MainForm : Form
    {
       
        public MainForm()
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
            DiskData diskData = new DiskData();
            comboRegister.DataSource = new BindingSource(diskData.GetDictionaryRegisters(), null);
            
            BufferLog bufferLog = new BufferLog();
            
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            listBufferLog.DataSource = null;
            Transaction transaction = new Transaction();
            
            transaction.setBeforeImage((int)comboRegister.SelectedValue);
            transaction.afterImage = double.Parse(txtValue.Text);
            
            //transaction.transaction = "<inicio TA><fim TA>";
            //transactions.Add(transaction.transaction);
            //listBufferLog.DataSource = transactions;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
