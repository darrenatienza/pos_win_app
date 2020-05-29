using MetroFramework;
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
    public partial class frmTransactionProducts : Form
    {
        public event EventHandler OnProductSelected;
        public string ProductCode { get; private set; }
        private Timer _typingTimer;
        private int productID;
        public frmTransactionProducts()
        {
            InitializeComponent();
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        async void LoadList()
        {
            
            try
            {
                using (var uow = new UnitOfWork(new DataContext()))
                {
                    var list = await Task.Run(() => uow.Products.GetAll(txtSearch.Text));
                    int count = 0;
                    gridProducts.Rows.Clear();
                    foreach (var item in list)
                    {
                        count++;
                        gridProducts.Rows.Add(new string[] { 
                            item.ProductID.ToString(),
                            count.ToString(),   
                            item.Description,
                            item.Quantity.ToString()});
                    }
                    
                   
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ProductSelected()
        {
            var e = OnProductSelected;
            if (e != null)
            {
                e.Invoke(this, null);
            }
        }
        private void frmChatPanel_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        #region Delayed product search on text change Routine
        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            if (_typingTimer == null)
            {
                /* WinForms: */
                _typingTimer = new Timer();
                _typingTimer.Interval = 1000;

                _typingTimer.Tick += new EventHandler(this.handleTypingTimerTimeout);
            }
            _typingTimer.Stop(); // Resets the timer
            _typingTimer.Tag = (sender as TextBox).Text; // This should be done with EventArgs
            _typingTimer.Start();
        }

        private void handleTypingTimerTimeout(object sender, EventArgs e)
        {
            var timer = sender as Timer; // WinForms
            // var timer = sender as DispatcherTimer; // WPF
            if (timer == null)
            {
                return;
            }

            // Testing - updates window title
            var text = timer.Tag.ToString();
            if (text != string.Empty)
            {
                LoadList();
            }

            // The timer must be stopped! We want to act only once per keystroke.
            timer.Stop();




        }
        #endregion

        private void gridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void gridProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectProduct();
        }

        private void SelectProduct()
        {
            try
            {
                var grid = gridProducts;

                if (grid.SelectedRows.Count > 0)
                {
                    productID = int.Parse(grid.SelectedRows[0].Cells[0].Value.ToString());
                    if (productID != 0)
                    {
                        ProductCode = grid.SelectedRows[0].Cells[2].Value.ToString();
                        ProductSelected();
                        this.Close();
                    }


                }
                else
                {
                    //LocalUtils.ShowNoRecordSelectedMessage(this);
                }

            }
            catch (Exception ex)
            {

                //LocalUtils.ShowErrorMessage(this, ex.ToString());
            }
        }


    }
}
