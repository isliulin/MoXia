﻿namespace Carpenter . ControlUser
{
    partial class DLPlanDayPort
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components . Dispose ( );
            }
            base . Dispose ( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.workShopSection = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.PlanTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Remark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.commen = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gridControl1.Size = new System.Drawing.Size(327, 292);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.DarkSeaGreen;
            this.gridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.workShopSection,
            this.PlanTime,
            this.Remark,
            this.commen});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // workShopSection
            // 
            this.workShopSection.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.workShopSection.AppearanceCell.Options.UseFont = true;
            this.workShopSection.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.workShopSection.AppearanceHeader.Options.UseFont = true;
            this.workShopSection.Caption = "单号";
            this.workShopSection.ColumnEdit = this.repositoryItemMemoEdit1;
            this.workShopSection.FieldName = "workShopSection";
            this.workShopSection.Name = "workShopSection";
            this.workShopSection.Visible = true;
            this.workShopSection.VisibleIndex = 0;
            this.workShopSection.Width = 49;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // PlanTime
            // 
            this.PlanTime.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.PlanTime.AppearanceCell.Options.UseFont = true;
            this.PlanTime.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.PlanTime.AppearanceHeader.Options.UseFont = true;
            this.PlanTime.Caption = "计划日期";
            this.PlanTime.ColumnEdit = this.repositoryItemMemoEdit1;
            this.PlanTime.DisplayFormat.FormatString = "d";
            this.PlanTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.PlanTime.FieldName = "PlanTime";
            this.PlanTime.Name = "PlanTime";
            this.PlanTime.Visible = true;
            this.PlanTime.VisibleIndex = 1;
            this.PlanTime.Width = 83;
            // 
            // Remark
            // 
            this.Remark.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.Remark.AppearanceCell.Options.UseFont = true;
            this.Remark.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.Remark.AppearanceHeader.Options.UseFont = true;
            this.Remark.Caption = "数量";
            this.Remark.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Remark.FieldName = "Remark";
            this.Remark.Name = "Remark";
            this.Remark.Visible = true;
            this.Remark.VisibleIndex = 2;
            this.Remark.Width = 52;
            // 
            // commen
            // 
            this.commen.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.commen.AppearanceCell.Options.UseFont = true;
            this.commen.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.commen.AppearanceHeader.Options.UseFont = true;
            this.commen.Caption = "备注";
            this.commen.FieldName = "commen";
            this.commen.Name = "commen";
            this.commen.Visible = true;
            this.commen.VisibleIndex = 3;
            this.commen.Width = 260;
            // 
            // DLPlanDayPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "DLPlanDayPort";
            this.Size = new System.Drawing.Size(327, 292);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress . XtraGrid . Views . Grid . GridView gridView1;
        private DevExpress . XtraGrid . Columns . GridColumn PlanTime;
        private DevExpress . XtraGrid . Columns . GridColumn Remark;
        private DevExpress . XtraEditors . Repository . RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress . XtraGrid . Columns . GridColumn workShopSection;
        public DevExpress . XtraGrid . GridControl gridControl1;
        private DevExpress . XtraGrid . Columns . GridColumn commen;
    }
}
