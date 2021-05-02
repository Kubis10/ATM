
namespace Bankomat
{
    partial class PrzelewT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrzelewT));
            this.back_btn = new System.Windows.Forms.Button();
            this.t_box = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ok_btn = new System.Windows.Forms.Button();
            this.kwota = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.t_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kwota)).BeginInit();
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
            // t_box
            // 
            this.t_box.Location = new System.Drawing.Point(346, 117);
            this.t_box.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.t_box.Name = "t_box";
            this.t_box.Size = new System.Drawing.Size(120, 20);
            this.t_box.TabIndex = 14;
            this.t_box.ThousandsSeparator = true;
            this.t_box.Value = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Podaj numer telefonu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Podaj kwotę";
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.GreenYellow;
            this.ok_btn.ForeColor = System.Drawing.Color.Black;
            this.ok_btn.Location = new System.Drawing.Point(359, 285);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(93, 35);
            this.ok_btn.TabIndex = 18;
            this.ok_btn.Text = "Wyślij";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // kwota
            // 
            this.kwota.Location = new System.Drawing.Point(346, 213);
            this.kwota.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.kwota.Name = "kwota";
            this.kwota.Size = new System.Drawing.Size(120, 20);
            this.kwota.TabIndex = 19;
            // 
            // PrzelewT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kwota);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_box);
            this.Controls.Add(this.back_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrzelewT";
            this.Text = "Przelew na telefon";
            ((System.ComponentModel.ISupportInitialize)(this.t_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kwota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.NumericUpDown t_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.NumericUpDown kwota;
    }
}