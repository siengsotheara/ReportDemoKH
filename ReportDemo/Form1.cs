using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyy-MM" + "-01"));

            PrinterSettings printer = new PrinterSettings();
            string file_path = Application.StartupPath + @"\Report\ReportREFInvalidCustomer.rpt";

            CRAXDDRT.Application crxApp = new CRAXDDRT.Application();
            CRAXDDRT.Report crxReport = new CRAXDDRT.Report();
            crxReport = crxApp.OpenReport(file_path, null);
            foreach (CRAXDDRT.DatabaseTable crxdt in crxReport.Database.Tables)
            {
                crxdt.SetLogOnInfo(@".\SQLEXPRESS", "EPower", "sa", "underadmin");
            }
            crxReport.SelectPrinter("", printer.PrinterName, "");
            crxReport.ParameterFields.GetItemByName("@COMPANY_NAME", Missing.Value).AddCurrentValue("អ៊ី-ផៅវើ E-Power");
            crxReport.ParameterFields.GetItemByName("@COMPANY_ADDRESS", Missing.Value).AddCurrentValue("ផ្ទះលេខ១៨ ផ្លូវលេខ ៦១៨​​ ខណ្ឌទួលគោក រាជធានីភ្នំពេញ");
            crxReport.ParameterFields.GetItemByName("@LOGIN_NAME", Missing.Value).AddCurrentValue("admin");
            crxReport.ParameterFields.GetItemByName("@DATA_MONTH", Missing.Value).AddCurrentValue(dt);

            crxReport.PaperOrientation = CRAXDDRT.CRPaperOrientation.crPortrait;
            crxReport.PaperSize = CRAXDDRT.CRPaperSize.crPaperA4;
            axCrystalActiveXReportViewer1.ReportSource = crxReport;
            axCrystalActiveXReportViewer1.ViewReport();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboConnectionType.SelectedIndex = 0;
            cboCurrency.SelectedIndex = 0;
            cboCustomerType.SelectedIndex = 0;
            cboPowerType.SelectedIndex = 0;
        }
    }
}
