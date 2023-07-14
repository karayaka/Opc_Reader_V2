namespace Opc_Reader_V2.Views
{
    partial class RunPartViewForm
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
            this.grid_RunPartView = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TimeStamp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JobGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JobName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PlanGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PlanName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RunGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RunNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ActualCutTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ActualStopTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ActualWaitTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PartId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PartRefId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PartNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CutState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CutStartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CutEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SortState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SortStartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SortEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StackAreaType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Refresh = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grid_RunPartView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_RunPartView
            // 
            this.grid_RunPartView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_RunPartView.Location = new System.Drawing.Point(2, 2);
            this.grid_RunPartView.MainView = this.gridView1;
            this.grid_RunPartView.Name = "grid_RunPartView";
            this.grid_RunPartView.Size = new System.Drawing.Size(1095, 555);
            this.grid_RunPartView.TabIndex = 0;
            this.grid_RunPartView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.TimeStamp,
            this.JobGuid,
            this.JobName,
            this.PlanGuid,
            this.PlanName,
            this.RunGuid,
            this.RunNumber,
            this.ActualCutTime,
            this.ActualStopTime,
            this.ActualWaitTime,
            this.PartId,
            this.PartRefId,
            this.PartNumber,
            this.CutState,
            this.CutStartTime,
            this.CutEndTime,
            this.SortState,
            this.SortStartTime,
            this.SortEndTime,
            this.StackAreaType,
            this.PartName});
            this.gridView1.GridControl = this.grid_RunPartView;
            this.gridView1.Name = "gridView1";
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // TimeStamp
            // 
            this.TimeStamp.Caption = "TimeStamp";
            this.TimeStamp.Name = "TimeStamp";
            this.TimeStamp.Visible = true;
            this.TimeStamp.VisibleIndex = 1;
            // 
            // JobGuid
            // 
            this.JobGuid.Caption = "JobGuid";
            this.JobGuid.Name = "JobGuid";
            this.JobGuid.Visible = true;
            this.JobGuid.VisibleIndex = 2;
            // 
            // JobName
            // 
            this.JobName.Caption = "JobName";
            this.JobName.Name = "JobName";
            this.JobName.Visible = true;
            this.JobName.VisibleIndex = 3;
            // 
            // PlanGuid
            // 
            this.PlanGuid.Caption = "PlanGuid";
            this.PlanGuid.Name = "PlanGuid";
            this.PlanGuid.Visible = true;
            this.PlanGuid.VisibleIndex = 4;
            // 
            // PlanName
            // 
            this.PlanName.Caption = "PlanName";
            this.PlanName.Name = "PlanName";
            this.PlanName.Visible = true;
            this.PlanName.VisibleIndex = 5;
            // 
            // RunGuid
            // 
            this.RunGuid.Caption = "RunGuid";
            this.RunGuid.Name = "RunGuid";
            this.RunGuid.Visible = true;
            this.RunGuid.VisibleIndex = 6;
            // 
            // RunNumber
            // 
            this.RunNumber.Caption = "RunNumber";
            this.RunNumber.Name = "RunNumber";
            this.RunNumber.Visible = true;
            this.RunNumber.VisibleIndex = 7;
            // 
            // ActualCutTime
            // 
            this.ActualCutTime.Caption = "ActualCutTime";
            this.ActualCutTime.Name = "ActualCutTime";
            this.ActualCutTime.Visible = true;
            this.ActualCutTime.VisibleIndex = 8;
            // 
            // ActualStopTime
            // 
            this.ActualStopTime.Caption = "ActualStopTime";
            this.ActualStopTime.Name = "ActualStopTime";
            this.ActualStopTime.Visible = true;
            this.ActualStopTime.VisibleIndex = 9;
            // 
            // ActualWaitTime
            // 
            this.ActualWaitTime.Caption = "ActualWaitTime";
            this.ActualWaitTime.Name = "ActualWaitTime";
            this.ActualWaitTime.Visible = true;
            this.ActualWaitTime.VisibleIndex = 10;
            // 
            // PartId
            // 
            this.PartId.Caption = "PartId";
            this.PartId.Name = "PartId";
            this.PartId.Visible = true;
            this.PartId.VisibleIndex = 11;
            // 
            // PartRefId
            // 
            this.PartRefId.Caption = "PartRefId";
            this.PartRefId.Name = "PartRefId";
            this.PartRefId.Visible = true;
            this.PartRefId.VisibleIndex = 12;
            // 
            // PartNumber
            // 
            this.PartNumber.Caption = "PartNumber";
            this.PartNumber.Name = "PartNumber";
            this.PartNumber.Visible = true;
            this.PartNumber.VisibleIndex = 13;
            // 
            // CutState
            // 
            this.CutState.Caption = "CutState";
            this.CutState.Name = "CutState";
            this.CutState.Visible = true;
            this.CutState.VisibleIndex = 14;
            // 
            // CutStartTime
            // 
            this.CutStartTime.Caption = "CutStartTime";
            this.CutStartTime.Name = "CutStartTime";
            this.CutStartTime.Visible = true;
            this.CutStartTime.VisibleIndex = 15;
            // 
            // CutEndTime
            // 
            this.CutEndTime.Caption = "CutEndTime";
            this.CutEndTime.Name = "CutEndTime";
            this.CutEndTime.Visible = true;
            this.CutEndTime.VisibleIndex = 16;
            // 
            // SortState
            // 
            this.SortState.Caption = "SortState";
            this.SortState.Name = "SortState";
            this.SortState.Visible = true;
            this.SortState.VisibleIndex = 17;
            // 
            // SortStartTime
            // 
            this.SortStartTime.Caption = "SortStartTime";
            this.SortStartTime.Name = "SortStartTime";
            this.SortStartTime.Visible = true;
            this.SortStartTime.VisibleIndex = 18;
            // 
            // SortEndTime
            // 
            this.SortEndTime.Caption = "SortEndTime";
            this.SortEndTime.Name = "SortEndTime";
            this.SortEndTime.Visible = true;
            this.SortEndTime.VisibleIndex = 19;
            // 
            // StackAreaType
            // 
            this.StackAreaType.Caption = "StackAreaType";
            this.StackAreaType.Name = "StackAreaType";
            this.StackAreaType.Visible = true;
            this.StackAreaType.VisibleIndex = 20;
            // 
            // PartName
            // 
            this.PartName.Caption = "PartName";
            this.PartName.Name = "PartName";
            this.PartName.Visible = true;
            this.PartName.VisibleIndex = 21;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Refresh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1099, 45);
            this.panelControl1.TabIndex = 1;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(1012, 12);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 0;
            this.btn_Refresh.Text = "YENİLE";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.grid_RunPartView);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 45);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1099, 559);
            this.panelControl2.TabIndex = 2;
            // 
            // RunPartViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 604);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RunPartViewForm";
            this.Text = "RunPartViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.grid_RunPartView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid_RunPartView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Refresh;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn TimeStamp;
        private DevExpress.XtraGrid.Columns.GridColumn JobGuid;
        private DevExpress.XtraGrid.Columns.GridColumn JobName;
        private DevExpress.XtraGrid.Columns.GridColumn PlanGuid;
        private DevExpress.XtraGrid.Columns.GridColumn PlanName;
        private DevExpress.XtraGrid.Columns.GridColumn RunGuid;
        private DevExpress.XtraGrid.Columns.GridColumn RunNumber;
        private DevExpress.XtraGrid.Columns.GridColumn ActualCutTime;
        private DevExpress.XtraGrid.Columns.GridColumn ActualStopTime;
        private DevExpress.XtraGrid.Columns.GridColumn ActualWaitTime;
        private DevExpress.XtraGrid.Columns.GridColumn PartId;
        private DevExpress.XtraGrid.Columns.GridColumn PartRefId;
        private DevExpress.XtraGrid.Columns.GridColumn PartNumber;
        private DevExpress.XtraGrid.Columns.GridColumn CutState;
        private DevExpress.XtraGrid.Columns.GridColumn CutStartTime;
        private DevExpress.XtraGrid.Columns.GridColumn CutEndTime;
        private DevExpress.XtraGrid.Columns.GridColumn SortState;
        private DevExpress.XtraGrid.Columns.GridColumn SortStartTime;
        private DevExpress.XtraGrid.Columns.GridColumn SortEndTime;
        private DevExpress.XtraGrid.Columns.GridColumn StackAreaType;
        private DevExpress.XtraGrid.Columns.GridColumn PartName;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}