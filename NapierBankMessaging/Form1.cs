using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace NapierBankMessaging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }



        private void btnProcess_Click(object sender, EventArgs e)
        {
            string currentPath = Directory.GetCurrentDirectory();
            string path = Path.GetFullPath(Path.Combine(currentPath, @"..\..\..\..\"));
            

            string messageIn = txtMessIn.Text;
            string messageHead = txtHeader.Text;
            string messageOut = "";


            
            if (txtHeader.Text == "")
            {
                txtMessOut.Text = "You need to add a Message Header";
            }
            else
            {
                string messageType = messageHead.Substring(0, 1);

                if (messageType == "S")
                {
                    //call sms, need to make this a class
                    ProcessSMS(messageIn, ref messageOut, path);
                }
                else if (messageType == "E")
                {
                    //call email
                    ProcessEmail(messageIn, ref messageOut, path);
                }
                else if (messageType == "T")
                {
                    //call tweets
                    ProcessTweet(messageIn, ref messageOut, path);
                }
                else
                {
                    txtMessOut.Text = "Invalid Message Header";
                }

                txtMessOut.Text = messageOut;

            }

        }




        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessIn.Text = "";
            txtMessOut.Text = "";
            txtHeader.Text = "";
            txtList.Text = "";
        }


        public void ProcessSMS(string messageIn, ref string messageOut, string path)
        {
            string[] textAbbreviation = { };
            string[] textWords = { };

            List<string> listAbb = new List<string>();
            List<string> listWords = new List<string>();


            int counter = 0;

            // Read the file line by line.  
            foreach (string line in System.IO.File.ReadLines(@path + "textwords.csv"))
            {
                string[] columns = line.Split(',');
                listAbb.Add(columns[0]);
                listWords.Add(columns[1]);
                counter++;
            }

            textAbbreviation = listAbb.ToArray();
            textWords = listWords.ToArray();


            string[] input = messageIn.Split(' ');


            for (int i = 0; i < (textAbbreviation.Length); i++)
            {
                for (int j = 0; j < (input.Length); j++)
                {
                    if (input[j] == textAbbreviation[i])
                    {
                        input[j] = input[j] + " <" + textWords[i] + ">";
                    }

                }

            }

            for (int i = 0; i < (input.Length); i++)
            {
                messageOut = messageOut + input[i] + " ";
            }

        }

        public void ProcessEmail(string messageIn, ref string messageOut, string path)
        {

            

            StreamWriter sw = new StreamWriter(path + "quarantineList.txt", true);
            StreamWriter swSIR = new StreamWriter(path + "SIR.txt", true);

            string email = @"((http|ftp|https):\/\/[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?)";

            String[] lines;


            lines = Regex.Split(messageIn, @"\r\n|\r|\n");
            string sir = lines[0].Substring(0, 10);

            if (sir == "Sort Code:")
            {
                swSIR.WriteLine(lines[0]);                
                swSIR.WriteLine(lines[1]);
            }
            swSIR.Close();





            foreach (Match item in Regex.Matches(messageIn, email))
            {
                sw.WriteLine(item);
            }
            sw.Close();

            messageOut = Regex.Replace(messageIn, email, "<URL Quarantined>");

            


            

            
            
            


        }


        public void ProcessTweet(string messageIn, ref string messageOut, string path)
        {
            StreamWriter swHashtag = new StreamWriter(path + "hashtagList.txt", true);
            StreamWriter swMentions = new StreamWriter(path + "mentionsList.txt", true);

            string[] textAbbreviation = { };
            string[] textWords = { };

            List<string> listAbb = new List<string>();
            List<string> listWords = new List<string>();


            int counter = 0;

            // Read the file line by line.  
            foreach (string line in System.IO.File.ReadLines(@path + "textwords.csv"))
            {
                string[] columns = line.Split(',');
                listAbb.Add(columns[0]);
                listWords.Add(columns[1]);
                counter++;
            }

            textAbbreviation = listAbb.ToArray();
            textWords = listWords.ToArray();


            string[] input = Regex.Split(messageIn, @"\r\n|\r|\n| ");




            for (int i = 0; i < (input.Length); i++)
            {
                for (int j = 0; j < (textAbbreviation.Length); j++)
                {
                    if (input[i] == textAbbreviation[j])
                    {
                        input[i] = input[i] + " <" + textWords[j] + ">";
                    }
                }

                string firstDiget = input[i].Substring(0, 1);

                if (firstDiget == "#")
                {
                    swHashtag.WriteLine(input[i]);
                }
                if (firstDiget == "@")
                {
                    swMentions.WriteLine(input[i]);
                }
            }

            swHashtag.Close();
            swMentions.Close();

            for (int i = 0; i < (input.Length); i++)
            {
                messageOut = messageOut + input[i] + " ";
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            
            string currentPath = Directory.GetCurrentDirectory();
            string path = Path.GetFullPath(Path.Combine(currentPath, @"..\..\..\..\"));

            txtList.Text = "";

            
            txtList.AppendText("Trending List" + "\r\n");
            foreach (string line in System.IO.File.ReadLines(@path + "hashtagList.txt"))
            {
                txtList.AppendText(line + "\r\n");
            }
            

            txtList.AppendText("\r\n" + "Mentions List" + "\r\n");
            foreach (string line in System.IO.File.ReadLines(@"C:\Users\chris\OneDrive\Documents\3rdYearSoftwareEngineeringCW\mentionsList.txt"))
            {
                txtList.AppendText(line + "\r\n");
            }
            

            txtList.AppendText("\r\n" + "SIR List" + "\r\n");
            foreach (string line in System.IO.File.ReadLines(@"C:\Users\chris\OneDrive\Documents\3rdYearSoftwareEngineeringCW\SIR.txt"))
            {
                txtList.AppendText(line + "\r\n");
            }
            
             

            txtList.Text = "Help MEEEEEE!!!!!";

        }




        

        private void btnDisplay_Click_1(object sender, EventArgs e)
        {
            
            string currentPath = Directory.GetCurrentDirectory();
            string path = Path.GetFullPath(Path.Combine(currentPath, @"..\..\..\..\"));

            txtList.Text = "";

            
            txtList.AppendText("Trending List" + "\r\n");
            foreach (string line in System.IO.File.ReadLines(@path + "hashtagList.txt"))
            {
                txtList.AppendText(line + "\r\n");
            }
            

            txtList.AppendText("\r\n" + "Mentions List" + "\r\n");
            foreach (string line in System.IO.File.ReadLines(@path + "mentionsList.txt"))
            {
                txtList.AppendText(line + "\r\n");
            }
            

            txtList.AppendText("\r\n" + "SIR List" + "\r\n");
            foreach (string line in System.IO.File.ReadLines(@path + "SIR.txt"))
            {
                txtList.AppendText(line + "\r\n");
            }

        }
    }
}
