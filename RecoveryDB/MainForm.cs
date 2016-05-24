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
            FormController.Commit();
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
            comboRegister.DataSource = new BindingSource(FormController.FillComboRegisters(0), null);
            comboTransaction.DataSource = new BindingSource(FormController.FillComboTransactions(), null);
            listBufferLog.DataSource = FormController.FillListBufferLog();
            gridDiskData.DataSource = FormController.FillDiskDataList();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            listBufferLog.DataSource = null;

            FormController.Execute((int)comboTransaction.SelectedValue, (int)comboRegister.SelectedValue, double.Parse(txtValue.Text));
            listBufferLog.DataSource = FormController.FillListBufferLog();
            gridDataBuffer.DataSource = FormController.FillBufferDataList();
            comboTransaction.DataSource = new BindingSource(FormController.FillComboTransactions(), null);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBufferLog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblRegister_Click(object sender, EventArgs e)
        {

        }

        private void lblValue_Click(object sender, EventArgs e)
        {

        }

        private void comboTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboRegister.DataSource = new BindingSource(FormController.FillComboRegisters((int)comboTransaction.SelectedValue), null);
        }
    }
}
