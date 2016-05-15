namespace RecoveryDB
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCommit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCheckpoint = new System.Windows.Forms.Button();
            this.btnFalha = new System.Windows.Forms.Button();
            this.listBufferLog = new System.Windows.Forms.ListView();
            this.listDataBuffer = new System.Windows.Forms.ListView();
            this.listDiskBuffer = new System.Windows.Forms.ListView();
            this.listDataDisk = new System.Windows.Forms.ListView();
            this.lblRegister = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.Label();
            this.comboRegister = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(27, 186);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(86, 34);
            this.btnCommit.TabIndex = 0;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buffer Log";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Buffer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Disk Buffer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data Disk";
            // 
            // btnCheckpoint
            // 
            this.btnCheckpoint.Location = new System.Drawing.Point(27, 226);
            this.btnCheckpoint.Name = "btnCheckpoint";
            this.btnCheckpoint.Size = new System.Drawing.Size(86, 37);
            this.btnCheckpoint.TabIndex = 9;
            this.btnCheckpoint.Text = "Checkpoint";
            this.btnCheckpoint.UseVisualStyleBackColor = true;
            // 
            // btnFalha
            // 
            this.btnFalha.BackColor = System.Drawing.Color.Red;
            this.btnFalha.ForeColor = System.Drawing.SystemColors.Info;
            this.btnFalha.Location = new System.Drawing.Point(27, 272);
            this.btnFalha.Name = "btnFalha";
            this.btnFalha.Size = new System.Drawing.Size(86, 39);
            this.btnFalha.TabIndex = 10;
            this.btnFalha.Text = "Simular Falha";
            this.btnFalha.UseVisualStyleBackColor = false;
            // 
            // listBufferLog
            // 
            this.listBufferLog.Location = new System.Drawing.Point(262, 82);
            this.listBufferLog.Name = "listBufferLog";
            this.listBufferLog.Size = new System.Drawing.Size(170, 161);
            this.listBufferLog.TabIndex = 11;
            this.listBufferLog.UseCompatibleStateImageBehavior = false;
            // 
            // listDataBuffer
            // 
            this.listDataBuffer.Location = new System.Drawing.Point(437, 82);
            this.listDataBuffer.Name = "listDataBuffer";
            this.listDataBuffer.Size = new System.Drawing.Size(170, 161);
            this.listDataBuffer.TabIndex = 12;
            this.listDataBuffer.UseCompatibleStateImageBehavior = false;
            // 
            // listDiskBuffer
            // 
            this.listDiskBuffer.Location = new System.Drawing.Point(262, 277);
            this.listDiskBuffer.Name = "listDiskBuffer";
            this.listDiskBuffer.Size = new System.Drawing.Size(170, 161);
            this.listDiskBuffer.TabIndex = 13;
            this.listDiskBuffer.UseCompatibleStateImageBehavior = false;
            // 
            // listDataDisk
            // 
            this.listDataDisk.Location = new System.Drawing.Point(437, 277);
            this.listDataDisk.Name = "listDataDisk";
            this.listDataDisk.Size = new System.Drawing.Size(170, 161);
            this.listDataDisk.TabIndex = 14;
            this.listDataDisk.UseCompatibleStateImageBehavior = false;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(12, 63);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(51, 13);
            this.lblRegister.TabIndex = 16;
            this.lblRegister.Text = "Registros";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 17;
            // 
            // txtValue
            // 
            this.txtValue.AutoSize = true;
            this.txtValue.Location = new System.Drawing.Point(12, 122);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(31, 13);
            this.txtValue.TabIndex = 18;
            this.txtValue.Text = "Valor";
            // 
            // comboRegister
            // 
            this.comboRegister.FormattingEnabled = true;
            this.comboRegister.Location = new System.Drawing.Point(15, 80);
            this.comboRegister.Name = "comboRegister";
            this.comboRegister.Size = new System.Drawing.Size(121, 21);
            this.comboRegister.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 449);
            this.Controls.Add(this.comboRegister);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.listDataDisk);
            this.Controls.Add(this.listDiskBuffer);
            this.Controls.Add(this.listDataBuffer);
            this.Controls.Add(this.listBufferLog);
            this.Controls.Add(this.btnFalha);
            this.Controls.Add(this.btnCheckpoint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCommit);
            this.Name = "Form1";
            this.Text = "Recovery Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCheckpoint;
        private System.Windows.Forms.Button btnFalha;
        private System.Windows.Forms.ListView listBufferLog;
        private System.Windows.Forms.ListView listDataBuffer;
        private System.Windows.Forms.ListView listDiskBuffer;
        private System.Windows.Forms.ListView listDataDisk;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtValue;
        private System.Windows.Forms.ComboBox comboRegister;
    }
}

