using System;
using System.Linq;
using System.Windows.Forms;

namespace ObsttaxiBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateVerf�gbareFr�chteLabel();
        }

        // Aktualisiert das Label mit den verf�gbaren Fr�chten
        private void UpdateVerf�gbareFr�chteLabel()
        {
            lbVerfuegbareFruechte.Text = "Verf�gbare Fr�chte:\n" +
                string.Join("\n", FruechteBibliothek.Verf�gbareFr�chte.Keys);
        }

        // Eventhandler: Wird ausgef�hrt, wenn der Button geklickt wird
        private void btnFuegeFruchtHinzu_Click(object sender, EventArgs e)
        {
            string eingabe = tbFruchtEingabe.Text.Trim(); // Eingabe aus TextBox holen

            // Eingabe validieren
            if (string.IsNullOrWhiteSpace(eingabe))
            {
                MessageBox.Show("Bitte geben Sie eine Frucht ein.", "Eingabe erforderlich", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // �berpr�fen, ob die Frucht verf�gbar ist
            if (!FruechteBibliothek.Verf�gbareFr�chte.ContainsKey(eingabe))
            {
                MessageBox.Show("Die eingegebene Frucht ist nicht verf�gbar.", "Ung�ltige Frucht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Abrufen der Frucht aus der Bibliothek
            Frucht ausgew�hlteFrucht = FruechteBibliothek.Verf�gbareFr�chte[eingabe];

            // Pr�fen, ob die Frucht bereits in der ListBox ist
            if (lbAusgewaehlteFruechte.Items.Cast<Frucht>().Any(frucht => frucht.Name == ausgew�hlteFrucht.Name))
            {
                MessageBox.Show("Diese Frucht wurde bereits hinzugef�gt.", "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Frucht hinzuf�gen
            lbAusgewaehlteFruechte.Items.Add(ausgew�hlteFrucht);

            // TextBox leeren
            tbFruchtEingabe.Clear();
        }
    }
}
