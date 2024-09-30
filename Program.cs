using CA24093002;
using System.Text;

Random rnd = new();
List<Recipe> cookbook = [];

using StreamReader sr = new(
    path: @"..\..\..\src\szakacskonyvCLI_adatok.csv",
    encoding: Encoding.UTF8);
while (!sr.EndOfStream) cookbook.Add(new(sr.ReadLine()));

Console.WriteLine($"3. feladat: Az állományban {cookbook.Count} recept szerepel.");

var f4 = cookbook.Count(r => r.PrepTime < 65);
Console.WriteLine($"4. feladat: a receptek között {f4} " +
    $"darab 65 percnél rövidebb elkészítési idejű recept van.");

var f5 = cookbook.GroupBy(r => r.Type);
Console.WriteLine("5. feladat: receptek száma ételfajtánként:");
foreach (var foodTypesGroup in f5)
{
    Console.WriteLine($"\t{foodTypesGroup.Key}: {foodTypesGroup.Count()} db");
}

var f6 = cookbook
    .Where(r => r.Difficulity == "könnyű")
    .ToList();
Console.WriteLine("6. feladat: az egyik könnyen elkészíthető étel: " +
    $"{f6[rnd.Next(f6.Count)]}");