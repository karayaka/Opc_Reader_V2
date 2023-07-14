namespace Opc_Reader_V2.Views
{
    partial class JobInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtJobGuid = new System.Windows.Forms.TextBox();
            this.btnReadData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.grdJobGuid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdJobGuid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJobGuid
            // 
            this.txtJobGuid.Location = new System.Drawing.Point(52, 11);
            this.txtJobGuid.Margin = new System.Windows.Forms.Padding(2);
            this.txtJobGuid.Name = "txtJobGuid";
            this.txtJobGuid.Size = new System.Drawing.Size(619, 20);
            this.txtJobGuid.TabIndex = 0;
            // 
            // btnReadData
            // 
            this.btnReadData.Location = new System.Drawing.Point(674, 2);
            this.btnReadData.Margin = new System.Windows.Forms.Padding(2);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(120, 30);
            this.btnReadData.TabIndex = 2;
            this.btnReadData.Text = "Read Data";
            this.btnReadData.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "JobGuid:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Controls.Add(this.txtJobGuid);
            this.panel1.Controls.Add(this.btnReadData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 38);
            this.panel1.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(798, 16);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "label2";
            // 
            // grdJobGuid
            // 
            this.grdJobGuid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdJobGuid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdJobGuid.Location = new System.Drawing.Point(0, 0);
            this.grdJobGuid.Margin = new System.Windows.Forms.Padding(2);
            this.grdJobGuid.Name = "grdJobGuid";
            this.grdJobGuid.RowHeadersWidth = 51;
            this.grdJobGuid.RowTemplate.Height = 24;
            this.grdJobGuid.Size = new System.Drawing.Size(908, 450);
            this.grdJobGuid.TabIndex = 6;
            // 
            // JobInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdJobGuid);
            this.Name = "JobInfoForm";
            this.Text = "JobInfoForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdJobGuid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtJobGuid;
        private System.Windows.Forms.Button btnReadData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.DataGridView grdJobGuid;
    }
}