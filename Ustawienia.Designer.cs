
namespace Bankomat
{
    partial class Ustawienia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ustawienia));
            this.back_btn = new System.Windows.Forms.Button();
            this.zmien_pin_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Image = global::Bankomat.Properties.Resources.arrow_back;
            this.back_btn.Location = new System.Drawing.Point(748, 398);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(40, 40);
            this.back_btn.TabIndex = 11;
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // zmien_pin_btn
            // 
            this.zmien_pin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zmien_pin_btn.Location = new System.Drawing.Point(269, 180);
            this.zmien_pin_btn.Name = "zmien_pin_btn";
            this.zmien_pin_btn.Size = new System.Drawing.Size(87, 40);
            this.zmien_pin_btn.TabIndex = 12;
            this.zmien_pin_btn.Text = "Zmień PIN";
            this.zmien_pin_btn.UseVisualStyleBackColor = true;
            this.zmien_pin_btn.Click += new System.EventHandler(this.zmien_pin_btn_Click);
            // 
            // Ustawienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zmien_pin_btn);
            this.Controls.Add(this.back_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ustawienia";
            this.Text = "Ustawienia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button zmien_pin_btn;
    }
}