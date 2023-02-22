//This is ProductHandler.cs file
using System;
using System.IO;
using System.Text;
namespace Example_35
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
                //Here we declare the binary writer and reader objects
                //Here we initialize binaryWriter object.
                BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filePath, FileMode.Append));
                binaryWriter.Write(name);
                binaryWriter.Write(amount);
                binaryWriter.Write(price);
                binaryWriter.Close();
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
            string name;
            int amount;
            double price;
            int counter = 0;
            bool found = false;
            //Here we declare the binary writer and reader objects
            BinaryReader binaryReader = null;
            StringBuilder result = new StringBuilder();
            //Here we open the file for reading.
            try
            {
                binaryReader = new BinaryReader(new FileStream(filePath, FileMode.Open));

                //This is an infinite for loop-
                for (; ; )
                {
                    //Here we read an inventory entry.
                    name = binaryReader.ReadString();
                    amount = binaryReader.ReadInt32();
                    price = binaryReader.ReadDouble();
                    /*Here we check whether the item name matches the one requested.
                    If so, we save the information*/
                    if (name.Equals(productName))
                    {
                        found = true;
                        result.Append(++counter + ". ");
                        result.Append(string.Format(amount + " " + name + " items. " + "Price: {0:} $  eachch" + Environment.NewLine, price));
                        result.Append(string.Format("Total value of {0}: {1} $." + Environment.NewLine, name, (price * amount)));
                        //We could also break the loop after finding the first entry with given name
                        // break;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                result.Append(filePath + " not found!");

            }
            catch (EndOfStreamException)
            {
                if (!found)
                    result.Append(productName + " was not found!");
            }
            catch (IOException)
            {
                result.Append("Error reading " + filePath);
            }
            finally
            {
                binaryReader.Close();
            }
            return result.ToString();
        }
    }
}