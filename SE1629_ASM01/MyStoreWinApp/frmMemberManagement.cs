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
    public partial class frmMemberManagement : Form
    {
        public bool IsAdmin { get; set; }
        public string UserEmail { get; set; }
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        public frmMemberManagement()
        {
            InitializeComponent();
        }
        //GET ALL MEMBERS IN DATABASE
        public void LoadMemberList()
        {

            var members = memberRepository.GetMembers();
            try
            {
                source = new BindingSource();
                source.DataSource = members;


                txtID.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtID.DataBindings.Add("Text", source, "Id");
                txtName.DataBindings.Add("Text", source, "Name");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                //UpdateBindings();

                dgvMembers.DataSource = null;
                dgvMembers.DataSource = source;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load Member List");
            }
        }

        //FORM LOAD EVENT
        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            lbUserEmail.Text = UserEmail;

            if (!IsAdmin)
            {
                btnDelete.Enabled = false;
                btnInsert.Enabled = false;
            }
            //cboCity.DataSource = memberRepository.GetCities();
            LoadMemberList();
            //dgvMembers.CellDoubleClick += DgvCellDoubleClick;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            source.DataSource = memberRepository.GetMembers().OrderByDescending(mem => mem.Name).ToList();
        }
        
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                source.DataSource = memberRepository.GetByName(txtSearch.Text);
            }
            e.Handled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var member = new Member { Id = int.Parse(txtID.Text) };
                    memberRepository.Delete(member.Id);
                }
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }
    }
}
