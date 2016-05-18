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

        FormController controller = new FormController();

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.Commit();
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
            comboRegister.DataSource = new BindingSource(controller.FillComboRegisters(), null);
            comboTransaction.DataSource = new BindingSource(controller.FillComboTransactions(), null);
            listBufferLog.DataSource = controller.FillListBufferLog();
            gridDiskData.DataSource = controller.FillDiskDataList();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            listBufferLog.DataSource = null;

            controller.Execute((int)comboTransaction.SelectedValue, (int)comboRegister.SelectedValue, double.Parse(txtValue.Text));
            listBufferLog.DataSource = controller.FillListBufferLog();
            gridDataBuffer.DataSource = controller.FillBufferDataList();
            comboTransaction.DataSource = new BindingSource(controller.FillComboTransactions(), null);

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
    }
}
