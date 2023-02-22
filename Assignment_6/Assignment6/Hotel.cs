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
                //Here we declare the binary writer and reader objects
                //Here we initialize binaryWriter object.
                BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filePath, FileMode.Append));
                binaryWriter.Write(this.name);
                binaryWriter.Write(this.constructionDate);
                binaryWriter.Write(this.address);
                binaryWriter.Write(this.staff);
                binaryWriter.Close();
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
                //Here we declare the binary writer and reader objects
                //Here we initialize binaryWriter object.
                BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filePath, FileMode.Append));
                
                foreach (Room room in rooms)
                {
                    binaryWriter.Write(room.RoomNumber);
                    binaryWriter.Write(room.Area);
                    binaryWriter.Write(room.Type);
                    binaryWriter.Write(room.PricePerNight);
                    binaryWriter.Write(room.Description);
                }
                binaryWriter.Close();
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
                //Here we declare the binary writer and reader objects
                //Here we initialize binaryWriter object.
                BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filePath, FileMode.Append));

                foreach (Customer customer in customers)
                {
                    binaryWriter.Write(customer.Name);
                    binaryWriter.Write(customer.RoomNumber);
                    binaryWriter.Write(customer.ArrivalDate);
                    binaryWriter.Write(customer.LengthOfStay);
                }
                binaryWriter.Close();
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
        public string ReadFromFileCustomer(string filePath)
        {
            string customerName;
            string customerRoomNumber;
            string arrivalDate;
            int lengthOfStay;

        //Here we declare the binary writer and reader objects
            BinaryReader binaryReader = null;
            StringBuilder result = new StringBuilder();
            //Here we open the file for reading.
            try
            {
                binaryReader = new BinaryReader(new FileStream(filePath, FileMode.Open));
                foreach (Customer customer in customers)
                {
                    customerName = binaryReader.ReadString();
                    customerRoomNumber = binaryReader.ReadString();
                    arrivalDate = binaryReader.ReadString();
                    lengthOfStay = binaryReader.ReadInt32();
                    result.Append(string.Format("\n\tCustomer's name: " + customerName + "\n\tCustomer's Room: " + customerRoomNumber + 
                                                "\n\tArrival date: " + arrivalDate + "\n\tLength of stay: " + lengthOfStay + " days" + Environment.NewLine));
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
                binaryReader.Close();
            }
            return result.ToString();
        }

        public string ReadFromFileRoom(string filePath)
        {
            string roomNumber;
            string area;
            string type;
            double pricePerNight;
            string description;
            //Here we declare the binary writer and reader objects
            BinaryReader binaryReader = null;
            StringBuilder result = new StringBuilder();
            //Here we open the file for reading.
            try
            {
                binaryReader = new BinaryReader(new FileStream(filePath, FileMode.Open));
                //Here we read an inventory entry.
                foreach (Room room in rooms)
                {
                    roomNumber = binaryReader.ReadString();
                    area = binaryReader.ReadString();
                    type = binaryReader.ReadString();
                    pricePerNight = binaryReader.ReadDouble();
                    description = binaryReader.ReadString();
                    result.Append(string.Format("\n\tRoom number: " + roomNumber + "\n\tArea: " + area + "\n\tRoom type: " + type + 
                                                "\n\tPrice Per Night: " + pricePerNight + "\n\tAddition information: " + description + Environment.NewLine));
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
                binaryReader.Close();
            }
            return result.ToString();
        }
        public string ReadFromFileHotel(string filePath)
        {
            string hotelName;
            string constructionDate;
            string address;
            int staff;
            //Here we declare the binary writer and reader objects
            BinaryReader binaryReader = null;
            StringBuilder result = new StringBuilder();
            //Here we open the file for reading.
            try
            {
                binaryReader = new BinaryReader(new FileStream(filePath, FileMode.Open));
                //Here we read an inventory entry.
                hotelName = binaryReader.ReadString();
                constructionDate = binaryReader.ReadString();
                address = binaryReader.ReadString();
                staff = binaryReader.ReadInt32();
                result.Append(string.Format("\n\tHotel: " + hotelName + " \n\tDay of Construction: " + constructionDate + "\n\tAddress: " + address + 
                                            "\n\tNumber of staff: " + staff + Environment.NewLine));
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
                binaryReader.Close();
            }
            return result.ToString();
        }
    }
    
    
}
