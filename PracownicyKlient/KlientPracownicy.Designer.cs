namespace PracownicyKlient
{
    partial class PracownicyForm
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
            this.Imie = new System.Windows.Forms.Label();
            this.Nazwisko = new System.Windows.Forms.Label();
            this.PESEL = new System.Windows.Forms.Label();
            this.ImieBox = new System.Windows.Forms.TextBox();
            this.NazwiskoBox = new System.Windows.Forms.TextBox();
            this.PESELBox = new System.Windows.Forms.TextBox();
            this.DodajButton = new System.Windows.Forms.Button();
            this.WczytajButton = new System.Windows.Forms.Button();
            this.SprawdzButton = new System.Windows.Forms.Button();
            this.UsunButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Imie
            // 
            this.Imie.AutoSize = true;
            this.Imie.Location = new System.Drawing.Point(12, 19);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(26, 13);
            this.Imie.TabIndex = 0;
            this.Imie.Text = "Imię";
            // 
            // Nazwisko
            // 
            this.Nazwisko.AutoSize = true;
            this.Nazwisko.Location = new System.Drawing.Point(12, 73);
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.Size = new System.Drawing.Size(53, 13);
            this.Nazwisko.TabIndex = 1;
            this.Nazwisko.Text = "Nazwisko";
            // 
            // PESEL
            // 
            this.PESEL.AutoSize = true;
            this.PESEL.Location = new System.Drawing.Point(12, 126);
            this.PESEL.Name = "PESEL";
            this.PESEL.Size = new System.Drawing.Size(41, 13);
            this.PESEL.TabIndex = 2;
            this.PESEL.Text = "PESEL";
            // 
            // ImieBox
            // 
            this.ImieBox.Location = new System.Drawing.Point(15, 35);
            this.ImieBox.Name = "ImieBox";
            this.ImieBox.Size = new System.Drawing.Size(100, 20);
            this.ImieBox.TabIndex = 3;
            this.ImieBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ImieBox_KeyPress);
            // 
            // NazwiskoBox
            // 
            this.NazwiskoBox.Location = new System.Drawing.Point(15, 89);
            this.NazwiskoBox.Name = "NazwiskoBox";
            this.NazwiskoBox.Size = new System.Drawing.Size(100, 20);
            this.NazwiskoBox.TabIndex = 4;
            this.NazwiskoBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NazwiskoBox_KeyPress);
            // 
            // PESELBox
            // 
            this.PESELBox.Location = new System.Drawing.Point(15, 142);
            this.PESELBox.Name = "PESELBox";
            this.PESELBox.Size = new System.Drawing.Size(100, 20);
            this.PESELBox.TabIndex = 5;
            this.PESELBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PESELBox_KeyPress);
            // 
            // DodajButton
            // 
            this.DodajButton.Location = new System.Drawing.Point(166, 32);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(75, 23);
            this.DodajButton.TabIndex = 6;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            this.DodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // WczytajButton
            // 
            this.WczytajButton.Location = new System.Drawing.Point(260, 32);
            this.WczytajButton.Name = "WczytajButton";
            this.WczytajButton.Size = new System.Drawing.Size(75, 23);
            this.WczytajButton.TabIndex = 7;
            this.WczytajButton.Text = "Wczytaj";
            this.WczytajButton.UseVisualStyleBackColor = true;
            this.WczytajButton.Click += new System.EventHandler(this.WczytajButton_Click);
            // 
            // SprawdzButton
            // 
            this.SprawdzButton.Location = new System.Drawing.Point(211, 89);
            this.SprawdzButton.Name = "SprawdzButton";
            this.SprawdzButton.Size = new System.Drawing.Size(75, 23);
            this.SprawdzButton.TabIndex = 8;
            this.SprawdzButton.Text = "Sprawdź";
            this.SprawdzButton.UseVisualStyleBackColor = true;
            this.SprawdzButton.Click += new System.EventHandler(this.SprawdzButton_Click);
            // 
            // UsunButton
            // 
            this.UsunButton.Location = new System.Drawing.Point(211, 142);
            this.UsunButton.Name = "UsunButton";
            this.UsunButton.Size = new System.Drawing.Size(75, 23);
            this.UsunButton.TabIndex = 9;
            this.UsunButton.Text = "Usuń";
            this.UsunButton.UseVisualStyleBackColor = true;
            this.UsunButton.Click += new System.EventHandler(this.UsunButton_Click);
            // 
            // PracownicyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 207);
            this.Controls.Add(this.UsunButton);
            this.Controls.Add(this.SprawdzButton);
            this.Controls.Add(this.WczytajButton);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.PESELBox);
            this.Controls.Add(this.NazwiskoBox);
            this.Controls.Add(this.ImieBox);
            this.Controls.Add(this.PESEL);
            this.Controls.Add(this.Nazwisko);
            this.Controls.Add(this.Imie);
            this.Name = "PracownicyForm";
            this.Text = "Pracownicy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Imie;
        private System.Windows.Forms.Label Nazwisko;
        private System.Windows.Forms.Label PESEL;
        private System.Windows.Forms.TextBox ImieBox;
        private System.Windows.Forms.TextBox NazwiskoBox;
        private System.Windows.Forms.TextBox PESELBox;
        private System.Windows.Forms.Button DodajButton;
        private System.Windows.Forms.Button WczytajButton;
        private System.Windows.Forms.Button SprawdzButton;
        private System.Windows.Forms.Button UsunButton;
    }
}

