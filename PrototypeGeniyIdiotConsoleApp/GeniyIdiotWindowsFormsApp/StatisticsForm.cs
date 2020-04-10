using System;
using System.Windows.Forms;
using GeniyIdiot.Common;
using System.IO;
namespace GeniyIdiotWindowsFormsApp
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
            ShowStatistics();
        }

        private void ShowStatistics()
        {
            listView1.View = View.Details;
            var result = FileSystem.GetString("Statistics.txt");
            string[] delimeter = new string[1];
            delimeter[0] = "\r\n";
            var SplitedStrings = result.Split(delimeter, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < SplitedStrings.Length; i++)
            {
                var splitedWord = SplitedStrings[i].Split('$');
                ListViewItem listContent = new ListViewItem();
                listContent.Text = splitedWord[0];
                listContent.SubItems.Add(splitedWord[1]);
                listContent.SubItems.Add(splitedWord[2]);
                listView1.Items.Add(listContent);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

