using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuTextbox;
using FluentValidation.Results;
using MetroFramework;
using POS.App.Helpers;
using POS.App.UserControls;
using POS.App.UserControls.MyControls;
using POS.Logic;
using POS.Logic.Models;
using POS.Logic.Validators;
using POS.Queries.Core.Domain;
using POS.Queries.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation;
using Helpers;
namespace POS.App.Forms
{
    public partial class frmMemberManager : Form
    {

        private int memberID;
        public frmMemberManager()
        {
            InitializeComponent();
        }
       

       
        private void pnlContents_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        /// <summary>
        /// Validates Form Fields data
        /// </summary>
        /// <returns>If Validation succed, returns True. If not, returns false.</returns>
        private void ValidatedFields(MemberModel model)
        {

            var validator = new MemberValidator();
            validator.ValidateAndThrow(model);
            
            
        }

      
        private void Save()
        {
            try
            {

                var model = new MemberModel();
                model.Address = txtAddress.Text;
                model.ContactNumber = txtContactNumber.Text;
                model.FullName = txtFullName.Text;
                ValidatedFields(model);
                if (memberID > 0)
                {
                    Factories.CreateMember().Edit(memberID, model);

                }
                else
                {
                    Factories.CreateMember().Add(model);
                }
                LocalUtils.ShowSaveMessage(this);
                LoadList();
                page.SetPage(pageList);
                    
            }
            catch (Exception ex)
            {

                LocalUtils.ShowErrorMessage(this, ex.Message);
            }
        }
        private void SetData()
        {
            try
            {
                var model = Factories.CreateMember().Get(memberID);
                txtAddress.Text = model.Address;
                txtFullName.Text = model.FullName;
                txtContactNumber.Text = model.ContactNumber;
            }
            catch (Exception ex)
            {

                LocalUtils.ShowErrorMessage(this, ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditsSupplier_Load(object sender, EventArgs e)
        {
            LoadList();
           
        }
        async void LoadList()
        {
            try
            {
                await Task.Delay(1000);
                var models = await Task.Run(() => Factories.CreateMember().GetAllBy(txtSearch.Text));
                int count = 0;
                gridMembers.Rows.Clear();
                foreach (var item in models)
                {
                    count++;
                    gridMembers.Rows.Add(new string[] {
                            item.ID.ToString(),
                            count.ToString(),
                            item.FullName,
                            item.Address,
                    item.ContactNumber});
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            page.SetPage(pageDetails);
            memberID = 0;
            ResetInputs();
        }
        private void ResetInputs()
        {
            var textboxes = LocalUtils.GetAll(pageDetails, typeof(BunifuTextBox));
            foreach (BunifuTextBox item in textboxes)
            {
                item.Text = string.Empty;
            }
            var comboboxes = LocalUtils.GetAll(pageDetails, typeof(Bunifu.UI.WinForms.BunifuDropdown));
            foreach (Bunifu.UI.WinForms.BunifuDropdown item in comboboxes)
            {
                item.SelectedIndex = -1;
                item.Enabled = true;
            }
            var dates = LocalUtils.GetAll(pageDetails, typeof(BunifuDatepicker));
            foreach (BunifuDatepicker item in dates)
            {
                item.Value = DateTime.UtcNow;
            }
        }

        private void gridSuppliers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            page.SetPage(pageList);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
        private void Delete()
        {
            try
            {
                var grid = gridMembers;

                if (grid.SelectedRows.Count > 0)
                {
                    memberID = int.Parse(grid.SelectedRows[0].Cells[0].Value.ToString());
                    if (memberID != 0)
                    {
                        DialogResult result = MetroMessageBox.Show(this, "Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            Factories.CreateMember().Delete(memberID);
                            LoadList();
                        }
                    }
                    else
                    {
                        LocalUtils.ShowNoRecordFoundMessage(this);
                    }

                }
                else
                {

                    LocalUtils.ShowNoRecordSelectedMessage(this);
                }

            }
            catch (Exception ex)
            {

                LocalUtils.ShowErrorMessage(this, ex.Message);
            }
        }

        private void txtContactNumber_TextChange(object sender, EventArgs e)
        {
            
        }

        private void txtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void Edit()
        {
            try
            {
                var grid = gridMembers;

                if (grid.SelectedRows.Count > 0)
                {
                    memberID = int.Parse(grid.SelectedRows[0].Cells[0].Value.ToString());
                    if (memberID != 0)
                    {
                        page.SetPage(pageDetails);
                        SetData();
                    }
                }
                else
                {
                    LocalUtils.ShowNoRecordSelectedMessage(this);
                }

            }
            catch (Exception ex)
            {

                LocalUtils.ShowErrorMessage(this, ex.ToString());
            }
        }
    }
}
