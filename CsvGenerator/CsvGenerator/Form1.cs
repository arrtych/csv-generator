using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvGenerator
{
    public enum ColumnNames
    {
        ID, Name, Phone, City, Date
    };
    

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            //Create columns with values

            addColumnName1.DataSource = Enum.GetValues(typeof(ColumnNames));
            addColumnName1.SelectedItem = ColumnNames.ID;
            addColumnName2.DataSource = Enum.GetValues(typeof(ColumnNames));
            addColumnName2.SelectedItem = ColumnNames.Name;
            addColumnName3.DataSource = Enum.GetValues(typeof(ColumnNames));
            addColumnName3.SelectedItem = ColumnNames.Phone;
            addColumnName4.DataSource = Enum.GetValues(typeof(ColumnNames));
            addColumnName4.SelectedItem = ColumnNames.City;
            addColumnName5.DataSource = Enum.GetValues(typeof(ColumnNames));
            addColumnName5.SelectedItem = ColumnNames.Date;

        }

        private void generateBtn_Click(object sender, EventArgs e)
        {            
            try
            {
                //RandomData object for generating data in loop later
                RandomData rd = new RandomData(0);
                // number of rows from input with converting to integer
                int rows = Convert.ToInt32(rows_num.Text);
                //create list of RandomData objects
                var persons = new List<RandomData>();

                /*
                 * checkColumn methods is necessary to select type of random data for every column.
                 * It generates necessary type of data , but copies that for all lines, what is not correct programm work.
                 *  Lower is code for right generating data, but without checking combobox types. Because i don't know how to do correct.
                 * 
                for (int i = 0; i < rows; i++)
                {
                    persons.Add(new RandomData(i) {
                        name = checkColumn2(),
                        phone = checkColumn3(),
                        city = checkColumn4(),
                        date = checkColumn5()
                    });
                }*/

                //generate RandomData object in loop
                for (int i = 0; i < rows; i++)
                {
                    persons.Add(new RandomData(i)
                    {
                        name = rd.getName(),
                        phone = rd.getPhone(),
                        city = rd.getCity(),
                        date = rd.getDate()
                    });
                }

                //Write objects from list to Textbox
                foreach (RandomData person in persons)
                {
                    data_box.Text += person.toString()+"\n";
                }
                //write all data from texbox to csv file
                System.IO.File.WriteAllText("output.csv", data_box.Text);
            }
            catch (FormatException) { }
            catch (UnauthorizedAccessException) { }
            catch (System.IO.FileNotFoundException) { }
        }


        //To check 2 combobox for generating necessary data depending on the selected item
        private String checkColumn2()
        {
            RandomData rd = new RandomData(0);
            Random random = new Random();
            if (addColumnName2.SelectedItem.Equals(ColumnNames.ID))
                return Convert.ToString(random.Next(0, Convert.ToInt32(rows_num.Text)));
            else if (addColumnName2.SelectedItem.Equals(ColumnNames.Name))
                return new RandomData(1).getName();
            else if (addColumnName2.SelectedItem.Equals(ColumnNames.Phone))
                return new RandomData(0).getPhone();
            else if (addColumnName2.SelectedItem.Equals(ColumnNames.City))
                return rd.getCity();
            else if (addColumnName2.SelectedItem.Equals(ColumnNames.Date))
                return rd.getDate();
            else
                return null;
        }

        //To check 3 combobox for generating necessary data depending on the selected item
        private String checkColumn3()
        {
            RandomData rd = new RandomData(0);
            Random random = new Random();
            if (addColumnName3.SelectedItem.Equals(ColumnNames.ID))
                return Convert.ToString(random.Next(0, Convert.ToInt32(rows_num.Text)));
            else if (addColumnName3.SelectedItem.Equals(ColumnNames.Name))
                return rd.getName();
            else if (addColumnName3.SelectedItem.Equals(ColumnNames.Phone))
                return rd.getPhone();
            else if (addColumnName3.SelectedItem.Equals(ColumnNames.City))
                return rd.getCity();
            else if (addColumnName3.SelectedItem.Equals(ColumnNames.Date))
                return rd.getDate();
            else
                return null;
        }

        //To check 4 combobox for generating necessary data depending on the selected item
        private String checkColumn4()
        {
            RandomData rd = new RandomData(0);
            Random random = new Random();
            if (addColumnName4.SelectedItem.Equals(ColumnNames.ID))
                return Convert.ToString(random.Next(0, Convert.ToInt32(rows_num.Text)));
            else if (addColumnName4.SelectedItem.Equals(ColumnNames.Name))
                return rd.getName();
            else if (addColumnName4.SelectedItem.Equals(ColumnNames.Phone))
                return rd.getPhone();
            else if (addColumnName4.SelectedItem.Equals(ColumnNames.City))
                return rd.getCity();
            else if (addColumnName4.SelectedItem.Equals(ColumnNames.Date))
                return rd.getDate();
            else
                return null;
        }

        //To check  combobox for generating necessary data depending on the selected item
        private String checkColumn5()
        {
            RandomData rd = new RandomData(0);
            Random random = new Random();
            if (addColumnName5.SelectedItem.Equals(ColumnNames.ID))
                return Convert.ToString(random.Next(0, Convert.ToInt32(rows_num.Text)));
            else if (addColumnName5.SelectedItem.Equals(ColumnNames.Name))
                return rd.getName();
            else if (addColumnName5.SelectedItem.Equals(ColumnNames.Phone))
                return rd.getPhone();
            else if (addColumnName5.SelectedItem.Equals(ColumnNames.City))
                return rd.getCity();
            else if (addColumnName5.SelectedItem.Equals(ColumnNames.Date))
                return rd.getDate();
            else
                return null;
        }
    }
}
