using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using MagentoApp.Report;

namespace MagentoApp
{
    public partial class PrintOrderForm : Form
    {
        private static DataTable dt = new DataTable();
        private static DataSet dataSet = new DataSet();

        public PrintOrderForm()
        {
            InitializeComponent();
        }

        private void PrintOrderForm_Load(object sender, EventArgs e)
        {

            try
            {
                string salesId = InvoiceParameter.SalesId;

                if (!salesId.Equals(""))
                {
                    ReportDocument cryRpt = new ReportDocument();
                    cryRpt.Load(@"Report\InvoiceReport.rpt");

                    ParameterFieldDefinitions crParameterFieldDefinitions;
                    ParameterFieldDefinition crParameterFieldDefinition;
                    ParameterValues crParameterValues = new ParameterValues();
                    ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                    crParameterDiscreteValue.Value = salesId;
                    crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["OrderId"];
                    crParameterValues = crParameterFieldDefinition.CurrentValues;

                    crParameterValues.Clear();
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    crystalReportViewerInvoice.ReportSource = cryRpt;
                    crystalReportViewerInvoice.Refresh();

                }
                else
                {
                    ReportDocument cryRpt = new ReportDocument();
                    cryRpt.Load(@"Report\InvoiceReport.rpt");
                    crystalReportViewerInvoice.ReportSource = cryRpt;
                    crystalReportViewerInvoice.Refresh();


                }

                

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            


        }
    }
}
