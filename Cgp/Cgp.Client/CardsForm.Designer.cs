using Contal.Cgp.Globals.PlatformPC;

namespace Contal.Cgp.Client
{
    partial class CardsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardsForm));
            this._pFilter = new System.Windows.Forms.Panel();
            this._cbPersonFilter = new System.Windows.Forms.ComboBox();
            this._lPersonFilter = new System.Windows.Forms.Label();
            this._cbCardStateFilter = new System.Windows.Forms.ComboBox();
            this._lCardState = new System.Windows.Forms.Label();
            this._cbCardSystemFilter = new System.Windows.Forms.ComboBox();
            this._lCardSystemFilter = new System.Windows.Forms.Label();
            this._lCardNumberFilter = new System.Windows.Forms.Label();
            this._eCardNumberFilter = new System.Windows.Forms.TextBox();
            this._bFilterClear = new System.Windows.Forms.Button();
            this._bRunFilter = new System.Windows.Forms.Button();
            this._pControl = new System.Windows.Forms.Panel();
            this.bExportExcel = new System.Windows.Forms.Button();
            this._lRecordCount = new System.Windows.Forms.Label();
            this._bPrint = new System.Windows.Forms.Button();
            this._bCSVImport = new System.Windows.Forms.Button();
            this._cdgvData = new Contal.Cgp.Components.CgpDataGridView();
            this._pFilter.SuspendLayout();
            this._pControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cdgvData.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // _pFilter
            // 
            this._pFilter.Controls.Add(this._cbPersonFilter);
            this._pFilter.Controls.Add(this._lPersonFilter);
            this._pFilter.Controls.Add(this._cbCardStateFilter);
            this._pFilter.Controls.Add(this._lCardState);
            this._pFilter.Controls.Add(this._cbCardSystemFilter);
            this._pFilter.Controls.Add(this._lCardSystemFilter);
            this._pFilter.Controls.Add(this._lCardNumberFilter);
            this._pFilter.Controls.Add(this._eCardNumberFilter);
            this._pFilter.Controls.Add(this._bFilterClear);
            this._pFilter.Controls.Add(this._bRunFilter);
            this._pFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._pFilter.Location = new System.Drawing.Point(0, 403);
            this._pFilter.Name = "_pFilter";
            this._pFilter.Font = CgpUIDesign.Default;
            this._pFilter.Size = new System.Drawing.Size(960, 73);
            this._pFilter.TabIndex = 1;
            // 
            // _cbPersonFilter
            // 
            this._cbPersonFilter.FormattingEnabled = true;
            this._cbPersonFilter.Location = new System.Drawing.Point(269, 32);
            this._cbPersonFilter.Name = "_cbPersonFilter";
            this._cbPersonFilter.Font = CgpUIDesign.Default;
            this._cbPersonFilter.Size = new System.Drawing.Size(121, 28);
            this._cbPersonFilter.TabIndex = 5;
            this._cbPersonFilter.SelectedIndexChanged += new System.EventHandler(this._cbPersonFilter_SelectedIndexChanged);
            this._cbPersonFilter.TextChanged += new System.EventHandler(this.FilterValueChanged);
            this._cbPersonFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterKeyDown);
            // 
            // _lPersonFilter
            // 
            this._lPersonFilter.AutoSize = true;
            this._lPersonFilter.Location = new System.Drawing.Point(266, 6);
            this._lPersonFilter.Name = "_lPersonFilter";
            this._lPersonFilter.Font = CgpUIDesign.Default;
            this._lPersonFilter.Size = new System.Drawing.Size(59, 20);
            this._lPersonFilter.TabIndex = 4;
            this._lPersonFilter.Text = "Person";
            // 
            // _cbCardStateFilter
            // 
            this._cbCardStateFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbCardStateFilter.FormattingEnabled = true;
            this._cbCardStateFilter.Location = new System.Drawing.Point(396, 32);
            this._cbCardStateFilter.Name = "_cbCardStateFilter";
            this._cbCardStateFilter.Font = CgpUIDesign.Default;
            this._cbCardStateFilter.Size = new System.Drawing.Size(121, 28);
            this._cbCardStateFilter.TabIndex = 7;
            this._cbCardStateFilter.TextChanged += new System.EventHandler(this.FilterValueChanged);
            this._cbCardStateFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterKeyDown);
            // 
            // _lCardState
            // 
            this._lCardState.AutoSize = true;
            this._lCardState.Location = new System.Drawing.Point(393, 6);
            this._lCardState.Name = "_lCardState";
            this._lCardState.Font = CgpUIDesign.Default;
            this._lCardState.Size = new System.Drawing.Size(83, 20);
            this._lCardState.TabIndex = 6;
            this._lCardState.Text = "Card state";
            // 
            // _cbCardSystemFilter
            // 
            this._cbCardSystemFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbCardSystemFilter.FormattingEnabled = true;
            this._cbCardSystemFilter.Location = new System.Drawing.Point(142, 32);
            this._cbCardSystemFilter.Name = "_cbCardSystemFilter";
            this._cbCardSystemFilter.Font = CgpUIDesign.Default;
            this._cbCardSystemFilter.Size = new System.Drawing.Size(121, 28);
            this._cbCardSystemFilter.TabIndex = 3;
            this._cbCardSystemFilter.TextChanged += new System.EventHandler(this.FilterValueChanged);
            this._cbCardSystemFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterKeyDown);
            // 
            // _lCardSystemFilter
            // 
            this._lCardSystemFilter.AutoSize = true;
            this._lCardSystemFilter.Location = new System.Drawing.Point(139, 6);
            this._lCardSystemFilter.Name = "_lCardSystemFilter";
            this._lCardSystemFilter.Font = CgpUIDesign.Default;
            this._lCardSystemFilter.Size = new System.Drawing.Size(97, 20);
            this._lCardSystemFilter.TabIndex = 2;
            this._lCardSystemFilter.Text = "Card system";
            // 
            // _lCardNumberFilter
            // 
            this._lCardNumberFilter.AutoSize = true;
            this._lCardNumberFilter.Location = new System.Drawing.Point(12, 6);
            this._lCardNumberFilter.Name = "_lCardNumberFilter";
            this._lCardNumberFilter.Font = CgpUIDesign.Default;
            this._lCardNumberFilter.Size = new System.Drawing.Size(101, 20);
            this._lCardNumberFilter.TabIndex = 0;
            this._lCardNumberFilter.Text = "Card number";
            // 
            // _eCardNumberFilter
            // 
            this._eCardNumberFilter.Location = new System.Drawing.Point(12, 32);
            this._eCardNumberFilter.Name = "_eCardNumberFilter";
            this._eCardNumberFilter.Font = CgpUIDesign.Default;
            this._eCardNumberFilter.Size = new System.Drawing.Size(124, 26);
            this._eCardNumberFilter.TabIndex = 1;
            this._eCardNumberFilter.TextChanged += new System.EventHandler(this.FilterValueChanged);
            this._eCardNumberFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterKeyDown);
            // 
            // _bFilterClear
            // 
            this._bFilterClear.Location = new System.Drawing.Point(604, 30);
            this._bFilterClear.Name = "_bFilterClear";
            this._bFilterClear.Font = CgpUIDesign.Default;
            this._bFilterClear.Size = new System.Drawing.Size(75, 32);
            this._bFilterClear.TabIndex = 9;
            this._bFilterClear.Text = "Clear";
            this._bFilterClear.UseVisualStyleBackColor = true;
            this._bFilterClear.Click += new System.EventHandler(this._bFilterClear_Click);
            // 
            // _bRunFilter
            // 
            this._bRunFilter.Location = new System.Drawing.Point(523, 30);
            this._bRunFilter.Name = "_bRunFilter";
            this._bRunFilter.Font = CgpUIDesign.Default;
            this._bRunFilter.Size = new System.Drawing.Size(75, 32);
            this._bRunFilter.TabIndex = 8;
            this._bRunFilter.Text = "Filter";
            this._bRunFilter.UseVisualStyleBackColor = true;
            this._bRunFilter.Click += new System.EventHandler(this._bRunFilter_Click);
            // 
            // _pControl
            // 
            this._pControl.Controls.Add(this.bExportExcel);
            this._pControl.Controls.Add(this._lRecordCount);
            this._pControl.Controls.Add(this._bPrint);
            this._pControl.Controls.Add(this._bCSVImport);
            this._pControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._pControl.Location = new System.Drawing.Point(0, 476);
            this._pControl.Name = "_pControl";
            this._pControl.Size = new System.Drawing.Size(960, 43);
            this._pControl.TabIndex = 2;
            // 
            // bExportExcel
            // 
            this.bExportExcel.Location = new System.Drawing.Point(188, 6);
            this.bExportExcel.Name = "bExportExcel";
            this.bExportExcel.Font = CgpUIDesign.Default;
            this.bExportExcel.Size = new System.Drawing.Size(98, 34);
            this.bExportExcel.TabIndex = 6;
            this.bExportExcel.Text = "Export To Excel";
            this.bExportExcel.UseVisualStyleBackColor = true;
            this.bExportExcel.Click += new System.EventHandler(this.bExportExcel_Click);
            // 
            // _lRecordCount
            // 
            this._lRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._lRecordCount.AutoSize = true;
            this._lRecordCount.Location = new System.Drawing.Point(780, 17);
            this._lRecordCount.Name = "_lRecordCount";
            this._lRecordCount.Font = CgpUIDesign.Default;
            this._lRecordCount.Size = new System.Drawing.Size(104, 20);
            this._lRecordCount.TabIndex = 5;
            this._lRecordCount.Text = "RecordCount";
            // 
            // _bPrint
            // 
            this._bPrint.Enabled = false;
            this._bPrint.Location = new System.Drawing.Point(93, 6);
            this._bPrint.Name = "_bPrint";
            this._bPrint.Font = CgpUIDesign.Default;
            this._bPrint.Size = new System.Drawing.Size(75, 34);
            this._bPrint.TabIndex = 4;
            this._bPrint.Text = "Print";
            this._bPrint.UseVisualStyleBackColor = true;
            this._bPrint.Click += new System.EventHandler(this._bPrint_Click);
            // 
            // _bCSVImport
            // 
            this._bCSVImport.Location = new System.Drawing.Point(12, 6);
            this._bCSVImport.Name = "_bCSVImport";
            this._bCSVImport.Font = CgpUIDesign.Default;
            this._bCSVImport.Size = new System.Drawing.Size(75, 34);
            this._bCSVImport.TabIndex = 3;
            this._bCSVImport.Text = "CSV Import";
            this._bCSVImport.UseVisualStyleBackColor = true;
            this._bCSVImport.Click += new System.EventHandler(this._bCSVImport_Click);
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
            this._cdgvData.DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._cdgvData.DataGrid.ColumnHeadersHeight = 34;
            this._cdgvData.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._cdgvData.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cdgvData.DataGrid.Location = new System.Drawing.Point(0, 0);
            this._cdgvData.DataGrid.Name = "_dgvData";
            this._cdgvData.DataGrid.ReadOnly = true;
            this._cdgvData.DataGrid.RowHeadersVisible = false;
            this._cdgvData.DataGrid.RowHeadersWidth = 62;
            this._cdgvData.DataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this._cdgvData.DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this._cdgvData.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._cdgvData.DataGrid.Size = new System.Drawing.Size(960, 403);
            this._cdgvData.DataGrid.TabIndex = 0;
            this._cdgvData.DefaultSortColumnName = null;
            this._cdgvData.DefaultSortDirection = System.ComponentModel.ListSortDirection.Ascending;
            this._cdgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cdgvData.LocalizationHelper = null;
            this._cdgvData.Location = new System.Drawing.Point(0, 0);
            this._cdgvData.Name = "_cdgvData";
            this._cdgvData.Size = new System.Drawing.Size(960, 403);
            this._cdgvData.TabIndex = 3;
            // 
            // CardsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(960, 519);
            this.Controls.Add(this._cdgvData);
            this.Controls.Add(this._pFilter);
            this.Controls.Add(this._pControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CardsForm";
            this.Text = "CarsForm";
            this._pFilter.ResumeLayout(false);
            this._pFilter.PerformLayout();
            this._pControl.ResumeLayout(false);
            this._pControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cdgvData.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _pFilter;
        private System.Windows.Forms.Button _bFilterClear;
        private System.Windows.Forms.Button _bRunFilter;
        private System.Windows.Forms.Panel _pControl;
        private System.Windows.Forms.ComboBox _cbCardSystemFilter;
        private System.Windows.Forms.Label _lCardSystemFilter;
        private System.Windows.Forms.Label _lCardNumberFilter;
        private System.Windows.Forms.TextBox _eCardNumberFilter;
        private System.Windows.Forms.ComboBox _cbCardStateFilter;
        private System.Windows.Forms.Label _lCardState;
        private System.Windows.Forms.ComboBox _cbPersonFilter;
        private System.Windows.Forms.Label _lPersonFilter;
        private System.Windows.Forms.Button _bCSVImport;
        private System.Windows.Forms.Button _bPrint;
        private Contal.Cgp.Components.CgpDataGridView _cdgvData;
        private System.Windows.Forms.Label _lRecordCount;
        private System.Windows.Forms.Button bExportExcel;
    }
}
