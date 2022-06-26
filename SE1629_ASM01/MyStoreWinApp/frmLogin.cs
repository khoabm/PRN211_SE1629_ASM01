using BusinessObject;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.ToString();
            string password = txtPassword.Text.ToString();
            string defaultEmail = GetEmail();
            string defaultPassword = GetPassword();
            if (email.Equals(defaultEmail) && password.Equals(defaultPassword))
            {

                frmMemberManagement frmMemberManagement = new frmMemberManagement
                {
                    Text = "Member Management",
                    IsAdmin = true,
                    UserEmail = txtEmail.Text
                };
                frmMemberManagement.Closed += (sender, e) => this.Close();
                frmMemberManagement.Show();
                this.Hide();
            }
            else
            {
                Member member = memberRepository.MemberLogin(email, password);
                if (member != null)
                {
                    frmMemberManagement frmMemberManagement = new frmMemberManagement
                    {
                        Text = "Member Management",
                        IsAdmin = false,
                        UserEmail = txtEmail.Text
                    };
                    frmMemberManagement.Closed += (sender, e) => this.Close();
                    frmMemberManagement.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password", "Login");
                }
            }
        }

        public string GetEmail()
        {
            string email;
            IConfiguration config = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json", true, true).Build();
            email = config["DefautlAccount:email"];
            return email;
        }
        public string GetPassword()
        {
            string email;
            IConfiguration config = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json", true, true).Build();
            email = config["DefautlAccount:password"];
            return email;
        }
    }
}
