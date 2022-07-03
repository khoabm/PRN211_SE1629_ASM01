using DataAccess.Repository;
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
    public partial class frmInsertMember : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        public frmInsertMember()
        {
            InitializeComponent();
        }

        private void frmInsertMember_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int id = memberRepository.getNewID();
                string email = txtEmail.Text.ToString();
                string password = txtPassword.Text.ToString();
                string name = txtEmail.Text.ToString();
                string city = txtCity.Text.ToString();
                string country = txtCountry.Text.ToString();
                if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Email and password must not be empty", "Insert Failed");
                }
                else
                {
                    memberRepository.insertMember(id, email, password, name, city, country);
                    MessageBox.Show("Insert Success", "Insert Success");
                    this.Hide();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Insert Failed");
            }
            

        }
    }
}
