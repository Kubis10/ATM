
namespace Bankomat
{
    partial class Blik
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blik));
            this.back_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.blik_nr = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Image = global::Bankomat.Properties.Resources.arrow_back;
            this.back_btn.Location = new System.Drawing.Point(748, 398);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(40, 40);
            this.back_btn.TabIndex = 1;
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(303, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Twój kod BLIK";
            // 
            // blik_nr
            // 
            this.blik_nr.AutoSize = true;
            this.blik_nr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blik_nr.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.blik_nr.Location = new System.Drawing.Point(320, 148);
            this.blik_nr.Name = "blik_nr";
            this.blik_nr.Padding = new System.Windows.Forms.Padding(10);
            this.blik_nr.Size = new System.Drawing.Size(156, 59);
            this.blik_nr.TabIndex = 3;
            this.blik_nr.Text = "037 235";
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar.Location = new System.Drawing.Point(320, 210);
            this.progressBar.Maximum = 60;
            this.progressBar.Name = "progressBar";
            this.progressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar.Size = new System.Drawing.Size(156, 10);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Interval = 60000;
            this.timer.Tick += new System.EventHandler(this.Blik_Load);
            // 
            // Blik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.blik_nr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Blik";
            this.Text = "BLIK";
            this.Load += new System.EventHandler(this.Blik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label blik_nr;
        private System.Windows.Forms.ProgressBar progressBar;
        protected System.Windows.Forms.Timer timer;
    }
}