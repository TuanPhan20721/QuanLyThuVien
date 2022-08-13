
namespace QuanLyTV
{
    partial class Menu
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
            this.btnQLDG = new System.Windows.Forms.Button();
            this.btnQLMT = new System.Windows.Forms.Button();
            this.btnQLS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQLDG
            // 
            this.btnQLDG.Location = new System.Drawing.Point(218, 91);
            this.btnQLDG.Name = "btnQLDG";
            this.btnQLDG.Size = new System.Drawing.Size(93, 81);
            this.btnQLDG.TabIndex = 6;
            this.btnQLDG.Text = "Quản lý độc giả";
            this.btnQLDG.UseVisualStyleBackColor = true;
            this.btnQLDG.Click += new System.EventHandler(this.btnQLDG_Click);
            // 
            // btnQLMT
            // 
            this.btnQLMT.Location = new System.Drawing.Point(379, 91);
            this.btnQLMT.Name = "btnQLMT";
            this.btnQLMT.Size = new System.Drawing.Size(93, 81);
            this.btnQLMT.TabIndex = 5;
            this.btnQLMT.Text = "Quản lý mượn  trả";
            this.btnQLMT.UseVisualStyleBackColor = true;
            this.btnQLMT.Click += new System.EventHandler(this.btnQLMT_Click);
            // 
            // btnQLS
            // 
            this.btnQLS.Location = new System.Drawing.Point(64, 91);
            this.btnQLS.Name = "btnQLS";
            this.btnQLS.Size = new System.Drawing.Size(93, 81);
            this.btnQLS.TabIndex = 4;
            this.btnQLS.Text = "Quản lý sách";
            this.btnQLS.UseVisualStyleBackColor = true;
            this.btnQLS.Click += new System.EventHandler(this.btnQLS_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 256);
            this.Controls.Add(this.btnQLDG);
            this.Controls.Add(this.btnQLMT);
            this.Controls.Add(this.btnQLS);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQLDG;
        private System.Windows.Forms.Button btnQLMT;
        private System.Windows.Forms.Button btnQLS;
    }
}