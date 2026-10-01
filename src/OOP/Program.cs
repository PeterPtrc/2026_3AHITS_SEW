// ------------------------------
// OOP
// ------------------------------

namespace OOP;

class Schule
{
   public string name; //member Variable
   public int anzahlSchueler;
   public int anzahlLehrer;

   public int AnzahlPersonen()
    {
        return anzahlLehrer + anzahlSchueler;
    }
}

class Program
{
    static void Main(string[] args)
    {   
        //HTL
        Schule htl = new Schule(); //Objekt erstellen (instanzieren)
        htl.name ="HTL Braunau"; //member Variable setzen
        htl.anzahlSchueler = 800;
        htl.anzahlLehrer = 100;

        Console.WriteLine($"Fully Personen: {htl.AnzahlPersonen()}");

        //HLW
        Schule hlw = new Schule();
        hlw.name = "HLW Braunau";
        hlw.anzahlSchueler = 600;
        hlw.anzahlLehrer = 80;
    }
}
