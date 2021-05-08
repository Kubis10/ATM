
namespace Bankomat
{
    partial class Przelewy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Przelewy));
            this.back_btn = new System.Windows.Forms.Button();
            this.telp_btn = new System.Windows.Forms.Button();
            this.cardp_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // telp_btn
            // 
            this.telp_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.telp_btn.Location = new System.Drawing.Point(247, 166);
            this.telp_btn.Name = "telp_btn";
            this.telp_btn.Size = new System.Drawing.Size(80, 80);
            this.telp_btn.TabIndex = 13;
            this.telp_btn.Text = "Przelew na telefon";
            this.telp_btn.UseVisualStyleBackColor = true;
            this.telp_btn.Click += new System.EventHandler(this.telp_btn_Click);
            // 
            // cardp_btn
            // 
            this.cardp_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardp_btn.Location = new System.Drawing.Point(442, 166);
            this.cardp_btn.Name = "cardp_btn";
            this.cardp_btn.Size = new System.Drawing.Size(80, 80);
            this.cardp_btn.TabIndex = 14;
            this.cardp_btn.Text = "Przelew na konto";
            this.cardp_btn.UseVisualStyleBackColor = true;
            this.cardp_btn.Click += new System.EventHandler(this.cardp_btn_Click);
            // 
            // Przelewy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cardp_btn);
            this.Controls.Add(this.telp_btn);
            this.Controls.Add(this.back_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Przelewy";
            this.Text = "Przelewy";
            this.Load += new System.EventHandler(this.Przelewy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button telp_btn;
        private System.Windows.Forms.Button cardp_btn;
    }
}