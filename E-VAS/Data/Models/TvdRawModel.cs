namespace E_VAS.Data.Models
{
    public class TvdRawModel
    {
        public string Ohrmarkennummer { get; set; }
        public string Name { get; set; }
        public string Geschlecht { get; set; }
        public string Geburtsdatum { get; set; }
        public int Alter { get; set; }
        public int? Geburtsbetrieb { get; set; }
        public string Rasse { get; set; }
        public string Labelmeldung { get; set; }
        public string Erstkalbung { get; set; }
        public string LetzteAbkalbung { get; set; }
        public string Nutzungsart { get; set; }
        public string Gltigab { get; set; }
        public string VorherigeNutzungsart { get; set; }
        public string Zugangsdatum { get; set; }
        public string Herkunftsbetrieb { get; set; }
        public string Abgangsdatum { get; set; }
        public string Folgebetrieb { get; set; }
        public string Tiergeschichte { get; set; }
        public string LetzteGanzjahrestierhaltung { get; set; }
        public string BVDStatus { get; set; }
        public string BLZ_Status { get; set; }
        public string Mutter_OM { get; set; }
        public string Mutter_Name { get; set; }
        public string Mutter_Rasse { get; set; }
        public string Vater_OM { get; set; }
        public string Vater_Name { get; set; }
        public string Vater_Rasse { get; set; }
        public string Todesdatum { get; set; }
    }
}