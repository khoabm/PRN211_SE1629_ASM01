using BusinessObject;
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
    public partial class frmUpdateMember : Form
    {
        public frmUpdateMember()
        {
            InitializeComponent();
        }

        public Member Member { get; set; }
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(txtID.Text.ToString());
                string email = txtEmail.Text.ToString();
                string password = txtPassword.Text.ToString();
                string name = txtEmail.Text.ToString();
                string city = txtCity.Text.ToString();
                string country = txtCountry.Text.ToString();
                Member member = new Member
                {
                    Id= id,
                    Email= email,
                    Password= password,
                    Name= name,
                    City= city,
                    Country= country,
                };
                if (String.IsNullOrEmpty(email) || (String.IsNullOrEmpty(password)))
                {
                    MessageBox.Show("Email and password must not be empty", "Update failed");
                }
                else
                {
                    memberRepository.updateMember(member);
                    MessageBox.Show("Update success", "Update success");
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Update failed");
            }
        }

        private void frmUpdateMember_Load(object sender, EventArgs e)
        {
            
            txtID.Text = Member.Id.ToString();
            txtEmail.Text = Member.Email;
            txtPassword.Text = Member.Password;
            txtName.Text = Member.Name;
            txtCity.Text = Member.City;
            txtCountry.Text = Member.Country;
        }
    }
}
