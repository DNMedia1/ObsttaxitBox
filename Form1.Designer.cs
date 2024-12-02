namespace ObsttaxiBox
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lbVerfuegbareFruechte;
        private System.Windows.Forms.TextBox tbFruchtEingabe;
        private System.Windows.Forms.ListBox lbAusgewaehlteFruechte;
        private System.Windows.Forms.Button btnFuegeFruchtHinzu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbVerfuegbareFruechte = new Label();
            tbFruchtEingabe = new TextBox();
            lbAusgewaehlteFruechte = new ListBox();
            btnFuegeFruchtHinzu = new Button();
            SuspendLayout();
            // 
            // lbVerfuegbareFruechte
            // 
            lbVerfuegbareFruechte.AutoSize = true;
            lbVerfuegbareFruechte.Location = new Point(13, 50);
            lbVerfuegbareFruechte.Name = "lbVerfuegbareFruechte";
            lbVerfuegbareFruechte.Size = new Size(110, 15);
            lbVerfuegbareFruechte.TabIndex = 0;
            lbVerfuegbareFruechte.Text = "Verfügbare Früchte:";
            // 
            // tbFruchtEingabe
            // 
            tbFruchtEingabe.Location = new Point(16, 12);
            tbFruchtEingabe.Name = "tbFruchtEingabe";
            tbFruchtEingabe.Size = new Size(156, 23);
            tbFruchtEingabe.TabIndex = 1;
            // 
            // lbAusgewaehlteFruechte
            // 
            lbAusgewaehlteFruechte.FormattingEnabled = true;
            lbAusgewaehlteFruechte.ItemHeight = 15;
            lbAusgewaehlteFruechte.Location = new Point(13, 84);
            lbAusgewaehlteFruechte.Name = "lbAusgewaehlteFruechte";
            lbAusgewaehlteFruechte.Size = new Size(257, 94);
            lbAusgewaehlteFruechte.TabIndex = 2;
            // 
            // btnFuegeFruchtHinzu
            // 
            btnFuegeFruchtHinzu.Location = new Point(178, 10);
            btnFuegeFruchtHinzu.Name = "btnFuegeFruchtHinzu";
            btnFuegeFruchtHinzu.Size = new Size(92, 23);
            btnFuegeFruchtHinzu.TabIndex = 3;
            btnFuegeFruchtHinzu.Text = "Hinzufügen";
            btnFuegeFruchtHinzu.UseVisualStyleBackColor = true;
            btnFuegeFruchtHinzu.Click += btnFuegeFruchtHinzu_Click;
            // 
            // Form1
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(272, 286);
            Controls.Add(btnFuegeFruchtHinzu);
            Controls.Add(lbAusgewaehlteFruechte);
            Controls.Add(tbFruchtEingabe);
            Controls.Add(lbVerfuegbareFruechte);
            Name = "Form1";
            Text = "ObsttaxiBox";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
