using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace POS.App.UserControls.MyControls
{
    public partial class MyDataGridView : BunifuDataGridView
    {
        public MyDataGridView()
        {
            InitializeComponent();
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            Theme = PresetThemes.ForestGreen;
            AllowCustomTheming = true;
            CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            

        }
        public int RecordID
        {
            get
            {
                if (this.SelectedRows[0].Cells[0].Value == null || this.SelectedRows[0].Cells[0].Value.ToString() == string.Empty)
                {
                    return 0;
                }
                else
                {
                    return int.Parse(this.SelectedRows[0].Cells[0].Value.ToString());
                }
                 
            }

           
               
            
        }
    }
}
