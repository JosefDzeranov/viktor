using System;
using System.Windows.Forms;
using GeniyIdiot.Common;
using PrototypeGeniyIdiotConsoleApp;

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
            var result = FileSystem.GetString("Statistics.txt");
            string[] delimeter = new string[1];
            delimeter[0] = "\r\n";
            var SplitedStrings = result.Split(delimeter, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < SplitedStrings.Length; i++)
            {
                var splitedWord = SplitedStrings[i].Split('$');
                for (int j = 0; j < splitedWord.Length; j++)
                {
                    var label1 = new Label();
                    label1.Location = new System.Drawing.Point(10 * i, 10 * j);
                    label1.Text = splitedWord[j];
                    this.Controls.Add(label1);
                    label1.Name = "label" + j;
                }
            }
        }
    }
}
