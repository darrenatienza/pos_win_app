
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuTextbox;
using Helpers;
using MetroFramework;
using POS.App.Helpers;
using POS.App.UserControls;
using POS.App.UserControls.MyControls;
using POS.Logic;
using POS.Logic.Models;
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

namespace POS.App.Forms
{
    public partial class frmUserManager : Form
    {

        public int ProductID;
        private int _userID;


        public frmUserManager()
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
       
        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Validates Form Fields data
        /// </summary>
        /// <returns>If Validation succed, returns True. If not, returns false.</returns>
        private bool ValidatedFields()
        {

            var ctrlTextBoxes2 = LocalUtils.GetAll(tabUserDetail, typeof(BunifuTextBox))
                       .Where(c => c.CausesValidation == true).OrderBy(c => c.TabIndex);
            foreach (BunifuTextBox item in ctrlTextBoxes2)
            {

                if (item.Text == string.Empty)
                {
                    LocalUtils.ShowValidationFailedMessage(this);
                    return false;
                }
    
            }
            var ctrlDropdown = LocalUtils.GetAll(tabUserDetail, typeof(Bunifu.UI.WinForms.BunifuDropdown))
                        .Where(c => c.CausesValidation == true).OrderBy(c => c.TabIndex);
            foreach (Bunifu.UI.WinForms.BunifuDropdown item in ctrlDropdown)
            {
                if (item.SelectedIndex < 0)
                {
                    item.Focus();
                    LocalUtils.ShowValidationFailedMessage(this);
                    return false;
                }
            }

            return true;
        }

       
        void AddToolTipToFields()
        {
            var ctrlTextBoxes2 = LocalUtils.GetAll(pnlContents, typeof(MyTextBox))
                        .OrderBy(c => c.TabIndex);
            foreach (MyTextBox item in ctrlTextBoxes2)
            {
                bunifuToolTip1.SetToolTip(item, item.ToolTipText);
            }
           
            

            var ctrlDropdown = LocalUtils.GetAll(pnlContents, typeof(MyDropDownList))
                        .OrderBy(c => c.TabIndex);
            foreach (Bunifu.UI.WinForms.BunifuDropdown item in ctrlDropdown)
            {
                bunifuToolTip1.SetToolTip(item, item.Tag.ToString());
            }
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserManager_Load(object sender, EventArgs e)
        {
            
            LoadUsers();
            LoadRoles();
        }

        async void LoadUsers()
        {
            try
            {
                await Task.Delay(1000);
                var users = await Task.Run(() =>Factories.CreateUser().GetUserList(txtSearch.Text));
                int count = 0;
                gridUsers.Rows.Clear();
                foreach (var item in users)
                {
                    count++;
                    gridUsers.Rows.Add(new string[] {
                            item.UserID.ToString(),
                            count.ToString(),
                            item.UserName,
                            item.FullName,
                            item.Role});
                }

                

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            page.SetPage(tabUserDetail);
            _userID = 0;
            ResetInputs();

        }

        private void gridProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            page.SetPage(tabUserList);
           
            
        }
        private void ResetInputs()
        {
            var textboxes = LocalUtils.GetAll(tabUserDetail, typeof(BunifuTextBox));
            foreach (BunifuTextBox item in textboxes)
            {
                item.Text = string.Empty;
            }
            var comboboxes = LocalUtils.GetAll(tabUserDetail, typeof(Bunifu.UI.WinForms.BunifuDropdown));
            foreach (Bunifu.UI.WinForms.BunifuDropdown item in comboboxes)
            {
                item.SelectedIndex = -1;
                item.Enabled = true;
            }
            var dates = LocalUtils.GetAll(tabUserDetail, typeof(BunifuDatepicker));
            foreach (BunifuDatepicker item in dates)
            {
                item.Value = DateTime.UtcNow;
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtLimit_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
        private void Delete()
        {
            try
            {
                var grid = gridUsers;

                if (grid.SelectedRows.Count > 0)
                {
                    var userID = int.Parse(grid.SelectedRows[0].Cells[0].Value.ToString());
                    if (userID != 0)
                    {
                        DialogResult result = MetroMessageBox.Show(this, "Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            Factories.CreateUser().Delete(userID);
                            LoadUsers();
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

                //LocalUtils.ShowErrorMessage(this, ex.ToString());
            }
        }
        private void LoadRoles()
        {
            try
            {
                using (var uow = new UnitOfWork(new DataContext()))
                {
                    cboRoles.Items.Clear();
                    var roles = uow.Roles.GetAll();
                    foreach (var role in roles)
                    {
                        cboRoles.Items.Add(new ItemX(role.Description, role.RoleID.ToString()));
                    }
                }
            }
            catch (Exception ex)
            {

                LocalUtils.ShowErrorMessage(this, ex.Message);
            }
        }
        private async void Save()
        {
            try
            {
                if (!ValidatedFields())
                {
                    return;
                }
                var model = new AddEditUserModel();
                 model.UserName = txtUserName.Text;
                 model.FirstName = txtFirstName.Text;
                 model.MiddleName = txtMiddleName.Text;
                 model.LastName = txtLastName.Text;
                 model.Password = txtPassword.Text;
                 model.RoleID = int.Parse(((ItemX)cboRoles.SelectedItem).Value);
                 if (_userID == 0)
                 {
                     await Task.Run(() =>Factories.CreateUser().Add(model));
                     page.SetPage(tabUserList);
                     LoadUsers();
                 }
                 else
                 {
                     await Task.Run(() =>Factories.CreateUser().Edit(_userID, model));
                     page.SetPage(tabUserList);
                     LoadUsers();
                 }
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
                using (var uow = new UnitOfWork(new DataContext()))
                {
                    var user = uow.Users.GetUser(_userID);
                    if (user != null)
                    {
                        txtFirstName.Text = user.FirstName;
                        txtLastName.Text = user.LastName;
                        txtMiddleName.Text = user.MiddleName;
                        txtUserName.Text = user.UserName;
                        cboRoles.SelectedItem = LocalUtils.GetSelectedItemX(cboRoles.Items, user.Roles.First().RoleID.ToString());
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
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
                var grid = gridUsers;

                if (grid.SelectedRows.Count > 0)
                {
                    _userID = int.Parse(grid.SelectedRows[0].Cells[0].Value.ToString());
                    if (_userID != 0)
                    {
                        page.SetPage(tabUserDetail);
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
