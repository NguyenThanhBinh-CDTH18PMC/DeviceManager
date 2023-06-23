namespace DeviceManagerApp
{
    partial class frmQuanLyLoaiThietBi
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
            this.lblQLDeviceType = new System.Windows.Forms.Label();
            this.gbQlDeviceType = new System.Windows.Forms.GroupBox();
            this.btn_AddSpecs = new System.Windows.Forms.Button();
            this.rtbMotaLoaiTB = new System.Windows.Forms.RichTextBox();
            this.lblMoTaLoaiTB = new System.Windows.Forms.Label();
            this.gbTimKiemLoaiTb = new System.Windows.Forms.GroupBox();
            this.btnTimKiemLoaiTb = new System.Windows.Forms.Button();
            this.txtTiemKiemLoaiTb = new System.Windows.Forms.TextBox();
            this.btnXoaLoaiTb = new System.Windows.Forms.Button();
            this.btnSuaLoaiTb = new System.Windows.Forms.Button();
            this.btnThemLoaiTB = new System.Windows.Forms.Button();
            this.txtTenLoaiTB = new System.Windows.Forms.TextBox();
            this.lblTenLoaiTB = new System.Windows.Forms.Label();
            this.dgvLoaiTb = new System.Windows.Forms.DataGridView();
            this.DeviceTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbQlDeviceType.SuspendLayout();
            this.gbTimKiemLoaiTb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTb)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQLDeviceType
            // 
            this.lblQLDeviceType.AutoSize = true;
            this.lblQLDeviceType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQLDeviceType.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQLDeviceType.Location = new System.Drawing.Point(0, 0);
            this.lblQLDeviceType.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblQLDeviceType.Name = "lblQLDeviceType";
            this.lblQLDeviceType.Size = new System.Drawing.Size(389, 50);
            this.lblQLDeviceType.TabIndex = 0;
            this.lblQLDeviceType.Text = "Quản Lý Loại Thiết Bị";
            // 
            // gbQlDeviceType
            // 
            this.gbQlDeviceType.Controls.Add(this.btn_AddSpecs);
            this.gbQlDeviceType.Controls.Add(this.rtbMotaLoaiTB);
            this.gbQlDeviceType.Controls.Add(this.lblMoTaLoaiTB);
            this.gbQlDeviceType.Controls.Add(this.gbTimKiemLoaiTb);
            this.gbQlDeviceType.Controls.Add(this.btnXoaLoaiTb);
            this.gbQlDeviceType.Controls.Add(this.btnSuaLoaiTb);
            this.gbQlDeviceType.Controls.Add(this.btnThemLoaiTB);
            this.gbQlDeviceType.Controls.Add(this.txtTenLoaiTB);
            this.gbQlDeviceType.Controls.Add(this.lblTenLoaiTB);
            this.gbQlDeviceType.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQlDeviceType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbQlDeviceType.Location = new System.Drawing.Point(0, 50);
            this.gbQlDeviceType.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.gbQlDeviceType.Name = "gbQlDeviceType";
            this.gbQlDeviceType.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.gbQlDeviceType.Size = new System.Drawing.Size(1141, 250);
            this.gbQlDeviceType.TabIndex = 2;
            this.gbQlDeviceType.TabStop = false;
            this.gbQlDeviceType.Text = "Thông tin loại thiết bị";
            // 
            // btn_AddSpecs
            // 
            this.btn_AddSpecs.BackColor = System.Drawing.Color.Lime;
            this.btn_AddSpecs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddSpecs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AddSpecs.Location = new System.Drawing.Point(971, 198);
            this.btn_AddSpecs.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btn_AddSpecs.Name = "btn_AddSpecs";
            this.btn_AddSpecs.Size = new System.Drawing.Size(135, 40);
            this.btn_AddSpecs.TabIndex = 9;
            this.btn_AddSpecs.Text = "Thêm thông số";
            this.btn_AddSpecs.UseVisualStyleBackColor = false;
            this.btn_AddSpecs.Click += new System.EventHandler(this.AddSpecs_Click);
            // 
            // rtbMotaLoaiTB
            // 
            this.rtbMotaLoaiTB.Location = new System.Drawing.Point(197, 102);
            this.rtbMotaLoaiTB.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.rtbMotaLoaiTB.Name = "rtbMotaLoaiTB";
            this.rtbMotaLoaiTB.Size = new System.Drawing.Size(203, 78);
            this.rtbMotaLoaiTB.TabIndex = 3;
            this.rtbMotaLoaiTB.Text = "";
            // 
            // lblMoTaLoaiTB
            // 
            this.lblMoTaLoaiTB.AutoSize = true;
            this.lblMoTaLoaiTB.Location = new System.Drawing.Point(59, 114);
            this.lblMoTaLoaiTB.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblMoTaLoaiTB.Name = "lblMoTaLoaiTB";
            this.lblMoTaLoaiTB.Size = new System.Drawing.Size(58, 20);
            this.lblMoTaLoaiTB.TabIndex = 18;
            this.lblMoTaLoaiTB.Text = "Mô tả :";
            // 
            // gbTimKiemLoaiTb
            // 
            this.gbTimKiemLoaiTb.Controls.Add(this.btnTimKiemLoaiTb);
            this.gbTimKiemLoaiTb.Controls.Add(this.txtTiemKiemLoaiTb);
            this.gbTimKiemLoaiTb.Location = new System.Drawing.Point(655, 18);
            this.gbTimKiemLoaiTb.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.gbTimKiemLoaiTb.Name = "gbTimKiemLoaiTb";
            this.gbTimKiemLoaiTb.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.gbTimKiemLoaiTb.Size = new System.Drawing.Size(451, 162);
            this.gbTimKiemLoaiTb.TabIndex = 17;
            this.gbTimKiemLoaiTb.TabStop = false;
            this.gbTimKiemLoaiTb.Text = "Tìm Kiếm";
            // 
            // btnTimKiemLoaiTb
            // 
            this.btnTimKiemLoaiTb.BackColor = System.Drawing.Color.Lime;
            this.btnTimKiemLoaiTb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemLoaiTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimKiemLoaiTb.Location = new System.Drawing.Point(317, 34);
            this.btnTimKiemLoaiTb.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnTimKiemLoaiTb.Name = "btnTimKiemLoaiTb";
            this.btnTimKiemLoaiTb.Size = new System.Drawing.Size(107, 40);
            this.btnTimKiemLoaiTb.TabIndex = 8;
            this.btnTimKiemLoaiTb.Text = "Tìm kiếm";
            this.btnTimKiemLoaiTb.UseVisualStyleBackColor = false;
            // 
            // txtTiemKiemLoaiTb
            // 
            this.txtTiemKiemLoaiTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTiemKiemLoaiTb.Location = new System.Drawing.Point(25, 42);
            this.txtTiemKiemLoaiTb.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtTiemKiemLoaiTb.Name = "txtTiemKiemLoaiTb";
            this.txtTiemKiemLoaiTb.Size = new System.Drawing.Size(202, 27);
            this.txtTiemKiemLoaiTb.TabIndex = 7;
            // 
            // btnXoaLoaiTb
            // 
            this.btnXoaLoaiTb.BackColor = System.Drawing.Color.Lime;
            this.btnXoaLoaiTb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLoaiTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoaLoaiTb.Location = new System.Drawing.Point(529, 140);
            this.btnXoaLoaiTb.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnXoaLoaiTb.Name = "btnXoaLoaiTb";
            this.btnXoaLoaiTb.Size = new System.Drawing.Size(107, 40);
            this.btnXoaLoaiTb.TabIndex = 6;
            this.btnXoaLoaiTb.Text = "Xóa";
            this.btnXoaLoaiTb.UseVisualStyleBackColor = false;
            this.btnXoaLoaiTb.ClientSizeChanged += new System.EventHandler(this.btnXoaLoaiTb_Click);
            // 
            // btnSuaLoaiTb
            // 
            this.btnSuaLoaiTb.BackColor = System.Drawing.Color.Lime;
            this.btnSuaLoaiTb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaLoaiTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuaLoaiTb.Location = new System.Drawing.Point(529, 82);
            this.btnSuaLoaiTb.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnSuaLoaiTb.Name = "btnSuaLoaiTb";
            this.btnSuaLoaiTb.Size = new System.Drawing.Size(107, 40);
            this.btnSuaLoaiTb.TabIndex = 5;
            this.btnSuaLoaiTb.Text = "Cập nhật";
            this.btnSuaLoaiTb.UseVisualStyleBackColor = false;
            this.btnSuaLoaiTb.Click += new System.EventHandler(this.btnSuaLoaiTb_Click);
            // 
            // btnThemLoaiTB
            // 
            this.btnThemLoaiTB.BackColor = System.Drawing.Color.Lime;
            this.btnThemLoaiTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLoaiTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemLoaiTB.Location = new System.Drawing.Point(529, 18);
            this.btnThemLoaiTB.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnThemLoaiTB.Name = "btnThemLoaiTB";
            this.btnThemLoaiTB.Size = new System.Drawing.Size(107, 40);
            this.btnThemLoaiTB.TabIndex = 4;
            this.btnThemLoaiTB.Text = "Thêm Mới";
            this.btnThemLoaiTB.UseVisualStyleBackColor = false;
            this.btnThemLoaiTB.Click += new System.EventHandler(this.btnThemLoaiTB_Click);
            // 
            // txtTenLoaiTB
            // 
            this.txtTenLoaiTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenLoaiTB.Location = new System.Drawing.Point(197, 50);
            this.txtTenLoaiTB.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtTenLoaiTB.Name = "txtTenLoaiTB";
            this.txtTenLoaiTB.Size = new System.Drawing.Size(202, 27);
            this.txtTenLoaiTB.TabIndex = 2;
            // 
            // lblTenLoaiTB
            // 
            this.lblTenLoaiTB.AutoSize = true;
            this.lblTenLoaiTB.Location = new System.Drawing.Point(59, 56);
            this.lblTenLoaiTB.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTenLoaiTB.Name = "lblTenLoaiTB";
            this.lblTenLoaiTB.Size = new System.Drawing.Size(133, 20);
            this.lblTenLoaiTB.TabIndex = 1;
            this.lblTenLoaiTB.Text = "Tên Loại Thiết Bị :";
            // 
            // dgvLoaiTb
            // 
            this.dgvLoaiTb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiTb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeviceTypeId,
            this.Column2,
            this.Column3});
            this.dgvLoaiTb.Location = new System.Drawing.Point(0, 298);
            this.dgvLoaiTb.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgvLoaiTb.Name = "dgvLoaiTb";
            this.dgvLoaiTb.ReadOnly = true;
            this.dgvLoaiTb.RowHeadersWidth = 62;
            this.dgvLoaiTb.RowTemplate.Height = 33;
            this.dgvLoaiTb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiTb.Size = new System.Drawing.Size(400, 213);
            this.dgvLoaiTb.TabIndex = 3;
            this.dgvLoaiTb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiTb_CellClick);
            // 
            // DeviceTypeId
            // 
            this.DeviceTypeId.DataPropertyName = "Id";
            this.DeviceTypeId.HeaderText = "Mã Loại Thiết Bị";
            this.DeviceTypeId.MinimumWidth = 8;
            this.DeviceTypeId.Name = "DeviceTypeId";
            this.DeviceTypeId.ReadOnly = true;
            this.DeviceTypeId.Visible = false;
            this.DeviceTypeId.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Tên Loại Thiết Bị";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Description";
            this.Column3.HeaderText = "Mô Tả";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // frmQuanLyLoaiThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 512);
            this.Controls.Add(this.dgvLoaiTb);
            this.Controls.Add(this.gbQlDeviceType);
            this.Controls.Add(this.lblQLDeviceType);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.MinimumSize = new System.Drawing.Size(1159, 559);
            this.Name = "frmQuanLyLoaiThietBi";
            this.Text = "frmQuanLyLoaiThietBi";
            this.gbQlDeviceType.ResumeLayout(false);
            this.gbQlDeviceType.PerformLayout();
            this.gbTimKiemLoaiTb.ResumeLayout(false);
            this.gbTimKiemLoaiTb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQLDeviceType;
        private System.Windows.Forms.GroupBox gbQlDeviceType;
        private System.Windows.Forms.RichTextBox rtbMotaLoaiTB;
        private System.Windows.Forms.Label lblMoTaLoaiTB;
        private System.Windows.Forms.GroupBox gbTimKiemLoaiTb;
        private System.Windows.Forms.Button btnTimKiemLoaiTb;
        private System.Windows.Forms.TextBox txtTiemKiemLoaiTb;
        private System.Windows.Forms.Button btnXoaLoaiTb;
        private System.Windows.Forms.Button btnSuaLoaiTb;
        private System.Windows.Forms.Button btnThemLoaiTB;
        private System.Windows.Forms.TextBox txtTenLoaiTB;
        private System.Windows.Forms.Label lblTenLoaiTB;
        private System.Windows.Forms.DataGridView dgvLoaiTb;
        private System.Windows.Forms.Button btn_AddSpecs;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}