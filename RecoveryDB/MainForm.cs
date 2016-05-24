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
            if((int)comboTransaction.SelectedValue > 0)
            {
                comboTransaction.BackColor = Color.White;
                txtValue.BackColor = Color.White;
                transactionIdLabel.Show();

                FormController.Commit((int)comboTransaction.SelectedValue);
                listBufferLog.DataSource = FormController.FillListBufferLog();
                comboTransaction.DataSource = new BindingSource(FormController.FillComboTransactions(), null);
                gridDataBuffer.DataSource = FormController.FillDataBufferList();
                listDiskLog.DataSource = FormController.FillListDiskLog();
            }else
            {
                comboTransaction.BackColor = Color.FromArgb(255, 128, 128);
            }
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
            transactionIdLabel.Hide();

            FormController.transactionCounter = 0;
            comboRegister.DataSource = new BindingSource(FormController.FillComboRegisters(0), null);
            comboTransaction.DataSource = new BindingSource(FormController.FillComboTransactions(), null);
            listBufferLog.DataSource = FormController.FillListBufferLog();
            gridDiskData.DataSource = FormController.FillDiskDataList();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if(txtValue.Text != "")
            {
                comboTransaction.BackColor = Color.White;
                txtValue.BackColor = Color.White;

                FormController.Execute((int)comboTransaction.SelectedValue, (int)comboRegister.SelectedValue, double.Parse(txtValue.Text));
                listBufferLog.DataSource = FormController.FillListBufferLog();
                gridDataBuffer.DataSource = FormController.FillDataBufferList();
                comboTransaction.DataSource = new BindingSource(FormController.FillComboTransactions(), null);
                txtValue.Clear();
            }
            else
            {
                txtValue.BackColor = Color.FromArgb(255, 128, 128);
            }
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

        private void btnCheckpoint_Click(object sender, EventArgs e)
        {
            if (FormController.bufferLog.transactionList.Any())
            {
                FormController.Checkpoint();
                listDiskLog.DataSource = FormController.FillListDiskLog();
                gridDiskData.DataSource = FormController.FillDiskDataList();
            }
            
        }

        private void gridDataBuffer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFalha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("System Error \n" + "0x00003204c", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("System Error \n" + "0x0004FD290", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("System Error \n" + "0x0827BD6DA", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            FormController.WipeMemory();
            gridDataBuffer.DataSource = FormController.FillDataBufferList();
            listBufferLog.DataSource = FormController.FillListBufferLog();
            comboTransaction.DataSource = new BindingSource(FormController.FillComboTransactions(), null);
            MessageBox.Show("All the data in memory was lost, the system will execute its recovery routine", "System Recovery", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            FormController.Recovery();
            gridDiskData.DataSource = FormController.FillDiskDataList();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resetAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormController.bufferData.bufferRows.Clear();
            FormController.bufferLog.transactionList.Clear();
            FormController.diskLog.transactionList.Clear();

            gridDataBuffer.DataSource = null;
            listBufferLog.DataSource = null;
            listDiskLog.DataSource = null;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.Show();
        }
    }
}
