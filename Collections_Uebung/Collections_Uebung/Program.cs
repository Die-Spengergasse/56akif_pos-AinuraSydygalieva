using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace ExCollection.App
{

    public class Program
    {
       public static void Main(string[] args)
        {
            Dictionary<string, Klasse> klassen = new Dictionary<string, Klasse>();
            klassen.Add("3AHIF", new Klasse() { Name = "3AHIF", KV = "KV1" });
            klassen.Add("3BHIF", new Klasse() { Name = "3BHIF", KV = "KV2" });
            klassen.Add("3CHIF", new Klasse() { Name = "3CHIF", KV = "KV3" });
            klassen["3AHIF"].AddSchueler(new Students() { Id = 1001, Vorname = "VN1", Zuname = "ZN1" });
            klassen["3AHIF"].AddSchueler(new Students() { Id = 1002, Vorname = "VN2", Zuname = "ZN2" });
            klassen["3AHIF"].AddSchueler(new Students() { Id = 1003, Vorname = "VN3", Zuname = "ZN3" });
            klassen["3BHIF"].AddSchueler(new Students() { Id = 1011, Vorname = "VN4", Zuname = "ZN4" });
            klassen["3BHIF"].AddSchueler(new Students() { Id = 1012, Vorname = "VN5", Zuname = "ZN5" });
            klassen["3BHIF"].AddSchueler(new Students() { Id = 1013, Vorname = "VN6", Zuname = "ZN6" });

            Students s = klassen["3AHIF"].Schuelers[0];
            Console.WriteLine($"s sitzt in der Klasse {s.KlasseNavigation.Name} mit dem KV {s.KlasseNavigation.KV}.");
            Console.WriteLine("3AHIF vor ChangeKlasse:");
            Console.WriteLine(JsonConvert.SerializeObject(klassen["3AHIF"].Schuelers));
            s.ChangeKlasse(klassen["3BHIF"]);
            Console.WriteLine("3AHIF nach ChangeKlasse:");
            Console.WriteLine(JsonConvert.SerializeObject(klassen["3AHIF"].Schuelers));
            Console.WriteLine("3BHIF nach ChangeKlasse:");
            Console.WriteLine(JsonConvert.SerializeObject(klassen["3BHIF"].Schuelers));
            Console.WriteLine($"s sitzt in der Klasse {s.KlasseNavigation.Name} mit dem KV {s.KlasseNavigation.KV}.");
        }
    }
}
