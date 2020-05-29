using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.UI.WinForms.BunifuTextbox;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using POS.App.Helpers;
namespace POS.App.UserControls.MyControls
{
    public class MyTextBox : BunifuTextBox
    {
        public bool IsPassword { get; set; }
        public MyDataType MyDataType { get; set; }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
        }
        public int IntValue
        {
            get
            {
                int result = 0;

                if (MyDataType == Helpers.MyDataType.Integer)
                {

                    if (!int.TryParse(this.Text, out result))
                    {
                        result = 0;
                    }
                }
                return result;
            }
        }
        public double DoubleValue
        {
            get
            {
                double result = 0.0;

                if (MyDataType == Helpers.MyDataType.Double)
                {

                    if (!double.TryParse(this.Text, out result))
                    {
                        result = 0;
                    }
                }
                return result;
            }
        }
        private string toolTipText;
        public string ToolTipText
        {
            get
            {
                
                return toolTipText;
            }
            set
            {
                if (PlaceholderText != String.Empty)
                {
                    toolTipText = PlaceholderText;
                }
                else
                {
                    toolTipText = value;
                }
            }
        }
        
        public MyTextBox()
        {
           
            OnHoverState.BorderColor = Color.FromArgb(0, 192, 0);
            OnActiveState.BorderColor = Color.Lime;
            OnIdleState.BorderColor = Color.Silver;
        }

       
        public void Error(bool isError)
        {

            if (isError)
            {
                BackColor = Color.Red;
            }
            else
            {
                BackColor = Color.Transparent;
            }
           
           
           

        }

        public string PasswordName { get; set; }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyTextBox));
            this.SuspendLayout();
            // 
            // MyTextBox
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Lines = new string[0];
            this.Name = "MyTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public void SelectAllText()
        {
            this.SelectionStart = 0;
            this.SelectionLength = this.Text.Length;
        }

        
    }
}
