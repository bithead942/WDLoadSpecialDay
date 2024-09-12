using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace WDLoadSpecialDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string baseUrl = "http://holidayapi.com";
            string responderUrl = "/v1/holidays?country=US&year=" + txtYear.Text;
            string strName = "";
            string strDate = "";
            int iInserts = 0;

            HttpWebRequest ApiResponder = (HttpWebRequest)WebRequest.Create(baseUrl + responderUrl);
            ApiResponder.ContentType = "application/json";
            ApiResponder.Method = "POST";
            Stream postStream = ApiResponder.GetRequestStream();
            postStream.Close();


            HttpWebResponse ApiResponse = (HttpWebResponse)ApiResponder.GetResponse();
            Stream receiveStream = ApiResponse.GetResponseStream();
            StreamReader reader2 = new StreamReader(receiveStream, Encoding.UTF8);
            string content = reader2.ReadToEnd();
            JObject json = JObject.Parse(content);
            txtResponseCode.Text = (string)json["status"];

            foreach (var specialday in json["holidays"])
            {
                JToken dayinfo = specialday.First;
                foreach (JObject dateinfo in dayinfo)
                {
                    strName = (string)dateinfo["name"];
                    strDate = (string)dateinfo["date"];
                    Console.WriteLine("Name: {0}, Date: {1}", strName, strDate);
                    if ((int)special_DaysTableAdapter.Check_Date_Exist(strDate) == 0)  //only insert of a row doesn't exist
                    {
                        special_DaysTableAdapter.Insert_Special_Date(strDate, "Today is " + strName + " ");
                        iInserts = iInserts + 1;
                    }
                }
            }
            //Sydney's Birthday
            strDate = txtYear.Text + "-01-26";
            if ((int)special_DaysTableAdapter.Check_Date_Exist(strDate) == 0)
            {
                special_DaysTableAdapter.Insert_Special_Date(strDate, "Happy Birthday Sydney ");
                iInserts = iInserts + 1;
            }
            //Juli's Birthday
            strDate = txtYear.Text + "-05-04";
            if ((int)special_DaysTableAdapter.Check_Date_Exist(strDate) == 0)
            {
                special_DaysTableAdapter.Insert_Special_Date(strDate, "Happy Birthday Julie ");
                iInserts = iInserts + 1;
            }
            //Greg's Birthday
            strDate = txtYear.Text + "-05-24";
            if ((int)special_DaysTableAdapter.Check_Date_Exist(strDate) == 0)
            {
                special_DaysTableAdapter.Insert_Special_Date(strDate, "Happy Birthday Greg ");
                iInserts = iInserts + 1;
            }
            //Ethan's Birthday
            strDate = txtYear.Text + "-06-07";
            if ((int)special_DaysTableAdapter.Check_Date_Exist(strDate) == 0)
            {
                special_DaysTableAdapter.Insert_Special_Date(strDate, "Happy Birthday Ethan ");
                iInserts = iInserts + 1;
            }
            txtRowsInserted.Text = iInserts.ToString();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
