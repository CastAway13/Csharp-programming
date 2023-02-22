using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
namespace Assignment7_2

{
    class JSONSerializer
    {
        string filePath;
        public JSONSerializer(string filePath)
        {
            this.filePath = filePath;
        }
        public string WriteToJSONFileHotel(Hotel hotel)
        {
            //Here we define settings for the JSON serializer
            var serializingSettings = new DataContractJsonSerializerSettings();
            serializingSettings.UseSimpleDictionaryFormat = true;
            serializingSettings.MaxItemsInObjectGraph = 1000;
            
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Hotel), serializingSettings);
            
            FileStream fileWriter = new FileStream(filePath, FileMode.Create);
            
            jsonSerializer.WriteObject(fileWriter, hotel);
            fileWriter.Close();
            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists)
                return fileInfo.FullName + " exists? " + fileInfo.Exists + ". Current length: " + fileInfo.Length;
            return filePath + " does not exist!";

        }

        public string WriteToJSONFileRoom(List<Room> room)
        {
            //Here we define settings for the JSON serializer
            var serializingSettings = new DataContractJsonSerializerSettings();
            serializingSettings.UseSimpleDictionaryFormat = true;
            serializingSettings.MaxItemsInObjectGraph = 1000;

            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Room>), serializingSettings);

            FileStream fileWriter = new FileStream(filePath, FileMode.Create);

            jsonSerializer.WriteObject(fileWriter, room);
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

        public Hotel ReadHotelFromJSONFile()
        {
            //Here we read JSON data as text and display it on the screen.
            StreamReader reader = new StreamReader(filePath);
            string jsonData = reader.ReadToEnd();

            reader.Close();

            //Here we create a JavaScript serializer.
            
            System.Web.Script.Serialization.JavaScriptSerializer jsSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            //Here we deserialize JSON data, which was read as text from the file.
            
            return JsonConvert.DeserializeObject<Hotel>(jsonData);
        }

        public List<Room> ReadRoomFromJSONFile()
        {
            //Here we read JSON data as text and display it on the screen.
            StreamReader reader = new StreamReader(filePath);
            string jsonData = reader.ReadToEnd();

            reader.Close();

            //Here we create a JavaScript serializer.

            System.Web.Script.Serialization.JavaScriptSerializer jsSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            //Here we deserialize JSON data, which was read as text from the file.

            return JsonConvert.DeserializeObject<List<Room>>(jsonData);
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