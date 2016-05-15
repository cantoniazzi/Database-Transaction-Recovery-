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
            comboRegister.DataSource = new BindingSource(controller.fillComboRegisters(), null);
            //listDiskData.Items.AddRange(controller.FillDiskDataList());
            //listDiskData.Columns.Add("ID");
            //listDiskData.Columns.Add("Name");
            //listDiskData.Columns.Add("Salary");
            //controller.FillDiskDataList().ForEach(x => listDiskData.Items.Add(x));
            listDiskData.Columns.Add("coluna");
            listDiskData.Items.Add("lala");
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            listBufferLog.DataSource = null;

            controller.Execute((int)comboRegister.SelectedValue, double.Parse(txtValue.Text));
            listBufferLog.DataSource = controller.fillListBufferLog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
