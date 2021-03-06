﻿using eProdaja.WinUI;
using MoviePick.Data.Model;
using MoviePick.Data.Request;
using MoviePick.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviePick.WindowsFormsUI.Forms
{
    public partial class frmUserSearch : Form
    {
        APIService _serviceUser = new APIService("User");
        APIService _serviceUserType = new APIService("UserType");

        public frmUserSearch()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await LoadUsers();
        }

        private async Task LoadTypes()
        {
            var list = await _serviceUserType.GetAll<List<UserType>>();
            list.Insert(0, new UserType());
            cmbType.ValueMember = "Id";
            cmbType.DisplayMember = "Type";
            cmbType.DataSource = list;
        }

        private async Task LoadUsers()
        {
            UserSearchRequest request = new UserSearchRequest
            {
                Username = txtSearch.Text
            };

            var id = cmbType.SelectedValue;

            if (int.TryParse(id.ToString(), out int ID))
            {
                request.UserTypeId = ID;
            }

            var list = await _serviceUser.GetAll<List<User>>(request);
            List<frmUserSearchVM> vm = new List<frmUserSearchVM>();
            foreach (var item in list)
            {
                frmUserSearchVM ni = new frmUserSearchVM
                {
                    Email = item.Email,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Id = item.Id,
                    Phone = item.Phone,
                    Username = item.Username,
                    UserType = item.UserType.Type
                };
                vm.Add(ni);
            }
            dgvUser.DataSource = vm;
        }

        private async void frmUserSearch_Load(object sender, EventArgs e)
        {
            dgvUser.AutoGenerateColumns = false;
            await LoadTypes();
            await LoadUsers();
        }

        private async void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvUser.SelectedRows[0].DataBoundItem;
            var MTVS = await _serviceUser.GetById<User>((item as frmUserSearchVM).Id);
            frmUserAdd frm = new frmUserAdd(MTVS);
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private async void cmbType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            await LoadUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRptUser frm = new frmRptUser(dgvUser.DataSource as List<frmUserSearchVM>);
            frm.Show();
        }
    }
}
