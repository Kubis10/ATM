
namespace Bankomat
{
    partial class Stan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stan));
            this.back_btn = new System.Windows.Forms.Button();
            this.acc_stan = new System.Windows.Forms.Label();
            this.stan_konta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Image = global::Bankomat.Properties.Resources.arrow_back;
            this.back_btn.Location = new System.Drawing.Point(748, 398);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(40, 40);
            this.back_btn.TabIndex = 0;
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // acc_stan
            // 
            this.acc_stan.AutoSize = true;
            this.acc_stan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.acc_stan.Location = new System.Drawing.Point(307, 125);
            this.acc_stan.Name = "acc_stan";
            this.acc_stan.Size = new System.Drawing.Size(189, 25);
            this.acc_stan.TabIndex = 1;
            this.acc_stan.Text = "Aktualny stan konta:";
            // 
            // stan_konta
            // 
            this.stan_konta.AutoSize = true;
            this.stan_konta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stan_konta.Location = new System.Drawing.Point(343, 183);
            this.stan_konta.Name = "stan_konta";
            this.stan_konta.Size = new System.Drawing.Size(37, 25);
            this.stan_konta.TabIndex = 2;
            this.stan_konta.Text = "0zł";
            this.stan_konta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Stan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stan_konta);
            this.Controls.Add(this.acc_stan);
            this.Controls.Add(this.back_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stan";
            this.Text = "Stan";
            this.Load += new System.EventHandler(this.Stan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label acc_stan;
        private System.Windows.Forms.Label stan_konta;
    }
}