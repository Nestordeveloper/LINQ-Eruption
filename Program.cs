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

Eruption firstEruption = eruptions.First(f => f.Location == "Chile");

if (firstEruption != null)
{
    Console.WriteLine("# Primera erupción en Chile:");
    Console.WriteLine($"Nombre: {firstEruption.Volcano}");
    Console.WriteLine($"Año: {firstEruption.Year}");
    Console.WriteLine($"Ubicación: {firstEruption.Location}");
    Console.WriteLine($"Altitud: {firstEruption.ElevationInMeters}");
    Console.WriteLine($"Tipo: {firstEruption.Type}");
}
else
{
    Console.WriteLine("No se encontró ninguna erupción en Chile.");
}

Eruption hawaiiEruption = eruptions.First(h => h.Location == "Hawaiian Is");

if (hawaiiEruption != null)
{
    Console.WriteLine("# Primera erupción en Hawaii:");
    Console.WriteLine($"Nombre: {hawaiiEruption.Volcano}");
    Console.WriteLine($"Año: {hawaiiEruption.Year}");
    Console.WriteLine($"Ubicación: {hawaiiEruption.Location}");
    Console.WriteLine($"Altitud: {hawaiiEruption.ElevationInMeters}");
    Console.WriteLine($"Tipo: {hawaiiEruption.Type}");
}
else
{
    Console.WriteLine("No se encontró ninguna erupción en Hawaii.");
}

Eruption newZealandEruption = eruptions.First(e => e.Year > 1900 && e.Location == "New Zealand");

if (newZealandEruption != null)
{
    Console.WriteLine("# Primera erupción despues de 1900 en Nueva Zelanda:");
    Console.WriteLine($"Nombre: {newZealandEruption.Volcano}");
    Console.WriteLine($"Año: {newZealandEruption.Year}");
    Console.WriteLine($"Ubicación: {newZealandEruption.Location}");
    Console.WriteLine($"Altitud: {newZealandEruption.ElevationInMeters}");
    Console.WriteLine($"Tipo: {newZealandEruption.Type}");
}
else
{
    Console.WriteLine("No se encontró ninguna erupción en Nueva Zelanda después de 1900.");
}

IEnumerable<Eruption> elevationOver = eruptions.Where(o => o.ElevationInMeters > 2000);
PrintEach(elevationOver, "Volcanes con elevación superior a 2000 metros:");

IEnumerable<Eruption> volcanosL = eruptions.Where(l => l.Volcano.StartsWith("L"));
int countVolcanosL = volcanosL.Count();
Console.WriteLine($"Número de volcanes que comienzan con 'L': {countVolcanosL}");
PrintEach(volcanosL, "Volcanes que comienzan con L:");

int highestVolcano = eruptions.Max(hv => hv.ElevationInMeters);
Console.WriteLine($"El volcan más alto del mundo tiene: {highestVolcano} metros de altura.");
Eruption highVolcano = eruptions.First(e => e.ElevationInMeters == highestVolcano);
if (highVolcano != null)
{
    Console.WriteLine("# El volcan más alto del mundo:");
    Console.WriteLine($"Nombre: {highVolcano.Volcano}");
    Console.WriteLine($"Año: {highVolcano.Year}");
    Console.WriteLine($"Ubicación: {highVolcano.Location}");
    Console.WriteLine($"Altitud: {highVolcano.ElevationInMeters}");
    Console.WriteLine($"Tipo: {highVolcano.Type}");
}
else
{
    Console.WriteLine("No se encontro el volcan.");
}

IEnumerable<Eruption> alphaVolcano = eruptions.OrderBy(e => e.Volcano);
PrintEach(alphaVolcano, "Volcanes ordenados alfabeticamente.");

IEnumerable<Eruption> eruptionsBefore1000CE = alphaVolcano.Where(e => e.Year < 1000);
PrintEach(eruptionsBefore1000CE, "Volcanes que eupcionaron antes del 1000 CE, ordenados alfabeticamente.");

var volcanoNamesBefore1000CE = eruptions
    .Where(e => e.Year < 1000)
    .OrderBy(e => e.Volcano)
    .Select(e => e.Volcano);

PrintEach(volcanoNamesBefore1000CE, "Nombres de volcanes que hicieron erupción antes del 1000 CE, ordenados alfabéticamente.");

// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}