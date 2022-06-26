using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections;
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

            //Load cities list
            //cboCity.DataSource = memberRepository.GetCities();
            IList cboCityDataSource = new List<string>();
            List<string> cities = (from c in memberRepository.GetCities() select c).ToList();

            foreach (string c in cities)
            {
                cboCityDataSource.Add(c);
            }
            cboCityDataSource.Insert(0, "None");
            cboCity.DataSource = cboCityDataSource;
            //Load countries list
            IList cboCountryDataSource = new List<string>();
            List<string> countries = (from c in memberRepository.GetCountries() select c).ToList();

            foreach (string c in countries)
            {
                cboCountryDataSource.Add(c);
            }
            cboCountryDataSource.Insert(0, "None");
            cboCountry.DataSource = cboCountryDataSource;
            //cboCountry.DataSource = memberRepository.GetCountries();
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsertMember frmInsertMember = new frmInsertMember();
            frmInsertMember.ShowDialog();
            LoadMemberList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var member = memberRepository.getMemberByID(int.Parse(txtID.Text));
            frmUpdateMember frmUpdateMember = new frmUpdateMember { Member = member };
            //memberRepository.updateMember(member);
            frmUpdateMember.ShowDialog();
            LoadMemberList();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string? city = cboCity.SelectedValue.ToString();
            string? country = cboCountry.SelectedValue.ToString();
            if (city.Equals("None") && country.Equals("None"))
            {
                MessageBox.Show("Choose a city or country", "Filter");
            }
            else
            {
                if (city == "None")
                {
                    source.DataSource = memberRepository.GetMembers().Where(x => x.Country == country).ToList();
                }
                else if (country == "None")
                {
                    source.DataSource = memberRepository.GetMembers().Where(x => x.City == city).ToList();
                    
                    //MessageBox.Show("No country");
                }
                else
                {
                    source.DataSource = memberRepository.GetMembers()
                        .Where(m => (m.Country == country) && (m.City == city)).ToList();
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           DialogResult dr =  MessageBox.Show("Are you sure to quit", "Quit", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
