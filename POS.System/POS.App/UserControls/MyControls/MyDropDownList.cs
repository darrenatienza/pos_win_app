using Bunifu.UI.WinForms;
using POS.App.Helpers;
using POS.Queries.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.App.UserControls.MyControls
{
    public class MyDropDownList : BunifuDropdown
    {
        public MyDropDownList()
        {
            Color = System.Drawing.Color.Gray;
            IndicatorColor = System.Drawing.Color.Gray;
            ForeColor = System.Drawing.Color.Gray;
            ItemHighLightColor = System.Drawing.Color.LightGray;
            ItemForeColor = System.Drawing.Color.DarkGray;
        }
        public void AddItems(ItemX item)
        {
            this.Items.Add(item);
        }
        public void UpdateIndex()
        {
            int index = -1;
            foreach (ItemX item in this.Items)
            {
                index++;
                if (item.Name == this.Text)
                {
                    this.SelectedIndex = index;
                }
            }
        }

        
    }
}
