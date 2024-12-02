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
            UpdateVerfügbareFrüchteLabel();
        }

        // Aktualisiert das Label mit den verfügbaren Früchten
        private void UpdateVerfügbareFrüchteLabel()
        {
            lbVerfuegbareFruechte.Text = "Verfügbare Früchte:\n" +
                string.Join("\n", FruechteBibliothek.VerfügbareFrüchte.Keys);
        }

        // Eventhandler: Wird ausgeführt, wenn der Button geklickt wird
        private void btnFuegeFruchtHinzu_Click(object sender, EventArgs e)
        {
            string eingabe = tbFruchtEingabe.Text.Trim(); // Eingabe aus TextBox holen

            // Eingabe validieren
            if (string.IsNullOrWhiteSpace(eingabe))
            {
                MessageBox.Show("Bitte geben Sie eine Frucht ein.", "Eingabe erforderlich", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Überprüfen, ob die Frucht verfügbar ist
            if (!FruechteBibliothek.VerfügbareFrüchte.ContainsKey(eingabe))
            {
                MessageBox.Show("Die eingegebene Frucht ist nicht verfügbar.", "Ungültige Frucht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Abrufen der Frucht aus der Bibliothek
            Frucht ausgewählteFrucht = FruechteBibliothek.VerfügbareFrüchte[eingabe];

            // Prüfen, ob die Frucht bereits in der ListBox ist
            if (lbAusgewaehlteFruechte.Items.Cast<Frucht>().Any(frucht => frucht.Name == ausgewählteFrucht.Name))
            {
                MessageBox.Show("Diese Frucht wurde bereits hinzugefügt.", "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Frucht hinzufügen
            lbAusgewaehlteFruechte.Items.Add(ausgewählteFrucht);

            // TextBox leeren
            tbFruchtEingabe.Clear();
        }
    }
}
