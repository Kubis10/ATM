
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
            this.zmien_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.add_user_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // konto_btn
            // 
            this.konto_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.konto_btn.Location = new System.Drawing.Point(353, 42);
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
            this.wplata_btn.Location = new System.Drawing.Point(353, 99);
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
            this.wyplata_btn.Location = new System.Drawing.Point(353, 156);
            this.wyplata_btn.Name = "wyplata_btn";
            this.wyplata_btn.Size = new System.Drawing.Size(87, 40);
            this.wyplata_btn.TabIndex = 2;
            this.wyplata_btn.Text = "Wypłata";
            this.wyplata_btn.UseVisualStyleBackColor = true;
            this.wyplata_btn.Click += new System.EventHandler(this.wyplata_btn_Click);
            // 
            // zmien_btn
            // 
            this.zmien_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zmien_btn.Location = new System.Drawing.Point(353, 214);
            this.zmien_btn.Name = "zmien_btn";
            this.zmien_btn.Size = new System.Drawing.Size(87, 40);
            this.zmien_btn.TabIndex = 3;
            this.zmien_btn.Text = "Zmień PIN";
            this.zmien_btn.UseVisualStyleBackColor = true;
            this.zmien_btn.Click += new System.EventHandler(this.zmien_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Firebrick;
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.exit_btn.Location = new System.Drawing.Point(353, 343);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(87, 38);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "Wyjdź";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // add_user_btn
            // 
            this.add_user_btn.Image = global::Bankomat.Properties.Resources.add_user;
            this.add_user_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.add_user_btn.Location = new System.Drawing.Point(622, 115);
            this.add_user_btn.Name = "add_user_btn";
            this.add_user_btn.Size = new System.Drawing.Size(80, 60);
            this.add_user_btn.TabIndex = 5;
            this.add_user_btn.Text = "Dodaj użytkownika";
            this.add_user_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add_user_btn.UseVisualStyleBackColor = true;
            this.add_user_btn.Visible = false;
            this.add_user_btn.Click += new System.EventHandler(this.add_user_btn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_user_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.zmien_btn);
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
        private System.Windows.Forms.Button zmien_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button add_user_btn;
    }
}