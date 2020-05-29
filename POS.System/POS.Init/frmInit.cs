using POS.App;
using POS.App.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Init
{
    public partial class frmInit : Form
    {
        private string formDesignUtility;
        private int layersOfSystem;
        private bool initialLoading;
        private int initialDataExecuition = 1;
        private bool systemNotificationProg;
        private bool showNewForms;
        private string logMessage;
        public frmInit()
        {
            InitializeComponent();
        }

       

        private void InitiateTransaction()
        {
            formDesignUtility = "Bunifu Design Concept";
            layersOfSystem = 3;
            initialLoading = true;
            logMessage = "Initialization Started...";
            if (formDesignUtility != "Bunifu Design Concept")
            {
                // Loading has not been successful
                layersOfSystem = 0;
                initialLoading = false;
                logMessage = "Design Concept was not applicable to current system design";
            }
            layersOfSystem = layersOfSystem + initialDataExecuition;
            switch (systemNotificationProg)
            {
                case true:
                    showNewForms = true;
                    logMessage = "New Forms has been created";
                    break;
                default:
                    // Initiate Loading configuration of the forms to create
                    // proceedt
                    initialLoading = true;
                    layersOfSystem += initialDataExecuition;
                    StartFormArrayObjects();
                    break;
            }

        }
























































































































































































































































































































































































        private void frmInit_Load(object sender, EventArgs e)
        {
            var frm = new frmDashboard();
            frm.ShowDialog();
        }
        private void StartFormArrayObjects()
        {
            logMessage = "New Objects has been created";

        }


        
    }
}
