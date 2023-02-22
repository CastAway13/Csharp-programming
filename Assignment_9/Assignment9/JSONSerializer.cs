using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Assignment9
{
    class JSONSerializer
    {
        string filePath;
        public JSONSerializer(string filePath)
        {
            this.filePath = filePath;
        }
        public string WriteToJSONFileFlight(List<Flight> flight)
        {
            //Here we define settings for the JSON serializer
            var serializingSettings = new DataContractJsonSerializerSettings();
            serializingSettings.UseSimpleDictionaryFormat = true;
            serializingSettings.MaxItemsInObjectGraph = 1000;

            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Flight>), serializingSettings);

            FileStream fileWriter = new FileStream(filePath, FileMode.Create);

            jsonSerializer.WriteObject(fileWriter, flight);
            fileWriter.Close();
            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists)
                return fileInfo.FullName + " exists? " + fileInfo.Exists + ". Current length: " + fileInfo.Length;
            return filePath + " does not exist!";
        }
        public string WriteToJSONFileCustomer(List<Customer> customer)
        {
            //Here we define settings for the JSON serializer
            var serializingSettings = new DataContractJsonSerializerSettings();
            serializingSettings.UseSimpleDictionaryFormat = true;
            serializingSettings.MaxItemsInObjectGraph = 1000;

            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Customer>), serializingSettings);

            FileStream fileWriter = new FileStream(filePath, FileMode.Create);

            jsonSerializer.WriteObject(fileWriter, customer);
            fileWriter.Close();
            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists)
                return fileInfo.FullName + " exists? " + fileInfo.Exists + ". Current length: " + fileInfo.Length;
            return filePath + " does not exist!";
        }
        public List<Flight> ReadFlightFromJSONFile()
        {
            //Here we read JSON data as text and display it on the screen.
            StreamReader reader = new StreamReader(filePath);
            string jsonData = reader.ReadToEnd();

            reader.Close();

            //Here we create a JavaScript serializer.

            System.Web.Script.Serialization.JavaScriptSerializer jsSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            //Here we deserialize JSON data, which was read as text from the file.

            return JsonConvert.DeserializeObject<List<Flight>>(jsonData);
        }
        public List<Customer> ReadCustomerFromJSONFile()
        {
            //Here we read JSON data as text and display it on the screen.
            StreamReader reader = new StreamReader(filePath);
            string jsonData = reader.ReadToEnd();

            reader.Close();

            //Here we create a JavaScript serializer.

            System.Web.Script.Serialization.JavaScriptSerializer jsSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            //Here we deserialize JSON data, which was read as text from the file.

            return JsonConvert.DeserializeObject<List<Customer>>(jsonData);
        }
    }
}
