using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvGenerator
{
    class RandomData
    {

        public int id;
        public string name,city,phone;
        public string date;
        public string separator = ",";

        //random object
        Random random = new Random();
        
        //class constructor
        public RandomData(int id)
        {
            this.id = id;
        }

        public enum FirstNames
        {
            Vasja,Petja,Roman,Kirill,Deniss
        };
        public enum LastNames
        {
            Petrov,Ivanov,Sidorov,Denissov,Pushkin
        };

        public enum Сities
        {
            Moscow, Narva, Oslo, Tallinn, Tartu, Tokio
        };

        public string[] phone_numbers =
        {
            "+372 55667788","+372 57916842","+372 59279333","+372 54755895","+372 537554695"
        };

        //To generate random name
        public String getName()
        {
            //number of elements in enum FirstNames 
            int firstNameEnumSize = Enum.GetNames(typeof(FirstNames)).Length;
            //number of elements in enum LastNames
            int lastNameEnumSize = Enum.GetNames(typeof(LastNames)).Length;
            //generate random firstname + random lastname
            String result = Enum.GetNames(typeof(FirstNames))[random.Next(0, firstNameEnumSize)] +
                " " + Enum.GetNames(typeof(LastNames))[random.Next(0, lastNameEnumSize)];
            return result;
        }

        //To generate random city
        public string getCity()
        {
            //number of elements in enum Сities 
            int citiesEnumSize = Enum.GetNames(typeof(Сities)).Length;
            //generate random cities from enum Сities
            String result = Enum.GetNames(typeof(Сities))[random.Next(0, citiesEnumSize)];
            return result;
        }

        //To generate random phone number
        public String getPhone()
        {
            return phone_numbers[random.Next(phone_numbers.Length)];
        }

        //To generate random date between today and 20 years ago
        public string getDate()
        {

            DateTime start = new DateTime(1998, 10, 31);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(range)).ToString("MM:dd:yyyy");
        }

        //To print all data of object
        public String toString()
        {
            return this.id + separator +
                "\"" + this.name + "\"" +
                separator + "\"" + this.phone + "\"" +
                separator + "\"" + this.city + "\"" +
                separator + "\"" + this.date + "\"";
        }


    }
}
