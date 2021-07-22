using ParcelsManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ParcelsManagementSystem.Utilities
{
    /// <summary>
    /// Read the XML file
    /// </summary>
    public static class ReadXML
    {
        /// <summary>
        /// Parse the XML and Read Data
        /// </summary>
        /// <param name="sPath"></param>
        /// <returns></returns>
        public static Container ReadXMLToModel(string sPath)
        {
            Container container;

            using (TextReader textReader = new StreamReader(sPath))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(Container));
                container = (Container)deserializer.Deserialize(textReader);
                textReader.Close();
            }

            return container;
        }
    }
}
