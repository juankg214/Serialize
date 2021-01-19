using Microsoft.Win32.SafeHandles;
using System;
using System.IO;
using System.Xml.Serialization;

namespace SerializeXML
{
    class Program
    {

        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(XMLObjectModel));
            XMLObjectModel xmlObject;

            using (var sr = new StreamReader("test.xml"))
            {
                xmlObject = (XMLObjectModel)serializer.Deserialize(sr);
            }

            Console.WriteLine(xmlObject.Beneficiarios[0].PrimerApellido);

           
        }
    }
}
