using GeniyIdiot.Common;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class GetNameFromUser : Form
    {
        public static User user;
        public GetNameFromUser()
        {
            InitializeComponent();
            askUserName.Text = "Как Вас зовут?";
            writeUserName.Text = "";
        }
        public void enterName_Click(object sender, EventArgs e)
        {
            if (writeUserName.Text == "")
            { MessageBox.Show("Пожалуйста, введите имя пользователя!");
                return;
            }
            var sendToOtherForm = writeUserName.Text;
            user = new User(sendToOtherForm);
            var fm = new MainForm();
            fm.userName.Text = user.Name; 
            Close();
        }
        
    }
}
