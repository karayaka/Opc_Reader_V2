﻿namespace Opc_Reader_V2
{
    partial class Form1
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
            this.mainWorker = new System.ComponentModel.BackgroundWorker();
            this.btnStartRead = new DevExpress.XtraEditors.SimpleButton();
            this.btnProjectInfo = new DevExpress.XtraEditors.SimpleButton();
            this.btnPlanInfo = new DevExpress.XtraEditors.SimpleButton();
            this.btnPartInfo = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // mainWorker
            // 
            this.mainWorker.WorkerReportsProgress = true;
            this.mainWorker.WorkerSupportsCancellation = true;
            this.mainWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.mainWorker_DoWork);
            this.mainWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.mainWorker_ProgressChanged);
            this.mainWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.mainWorker_RunWorkerCompleted);
            // 
            // btnStartRead
            // 
            this.btnStartRead.Location = new System.Drawing.Point(12, 12);
            this.btnStartRead.Name = "btnStartRead";
            this.btnStartRead.Size = new System.Drawing.Size(123, 39);
            this.btnStartRead.TabIndex = 0;
            this.btnStartRead.Text = "Okuma Başla";
            this.btnStartRead.Click += new System.EventHandler(this.btnStartRead_Click);
            // 
            // btnProjectInfo
            // 
            this.btnProjectInfo.Location = new System.Drawing.Point(12, 67);
            this.btnProjectInfo.Name = "btnProjectInfo";
            this.btnProjectInfo.Size = new System.Drawing.Size(191, 39);
            this.btnProjectInfo.TabIndex = 1;
            this.btnProjectInfo.Text = "Proje Bilgileri (ProjectInfo)";
            // 
            // btnPlanInfo
            // 
            this.btnPlanInfo.Location = new System.Drawing.Point(12, 112);
            this.btnPlanInfo.Name = "btnPlanInfo";
            this.btnPlanInfo.Size = new System.Drawing.Size(191, 39);
            this.btnPlanInfo.TabIndex = 2;
            this.btnPlanInfo.Text = "Plan Bilgileri (PlanInfo)";
            // 
            // btnPartInfo
            // 
            this.btnPartInfo.Location = new System.Drawing.Point(12, 157);
            this.btnPartInfo.Name = "btnPartInfo";
            this.btnPartInfo.Size = new System.Drawing.Size(191, 39);
            this.btnPartInfo.TabIndex = 3;
            this.btnPartInfo.Text = "Parça Bilgileri (PartInfo)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPartInfo);
            this.Controls.Add(this.btnPlanInfo);
            this.Controls.Add(this.btnProjectInfo);
            this.Controls.Add(this.btnStartRead);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker mainWorker;
        private DevExpress.XtraEditors.SimpleButton btnStartRead;
        private DevExpress.XtraEditors.SimpleButton btnProjectInfo;
        private DevExpress.XtraEditors.SimpleButton btnPlanInfo;
        private DevExpress.XtraEditors.SimpleButton btnPartInfo;
    }
}

