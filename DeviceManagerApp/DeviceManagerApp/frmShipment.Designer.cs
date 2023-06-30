
namespace DeviceManagerApp
{
    partial class frmShipment
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
            this.components = new System.ComponentModel.Container();
            this.tbManageShipment = new System.Windows.Forms.TabControl();
            this.tab_Shipment = new System.Windows.Forms.TabPage();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.dtp_ImportDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_ShipmentName = new System.Windows.Forms.TextBox();
            this.btn_AddDevice = new System.Windows.Forms.Button();
            this.dtgv_Shipment = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_ShipmentDetail = new System.Windows.Forms.TabPage();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbManageShipment.SuspendLayout();
            this.tab_Shipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Shipment)).BeginInit();
            this.tab_ShipmentDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbManageShipment
            // 
            this.tbManageShipment.Controls.Add(this.tab_Shipment);
            this.tbManageShipment.Controls.Add(this.tab_ShipmentDetail);
            this.tbManageShipment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbManageShipment.Location = new System.Drawing.Point(12, 13);
            this.tbManageShipment.Name = "tbManageShipment";
            this.tbManageShipment.SelectedIndex = 0;
            this.tbManageShipment.Size = new System.Drawing.Size(1218, 491);
            this.tbManageShipment.TabIndex = 0;
            this.tbManageShipment.Tag = "";
            // 
            // tab_Shipment
            // 
            this.tab_Shipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tab_Shipment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tab_Shipment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tab_Shipment.Controls.Add(this.btn_Update);
            this.tab_Shipment.Controls.Add(this.btn_Del);
            this.tab_Shipment.Controls.Add(this.label4);
            this.tab_Shipment.Controls.Add(this.textBox2);
            this.tab_Shipment.Controls.Add(this.label3);
            this.tab_Shipment.Controls.Add(this.textBox1);
            this.tab_Shipment.Controls.Add(this.btn_Create);
            this.tab_Shipment.Controls.Add(this.dtp_ImportDate);
            this.tab_Shipment.Controls.Add(this.label2);
            this.tab_Shipment.Controls.Add(this.label1);
            this.tab_Shipment.Controls.Add(this.label);
            this.tab_Shipment.Controls.Add(this.comboBox1);
            this.tab_Shipment.Controls.Add(this.txt_ShipmentName);
            this.tab_Shipment.Controls.Add(this.btn_AddDevice);
            this.tab_Shipment.Controls.Add(this.dtgv_Shipment);
            this.tab_Shipment.ForeColor = System.Drawing.Color.Black;
            this.tab_Shipment.Location = new System.Drawing.Point(4, 33);
            this.tab_Shipment.Name = "tab_Shipment";
            this.tab_Shipment.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Shipment.Size = new System.Drawing.Size(1210, 454);
            this.tab_Shipment.TabIndex = 0;
            this.tab_Shipment.Tag = "";
            this.tab_Shipment.Text = "Phiếu nhập hàng";
            this.tab_Shipment.Click += new System.EventHandler(this.tab_Shipment_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.DimGray;
            this.btn_Update.BackgroundImage = global::DeviceManagerApp.Properties.Resources.pen_189869;
            this.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Update.ForeColor = System.Drawing.Color.Aqua;
            this.btn_Update.Location = new System.Drawing.Point(355, 375);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(55, 57);
            this.btn_Update.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btn_Update, "Lưu thay đổi (Ctrl + S)");
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.BackColor = System.Drawing.Color.DimGray;
            this.btn_Del.BackgroundImage = global::DeviceManagerApp.Properties.Resources.delete_file;
            this.btn_Del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Del.ForeColor = System.Drawing.Color.Aqua;
            this.btn_Del.Location = new System.Drawing.Point(424, 375);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(55, 57);
            this.btn_Del.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btn_Del, "Xóa phiếu (Ctrl + X)");
            this.btn_Del.UseVisualStyleBackColor = false;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã phiếu nhập:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 249);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Mô tả...";
            this.textBox2.Size = new System.Drawing.Size(276, 99);
            this.textBox2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã phiếu nhập:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Nhập mã phiếu...";
            this.textBox1.Size = new System.Drawing.Size(276, 30);
            this.textBox1.TabIndex = 10;
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.DimGray;
            this.btn_Create.BackgroundImage = global::DeviceManagerApp.Properties.Resources.add_file;
            this.btn_Create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Create.ForeColor = System.Drawing.Color.Aqua;
            this.btn_Create.Location = new System.Drawing.Point(278, 375);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(61, 57);
            this.btn_Create.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btn_Create, "Tạo phiếu (Ctrl + Enter)");
            this.btn_Create.UseVisualStyleBackColor = false;
            // 
            // dtp_ImportDate
            // 
            this.dtp_ImportDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ImportDate.Location = new System.Drawing.Point(203, 192);
            this.dtp_ImportDate.Name = "dtp_ImportDate";
            this.dtp_ImportDate.Size = new System.Drawing.Size(276, 30);
            this.dtp_ImportDate.TabIndex = 8;
            this.dtp_ImportDate.Value = new System.DateTime(2023, 6, 29, 13, 25, 6, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ngày nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hãng sản xuất:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(20, 39);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(111, 24);
            this.label.TabIndex = 5;
            this.label.Text = "Tên phiếu:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(203, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(276, 32);
            this.comboBox1.TabIndex = 4;
            // 
            // txt_ShipmentName
            // 
            this.txt_ShipmentName.Location = new System.Drawing.Point(203, 36);
            this.txt_ShipmentName.Name = "txt_ShipmentName";
            this.txt_ShipmentName.PlaceholderText = "Nhập tên phiếu...";
            this.txt_ShipmentName.Size = new System.Drawing.Size(276, 30);
            this.txt_ShipmentName.TabIndex = 3;
            // 
            // btn_AddDevice
            // 
            this.btn_AddDevice.BackColor = System.Drawing.Color.DarkGray;
            this.btn_AddDevice.BackgroundImage = global::DeviceManagerApp.Properties.Resources.buy;
            this.btn_AddDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddDevice.Location = new System.Drawing.Point(203, 375);
            this.btn_AddDevice.Name = "btn_AddDevice";
            this.btn_AddDevice.Size = new System.Drawing.Size(61, 57);
            this.btn_AddDevice.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_AddDevice, "Nhập hàng (Ctrl + A)");
            this.btn_AddDevice.UseVisualStyleBackColor = false;
            // 
            // dtgv_Shipment
            // 
            this.dtgv_Shipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Shipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Shipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ShipmentName,
            this.User,
            this.Date,
            this.Price});
            this.dtgv_Shipment.Location = new System.Drawing.Point(505, 17);
            this.dtgv_Shipment.Name = "dtgv_Shipment";
            this.dtgv_Shipment.RowHeadersWidth = 51;
            this.dtgv_Shipment.RowTemplate.Height = 29;
            this.dtgv_Shipment.Size = new System.Drawing.Size(699, 435);
            this.dtgv_Shipment.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // ShipmentName
            // 
            this.ShipmentName.DataPropertyName = "Name";
            this.ShipmentName.HeaderText = "Tên phiếu";
            this.ShipmentName.MinimumWidth = 6;
            this.ShipmentName.Name = "ShipmentName";
            this.ShipmentName.ReadOnly = true;
            // 
            // User
            // 
            this.User.DataPropertyName = "Person";
            this.User.HeaderText = "Người nhập";
            this.User.MinimumWidth = 6;
            this.User.Name = "User";
            this.User.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "ImportDate";
            this.Date.HeaderText = "Ngày";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "TotalPrice";
            this.Price.HeaderText = "Thanh toán";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // tab_ShipmentDetail
            // 
            this.tab_ShipmentDetail.Controls.Add(this.checkBox2);
            this.tab_ShipmentDetail.Location = new System.Drawing.Point(4, 33);
            this.tab_ShipmentDetail.Name = "tab_ShipmentDetail";
            this.tab_ShipmentDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ShipmentDetail.Size = new System.Drawing.Size(1210, 454);
            this.tab_ShipmentDetail.TabIndex = 2;
            this.tab_ShipmentDetail.Text = "Chi tiết lô hàng";
            this.tab_ShipmentDetail.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(537, 213);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(136, 28);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(521, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 40);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // frmShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 503);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbManageShipment);
            this.Name = "frmShipment";
            this.ShowIcon = false;
            this.Text = "frmShipment";
            this.tbManageShipment.ResumeLayout(false);
            this.tab_Shipment.ResumeLayout(false);
            this.tab_Shipment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Shipment)).EndInit();
            this.tab_ShipmentDetail.ResumeLayout(false);
            this.tab_ShipmentDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbManageShipment;
        private System.Windows.Forms.TabPage tab_Shipment;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_ShipmentName;
        private System.Windows.Forms.Button btn_AddDevice;
        private System.Windows.Forms.DataGridView dtgv_Shipment;
        private System.Windows.Forms.TabPage tab_ShipmentDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.DateTimePicker dtp_ImportDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_Update;
    }
}