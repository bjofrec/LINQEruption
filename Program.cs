// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

Eruption primeraEruptionInChile = eruptions.FirstOrDefault(e => e.Location == "Chile");
Console.WriteLine($"{primeraEruptionInChile}");

Eruption PrimeraEruptionInHawai = eruptions.FirstOrDefault(erup => erup.Location == "Hawaiian Is");
Console.WriteLine($"{PrimeraEruptionInHawai}");

Eruption PrimeraEruptionNuevaZelanda = eruptions.FirstOrDefault(e => e.Location == "New Zealand" && e.Year > 1900);
Console.WriteLine($"{PrimeraEruptionNuevaZelanda}");

Console.WriteLine("------------------------------------");

IEnumerable<Eruption> EruptionVolcanAltura = eruptions.Where(elev => elev.ElevationInMeters > 2000);
PrintEach(EruptionVolcanAltura, "Mayor a 2000 m");

Console.WriteLine("------------------------------------");

IEnumerable<Eruption> EruptionNombreComienzaConL = eruptions.Where(e => e.Volcano.First() == 'L');
PrintEach(EruptionNombreComienzaConL, "Los Volcanes que empiezan con L son:");
Console.WriteLine("------------------------------------");

int ElevationHigh = eruptions.Max(e => e.ElevationInMeters);
Console.WriteLine($"Elevación más alta: {ElevationHigh}");
Console.WriteLine("------------------------------------");

string nombreVolcanElevacionMasAlta = eruptions.Where(e => e.ElevationInMeters == ElevationHigh).Select(e => e.Volcano).FirstOrDefault();
Console.WriteLine($"Volcan con elevacion mas alta: {nombreVolcanElevacionMasAlta}");
Console.WriteLine("------------------------------------");

IEnumerable<string> nombresDeVolcanesOrdenados = eruptions.Select(e => e.Volcano).OrderBy(nombre => nombre);
Console.WriteLine("Nombres de los volcanes en orden alfabético:");
    foreach (string nombreVolcan in nombresDeVolcanesOrdenados)
    {
        Console.WriteLine(nombreVolcan);
    }
Console.WriteLine("------------------------------------");

IEnumerable<Eruption> EruptionAntesDe1000 = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano);
PrintEach(EruptionAntesDe1000, "Volcanes en erupcion antes del año 1000"); 

Console.WriteLine("------------------------------------");

IEnumerable<string> nombresVolcanesAntesDe1000 = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano).Select(e => e.Volcano);
foreach (var nombreVolcan in nombresVolcanesAntesDe1000)
{
    Console.WriteLine(nombreVolcan);
}

 
// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}