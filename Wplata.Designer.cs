
namespace Bankomat
{
    partial class Wplata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wplata));
            this.head_lb = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.NumericUpDown();
            this.wplac_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.money)).BeginInit();
            this.SuspendLayout();
            // 
            // head_lb
            // 
            this.head_lb.AutoSize = true;
            this.head_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.head_lb.Location = new System.Drawing.Point(254, 67);
            this.head_lb.Name = "head_lb";
            this.head_lb.Size = new System.Drawing.Size(284, 24);
            this.head_lb.TabIndex = 0;
            this.head_lb.Text = "Ile pieniędzy chciałbyś wpłacić?";
            // 
            // money
            // 
            this.money.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.money.Location = new System.Drawing.Point(344, 159);
            this.money.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(130, 20);
            this.money.TabIndex = 1;
            this.money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wplac_btn
            // 
            this.wplac_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.wplac_btn.Location = new System.Drawing.Point(366, 256);
            this.wplac_btn.Name = "wplac_btn";
            this.wplac_btn.Size = new System.Drawing.Size(83, 44);
            this.wplac_btn.TabIndex = 2;
            this.wplac_btn.Text = "Potwierdź";
            this.wplac_btn.UseVisualStyleBackColor = false;
            this.wplac_btn.Click += new System.EventHandler(this.wplac_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Image = global::Bankomat.Properties.Resources.arrow_back;
            this.back_btn.Location = new System.Drawing.Point(748, 398);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(40, 40);
            this.back_btn.TabIndex = 3;
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Wplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.wplac_btn);
            this.Controls.Add(this.money);
            this.Controls.Add(this.head_lb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Wplata";
            this.Text = "Wplata";
            this.Load += new System.EventHandler(this.Wplata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.money)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label head_lb;
        private System.Windows.Forms.NumericUpDown money;
        private System.Windows.Forms.Button wplac_btn;
        private System.Windows.Forms.Button back_btn;
    }
}