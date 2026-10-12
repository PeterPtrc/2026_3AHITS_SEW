namespace Uebung_2_1_3AHITS;

class Schulklasse
{
    int anzahlSchueler;
    string klassenvorstand;

    public Schulklasse (int anzahlSchueler, string klassenvorstand)
    {
        this.anzahlSchueler = anzahlSchueler;
        this.klassenvorstand  = klassenvorstand;
    }

    public override string ToString()
    {
        return $"Schueler: {anzahlSchueler} \n KV: {klassenvorstand}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Schulklasse ahits = new Schulklasse(22, "Strasser");
        Console.WriteLine(ahits.ToString());
    }
}
