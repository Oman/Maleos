﻿namespace EnforceForm
{
    partial class frmPunishmentDiscussRecords
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableDateTimePickerEndCheckDate = new EnforceUI.TableDateTimePicker(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableDateTimePickerBeginCheckDate = new EnforceUI.TableDateTimePicker(this.components);
            this.buttonQuery = new System.Windows.Forms.Button();
            this.enforceToolStrip = new EnforceUI.EnforceToolStrip(this.components);
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTar = new System.Windows.Forms.ToolStripButton();
            this.enforceLawGridViewSpotCheck = new EnforceUI.EnforceLawGridView(this.components);
            this.PutOnRecordCaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscussDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtPutOnRecordCaseName = new EnforceUI.DocumentAutoCompleteTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.header1 = new Maleos.Controls.Header();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.enforceToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewSpotCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Location = new System.Drawing.Point(3, 70);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.enforceToolStrip);
            this.panel2.Location = new System.Drawing.Point(3, 123);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.enforceLawGridViewSpotCheck);
            this.panel3.Location = new System.Drawing.Point(3, 153);
            this.panel3.Size = new System.Drawing.Size(954, 327);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TxtPutOnRecordCaseName);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.tableDateTimePickerEndCheckDate);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.tableDateTimePickerBeginCheckDate);
            this.panel4.Controls.Add(this.buttonQuery);
            // 
            // tableDateTimePickerEndCheckDate
            // 
            this.tableDateTimePickerEndCheckDate.CustomFormat = "yyyy年M月d日";
            this.tableDateTimePickerEndCheckDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tableDateTimePickerEndCheckDate.Location = new System.Drawing.Point(444, 15);
            this.tableDateTimePickerEndCheckDate.Name = "tableDateTimePickerEndCheckDate";
            this.tableDateTimePickerEndCheckDate.Size = new System.Drawing.Size(158, 23);
            this.tableDateTimePickerEndCheckDate.TabIndex = 32;
            this.tableDateTimePickerEndCheckDate.Value = new System.DateTime(2013, 3, 10, 20, 2, 46, 763);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "讨论时间:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "～";
            // 
            // tableDateTimePickerBeginCheckDate
            // 
            this.tableDateTimePickerBeginCheckDate.CustomFormat = "yyyy年M月d日";
            this.tableDateTimePickerBeginCheckDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tableDateTimePickerBeginCheckDate.Location = new System.Drawing.Point(258, 15);
            this.tableDateTimePickerBeginCheckDate.Name = "tableDateTimePickerBeginCheckDate";
            this.tableDateTimePickerBeginCheckDate.Size = new System.Drawing.Size(158, 23);
            this.tableDateTimePickerBeginCheckDate.TabIndex = 31;
            this.tableDateTimePickerBeginCheckDate.Value = new System.DateTime(2013, 3, 9, 15, 10, 41, 390);
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(608, 14);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonQuery.TabIndex = 29;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // enforceToolStrip
            // 
            this.enforceToolStrip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enforceToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripSeparator1,
            this.toolStripButtonEdit,
            this.toolStripSeparator2,
            this.toolStripButtonDel,
            this.toolStripButtonTar});
            this.enforceToolStrip.Location = new System.Drawing.Point(0, 0);
            this.enforceToolStrip.Name = "enforceToolStrip";
            this.enforceToolStrip.Size = new System.Drawing.Size(954, 25);
            this.enforceToolStrip.TabIndex = 7;
            this.enforceToolStrip.Text = "enforceToolStrip1";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.Image = global::Maleos.Properties.Resources.application_add;
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonAdd.Text = "添加";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.Image = global::Maleos.Properties.Resources.application_edit;
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonEdit.Text = "编辑";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonDel
            // 
            this.toolStripButtonDel.Image = global::Maleos.Properties.Resources.application_delete;
            this.toolStripButtonDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDel.Name = "toolStripButtonDel";
            this.toolStripButtonDel.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonDel.Text = "删除";
            this.toolStripButtonDel.Click += new System.EventHandler(this.toolStripButtonDel_Click);
            // 
            // toolStripButtonTar
            // 
            this.toolStripButtonTar.Image = global::Maleos.Properties.Resources.savedoc;
            this.toolStripButtonTar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTar.Name = "toolStripButtonTar";
            this.toolStripButtonTar.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonTar.Text = "归档";
            this.toolStripButtonTar.Click += new System.EventHandler(this.toolStripButtonTar_Click);
            // 
            // enforceLawGridViewSpotCheck
            // 
            this.enforceLawGridViewSpotCheck.AllowUserToAddRows = false;
            this.enforceLawGridViewSpotCheck.AutoUpdate = false;
            this.enforceLawGridViewSpotCheck.BackgroundColor = System.Drawing.Color.White;
            this.enforceLawGridViewSpotCheck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enforceLawGridViewSpotCheck.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.enforceLawGridViewSpotCheck.ColumnHeadersHeight = 40;
            this.enforceLawGridViewSpotCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.enforceLawGridViewSpotCheck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PutOnRecordCaseName,
            this.HostName,
            this.ReportName,
            this.RecordUserName,
            this.DiscussDate});
            this.enforceLawGridViewSpotCheck.Custom = false;
            this.enforceLawGridViewSpotCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enforceLawGridViewSpotCheck.EntityType = null;
            this.enforceLawGridViewSpotCheck.Location = new System.Drawing.Point(0, 0);
            this.enforceLawGridViewSpotCheck.Name = "enforceLawGridViewSpotCheck";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enforceLawGridViewSpotCheck.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.enforceLawGridViewSpotCheck.RowTemplate.Height = 36;
            this.enforceLawGridViewSpotCheck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enforceLawGridViewSpotCheck.Size = new System.Drawing.Size(954, 327);
            this.enforceLawGridViewSpotCheck.TabIndex = 6;
            // 
            // PutOnRecordCaseName
            // 
            this.PutOnRecordCaseName.HeaderText = "案件名称";
            this.PutOnRecordCaseName.Name = "PutOnRecordCaseName";
            this.PutOnRecordCaseName.Width = 200;
            // 
            // HostName
            // 
            this.HostName.HeaderText = "主持人";
            this.HostName.Name = "HostName";
            // 
            // ReportName
            // 
            this.ReportName.HeaderText = "汇报人";
            this.ReportName.Name = "ReportName";
            this.ReportName.ReadOnly = true;
            // 
            // RecordUserName
            // 
            this.RecordUserName.HeaderText = "记录人";
            this.RecordUserName.Name = "RecordUserName";
            // 
            // DiscussDate
            // 
            this.DiscussDate.HeaderText = "讨论时间";
            this.DiscussDate.Name = "DiscussDate";
            this.DiscussDate.ReadOnly = true;
            this.DiscussDate.Width = 150;
            // 
            // TxtPutOnRecordCaseName
            // 
            this.TxtPutOnRecordCaseName.ControlText = "";
            this.TxtPutOnRecordCaseName.Location = new System.Drawing.Point(66, 15);
            this.TxtPutOnRecordCaseName.Name = "TxtPutOnRecordCaseName";
            this.TxtPutOnRecordCaseName.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPutOnRecordCaseName.PopupOffset = new System.Drawing.Point(12, 0);
            this.TxtPutOnRecordCaseName.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.TxtPutOnRecordCaseName.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.TxtPutOnRecordCaseName.PopupWidth = 300;
            this.TxtPutOnRecordCaseName.Size = new System.Drawing.Size(128, 23);
            this.TxtPutOnRecordCaseName.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "案件名称:";
            // 
            // header1
            // 
            this.header1.Appearance.BackColor = System.Drawing.Color.White;
            this.header1.Appearance.Options.UseBackColor = true;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(960, 75);
            this.header1.TabIndex = 9;
            this.header1.Title = "行政处罚集体讨论记录";
            // 
            // frmPunishmentDiscussRecords
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.header1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frmPunishmentDiscussRecords";
            this.Load += new System.EventHandler(this.frmPunishmentDiscussRecords_Load);
            this.Controls.SetChildIndex(this.panelTop, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.pager, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.header1, 0);
            this.panelTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.enforceToolStrip.ResumeLayout(false);
            this.enforceToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enforceLawGridViewSpotCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnforceUI.TableDateTimePicker tableDateTimePickerEndCheckDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private EnforceUI.TableDateTimePicker tableDateTimePickerBeginCheckDate;
        private System.Windows.Forms.Button buttonQuery;
        private EnforceUI.EnforceToolStrip enforceToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel;
        private EnforceUI.EnforceLawGridView enforceLawGridViewSpotCheck;
        private EnforceUI.DocumentAutoCompleteTextBox TxtPutOnRecordCaseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PutOnRecordCaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscussDate;
        private Maleos.Controls.Header header1;
        private System.Windows.Forms.ToolStripButton toolStripButtonTar;
    }
}
