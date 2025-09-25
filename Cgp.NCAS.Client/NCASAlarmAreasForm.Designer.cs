namespace Contal.Cgp.NCAS.Client
{
    partial class NCASAlarmAreasForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NCASAlarmAreasForm));
            this._lName = new System.Windows.Forms.Label();
            this._eNameFilter = new System.Windows.Forms.TextBox();
            this._bFilterClear = new System.Windows.Forms.Button();
            this._pFilter = new System.Windows.Forms.Panel();
            this._lRecordCount = new System.Windows.Forms.Label();
            this._lSectionId = new System.Windows.Forms.Label();
            this._tbSectionIdFilter = new System.Windows.Forms.TextBox();
            this._lShortName = new System.Windows.Forms.Label();
            this._eShortNameFilter = new System.Windows.Forms.TextBox();
            this._bRunFilter = new System.Windows.Forms.Button();
            this._cdgvData = new Contal.Cgp.Components.CgpDataGridView();
            this._pFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cdgvData.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // _lName
            // 
            this._lName.AutoSize = true;
            this._lName.Location = new System.Drawing.Point(12, 6);
            this._lName.Name = "_lName";
            this._lName.Size = new System.Drawing.Size(51, 20);
            this._lName.TabIndex = 20;
            this._lName.Text = "Name";
            // 
            // _eNameFilter
            // 
            this._eNameFilter.Location = new System.Drawing.Point(12, 30);
            this._eNameFilter.Name = "_eNameFilter";
            this._eNameFilter.Size = new System.Drawing.Size(119, 26);
            this._eNameFilter.TabIndex = 3;
            this._eNameFilter.TextChanged += new System.EventHandler(this.FilterValueChanged);
            // 
            // _bFilterClear
            // 
            this._bFilterClear.Location = new System.Drawing.Point(477, 28);
            this._bFilterClear.Name = "_bFilterClear";
            this._bFilterClear.Size = new System.Drawing.Size(75, 32);
            this._bFilterClear.TabIndex = 6;
            this._bFilterClear.Text = "Clear";
            this._bFilterClear.UseVisualStyleBackColor = true;
            this._bFilterClear.Click += new System.EventHandler(this._bFilterClear_Click);
            // 
            // _pFilter
            // 
            this._pFilter.Controls.Add(this._lRecordCount);
            this._pFilter.Controls.Add(this._lSectionId);
            this._pFilter.Controls.Add(this._tbSectionIdFilter);
            this._pFilter.Controls.Add(this._lShortName);
            this._pFilter.Controls.Add(this._eShortNameFilter);
            this._pFilter.Controls.Add(this._lName);
            this._pFilter.Controls.Add(this._eNameFilter);
            this._pFilter.Controls.Add(this._bFilterClear);
            this._pFilter.Controls.Add(this._bRunFilter);
            this._pFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._pFilter.Location = new System.Drawing.Point(0, 331);
            this._pFilter.Name = "_pFilter";
            this._pFilter.Size = new System.Drawing.Size(830, 70);
            this._pFilter.TabIndex = 24;
            // 
            // _lRecordCount
            // 
            this._lRecordCount.AutoSize = true;
            this._lRecordCount.Location = new System.Drawing.Point(408, 6);
            this._lRecordCount.Name = "_lRecordCount";
            this._lRecordCount.Size = new System.Drawing.Size(109, 20);
            this._lRecordCount.TabIndex = 53;
            this._lRecordCount.Text = "Record count:";
            // 
            // _lSectionId
            // 
            this._lSectionId.AutoSize = true;
            this._lSectionId.Location = new System.Drawing.Point(262, 6);
            this._lSectionId.Name = "_lSectionId";
            this._lSectionId.Size = new System.Drawing.Size(77, 20);
            this._lSectionId.TabIndex = 24;
            this._lSectionId.Text = "SectionId";
            // 
            // _tbSectionIdFilter
            // 
            this._tbSectionIdFilter.Location = new System.Drawing.Point(262, 30);
            this._tbSectionIdFilter.Name = "_tbSectionIdFilter";
            this._tbSectionIdFilter.Size = new System.Drawing.Size(119, 26);
            this._tbSectionIdFilter.TabIndex = 23;
            this._tbSectionIdFilter.TextChanged += new System.EventHandler(this.FilterValueChanged);
            // 
            // _lShortName
            // 
            this._lShortName.AutoSize = true;
            this._lShortName.Location = new System.Drawing.Point(137, 6);
            this._lShortName.Name = "_lShortName";
            this._lShortName.Size = new System.Drawing.Size(92, 20);
            this._lShortName.TabIndex = 22;
            this._lShortName.Text = "Short name";
            // 
            // _eShortNameFilter
            // 
            this._eShortNameFilter.Location = new System.Drawing.Point(137, 30);
            this._eShortNameFilter.Name = "_eShortNameFilter";
            this._eShortNameFilter.Size = new System.Drawing.Size(119, 26);
            this._eShortNameFilter.TabIndex = 4;
            this._eShortNameFilter.TextChanged += new System.EventHandler(this.FilterValueChanged);
            // 
            // _bRunFilter
            // 
            this._bRunFilter.Location = new System.Drawing.Point(396, 28);
            this._bRunFilter.Name = "_bRunFilter";
            this._bRunFilter.Size = new System.Drawing.Size(75, 32);
            this._bRunFilter.TabIndex = 5;
            this._bRunFilter.Text = "Filter";
            this._bRunFilter.UseVisualStyleBackColor = true;
            this._bRunFilter.Click += new System.EventHandler(this._bRunFilter_Click);
            // 
            // _cdgvData
            // 
            this._cdgvData.AllwaysRefreshOrder = false;
            this._cdgvData.CgpDataGridEvents = null;
            this._cdgvData.CopyOnRightClick = true;
            // 
            // 
            // 
            this._cdgvData.DataGrid.AllowUserToAddRows = false;
            this._cdgvData.DataGrid.AllowUserToDeleteRows = false;
            this._cdgvData.DataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cdgvData.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._cdgvData.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._cdgvData.DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._cdgvData.DataGrid.ColumnHeadersHeight = 34;
            this._cdgvData.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._cdgvData.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cdgvData.DataGrid.Location = new System.Drawing.Point(0, 0);
            this._cdgvData.DataGrid.Margin = new System.Windows.Forms.Padding(4);
            this._cdgvData.DataGrid.Name = "_dgvData";
            this._cdgvData.DataGrid.ReadOnly = true;
            this._cdgvData.DataGrid.RowHeadersVisible = false;
            this._cdgvData.DataGrid.RowHeadersWidth = 62;
            this._cdgvData.DataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this._cdgvData.DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this._cdgvData.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._cdgvData.DataGrid.Size = new System.Drawing.Size(830, 331);
            this._cdgvData.DataGrid.TabIndex = 0;
            this._cdgvData.DefaultSortColumnName = null;
            this._cdgvData.DefaultSortDirection = System.ComponentModel.ListSortDirection.Ascending;
            this._cdgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cdgvData.LocalizationHelper = null;
            this._cdgvData.Location = new System.Drawing.Point(0, 0);
            this._cdgvData.Margin = new System.Windows.Forms.Padding(4);
            this._cdgvData.Name = "_cdgvData";
            this._cdgvData.Size = new System.Drawing.Size(830, 331);
            this._cdgvData.TabIndex = 25;
            // 
            // NCASAlarmAreasForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(830, 401);
            this.Controls.Add(this._cdgvData);
            this.Controls.Add(this._pFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NCASAlarmAreasForm";
            this.Text = "NCASAlarmAreasForm";
            this._pFilter.ResumeLayout(false);
            this._pFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cdgvData.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _lName;
        private System.Windows.Forms.TextBox _eNameFilter;
        private System.Windows.Forms.Button _bFilterClear;
        private System.Windows.Forms.Panel _pFilter;
        private System.Windows.Forms.Button _bRunFilter;
        private System.Windows.Forms.Label _lShortName;
        private System.Windows.Forms.TextBox _eShortNameFilter;
        private Contal.Cgp.Components.CgpDataGridView _cdgvData;
        private System.Windows.Forms.Label _lSectionId;
        private System.Windows.Forms.TextBox _tbSectionIdFilter;
        private System.Windows.Forms.Label _lRecordCount;
    }
}
