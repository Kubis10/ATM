
namespace Bankomat
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.konto_btn = new System.Windows.Forms.Button();
            this.wplata_btn = new System.Windows.Forms.Button();
            this.wyplata_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.trans_btn = new System.Windows.Forms.Button();
            this.przelew_btn = new System.Windows.Forms.Button();
            this.sett_btn = new System.Windows.Forms.Button();
            this.admin_btn = new System.Windows.Forms.Button();
            this.history_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // konto_btn
            // 
            this.konto_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.konto_btn.Location = new System.Drawing.Point(280, 164);
            this.konto_btn.Name = "konto_btn";
            this.konto_btn.Size = new System.Drawing.Size(87, 40);
            this.konto_btn.TabIndex = 0;
            this.konto_btn.Text = "Stan Konta";
            this.konto_btn.UseVisualStyleBackColor = true;
            this.konto_btn.Click += new System.EventHandler(this.konto_btn_Click);
            // 
            // wplata_btn
            // 
            this.wplata_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wplata_btn.Location = new System.Drawing.Point(280, 92);
            this.wplata_btn.Name = "wplata_btn";
            this.wplata_btn.Size = new System.Drawing.Size(87, 40);
            this.wplata_btn.TabIndex = 1;
            this.wplata_btn.Text = "Wpłata";
            this.wplata_btn.UseVisualStyleBackColor = true;
            this.wplata_btn.Click += new System.EventHandler(this.wplata_btn_Click);
            // 
            // wyplata_btn
            // 
            this.wyplata_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wyplata_btn.Location = new System.Drawing.Point(446, 92);
            this.wyplata_btn.Name = "wyplata_btn";
            this.wyplata_btn.Size = new System.Drawing.Size(87, 40);
            this.wyplata_btn.TabIndex = 2;
            this.wyplata_btn.Text = "Wypłata";
            this.wyplata_btn.UseVisualStyleBackColor = true;
            this.wyplata_btn.Click += new System.EventHandler(this.wyplata_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Firebrick;
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.exit_btn.Location = new System.Drawing.Point(364, 362);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(87, 38);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "Wyjdź";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // trans_btn
            // 
            this.trans_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trans_btn.Location = new System.Drawing.Point(280, 235);
            this.trans_btn.Name = "trans_btn";
            this.trans_btn.Size = new System.Drawing.Size(87, 40);
            this.trans_btn.TabIndex = 6;
            this.trans_btn.Text = "Transakcje";
            this.trans_btn.UseVisualStyleBackColor = true;
            this.trans_btn.Click += new System.EventHandler(this.trans_btn_Click);
            // 
            // przelew_btn
            // 
            this.przelew_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.przelew_btn.Location = new System.Drawing.Point(446, 164);
            this.przelew_btn.Name = "przelew_btn";
            this.przelew_btn.Size = new System.Drawing.Size(87, 40);
            this.przelew_btn.TabIndex = 7;
            this.przelew_btn.Text = "Przelewy";
            this.przelew_btn.UseVisualStyleBackColor = true;
            this.przelew_btn.Click += new System.EventHandler(this.przelew_btn_Click);
            // 
            // sett_btn
            // 
            this.sett_btn.Image = global::Bankomat.Properties.Resources.settings;
            this.sett_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sett_btn.Location = new System.Drawing.Point(708, 383);
            this.sett_btn.Name = "sett_btn";
            this.sett_btn.Size = new System.Drawing.Size(80, 55);
            this.sett_btn.TabIndex = 8;
            this.sett_btn.Text = "Ustawienia";
            this.sett_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sett_btn.UseVisualStyleBackColor = true;
            this.sett_btn.Click += new System.EventHandler(this.sett_btn_Click);
            // 
            // admin_btn
            // 
            this.admin_btn.Image = global::Bankomat.Properties.Resources.admin;
            this.admin_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.admin_btn.Location = new System.Drawing.Point(708, 12);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(80, 55);
            this.admin_btn.TabIndex = 5;
            this.admin_btn.Text = "Panel Admina";
            this.admin_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.admin_btn.UseVisualStyleBackColor = true;
            this.admin_btn.Visible = false;
            this.admin_btn.Click += new System.EventHandler(this.admin_btn_Click);
            // 
            // history_btn
            // 
            this.history_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.history_btn.Location = new System.Drawing.Point(446, 235);
            this.history_btn.Name = "history_btn";
            this.history_btn.Size = new System.Drawing.Size(87, 40);
            this.history_btn.TabIndex = 9;
            this.history_btn.Text = "Historia konta";
            this.history_btn.UseVisualStyleBackColor = true;
            this.history_btn.Click += new System.EventHandler(this.history_btn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.history_btn);
            this.Controls.Add(this.sett_btn);
            this.Controls.Add(this.przelew_btn);
            this.Controls.Add(this.trans_btn);
            this.Controls.Add(this.admin_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.wyplata_btn);
            this.Controls.Add(this.wplata_btn);
            this.Controls.Add(this.konto_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button konto_btn;
        private System.Windows.Forms.Button wplata_btn;
        private System.Windows.Forms.Button wyplata_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button admin_btn;
        private System.Windows.Forms.Button trans_btn;
        private System.Windows.Forms.Button przelew_btn;
        private System.Windows.Forms.Button sett_btn;
        private System.Windows.Forms.Button history_btn;
    }
}