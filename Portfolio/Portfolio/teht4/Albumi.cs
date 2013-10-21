using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Portfolio
{
    [Serializable()]
    [XmlRoot("Records")]
    public class Records
    {
        public Records()
        {
            genre = new Genre();

        }

        [XmlElement("genre")]
        public Genre genre { get; set; }

    }
    [Serializable()]
    public class Genre
    {
        [XmlAttribute("name")]
        public string name { get; set; }
        [XmlElement("record")]
        public List<Record> Records { get; set; }
        public Genre()
        {
            Records = new List<Record>();
        }
    }
    [Serializable()]
    public class Record
    {
        [XmlAttribute("ISBN")]
        public string ISBN { get; set; }
        [XmlAttribute("Artist")]
        public string Artist { get; set; }
        [XmlAttribute("Title")]
        public string Title { get; set; }
        [XmlAttribute("Price")]
        public Double Price { get; set; }
        [XmlElement("song")]
        public List<Song> Songs { get; set; }

        public string ArtistTitle
        {
            get
            {
                return Artist + " : " + Title;
            }
            set { ArtistTitle = value; }
        }
        public string Kuva
        {
            get
            {
                return  "Images/" + ISBN+".jpg";
            }
            set { Kuva = value; }
        }
        public Record()
        {
            Songs = new List<Song>();
        }
    }
    [Serializable()]
    public class Song
    {
        [XmlAttribute("num")]
        public int Num { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
        public Song()
        {
        }
    }
}