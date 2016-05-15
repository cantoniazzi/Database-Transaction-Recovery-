namespace RecoveryDB
{
    partial class MainForm
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
            this.lblRegister = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.comboRegister = new System.Windows.Forms.ComboBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.listBufferLog = new System.Windows.Forms.ListBox();
            this.listLogDisk = new System.Windows.Forms.ListBox();
            this.listDataBuffer = new System.Windows.Forms.ListView();
            this.listDiskData = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnCommit
            // 
            this.btnCommit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCommit.Location = new System.Drawing.Point(24, 103);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(86, 33);
            this.btnCommit.TabIndex = 0;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buffer Log";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(619, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Buffer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Log Disk";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Disk Data";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnCheckpoint
            // 
            this.btnCheckpoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckpoint.Location = new System.Drawing.Point(24, 142);
            this.btnCheckpoint.Name = "btnCheckpoint";
            this.btnCheckpoint.Size = new System.Drawing.Size(86, 37);
            this.btnCheckpoint.TabIndex = 9;
            this.btnCheckpoint.Text = "Checkpoint";
            this.btnCheckpoint.UseVisualStyleBackColor = true;
            // 
            // btnFalha
            // 
            this.btnFalha.BackColor = System.Drawing.Color.Red;
            this.btnFalha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFalha.ForeColor = System.Drawing.SystemColors.Info;
            this.btnFalha.Location = new System.Drawing.Point(24, 188);
            this.btnFalha.Name = "btnFalha";
            this.btnFalha.Size = new System.Drawing.Size(86, 39);
            this.btnFalha.TabIndex = 10;
            this.btnFalha.Text = "Simular Falha";
            this.btnFalha.UseVisualStyleBackColor = false;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(9, 23);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(51, 13);
            this.lblRegister.TabIndex = 16;
            this.lblRegister.Text = "Registros";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(173, 41);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(116, 20);
            this.txtValue.TabIndex = 17;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(170, 23);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(31, 13);
            this.lblValue.TabIndex = 18;
            this.lblValue.Text = "Valor";
            // 
            // comboRegister
            // 
            this.comboRegister.DisplayMember = "value";
            this.comboRegister.FormattingEnabled = true;
            this.comboRegister.Location = new System.Drawing.Point(12, 40);
            this.comboRegister.Name = "comboRegister";
            this.comboRegister.Size = new System.Drawing.Size(121, 21);
            this.comboRegister.TabIndex = 19;
            this.comboRegister.ValueMember = "key";
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.Color.ForestGreen;
            this.btnExecute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecute.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExecute.Location = new System.Drawing.Point(326, 33);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(86, 34);
            this.btnExecute.TabIndex = 20;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // listBufferLog
            // 
            this.listBufferLog.FormattingEnabled = true;
            this.listBufferLog.Location = new System.Drawing.Point(243, 103);
            this.listBufferLog.Name = "listBufferLog";
            this.listBufferLog.Size = new System.Drawing.Size(310, 160);
            this.listBufferLog.TabIndex = 21;
            // 
            // listLogDisk
            // 
            this.listLogDisk.FormattingEnabled = true;
            this.listLogDisk.Location = new System.Drawing.Point(243, 297);
            this.listLogDisk.Name = "listLogDisk";
            this.listLogDisk.Size = new System.Drawing.Size(255, 160);
            this.listLogDisk.TabIndex = 22;
            // 
            // listDataBuffer
            // 
            this.listDataBuffer.Location = new System.Drawing.Point(579, 103);
            this.listDataBuffer.Name = "listDataBuffer";
            this.listDataBuffer.Size = new System.Drawing.Size(310, 160);
            this.listDataBuffer.TabIndex = 23;
            this.listDataBuffer.UseCompatibleStateImageBehavior = false;
            // 
            // listDiskData
            // 
            this.listDiskData.Location = new System.Drawing.Point(579, 297);
            this.listDiskData.Name = "listDiskData";
            this.listDiskData.Size = new System.Drawing.Size(310, 160);
            this.listDiskData.TabIndex = 24;
            this.listDiskData.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 502);
            this.Controls.Add(this.listDiskData);
            this.Controls.Add(this.listDataBuffer);
            this.Controls.Add(this.listLogDisk);
            this.Controls.Add(this.listBufferLog);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.comboRegister);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.btnFalha);
            this.Controls.Add(this.btnCheckpoint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCommit);
            this.Name = "MainForm";
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
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.ComboBox comboRegister;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ListBox listBufferLog;
        private System.Windows.Forms.ListBox listLogDisk;
        private System.Windows.Forms.ListView listDataBuffer;
        private System.Windows.Forms.ListView listDiskData;
    }
}

