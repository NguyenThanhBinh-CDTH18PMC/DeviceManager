
namespace DeviceManagerApp
{
    partial class DeviceDetail
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
            this.flp_ListSpecs = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lb_DeviceName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flp_ListSpecs
            // 
            this.flp_ListSpecs.Location = new System.Drawing.Point(503, 12);
            this.flp_ListSpecs.Name = "flp_ListSpecs";
            this.flp_ListSpecs.Size = new System.Drawing.Size(389, 426);
            this.flp_ListSpecs.TabIndex = 0;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Update.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Update.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Update.Location = new System.Drawing.Point(358, 399);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(125, 39);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "CẬP NHẬT";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lb_DeviceName
            // 
            this.lb_DeviceName.AutoSize = true;
            this.lb_DeviceName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lb_DeviceName.Location = new System.Drawing.Point(120, 187);
            this.lb_DeviceName.Name = "lb_DeviceName";
            this.lb_DeviceName.Size = new System.Drawing.Size(53, 20);
            this.lb_DeviceName.TabIndex = 2;
            this.lb_DeviceName.Text = "label1";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 235);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(471, 136);
            this.txtDescription.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(120, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 156);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FloralWhite;
            this.button1.Location = new System.Drawing.Point(12, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "ĐÓNG";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DeviceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lb_DeviceName);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.flp_ListSpecs);
            this.Name = "DeviceDetail";
            this.Text = "DeviceDetail";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_ListSpecs;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lb_DeviceName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}