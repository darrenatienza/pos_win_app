
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
    public partial class frmUpdateProductQuantity : Form
    {
        public event EventHandler OnProductUpdated;

        int productID;
        private string action;
        public FormAction FormAction { get; set; }


        public frmUpdateProductQuantity(int productID, string action)
        {
            this.productID = productID;
            this.action = action;
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
        private bool ValidatedFields()
        {

            var ctrlTextBoxes2 = LocalUtils.GetAll(tabProductDetail, typeof(BunifuTextBox))
                       .Where(c => c.CausesValidation == true).OrderBy(c => c.TabIndex);
            foreach (BunifuTextBox item in ctrlTextBoxes2)
            {

                if (item.Text == string.Empty)
                {
                    LocalUtils.ShowValidationFailedMessage(this);
                    return false;
                }
    
            }
            var ctrlDropdown = LocalUtils.GetAll(tabProductDetail, typeof(Bunifu.UI.WinForms.BunifuDropdown))
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
        private void Save()
        {
            try
            {
                if (!ValidatedFields())
                {
                    return;
                }
                var model = new ProductLogModel();
                model.Date = dtDate.Value;
                model.Quantity = Utils.ConvertToInteger(txtQuantity.Text);
                model.Remarks = txtRemarks.Text;
                model.Action = action;
                Factories.CreateProductLog().Update(productID, model);
                ProductUpdated();
                this.Close();
                
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
            lblTitle.Text = lblTitle.Text + " - " + action;
        }

       

       
        private void ResetInputs()
        {
            var textboxes = LocalUtils.GetAll(tabProductDetail, typeof(BunifuTextBox));
            foreach (BunifuTextBox item in textboxes)
            {
                item.Text = string.Empty;
            }
            var comboboxes = LocalUtils.GetAll(tabProductDetail, typeof(Bunifu.UI.WinForms.BunifuDropdown));
            foreach (Bunifu.UI.WinForms.BunifuDropdown item in comboboxes)
            {
                item.SelectedIndex = -1;
                item.Enabled = true;
            }
            var dates = LocalUtils.GetAll(tabProductDetail, typeof(BunifuDatepicker));
            foreach (BunifuDatepicker item in dates)
            {
                item.Value = DateTime.UtcNow;
            }
        }

        
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            txtQuantity.Text = Utils.ConvertToInteger(txtQuantity.Text).ToString();
        }


        private void ProductUpdated()
        {
            var e = OnProductUpdated;
            if (e != null)
            {
                e.Invoke(this, null);
            }
        }
        void SetData()
        {
            try
            {
                var model = Factories.CreateProductLog().GetProduct(productID);
            }
            catch (Exception ex)
            {

                LocalUtils.ShowErrorMessage(this,ex.Message);
            }
        }
       
    }
}
