using Eticaret.Core.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eticaret.Desktop
{
    public partial class FormCustomer : Form
    {

        // urllerimiz statik olarak kod içerisinde verdik.Bu bad smels.. 
        // todo url adreslerini config dosya üzerinden okuma yapmalıyız
        private string url = "https://localhost:44374/api/";

        public FormCustomer()
        {
            InitializeComponent();
            Load += FormCustomer_Load;
        }

        private async void FormCustomer_Load(object? sender, EventArgs e)
        {
            await UyeleriListele();
        }

        private async Task UyeleriListele()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var customers = await httpClient.GetFromJsonAsync<List<Customer>>(new Uri(url + "Customer/GetList"));
                dtgvCustomers.DataSource = customers;
            }
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {

            Customer customer = new Customer()
            {
                BirthDay = dtpBirthDay.Value,
                CreateDate = DateTime.Now,
                CustomerEmail = txtEmail.Text,
                CustomerLastName = txtCustomerSurname.Text,
                CustomerStatus = true,
                CustomerName = txtCustomerName.Text,
                CustomerUserName = txtCustomerUserName.Text,
                PhoneNumber = txtPhone.Text
            };

            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseMessage = await httpClient.PostAsJsonAsync(url + "Customer/Add/", customer);
                if (responseMessage.IsSuccessStatusCode)
                {
                    await UyeleriListele();
                    FormClear();
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        private void FormClear()
        {
            txtCustomerId.Text = "0";
            txtCustomerName.Text = string.Empty;
            dtpBirthDay.Value = DateTime.Now;
            txtCustomerSurname.Text = string.Empty;
            txtCustomerUserName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;

        }

        private void dtgvCustomers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtCustomerId.Text = dtgvCustomers.CurrentRow.Cells[0].Value.ToString();
            txtCustomerName.Text = dtgvCustomers.CurrentRow.Cells["CustomerName"].Value.ToString();

            txtCustomerSurname.Text = dtgvCustomers.CurrentRow.Cells["CustomerLastName"].Value.ToString();
            txtCustomerUserName.Text = dtgvCustomers.CurrentRow.Cells["CustomerUserName"].Value.ToString();
            txtEmail.Text = dtgvCustomers.CurrentRow.Cells["CustomerEmail"].Value.ToString();
            txtPhone.Text = dtgvCustomers.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            dtpBirthDay.Value = Convert.ToDateTime(dtgvCustomers.CurrentRow.Cells["BirthDay"].Value.ToString());
        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {
            ButonlarKontrolu();
        }

        private void ButonlarKontrolu()
        {
            bool aktifEt = false;
            if (!string.IsNullOrEmpty(txtCustomerId.Text))
            {
                if (int.Parse(txtCustomerId.Text) > 0)
                {
                    aktifEt = true;

                }
            }
            btnSil.Enabled = aktifEt;
            btnGuncelle.Enabled = aktifEt;
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                await httpClient.DeleteAsync(url + "Customer/Delete/" + txtCustomerId.Text);
                await UyeleriListele();
            }
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                BirthDay = dtpBirthDay.Value,
                CreateDate = DateTime.Now,
                CustomerEmail = txtEmail.Text,
                CustomerLastName = txtCustomerSurname.Text,
                CustomerStatus = true,
                CustomerName = txtCustomerName.Text,
                CustomerUserName = txtCustomerUserName.Text,
                PhoneNumber = txtPhone.Text,
                CustomerId = int.Parse(txtCustomerId.Text)
            };

            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseMessage = await httpClient.PutAsJsonAsync(url + "Customer/Update/", customer);
                if (responseMessage.IsSuccessStatusCode)
                {
                    await UyeleriListele();
                    FormClear();
                }
            }
        }
    }
}
