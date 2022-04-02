using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Simbarashe Lungu
 * Email: 19332184@rcconnect.co.za
 * DISD2: Group 4
 */
namespace Weather_Forecasting_System
{
    public partial class Form1 : Form
    {
        //Declaring and intializing variables...........
        string[] City = new string[1];
        DateTime[] DAte = new DateTime[1];
        int [] Min_Temp = new int [1];
        int[] Max_Temp = new int [1];
        int[] Precipitation = new int[1];
        int[] Humidity = new int[1];
        int[] Wind_Speed = new int[1];
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerateAllCities_Click(object sender, EventArgs e)
        {
           
            //Creating a string builder object....
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("City \t DAte \t Min Temp \t Max Temp \t Precipitation \t Humidity \t Wind Speed\n");
            //string All_Cities = "City \t DAte \t Min Temp \t Max Temp \t Precipitation \t Humidity \t Wind Speed\n";

            for (int i = 0; i < counter; i++)
            {

                stringBuilder.Append((i+1) + "." + City[i] + "\t" + DAte[i] + Max_Temp[i] + "\t" + Min_Temp[i] + "\t" + Precipitation[i] + "\t" + Humidity[i] + "\t" + Wind_Speed[i] + "\n");
                //All_Cities += City[i] + "\t" + DAte[i] + Max_Temp[i] + "\t" + Min_Temp[i] + "\t" + Precipitation[i] + "\t" + Humidity[i] + "\t" + Wind_Speed[i]+"\n";

            }
            //Printing Results....
            rchTxtBox.Text = stringBuilder.ToString();
        }

        //Diplaying Using a String Builder.......
        //public static void StringBuilderDisplay()
        //{
        //    StringBuilder stringBuilder = new StringBuilder();

        //    stringBuilder.Append("City \t MIN Temperature \t Max Temperature \t Date");

        //    for(int i = 0; i < counter; i++)
        //    {
        //        stringBuilder.Append(""+ City[i] + "\t" +  )
        //    }
        //}
       

        private void btnGenerateSpecificCity_Click(object sender, EventArgs e)
        {
                    } 

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime start = StartdateTimePicker2.Value;
            DateTime end = EnddateTimePicker1.Value;

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("City \t DAte \t Min Temp \t Max Temp \t Precipitation \t Humidity \t Wind Speed\n");

            for (int i = 0; i < counter; i++)
            {
                if((DAte[i] >= start) && (DAte[i])<= end)
                {
                    stringBuilder.Append((i + 1) + "." + City[i] + "\t" + DAte[i] + Max_Temp[i] + "\t" + Min_Temp[i] + "\t" + Precipitation[i] + "\t" + Humidity[i] + "\t" + Wind_Speed[i] + "\n");

                }
                //Printing Results....
                rchTxtBox.Text = stringBuilder.ToString();
            }
        }

        private void txtMaxTemp_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCapture_Click_1(object sender, EventArgs e)
        {
            //Checking if the user entered all the required details...
            if (txtCity.Text.Trim() == string.Empty)
            {
                MessageBox.Show("City name is required!!!");
                return;
            }
            else
                 if (txtMaxTemp.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Maximum temperature is required!!!");
                return;
            }
            else
                if (txtMinTemp.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Minimum temperature is required!!!");
                return;
            }
            else
                 if (txtPreciptation.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Precipitation is required!!!");
                return;
            }
            else
                if (txtWindSpeed.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Wind speed is required!!!");
                return;
            }

            //Initializing variables from textbox.....
            City[counter] = txtCity.Text;
            //Rezing an array......
            Array.Resize(ref City, City.Length + 1);

            DAte[counter] = Convert.ToDateTime(dateTimePicker1.Value);
            //Resize array......
            Array.Resize(ref DAte, DAte.Length + 1);

            Max_Temp[counter] = Convert.ToInt32(txtMaxTemp.Text);
            //Resize array.....
            Array.Resize(ref Max_Temp, Max_Temp.Length + 1);

            Min_Temp[counter] = Convert.ToInt32(txtMinTemp.Text);
            //Array Resize......
            Array.Resize(ref Min_Temp, Min_Temp.Length + 1);

            Precipitation[counter] = Convert.ToInt32(txtPreciptation.Text);
            //Array resize........
            Array.Resize(ref Precipitation, Precipitation.Length + 1);

            Humidity[counter] = Convert.ToInt32(txtHumidity.Text);
            //Array Resize.......
            Array.Resize(ref Humidity, Humidity.Length + 1);

            Wind_Speed[counter] = Convert.ToInt32(txtWindSpeed.Text);
            //Array Resize......
            Array.Resize(ref Wind_Speed, Wind_Speed.Length + 1);

            //Increasing......
            counter += 1;



            //Message box to show that the weather forcuse details has been sucessfully capture to thye system ........
            MessageBox.Show("Saved Successfully");

            //Clear what was in the text boxes
            txtCity.Clear();
            dateTimePicker1.Value.ToLocalTime();
            txtMaxTemp.Clear();
            txtMinTemp.Clear();
            txtPreciptation.Clear();
            txtHumidity.Clear();
            txtWindSpeed.Clear();

        }

        private void btnGenerateAllCities_Click_1(object sender, EventArgs e)
        {

        }

        private void EnddateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void StartdateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMaxTemp_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void rchTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWindSpeed_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHumidity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPreciptation_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMinTemp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
