using System;
using System.IO;    //  for StringWriter
using System.Xml;

namespace Sagssystem
{
    [Serializable]      // required for serialization.
    public class Projekt
    {
        private int _ID;
        public string RegistreretAf;
        public object Status;
        public string Tester;
        public string Afventer;
        private DateTime registreringsDatoTid;
        public string Ansvarlig;
        public string Kontakt;
        public string Ressource;
        public string BeskrivelseKort;
        public string BeskrivelseLang;

        public Projekt()
        {
            _ID = 0;
            registreringsDatoTid = DateTime.Now;
            RegistreretAf = "";
            Status = "Oprettet";
            Tester = "";
            Afventer = "";
            Ansvarlig = "";
            Kontakt = "";
            Ressource = "";
            BeskrivelseKort = "";
            BeskrivelseLang = "";
        }

        public Projekt(int nyID)
        {
            _ID = nyID;
            registreringsDatoTid = DateTime.Now;
            RegistreretAf = "";
            Status = "Oprettet";
            Tester = "";
            Afventer = "";
            Ansvarlig = "";
            Kontakt = "";
            Ressource = "";
            BeskrivelseKort = "";
            BeskrivelseLang = "";
        }

        public int ID
        {
            get { return _ID; }
        }

        public DateTime RegistreringsDatoTid
        {
            get { return registreringsDatoTid; }
        }

        public string ToXML()
        {
            StringWriter stream = new StringWriter();

            using (XmlWriter writer = XmlWriter.Create(stream, new XmlWriterSettings() { Indent = true }))
            {
                writer.WriteStartElement("Projekt");
                writer.WriteAttributeString("ID", _ID.ToString());
                writer.WriteElementString("RegistreretAf", RegistreretAf);
                writer.WriteElementString("status", Status.ToString()); 
                writer.WriteElementString("Tester", Tester);
                writer.WriteElementString("Afventer", Afventer);
                writer.WriteElementString("registreringsDatoTid", registreringsDatoTid.ToString());
                writer.WriteElementString("Ansvarlig", Ansvarlig);
                writer.WriteElementString("Kontakt", Kontakt);
                writer.WriteElementString("Ressource", Ressource);
                writer.WriteElementString("BeskrivelseKort", BeskrivelseKort);
                writer.WriteElementString("BeskrivelseLang", BeskrivelseLang);
                writer.WriteEndElement();
                writer.Flush();
            }

            return stream.ToString();
        }
    }
}
