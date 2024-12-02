using System.Collections.Generic;

namespace ObsttaxiBox
{
    // Die Frucht-Klasse: Modelliert eine Frucht mit Name und Fruchtart
    public class Frucht
    {
        public string Name { get; set; }
        public string Fruchtart { get; set; }

        public Frucht(string name, string fruchtart)
        {
            Name = name;
            Fruchtart = fruchtart;
        }

        // Überschreibt die ToString-Methode, um die Frucht darzustellen
        public override string ToString()
        {
            return $"{Name} ({Fruchtart})";
        }
    }

    // Die FruechteBibliothek-Klasse: Stellt eine zentrale Liste der verfügbaren Früchte bereit
    public static class FruechteBibliothek
    {
        // Ein Dictionary mit vordefinierten Früchten
        public static Dictionary<string, Frucht> VerfügbareFrüchte = new Dictionary<string, Frucht>
        {
            { "Birne", new Frucht("Birne", "Kernobst") },
            { "Apfel", new Frucht("Apfel", "Kernobst") },
            { "Kirsche", new Frucht("Kirsche", "Steinobst") },
            { "Traube", new Frucht("Traube", "Beerenobst") }
        };
    }
}
