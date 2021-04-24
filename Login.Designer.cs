
namespace Bankomat
{
    partial class Login
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.HeadLabel = new System.Windows.Forms.Label();
            this.label_card = new System.Windows.Forms.Label();
            this.pinLabel = new System.Windows.Forms.Label();
            this.Login_btn = new System.Windows.Forms.Button();
            this.pin_nr = new System.Windows.Forms.TextBox();
            this.card_nr = new System.Windows.Forms.TextBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeadLabel
            // 
            this.HeadLabel.AutoSize = true;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeadLabel.Location = new System.Drawing.Point(250, 9);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(318, 39);
            this.HeadLabel.TabIndex = 0;
            this.HeadLabel.Text = "Bankomat Express";
            // 
            // label_card
            // 
            this.label_card.AutoSize = true;
            this.label_card.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_card.Location = new System.Drawing.Point(374, 118);
            this.label_card.Name = "label_card";
            this.label_card.Size = new System.Drawing.Size(87, 17);
            this.label_card.TabIndex = 1;
            this.label_card.Text = "Numer Karty";
            // 
            // pinLabel
            // 
            this.pinLabel.AutoSize = true;
            this.pinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pinLabel.Location = new System.Drawing.Point(401, 171);
            this.pinLabel.Name = "pinLabel";
            this.pinLabel.Size = new System.Drawing.Size(30, 17);
            this.pinLabel.TabIndex = 2;
            this.pinLabel.Text = "PIN";
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Login_btn.Location = new System.Drawing.Point(366, 263);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(100, 43);
            this.Login_btn.TabIndex = 3;
            this.Login_btn.Text = "Zatwierdź";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // pin_nr
            // 
            this.pin_nr.Location = new System.Drawing.Point(383, 190);
            this.pin_nr.MaxLength = 4;
            this.pin_nr.Name = "pin_nr";
            this.pin_nr.PasswordChar = '*';
            this.pin_nr.Size = new System.Drawing.Size(64, 20);
            this.pin_nr.TabIndex = 4;
            this.pin_nr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pin_nr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // card_nr
            // 
            this.card_nr.Location = new System.Drawing.Point(366, 138);
            this.card_nr.MaxLength = 11;
            this.card_nr.Name = "card_nr";
            this.card_nr.Size = new System.Drawing.Size(100, 20);
            this.card_nr.TabIndex = 5;
            this.card_nr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.card_nr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // close_btn
            // 
            this.close_btn.Image = global::Bankomat.Properties.Resources.exit;
            this.close_btn.Location = new System.Drawing.Point(748, 398);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(40, 40);
            this.close_btn.TabIndex = 6;
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.card_nr);
            this.Controls.Add(this.pin_nr);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.pinLabel);
            this.Controls.Add(this.label_card);
            this.Controls.Add(this.HeadLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Bankomat - Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Label label_card;
        private System.Windows.Forms.Label pinLabel;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.TextBox pin_nr;
        private System.Windows.Forms.TextBox card_nr;
        private System.Windows.Forms.Button close_btn;
    }
}

