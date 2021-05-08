
namespace Bankomat
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.add_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.block_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_btn
            // 
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.Image = global::Bankomat.Properties.Resources.add_user;
            this.add_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.add_btn.Location = new System.Drawing.Point(253, 176);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(88, 63);
            this.add_btn.TabIndex = 11;
            this.add_btn.Text = "Dodaj użytkownika";
            this.add_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Image = global::Bankomat.Properties.Resources.arrow_back;
            this.back_btn.Location = new System.Drawing.Point(748, 398);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(40, 40);
            this.back_btn.TabIndex = 12;
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // block_btn
            // 
            this.block_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.block_btn.Image = global::Bankomat.Properties.Resources.user_blocked;
            this.block_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.block_btn.Location = new System.Drawing.Point(471, 176);
            this.block_btn.Name = "block_btn";
            this.block_btn.Size = new System.Drawing.Size(88, 63);
            this.block_btn.TabIndex = 13;
            this.block_btn.Text = "Blokowanie użytkownika";
            this.block_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.block_btn.UseVisualStyleBackColor = true;
            this.block_btn.Click += new System.EventHandler(this.block_btn_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.block_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.add_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button block_btn;
    }
}