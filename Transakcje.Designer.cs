
namespace Bankomat
{
    partial class Transakcje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transakcje));
            this.back_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tranz_box = new System.Windows.Forms.NumericUpDown();
            this.nr_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.ammo_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tranz_box)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(335, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ile rachunków?";
            // 
            // tranz_box
            // 
            this.tranz_box.Location = new System.Drawing.Point(345, 137);
            this.tranz_box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tranz_box.Name = "tranz_box";
            this.tranz_box.ReadOnly = true;
            this.tranz_box.Size = new System.Drawing.Size(120, 20);
            this.tranz_box.TabIndex = 15;
            this.tranz_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tranz_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nr_btn
            // 
            this.nr_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nr_btn.Location = new System.Drawing.Point(365, 175);
            this.nr_btn.Name = "nr_btn";
            this.nr_btn.Size = new System.Drawing.Size(76, 33);
            this.nr_btn.TabIndex = 16;
            this.nr_btn.Text = "Potwierdź";
            this.nr_btn.UseVisualStyleBackColor = false;
            this.nr_btn.Click += new System.EventHandler(this.nr_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.next_btn.Location = new System.Drawing.Point(365, 175);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(76, 33);
            this.next_btn.TabIndex = 17;
            this.next_btn.Text = "Zapłać";
            this.next_btn.UseVisualStyleBackColor = false;
            this.next_btn.Visible = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // ammo_box
            // 
            this.ammo_box.Location = new System.Drawing.Point(355, 137);
            this.ammo_box.MaxLength = 9;
            this.ammo_box.Name = "ammo_box";
            this.ammo_box.Size = new System.Drawing.Size(100, 20);
            this.ammo_box.TabIndex = 18;
            this.ammo_box.Visible = false;
            this.ammo_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(294, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Podaj cene 1 rachunku:";
            this.label2.Visible = false;
            // 
            // Transakcje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ammo_box);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.nr_btn);
            this.Controls.Add(this.tranz_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Transakcje";
            this.Text = "Transakcje";
            this.Load += new System.EventHandler(this.Transakcje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tranz_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tranz_box;
        private System.Windows.Forms.Button nr_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.TextBox ammo_box;
        private System.Windows.Forms.Label label2;
    }
}