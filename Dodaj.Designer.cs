
namespace Bankomat
{
    partial class Dodaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dodaj));
            this.label1 = new System.Windows.Forms.Label();
            this.cardID_box = new System.Windows.Forms.TextBox();
            this.pin_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.okey_btn = new System.Windows.Forms.Button();
            this.money_box = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.money_box)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj ID karty";
            // 
            // cardID_box
            // 
            this.cardID_box.Location = new System.Drawing.Point(352, 90);
            this.cardID_box.MaxLength = 11;
            this.cardID_box.Name = "cardID_box";
            this.cardID_box.Size = new System.Drawing.Size(100, 20);
            this.cardID_box.TabIndex = 1;
            this.cardID_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cardID_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // pin_box
            // 
            this.pin_box.Location = new System.Drawing.Point(352, 167);
            this.pin_box.MaxLength = 4;
            this.pin_box.Name = "pin_box";
            this.pin_box.Size = new System.Drawing.Size(100, 20);
            this.pin_box.TabIndex = 3;
            this.pin_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pin_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Podaj PIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Podaj kwotę początkową";
            // 
            // okey_btn
            // 
            this.okey_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.okey_btn.Location = new System.Drawing.Point(352, 323);
            this.okey_btn.Name = "okey_btn";
            this.okey_btn.Size = new System.Drawing.Size(100, 42);
            this.okey_btn.TabIndex = 6;
            this.okey_btn.Text = "Zatwierdź";
            this.okey_btn.UseVisualStyleBackColor = false;
            this.okey_btn.Click += new System.EventHandler(this.okey_btn_Click);
            // 
            // money_box
            // 
            this.money_box.DecimalPlaces = 2;
            this.money_box.Location = new System.Drawing.Point(342, 249);
            this.money_box.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.money_box.Name = "money_box";
            this.money_box.Size = new System.Drawing.Size(120, 20);
            this.money_box.TabIndex = 7;
            this.money_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.money_box);
            this.Controls.Add(this.okey_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pin_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cardID_box);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dodaj";
            this.Text = " Dodaj użytkownika";
            ((System.ComponentModel.ISupportInitialize)(this.money_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cardID_box;
        private System.Windows.Forms.TextBox pin_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button okey_btn;
        private System.Windows.Forms.NumericUpDown money_box;
    }
}