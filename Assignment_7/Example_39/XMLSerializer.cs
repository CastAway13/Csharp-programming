//This is XMLSerializer.cs file
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Example_39
{
    class XMLSerializer
    {
        string filePath;
        public XMLSerializer(string filePath)
        {
            this.filePath = filePath;
        }


        //This generic method serializes (writes) the object of generic data type to the file.
        public string WriteXML<T>(T type)
        {
            StringBuilder feedback = new StringBuilder();
            feedback.AppendLine("Provided data is invalid!");

            if (type == null)
                return feedback.ToString();



            //Here we define an XmlSerializer object
            XmlSerializer xmlSerializer = new XmlSerializer(type.GetType());

            //Here we define an XmlWriter object and define settings for it.
            XmlWriter xmlWriter = XmlWriter.Create(filePath,
                                          new XmlWriterSettings()
                                          {
                                              OmitXmlDeclaration = true,

                                              //ConformanceLevel specifies the level of conformance
                                              //(document, fragment, or automatic detection).
                                              //The default is Document.
                                              ConformanceLevel = ConformanceLevel.Auto,
                                              Indent = true

                                          });


            //Here we serialize data to the file
            xmlSerializer.Serialize(xmlWriter, type);

            //Here we clos ehe stream
            xmlWriter.Close();

            FileInfo fileInfo = new FileInfo(filePath);

            if (fileInfo.Exists)
            {
                feedback.Clear();
                feedback.AppendLine(fileInfo.FullName + " exists? " + fileInfo.Exists + ". Current length: " + fileInfo.Length);

            }

            return feedback.ToString();
        }


        //This generic method reeads and returns the content of the XML file
        //in a generic form
        public T ReadXML<T>()
        {

            //When the following technique is used, the stream will be automatically closed.
            using (var stream = System.IO.File.OpenRead(filePath))
            {
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(stream);
            }
        }

    }
}