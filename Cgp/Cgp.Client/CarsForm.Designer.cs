namespace Contal.Cgp.Client
{
    partial class CarsForm
    {
        private System.ComponentModel.IContainer components = null;
        private Contal.Cgp.Components.CgpDataGridView _cdgvData;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsForm));
            this._cdgvData = new Contal.Cgp.Components.CgpDataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this._cbSecurityLevelFilter = new System.Windows.Forms.ComboBox();
            this._lSecurityLevel = new System.Windows.Forms.Label();
            this._eBrandFilter = new System.Windows.Forms.TextBox();
            this._lBrand = new System.Windows.Forms.Label();
            this._eLpFilter = new System.Windows.Forms.TextBox();
            this._lLp = new System.Windows.Forms.Label();
            this._bFilterClear = new System.Windows.Forms.Button();
            this._bRunFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._cdgvData.DataGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cdgvData
            // 
            this._cdgvData.AllwaysRefreshOrder = false;
            this._cdgvData.CgpDataGridEvents = null;
            this._cdgvData.CopyOnRightClick = true;
            // 
            // 
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cdgvData.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._cdgvData.DataGrid.ColumnHeadersHeight = 34;
            this._cdgvData.DataGrid.Location = new System.Drawing.Point(0, 0);
            this._cdgvData.DataGrid.Name = "_dgvData";
            this._cdgvData.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cdgvData.DataGrid.RowHeadersWidth = 62;
            this._cdgvData.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this._cdgvData.DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this._cdgvData.DataGrid.TabIndex = 0;
            this._cdgvData.LocalizationHelper = null;
            this._cdgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cdgvData.Location = new System.Drawing.Point(0, 0);
            this._cdgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cdgvData.Location = new System.Drawing.Point(0, 0);
            this._cdgvData.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this._cdgvData.Name = "_cdgvData";
            this._cdgvData.Size = new System.Drawing.Size(1440, 615);
            this._cdgvData.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Controls.Add(this._cbSecurityLevelFilter);
            this.panel3.Controls.Add(this._lSecurityLevel);
            this.panel3.Controls.Add(this._eBrandFilter);
            this.panel3.Controls.Add(this._lBrand);
            this.panel3.Controls.Add(this._eLpFilter);
            this.panel3.Controls.Add(this._lLp);
            this.panel3.Controls.Add(this._bFilterClear);
            this.panel3.Controls.Add(this._bRunFilter);
            this.panel3.Location = new System.Drawing.Point(-2, 645);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1440, 100);
            this.panel3.TabIndex = 1;
            // 
            // _cbSecurityLevelFilter
            // 
            this._cbSecurityLevelFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSecurityLevelFilter.FormattingEnabled = true;
            this._cbSecurityLevelFilter.Location = new System.Drawing.Point(639, 48);
            this._cbSecurityLevelFilter.Margin = new System.Windows.Forms.Padding(4);
            this._cbSecurityLevelFilter.Name = "_cbSecurityLevelFilter";
            this._cbSecurityLevelFilter.Size = new System.Drawing.Size(180, 28);
            this._cbSecurityLevelFilter.TabIndex = 13;
            this._cbSecurityLevelFilter.TextChanged += new System.EventHandler(this.FilterValueChanged);
            // 
            // _lSecurityLevel
            // 
            this._lSecurityLevel.AutoSize = true;
            this._lSecurityLevel.Location = new System.Drawing.Point(635, 24);
            this._lSecurityLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lSecurityLevel.Name = "_lSecurityLevel";
            this._lSecurityLevel.Size = new System.Drawing.Size(101, 20);
            this._lSecurityLevel.TabIndex = 12;
            this._lSecurityLevel.Text = "Security level";
            // 
            // _eBrandFilter
            // 
            this._eBrandFilter.Location = new System.Drawing.Point(210, 48);
            this._eBrandFilter.Name = "_eBrandFilter";
            this._eBrandFilter.Size = new System.Drawing.Size(180, 26);
            this._eBrandFilter.TabIndex = 17;
            this._eBrandFilter.TextChanged += new System.EventHandler(this.FilterValueChanged);
            // 
            // _lBrand
            // 
            this._lBrand.AutoSize = true;
            this._lBrand.Location = new System.Drawing.Point(210, 24);
            this._lBrand.Name = "_lBrand";
            this._lBrand.Size = new System.Drawing.Size(52, 20);
            this._lBrand.TabIndex = 16;
            this._lBrand.Text = "Brand";
            // 
            // _eLpFilter
            // 
            this._eLpFilter.Location = new System.Drawing.Point(12, 48);
            this._eLpFilter.Name = "_eLpFilter";
            this._eLpFilter.Size = new System.Drawing.Size(180, 26);
            this._eLpFilter.TabIndex = 15;
            this._eLpFilter.TextChanged += new System.EventHandler(this.FilterValueChanged);
            // 
            // _lLp
            // 
            this._lLp.AutoSize = true;
            this._lLp.Location = new System.Drawing.Point(12, 24);
            this._lLp.Name = "_lLp";
            this._lLp.Size = new System.Drawing.Size(27, 20);
            this._lLp.TabIndex = 14;
            this._lLp.Text = "Lp";
            // 
            // _bFilterClear
            // 
            this._bFilterClear.Location = new System.Drawing.Point(1087, 48);
            this._bFilterClear.Margin = new System.Windows.Forms.Padding(4);
            this._bFilterClear.Name = "_bFilterClear";
            this._bFilterClear.Size = new System.Drawing.Size(112, 30);
            this._bFilterClear.TabIndex = 11;
            this._bFilterClear.Text = "Clear";
            this._bFilterClear.UseVisualStyleBackColor = true;
            this._bFilterClear.Click += new System.EventHandler(this._bFilterClear_Click);
            // 
            // _bRunFilter
            // 
            this._bRunFilter.Location = new System.Drawing.Point(965, 48);
            this._bRunFilter.Margin = new System.Windows.Forms.Padding(4);
            this._bRunFilter.Name = "_bRunFilter";
            this._bRunFilter.Size = new System.Drawing.Size(112, 30);
            this._bRunFilter.TabIndex = 10;
            this._bRunFilter.Text = "Filter";
            this._bRunFilter.UseVisualStyleBackColor = true;
            this._bRunFilter.Click += new System.EventHandler(this._bRunFilter_Click);
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 756);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this._cdgvData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CarsForm";
            this.Text = "Cars";
            ((System.ComponentModel.ISupportInitialize)(this._cdgvData.DataGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button _bFilterClear;
        private System.Windows.Forms.Button _bRunFilter;
        private System.Windows.Forms.ComboBox _cbSecurityLevelFilter;
        private System.Windows.Forms.Label _lSecurityLevel;
        private System.Windows.Forms.TextBox _eBrandFilter;
        private System.Windows.Forms.Label _lBrand;
        private System.Windows.Forms.TextBox _eLpFilter;
        private System.Windows.Forms.Label _lLp;
    }
}
