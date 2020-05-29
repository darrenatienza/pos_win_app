
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuTextbox;
using Helpers;
using MetroFramework;
using POS.App.Helpers;
using POS.App.UserControls;
using POS.App.UserControls.MyControls;
using POS.Logic;
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
    public partial class frmProductLog : Form
    {


        private int _productID;
        public FormAction FormAction { get; set; }


        public frmProductLog(int productID)
        {
            _productID = productID;
            InitializeComponent();
        }
        
        private void pnlContents_Paint(object sender, PaintEventArgs e)
        {
            
        }

       
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditsSupplier_Load(object sender, EventArgs e)
        {

            LoadProducts();
            SetData();
            
        }

        private void SetData()
        {
            var product = Factories.CreateProducts().Get(_productID);
            lblProductName.Text += " " + product.Description;
        }

        async void LoadProducts()
        {
            try
            {
                await Task.Delay(1000);
                var products = await Task.Run(() =>Factories.CreateProductLog().GetAll(_productID,""));
                int count = 0;
                gridProductLogs.Rows.Clear();
                foreach (var item in products)
                {
                    count++;
                    gridProductLogs.Rows.Add(new string[] {
                            item.ProductID.ToString(),
                            count.ToString(),
                            item.Date.ToShortDateString(),
                            item.ProductName,
                            item.Quantity.ToString(),
                            item.Action,
                            item.Remarks
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void gridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var grid = gridProductLogs;

                if (grid.SelectedRows.Count > 0)
                {
                    var id = int.Parse(grid.SelectedRows[0].Cells[0].Value.ToString());
                    if (id != 0)
                    {
                        //var model = Factories.CreateProducts().Get(_productID);
                        
                      
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

       

       

        
    }
}
