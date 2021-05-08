
namespace Bankomat
{
    partial class Blocked
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blocked));
            this.label1 = new System.Windows.Forms.Label();
            this.input_box = new System.Windows.Forms.TextBox();
            this.block_btn = new System.Windows.Forms.Button();
            this.unblock_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wpisz numer karty";
            // 
            // input_box
            // 
            this.input_box.Location = new System.Drawing.Point(331, 162);
            this.input_box.MaxLength = 11;
            this.input_box.Name = "input_box";
            this.input_box.Size = new System.Drawing.Size(100, 20);
            this.input_box.TabIndex = 1;
            this.input_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // block_btn
            // 
            this.block_btn.BackColor = System.Drawing.Color.Crimson;
            this.block_btn.Location = new System.Drawing.Point(284, 219);
            this.block_btn.Name = "block_btn";
            this.block_btn.Size = new System.Drawing.Size(72, 41);
            this.block_btn.TabIndex = 2;
            this.block_btn.Text = "Zablokuj";
            this.block_btn.UseVisualStyleBackColor = false;
            this.block_btn.Click += new System.EventHandler(this.block_btn_Click);
            // 
            // unblock_btn
            // 
            this.unblock_btn.BackColor = System.Drawing.Color.GreenYellow;
            this.unblock_btn.Location = new System.Drawing.Point(409, 219);
            this.unblock_btn.Name = "unblock_btn";
            this.unblock_btn.Size = new System.Drawing.Size(72, 41);
            this.unblock_btn.TabIndex = 3;
            this.unblock_btn.Text = "Odblokuj";
            this.unblock_btn.UseVisualStyleBackColor = false;
            this.unblock_btn.Click += new System.EventHandler(this.unblock_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Image = global::Bankomat.Properties.Resources.arrow_back;
            this.back_btn.Location = new System.Drawing.Point(748, 398);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(40, 40);
            this.back_btn.TabIndex = 13;
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Blocked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.unblock_btn);
            this.Controls.Add(this.block_btn);
            this.Controls.Add(this.input_box);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Blocked";
            this.Text = "Blokowanie użytkowników";
            this.Load += new System.EventHandler(this.Blocked_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_box;
        private System.Windows.Forms.Button block_btn;
        private System.Windows.Forms.Button unblock_btn;
        private System.Windows.Forms.Button back_btn;
    }
}