using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace Portfolio
{
    public class Serialisointi
    {
        #region XmlTiedostoMetodit
        public static void SerialisoiXml(string tiedosto, Palauteet ic)
        {
            XmlSerializer xs = new XmlSerializer(ic.GetType());
            TextWriter tw = new StreamWriter(tiedosto);
            try
            {
                xs.Serialize(tw, ic);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                tw.Close();
            }
        }
        public static void DeSerialisoiXml(string filePath, ref AutoLista leffat)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(AutoLista));
            try
            {

                FileStream xmlFile = new FileStream(filePath, FileMode.Open);
                leffat = (AutoLista)deserializer.Deserialize(xmlFile);
                xmlFile.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }

        }
        public static void DeSerialisoiXml(string filePath, ref Records records)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Records));
            try
            {

                FileStream xmlFile = new FileStream(filePath, FileMode.Open);
                records = (Records)deserializer.Deserialize(xmlFile);
                xmlFile.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }
        public static void DeSerialisoiXml(string filePath, ref Palauteet palautteet)
        {

            XmlSerializer deserializer = new XmlSerializer(typeof(Palauteet));
            try
            {

                FileStream xmlFile = new FileStream(filePath, FileMode.Open);
                palautteet = (Palauteet)deserializer.Deserialize(xmlFile);
                xmlFile.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }
        #endregion
    }
}