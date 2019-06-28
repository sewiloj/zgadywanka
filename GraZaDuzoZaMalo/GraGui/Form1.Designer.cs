namespace GraGui
{
    partial class Form1
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
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxLosowanie = new System.Windows.Forms.GroupBox();
            this.textBoxZakresDo = new System.Windows.Forms.TextBox();
            this.textBoxZakresOd = new System.Windows.Forms.TextBox();
            this.buttonWylosuj = new System.Windows.Forms.Button();
            this.labelZakresDo = new System.Windows.Forms.Label();
            this.labelZakresOd = new System.Windows.Forms.Label();
            this.groupBoxOdgadnij = new System.Windows.Forms.GroupBox();
            this.buttonSprawdz = new System.Windows.Forms.Button();
            this.labelPodajLiczbe = new System.Windows.Forms.Label();
            this.textBoxPodajLiczbe = new System.Windows.Forms.TextBox();
            this.labelOcena = new System.Windows.Forms.Label();
            this.buttonHistoria = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.groupBoxLosowanie.SuspendLayout();
            this.groupBoxOdgadnij.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(12, 12);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(75, 23);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa Gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.ButtonNowaGra_Click);
            // 
            // groupBoxLosowanie
            // 
            this.groupBoxLosowanie.Controls.Add(this.textBoxZakresDo);
            this.groupBoxLosowanie.Controls.Add(this.textBoxZakresOd);
            this.groupBoxLosowanie.Controls.Add(this.buttonWylosuj);
            this.groupBoxLosowanie.Controls.Add(this.labelZakresDo);
            this.groupBoxLosowanie.Controls.Add(this.labelZakresOd);
            this.groupBoxLosowanie.Location = new System.Drawing.Point(12, 42);
            this.groupBoxLosowanie.Name = "groupBoxLosowanie";
            this.groupBoxLosowanie.Size = new System.Drawing.Size(312, 128);
            this.groupBoxLosowanie.TabIndex = 1;
            this.groupBoxLosowanie.TabStop = false;
            this.groupBoxLosowanie.Text = "Losowanie";
            this.groupBoxLosowanie.Visible = false;
            // 
            // textBoxZakresDo
            // 
            this.textBoxZakresDo.Location = new System.Drawing.Point(110, 62);
            this.textBoxZakresDo.Name = "textBoxZakresDo";
            this.textBoxZakresDo.Size = new System.Drawing.Size(100, 20);
            this.textBoxZakresDo.TabIndex = 4;
            // 
            // textBoxZakresOd
            // 
            this.textBoxZakresOd.Location = new System.Drawing.Point(110, 29);
            this.textBoxZakresOd.Name = "textBoxZakresOd";
            this.textBoxZakresOd.Size = new System.Drawing.Size(100, 20);
            this.textBoxZakresOd.TabIndex = 3;
            // 
            // buttonWylosuj
            // 
            this.buttonWylosuj.Location = new System.Drawing.Point(231, 43);
            this.buttonWylosuj.Name = "buttonWylosuj";
            this.buttonWylosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonWylosuj.TabIndex = 2;
            this.buttonWylosuj.Text = "Wylosuj!";
            this.buttonWylosuj.UseVisualStyleBackColor = true;
            this.buttonWylosuj.Click += new System.EventHandler(this.ButtonWylosuj_Click);
            // 
            // labelZakresDo
            // 
            this.labelZakresDo.AutoSize = true;
            this.labelZakresDo.Location = new System.Drawing.Point(6, 65);
            this.labelZakresDo.Name = "labelZakresDo";
            this.labelZakresDo.Size = new System.Drawing.Size(55, 13);
            this.labelZakresDo.TabIndex = 1;
            this.labelZakresDo.Text = "Zakres do";
            // 
            // labelZakresOd
            // 
            this.labelZakresOd.AutoSize = true;
            this.labelZakresOd.Location = new System.Drawing.Point(6, 32);
            this.labelZakresOd.Name = "labelZakresOd";
            this.labelZakresOd.Size = new System.Drawing.Size(55, 13);
            this.labelZakresOd.TabIndex = 0;
            this.labelZakresOd.Text = "Zakres od";
            // 
            // groupBoxOdgadnij
            // 
            this.groupBoxOdgadnij.Controls.Add(this.labelOcena);
            this.groupBoxOdgadnij.Controls.Add(this.buttonSprawdz);
            this.groupBoxOdgadnij.Controls.Add(this.labelPodajLiczbe);
            this.groupBoxOdgadnij.Controls.Add(this.textBoxPodajLiczbe);
            this.groupBoxOdgadnij.Location = new System.Drawing.Point(12, 42);
            this.groupBoxOdgadnij.Name = "groupBoxOdgadnij";
            this.groupBoxOdgadnij.Size = new System.Drawing.Size(312, 114);
            this.groupBoxOdgadnij.TabIndex = 2;
            this.groupBoxOdgadnij.TabStop = false;
            this.groupBoxOdgadnij.Text = "Odgadnij";
            this.groupBoxOdgadnij.Visible = false;
            // 
            // buttonSprawdz
            // 
            this.buttonSprawdz.Location = new System.Drawing.Point(231, 33);
            this.buttonSprawdz.Name = "buttonSprawdz";
            this.buttonSprawdz.Size = new System.Drawing.Size(75, 23);
            this.buttonSprawdz.TabIndex = 2;
            this.buttonSprawdz.Text = "Sprawdź!";
            this.buttonSprawdz.UseVisualStyleBackColor = true;
            this.buttonSprawdz.Click += new System.EventHandler(this.ButtonSprawdz_Click);
            // 
            // labelPodajLiczbe
            // 
            this.labelPodajLiczbe.AutoSize = true;
            this.labelPodajLiczbe.Location = new System.Drawing.Point(9, 36);
            this.labelPodajLiczbe.Name = "labelPodajLiczbe";
            this.labelPodajLiczbe.Size = new System.Drawing.Size(64, 13);
            this.labelPodajLiczbe.TabIndex = 1;
            this.labelPodajLiczbe.Text = "Podaj liczbę";
            // 
            // textBoxPodajLiczbe
            // 
            this.textBoxPodajLiczbe.Location = new System.Drawing.Point(110, 33);
            this.textBoxPodajLiczbe.Name = "textBoxPodajLiczbe";
            this.textBoxPodajLiczbe.Size = new System.Drawing.Size(100, 20);
            this.textBoxPodajLiczbe.TabIndex = 0;
            // 
            // labelOcena
            // 
            this.labelOcena.AutoSize = true;
            this.labelOcena.Location = new System.Drawing.Point(107, 68);
            this.labelOcena.Name = "labelOcena";
            this.labelOcena.Size = new System.Drawing.Size(39, 13);
            this.labelOcena.TabIndex = 3;
            this.labelOcena.Text = "Ocena";
            this.labelOcena.Visible = false;
            // 
            // buttonHistoria
            // 
            this.buttonHistoria.Location = new System.Drawing.Point(250, 12);
            this.buttonHistoria.Name = "buttonHistoria";
            this.buttonHistoria.Size = new System.Drawing.Size(75, 23);
            this.buttonHistoria.TabIndex = 3;
            this.buttonHistoria.Text = "Historia";
            this.buttonHistoria.UseVisualStyleBackColor = true;
            this.buttonHistoria.Click += new System.EventHandler(this.ButtonHistoria_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(9, 364);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 5;
            this.labelError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 386);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonHistoria);
            this.Controls.Add(this.groupBoxOdgadnij);
            this.Controls.Add(this.groupBoxLosowanie);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Za dużo, za mało";
            this.groupBoxLosowanie.ResumeLayout(false);
            this.groupBoxLosowanie.PerformLayout();
            this.groupBoxOdgadnij.ResumeLayout(false);
            this.groupBoxOdgadnij.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBoxLosowanie;
        private System.Windows.Forms.Button buttonWylosuj;
        private System.Windows.Forms.Label labelZakresDo;
        private System.Windows.Forms.Label labelZakresOd;
        private System.Windows.Forms.TextBox textBoxZakresDo;
        private System.Windows.Forms.TextBox textBoxZakresOd;
        private System.Windows.Forms.GroupBox groupBoxOdgadnij;
        private System.Windows.Forms.Button buttonSprawdz;
        private System.Windows.Forms.Label labelPodajLiczbe;
        private System.Windows.Forms.TextBox textBoxPodajLiczbe;
        private System.Windows.Forms.Label labelOcena;
        private System.Windows.Forms.Button buttonHistoria;
        private System.Windows.Forms.Label labelError;
    }
}

