using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PmpLaserTagUI
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
            // Handling the QueryControl event that will populate all automatically generated Documents
            this.windowsUIView1.QueryControl += windowsUIView1_QueryControl;
        }

        // Assigning a required content for each auto generated Document
        void windowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {

            if (e.Document == frmSettingsDocument)
                e.Control = new PmpLaserTagUI.frmSettings();
            if (e.Document == frmGameDocument)
                e.Control = new PmpLaserTagUI.frmGame();
            if (e.Document == frmReportDocument)
                e.Control = new PmpLaserTagUI.frmReport();
            if (e.Control == null)
                e.Control = new System.Windows.Forms.Control();
        }
    }
}