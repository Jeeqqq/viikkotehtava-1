using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Portfolio
{
    [Serializable()]
    [XmlRoot("Palautteet")]
    public class Palauteet
    {
        public Palauteet()
        {
            palautteet = new List<PalauteForm>();

        }

        [XmlElement("palaute")]
        public List<PalauteForm> palautteet { get; set; }

    }
    [Serializable()]
    public class PalauteForm
    {
        [XmlElement("Pvm")]
        public string Pvm { get; set; }
        [XmlElement("Tekija")]
        public string Tekija { get; set; }
        [XmlElement("Opittu")]
        public string Opittu { get; set; }
        [XmlElement("HaluanOppia")]
        public string HaluanOppia { get; set; }
        [XmlElement("Hyvaa")]
        public string Hyvaa { get; set; }
        [XmlElement("Parannettavaa")]
        public string Parannettavaa { get; set; }
        [XmlElement("Muuta")]
        public string Muuta { get; set; }

        public PalauteForm()
        {

        }
    }
}