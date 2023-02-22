using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Hotel
    {
        protected string name;
        protected string constructionDate;
        protected string address;
        protected int staff;
        protected ArrayList rooms;
        protected ArrayList customers;

        public Hotel(string name, string constructionDate, string address, int staff, ArrayList rooms, ArrayList customers)
        {
            this.name = name;
            this.constructionDate = constructionDate;
            this.address = address;
            this.staff = staff;
            this.rooms = rooms;
            this.customers = customers;
        }
        public override string ToString()
        {
            string result = "";
            result = "\tHotel: " + this.name + " \n\tDay of Construction: " + this.constructionDate + "\n\tAddress: " + this.address +
                                            "\n\tNumber of staff: " + this.staff + Environment.NewLine;
            return result;
        }
        public string FindHotel(string searchName)
        {
            if (searchName.Equals(this.name)) return this.ToString();
            return "";
        }
        public void WriteToFileHotel(string filePath)
        {
            StringBuilder result = new StringBuilder();
            try
            {
                //Here we define a StreamWriter object for appending text.
                TextWriter textWriter = new StreamWriter(filePath, append: true);
                textWriter.WriteLine(this.name + ";" + this.constructionDate + ";" + this.address + ";" + this.staff);
                textWriter.Close();
            }
            catch (FileNotFoundException)
            {
                result.Append(filePath + " not found!");
            }
            catch (IOException)
            {
                result.Append("Error writing to file: " + filePath);
            }

            FileInfo fileInfo = new FileInfo(filePath);

            if (fileInfo.Exists)
                result.Append(fileInfo.FullName + " exists? " + fileInfo.Exists + ". Current length: " + fileInfo.Length);
            Console.WriteLine(result);
        }

        public void WriteToFileRoom(string filePath)
        {
            StringBuilder result = new StringBuilder();
            try
            {
                //Here we define a StreamWriter object for appending text.
                TextWriter textWriter = new StreamWriter(filePath, append: true);
                foreach (Room room in rooms)
                {
                    textWriter.WriteLine(room.RoomNumber + ";" + room.Area + ";" + room.Type + ";" + room.PricePerNight + ";" + room.Description);
                }
                textWriter.Close();
            }
            catch (FileNotFoundException)
            {
                result.Append(filePath + " not found!");
            }
            catch (IOException)
            {
                result.Append("Error writing to file: " + filePath);
            }

            FileInfo fileInfo = new FileInfo(filePath);

            if (fileInfo.Exists)
                result.Append(fileInfo.FullName + " exists? " + fileInfo.Exists + ". Current length: " + fileInfo.Length);
            Console.WriteLine(result);
        }

        public void WriteToFileCustomer(string filePath)
        {
            StringBuilder result = new StringBuilder();
            try
            {
                //Here we define a StreamWriter object for appending text.
                TextWriter textWriter = new StreamWriter(filePath, append: true);
                foreach (Customer customer in customers)
                {
                    textWriter.WriteLine(customer.Name + ";" + customer.RoomNumber + ";" + customer.ArrivalDate + ";" + customer.LengthOfStay);
                }
                textWriter.Close();
            }
            catch (FileNotFoundException)
            {
                result.Append(filePath + " not found!");
            }
            catch (IOException)
            {
                result.Append("Error writing to file: " + filePath);
            }

            FileInfo fileInfo = new FileInfo(filePath);

            if (fileInfo.Exists)
                result.Append(fileInfo.FullName + " exists? " + fileInfo.Exists + ". Current length: " + fileInfo.Length);
            Console.WriteLine(result);
        }

        public string ReadFromFileHotel(string filePath)
        {
            //Here we declare the binary writer and reader objects
            TextReader textReader = null;
            StringBuilder result = new StringBuilder();
            string item;
            //Here we open the file for reading.
            try
            {
                textReader = new StreamReader(filePath);
                // Read an inventory entry.
                while ((item = textReader.ReadLine()) != null)
                {
                    //Here we define a set of delimiter characters
                    char[] delimiterChars = {';'};
                    string[] info = item.Split(delimiterChars);

                    result.Append(string.Format("\n\tHotel: " + info[0] + "\n\tDay of construction: " + info[1] + 
                                                "\n\tAddress: " + info[2] + "\n\tNumber of staff: " + info[3] + Environment.NewLine));      
                }
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

        public string ReadFromFileRoom(string filePath)
        {
            //Here we declare the binary writer and reader objects
            TextReader textReader = null;
            StringBuilder result = new StringBuilder();
            string item;
            //Here we open the file for reading.
            try
            {
                textReader = new StreamReader(filePath);
                // Read an inventory entry.
                while ((item = textReader.ReadLine()) != null)
                {
                    //Here we define a set of delimiter characters
                    char[] delimiterChars = { ';' };
                    string[] info = item.Split(delimiterChars);

                    result.Append(string.Format("\n\tRoom number: " + info[0] + "\n\tArea: " + info[1] + "\n\tRoom type: " + info[2] + 
                                                "\n\tPrice per night: " + info[3] + "\n\tAddtion information: " + info[4] + Environment.NewLine));
                }
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

        public string ReadFromFileCustomer(string filePath)
        {
            //Here we declare the binary writer and reader objects
            TextReader textReader = null;
            StringBuilder result = new StringBuilder();
            string item;
            //Here we open the file for reading.
            try
            {
                textReader = new StreamReader(filePath);
                // Read an inventory entry.
                while ((item = textReader.ReadLine()) != null)
                {
                    //Here we define a set of delimiter characters
                    char[] delimiterChars = { ';' };
                    string[] info = item.Split(delimiterChars);

                    result.Append(string.Format("\n\tCustomer's name: " + info[0] + "\n\tCustomer's room: " + info[1] + 
                                                "\n\tArrival date: " + info[2] + "\n\tLength of stay: " + info[3] + " days" + Environment.NewLine));
                }
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
