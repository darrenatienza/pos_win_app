using Bunifu.UI.WinForms.BunifuTextbox;
using Helpers;
using MetroFramework;
using POS.App.Helpers;
using POS.App.UserControls.MyControls;
using POS.Logic;
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
    public partial class frmQuantityUpdate : Form
    {
        public event EventHandler OnProductSelected;
        public string ProductCode { get; private set; }
       
        private int posTransactionProductID;
        private int initialQuantity;
        private bool initialLoading = true;
        private int initialAvailable;
        public frmQuantityUpdate()
        {
            InitializeComponent();
        }
        public frmQuantityUpdate(int productTransactionID)
        {
            this.posTransactionProductID = productTransactionID;
            
            InitializeComponent();
            
            
        }
        
        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
             
        }
        private void ProductUpdated()
        {
            var e = OnProductSelected;
            if (e != null)
            {
                e.Invoke(this, null);
            }
        }
        private void frm_Load(object sender, EventArgs e)
        {
            
            SetData();
            initialLoading = false;
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       
        
        private void control_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void control_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }
        void SetData()
        {
            try
            {
                var model = Factories.CreatePosTransaction().GetProductTransaction(posTransactionProductID);
                lblAvailableQuantity.Text =  model.AvailableQuantity.ToString();
                lblPrice.Text = model.Price.ToString();
                lblProductName.Text = model.ProductName;
                
                txtQuantity.Text = model.PurchaseQuantity.ToString();
  
 
                lblTotal.Text =  model.Total.ToString();

                txtQuantity.SelectAll();
                initialQuantity = model.PurchaseQuantity;
                initialAvailable = model.AvailableQuantity;

                

            }
            catch (Exception ex)
            {

                LocalUtils.ShowErrorMessage(this, ex.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = (Utils.ConvertToInteger(txtQuantity.Text) + 1).ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = (Utils.ConvertToInteger(txtQuantity.Text) - 1).ToString();
        }

        private void txtQuantity_TextChange(object sender, EventArgs e)
        {
            LocalUtils.ShowSaveMessage(this);
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            Compute();
        }

        private void Compute()
        {
            
            
            var currentPurchaseQuantity = Utils.ConvertToInteger(txtQuantity.Text);
            var unitPrice = Utils.ConvertToDouble(lblPrice.Text);
            var model = Factories.CreatePosTransaction().ComputeUpdateQuantity(initialAvailable,initialQuantity, currentPurchaseQuantity, unitPrice);
            lblAvailableQuantity.Text = model.AvailableQuantity.ToString();
            lblTotal.Text = model.TotalAmount.ToString();
            txtQuantity.SelectionStart = txtQuantity.Text.Length;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            try
            {
                ValidateField();
                var quantity = Utils.ConvertToInteger(txtQuantity.Text);
                Factories.CreatePosTransaction().UpdateQuantity(posTransactionProductID, quantity);
                ProductUpdated();
                this.Close();
            }
            catch (Exception ex)
            {

                LocalUtils.ShowErrorMessage(this, ex.Message);
            }
        }

        private void ValidateField()
        {
            if (txtQuantity.Text == "" || txtQuantity.Text == "0")
            {
                throw new ApplicationException("Quantity must be provided!");
            }
        }

        private void txtQuantity_TextChanged_1(object sender, EventArgs e)
        {
            if (!initialLoading)
            {
                Compute();
            }
            
        }

    }
}
