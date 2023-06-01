
namespace DeviceManagerApp
{
    partial class QR_Code
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
            this.ptb_show = new System.Windows.Forms.PictureBox();
            this.Create = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_show)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_show
            // 
            this.ptb_show.Location = new System.Drawing.Point(100, 46);
            this.ptb_show.Name = "ptb_show";
            this.ptb_show.Size = new System.Drawing.Size(291, 250);
            this.ptb_show.TabIndex = 0;
            this.ptb_show.TabStop = false;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(486, 82);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(94, 29);
            this.Create.TabIndex = 1;
            this.Create.TabStop = false;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.button1_Click);
            // 
            // QR_Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.ptb_show);
            this.Name = "QR_Code";
            this.Text = "QR_Code";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_show)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_show;
        private System.Windows.Forms.Button Create;
    }
}