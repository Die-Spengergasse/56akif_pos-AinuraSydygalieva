using Newtonsoft.Json;

namespace ExCollection.App
{
    public class Students
    {
        // TODO: Erstelle ein Proeprty KlasseNavigation vom Typ Klasse, welches auf
        //       die Klasse des Schülers zeigt.
        // Füge dann über das Proeprty die Zeile
        // ein, damit der JSON Serializer das Objekt ausgeben kann.
        [JsonIgnore]
        public Klasse KlasseNavigation { get; set; } = new();
        public int Id { get; set; }
        public string Zuname { get; set; } = string.Empty;
        public string Vorname { get; set; } = string.Empty;
        /// <summary>
        /// Ändert die Klassenzugehörigkeit, indem der Schüler
        /// aus der alten Klasse, die in KlasseNavigation gespeichert ist, entfernt wird.
        /// Danach wird der Schüler in die neue Klasse mit der korrekten Navigation eingefügt.
        /// </summary>
        /// <param name="k"></param>
        
        public void ChangeKlasse(Klasse k)
        {
            KlasseNavigation.Schuelers.Remove(this);// aus der alten KlassenNav löschen
            
            k.Schuelers.Add(this);                  //dem Schüler sagen, dass er jz in dieser Klasse ist
            KlasseNavigation = k;                   //Klassennavi auf die neue Klasse
            
            
            
        }
    }
}
