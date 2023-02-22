//This is ProductHandler.cs file
using System;
using System.IO;
using System.Text;
namespace Example_36
{
    class ProductHanlder
    {
        string filePath;

        public ProductHanlder(string filePath)
        {
            this.filePath = filePath;
        }
        public string WriteToFile(string name, int amount, double price)
        {
            StringBuilder result = new StringBuilder();
            try
            {
                //Here we define a StreamWriter object for appending text.
                TextWriter textWriter = new StreamWriter(filePath, append: true);
                textWriter.WriteLine(name + ";" + amount + ";" + price);
                textWriter.Close();
            }
            catch (FileNotFoundException)
            {
                result.Append(filePath + " not found!");
            }
            catch (IOException)
            {
                result.Append("Error writing to file: " + this.filePath);
            }

            FileInfo fileInfo = new FileInfo(filePath);

            if (fileInfo.Exists)
                result.Append(fileInfo.FullName + " exists? " + fileInfo.Exists + ". Current length: " + fileInfo.Length);
            return result.ToString();
        }
        public string ReadFromFile(string productName)
        {
            //Here we declare the binary writer and reader objects
            TextReader textReader = null;
            StringBuilder result = new StringBuilder();
            string item;
            bool itemFound = false;
            //Here we open the file for reading.
            try
            {
                textReader = new StreamReader(filePath);
                // Read an inventory entry.
                while ((item = textReader.ReadLine()) != null)
                {
                    //Here we define a set of delimiter characters
                    char[] delimiterChars = { ' ', ';' };
                    string[] info = item.Split(delimiterChars);

                    /* See if the item matches the one requested.
                    If so, display information */
                    if (info[0].Equals(productName))
                    {
                        result.Append(string.Format(info[0] + " " + info[1] + " items. " +
                        "Price: {0:C} each\n", double.Parse(info[2])));
                        result.Append(string.Format("Total value of {0}: {1:C}.\n",
                        info[0], Int16.Parse(info[1]) * double.Parse((info[2]))));
                        itemFound = true;
                    }
                }
                if (itemFound == false)
                    result.Append(productName + " was not found." + Environment.NewLine);
            }
            catch (FileNotFoundException)
            {
                result.Append(filePath + " not found!");

            }

            catch (IOException)
            {
                result.Append("Error reading " + filePath);
            }
            finally
            {
                textReader.Close();
            }
            return result.ToString();
        }
    }
}