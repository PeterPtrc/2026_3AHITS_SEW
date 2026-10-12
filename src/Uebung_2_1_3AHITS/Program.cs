namespace Uebung_2_1_3AHITS;

class Schulklasse
{
    int anzahlSchueler;
    string klassenvorstand;

    public Schulklasse() : this(22, "Strasser")
    {
    }

    public Schulklasse(int anzahlSchueler, string klassenvorstand)
    {
        this.anzahlSchueler = anzahlSchueler;
        this.klassenvorstand = klassenvorstand;
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
        Schulklasse ahits = new Schulklasse();
        Console.WriteLine(ahits.ToString());
    }
}
