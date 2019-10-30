
using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using MagentoApp.API.Error;
using System.Drawing;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;
using MagentoApp.Model.Db;
using Microsoft.Office.Interop.Excel;
using MagentoApp.ReadWriteFromExcel;
using MagentoApp.Report;

namespace MagentoApp
{
    public partial class MainForm : Form
    {
        private static RestClient Client { get; set; }
        private string Token { get; set; }        

        private string BASE_URL;
        private static readonly string STATE = "Gujarat";        
        private static MainForm form;
        private static MasterItem masterItem = new MasterItem();
        private static List<MasterItem> masterItemList = new List<MasterItem>();
        private static System.Data.DataTable dt = new System.Data.DataTable();
        private static DataSet dataSet = new DataSet();
               

        public MainForm()
        {
            InitializeComponent();
        }


        private void Form_Load(object sender, EventArgs e)
        {
            form = this;
            
            //get data from config file
            string password = ConfigurationManager.AppSettings["userPassword"];
            string username = ConfigurationManager.AppSettings["userName"];
            BASE_URL = ConfigurationManager.AppSettings["URL"];

            //set date format
            dtpFromDate.Format = DateTimePickerFormat.Custom;
            dtpToDate.Format = DateTimePickerFormat.Custom;
            dtpOrderDate.Format = DateTimePickerFormat.Custom;
            dtpFromDate.CustomFormat = "yyyy-MM-dd";
            dtpToDate.CustomFormat = "yyyy-MM-dd";
            dtpOrderDate.CustomFormat = "yyyy-MM-dd";

            //initilize rest client
            SetClient(BASE_URL);

            //get token from server
            Token = ReplaceInvertedComma(GetAdminToken(username, password));            

            //create data grid view header
            dt.Columns.AddRange(new DataColumn[35]
            {
                new DataColumn("Bill No", typeof(string)),
                new DataColumn("Bill Date", typeof(string)),
                new DataColumn("Voucher Type",typeof(string)),
                new DataColumn("Godown", typeof(string)),
                new DataColumn("Customer Name", typeof(string)),
                new DataColumn("Address 1",typeof(string)),
                new DataColumn("Address 2", typeof(string)),
                new DataColumn("Address 3", typeof(string)),
                new DataColumn("Address 4",typeof(string)),
                new DataColumn("Country", typeof(string)),
                new DataColumn("State", typeof(string)),
                new DataColumn("GST Registration Type",typeof(string)),
                new DataColumn("GST No", typeof(string)),
                new DataColumn("Sales Ledger", typeof(string)),
                new DataColumn("Product Name",typeof(string)),
                new DataColumn("Batch No", typeof(string)),
                new DataColumn("Tax Rate", typeof(string)),
                new DataColumn("Manufacturing Date",typeof(string)),
                new DataColumn("Expiry Date", typeof(string)),
                new DataColumn("Quantity", typeof(string)),
                new DataColumn("Unit",typeof(string)),
                new DataColumn("Rate (Inclusive of Tax)", typeof(string)),
                new DataColumn("Rate (Basic)", typeof(string)),
                new DataColumn("Disc %",typeof(string)),
                new DataColumn("Amount", typeof(string)),
                new DataColumn("Delivery Charges", typeof(string)),
                new DataColumn("CGST",typeof(string)),
                new DataColumn("SGST", typeof(string)),
                new DataColumn("IGST", typeof(string)),
                new DataColumn("Round Off",typeof(string)),
                new DataColumn("Total Amount", typeof(string)),
                new DataColumn("Credit / Debit Card Ledger Name", typeof(string)),
                new DataColumn("Cash Ledger Name",typeof(string)),
                new DataColumn("Narration",typeof(string)),
                new DataColumn("SKU",typeof(string))
                
            });


        }

        private  void SetClient(string url)
        {
            Client = new RestClient(url);            

        }

        static string ReplaceInvertedComma(string data)
        {
            return data.Replace('"', ' ').Trim();            
        }
        
        private  string  GetAdminToken(string username, string password)
        {
            IRestResponse response = null;

            try
            {
                var request = CreateTokenRequest("/rest/V1/integration/admin/token", Method.POST);
                var user = new UserCredential();
                user.username = username;
                user.password = password;

                var json = JsonConvert.SerializeObject(user, Formatting.Indented);

                request.AddParameter("application/json", json, ParameterType.RequestBody);

                response = Client.Execute(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return response.Content;
                }
                else
                {
                    return response.Content;
                }

            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }

            return response.Content;


        }

        private RestRequest CreateTokenRequest(string endpoint,Method method)
        {
            var request = new RestRequest(endpoint, method);
            request.RequestFormat = DataFormat.Json;
            return request;
        }

        static  RestRequest CreateRequest(string endpoint, Method method,string token)
        {
            var request = new RestRequest(endpoint, method);
            try
            {                
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Authorization", "Bearer " + token);
                request.AddHeader("Content-Type", "application / json");
                return request;

            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }

            return request;

        }

        static void GetOrderById(string token,string orderId)
        {
            try
            {
                var request = CreateRequest("/rest/V1/orders/" + orderId, Method.GET, token);
                var response = Client.Execute(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    //var data =  response.Content;
                    OrderItem result = new OrderItem();
                    M2SalesOrderBillingAddress addressList = new M2SalesOrderBillingAddress();

                    //M2Invoice invoice = JsonConvert.DeserializeObject<M2Invoice>(response.Content);
                    M2SalesOrder order = JsonConvert.DeserializeObject<M2SalesOrder>(response.Content);

                    addressList = order.billing_address;
                    List<OrderItem> data = new List<OrderItem>(order.items);

                    foreach (var item in data)
                    {
                        result = item;

                        //MainForm form = new MainForm();
                        AddToGridByOrder(form.dgv, result, order, addressList);

                    }

                }
                else
                {
                    M2Error m2Error = JsonConvert.DeserializeObject<M2Error>(response.Content);
                    MessageBox.Show(m2Error.message, "Error " + response.StatusCode);
                }

            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
            

        }

        static void GetOrderByDate(string token, string order_date, string status, string date_condetion)
        {
            try
            {
                string searchCiretia = $"/rest/V1/orders?searchCriteria[filter_groups][0][filters][0][field]=created_at&searchCriteria[filter_groups][0][filters][0][value]={order_date} 00:00:00&searchCriteria[filter_groups][0][filters][0][condition_type]={date_condetion}&searchCriteria[filter_groups][1][filters][1][field]=status&searchCriteria[filter_groups][1][filters][1][value]=%25{status}%25&searchCriteria[filter_groups][1][filters][1][condition_type]=like";
                var request = CreateRequest(searchCiretia, Method.GET, token);
                var response = Client.Execute(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    //var data =  response.Content;
                    M2OrderItem result = new M2OrderItem();
                    M2OrderByDateBillingAddress addressList = new M2OrderByDateBillingAddress();
                    M2OrderByDatesItems m2OrderByDatesItems = new M2OrderByDatesItems();

                    string content = response.Content;

                    M2OrderByDates order = JsonConvert.DeserializeObject<M2OrderByDates>(content);
                    //check the total order
                    if (order.total_count == 0)
                    {
                        MessageBox.Show("Sorry no data found", "No Record");

                    }
                    else
                    {
                        List<M2OrderByDatesItems> datas = new List<M2OrderByDatesItems>(order.items);

                        foreach (var data in datas)
                        {
                            List<M2OrderItem> items = new List<M2OrderItem>(data.items);
                            addressList = data.billing_address;
                            m2OrderByDatesItems = data;


                            foreach (var item in items)
                            {

                                AddToGridByDate(form.dgv, item, m2OrderByDatesItems, addressList);

                            }

                        }

                    }

                }
                else
                {
                    M2Error m2Error = JsonConvert.DeserializeObject<M2Error>(response.Content);
                    MessageBox.Show(m2Error.message, "Error " + response.StatusCode);
                }

            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
            
        }

        static void GetOrderByFromDateToDate(string token, string from_date, string to_date, string status)
        {
            try
            {
                string searchCiretia;

                if (status.Equals("All"))
                {
                    searchCiretia = $"/rest/V1/orders?searchCriteria[filter_groups][0][filters][0][field]=created_at&searchCriteria[filter_groups][0][filters][0][value]={from_date} 00:00:00&searchCriteria[filter_groups][0][filters][0][condition_type]=gteq&searchCriteria[filter_groups][1][filters][1][field]=created_at&searchCriteria[filter_groups][1][filters][1][value]={to_date} 00:00:00&searchCriteria[filter_groups][1][filters][1][condition_type]=lteq";

                }
                else
                {
                    searchCiretia = $"/rest/V1/orders?searchCriteria[filter_groups][0][filters][0][field]=created_at&searchCriteria[filter_groups][0][filters][0][value]={from_date} 00:00:00&searchCriteria[filter_groups][0][filters][0][condition_type]=gteq&searchCriteria[filter_groups][1][filters][1][field]=created_at&searchCriteria[filter_groups][1][filters][1][value]={to_date} 00:00:00&searchCriteria[filter_groups][1][filters][1][condition_type]=lteq&searchCriteria[filter_groups][2][filters][2][field]=status&searchCriteria[filter_groups][2][filters][2][value]=%25processing%25&searchCriteria[filter_groups][2][filters][2][condition_type]=like";

                }

                var request = CreateRequest(searchCiretia, Method.GET, token);
                var response = Client.Execute(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    //var data =  response.Content;
                    M2OrderItem result = new M2OrderItem();
                    M2OrderByDateBillingAddress addressList = new M2OrderByDateBillingAddress();
                    M2OrderByDatesItems m2OrderByDatesItems = new M2OrderByDatesItems();

                    string content = response.Content;

                    M2OrderByDates order = JsonConvert.DeserializeObject<M2OrderByDates>(content);
                    //check the total order
                    if (order.total_count == 0)
                    {
                        MessageBox.Show("Sorry no data found", "No Record");

                    }
                    else
                    {
                        List<M2OrderByDatesItems> datas = new List<M2OrderByDatesItems>(order.items);

                        foreach (var data in datas)
                        {
                            List<M2OrderItem> items = new List<M2OrderItem>(data.items);
                            addressList = data.billing_address;
                            m2OrderByDatesItems = data;


                            foreach (var item in items)
                            {

                                AddToGridByDate(form.dgv, item, m2OrderByDatesItems, addressList);

                            }

                        }

                    }

                }
                else
                {
                    M2Error m2Error = JsonConvert.DeserializeObject<M2Error>(response.Content);
                    MessageBox.Show(m2Error.message, "Error " + response.StatusCode);
                }

            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }                        
           
        }

        static void AddToGridByOrder(DataGridView grid, OrderItem item,M2SalesOrder invoice, M2SalesOrderBillingAddress billingAddress)
        {
            try
            {
                string sku = item.sku;
                double CGST, SGST, BASE_AMOUNT, RateBasic, DeliveryCharge, BaseDiscountAmount, LineAmount, InvoiceAmount;
                string IGST, TaxRate;
                string customerName,customerLastName;
                customerName = invoice.customer_firstname;
                customerLastName = invoice.customer_lastname;
                if (customerName == null)
                {
                    customerName = billingAddress.firstname;
                    customerLastName = billingAddress.lastname;
                }

                ReadFromExcelFile(sku);
                TaxRate = masterItem.IGST + "%";
                IGST = masterItem.IGST;
                CGST = masterItem.CGST;
                SGST = masterItem.SGST;

                StringBuilder stringBuilder = new StringBuilder();
                List<string> streets = new List<string>(billingAddress.street);
                foreach (var street in streets)
                {
                    stringBuilder.Append(street);
                }

                BASE_AMOUNT = item.base_row_total_incl_tax;
                //discount amount per line
                BaseDiscountAmount = item.base_discount_amount;

                //get the base amount before tax
                if (BaseDiscountAmount > 0)
                {
                    LineAmount = BASE_AMOUNT - BaseDiscountAmount;
                    //line amount before tax
                    RateBasic = LineAmount * 100 / (100 + Double.Parse(masterItem.IGST));

                }
                else
                {
                    LineAmount = BASE_AMOUNT;
                    //line amount before tax
                    RateBasic = BASE_AMOUNT * 100 / (100 + Double.Parse(masterItem.IGST));
                }

                DeliveryCharge = invoice.shipping_amount;

                //check billing state
                if (billingAddress.region.Equals(STATE))
                {
                    //calculate taxe on base rate + delivery charge
                    CGST = (RateBasic + DeliveryCharge) * CGST / 100;
                    SGST = (RateBasic + DeliveryCharge) * SGST / 100;
                    IGST = "0";
                    //invoice amount 
                    InvoiceAmount = RateBasic + DeliveryCharge + CGST + SGST;
                }
                else
                {
                    CGST = 0.0;
                    SGST = 0.0;
                    //calculate taxe on base rate + delivery charge
                    IGST = ((RateBasic + DeliveryCharge) * Double.Parse(masterItem.IGST) / 100).ToString("#.##");
                    //invoice amount 
                    InvoiceAmount = RateBasic + DeliveryCharge + Double.Parse(IGST);
                }

                //add row to data table
                dt.Rows.Add(invoice.increment_id, invoice.created_at, "POS Invoice", "Main Location", customerName + " " + customerLastName, stringBuilder.ToString(),
                    "", "", "", billingAddress.country_id, billingAddress.region, "", "", "POS Sales", item.name, "", TaxRate, "", "", item.qty_ordered, "NO",
                    item.base_price_incl_tax, RateBasic.ToString("#.##"), item.discount_percent, LineAmount, invoice.shipping_amount, CGST.ToString("#.##"),
                    SGST.ToString("#.##"), IGST, "", InvoiceAmount.ToString("#.##"), "", "",sku);

                // set data grid view data source
                grid.DataSource = dt;
                grid.Columns["SKU"].Visible = false;
                grid.AllowUserToAddRows = false;
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message, "Error");
            }
            

        }

        static void AddToGridByDate(DataGridView grid, M2OrderItem item, M2OrderByDatesItems invoice, M2OrderByDateBillingAddress billingAddress)
        {
            try
            {
                string sku = item.sku;
                double CGST, SGST, BASE_AMOUNT, RateBasic,DeliveryCharge,BaseDiscountAmount, LineAmount,InvoiceAmount;
                string IGST, TaxRate;
                string customerName, customerLastName;
                customerName = invoice.customer_firstname;
                customerLastName = invoice.customer_lastname;
                if (customerName == null)
                {
                    customerName = billingAddress.firstname;
                    customerLastName = billingAddress.lastname;
                }

                ReadFromExcelFile(sku);
                TaxRate = masterItem.IGST + "%";
                IGST = masterItem.IGST;
                CGST = masterItem.CGST;
                SGST = masterItem.SGST;

                StringBuilder stringBuilder = new StringBuilder();
                List<string> streets = new List<string>(billingAddress.street);
                foreach (var street in streets)
                {
                    stringBuilder.Append(street);
                }

                BASE_AMOUNT = item.base_row_total_incl_tax;
                //discount amount per line
                BaseDiscountAmount = item.base_discount_amount;

                //get the base amount before tax
                if (BaseDiscountAmount > 0)
                {
                    LineAmount = BASE_AMOUNT - BaseDiscountAmount;
                    //line amount before tax
                    RateBasic = LineAmount * 100 / (100 + Double.Parse(masterItem.IGST));

                }
                else
                {
                    LineAmount = BASE_AMOUNT;
                    //line amount before tax
                    RateBasic = BASE_AMOUNT * 100 / (100 + Double.Parse(masterItem.IGST));
                }
                
                DeliveryCharge = invoice.shipping_amount;
                
                //check billing state
                if (billingAddress.region.Equals(STATE))
                {
                    //calculate taxe on base rate + delivery charge
                    CGST = (RateBasic + DeliveryCharge) * CGST / 100;
                    SGST = (RateBasic + DeliveryCharge) * SGST / 100;
                    IGST = "0";
                    //invoice amount 
                    InvoiceAmount = RateBasic + DeliveryCharge + CGST + SGST;
                }
                else
                {
                    CGST = 0;
                    SGST = 0;
                    //calculate taxe on base rate + delivery charge
                    IGST = ((RateBasic + DeliveryCharge) * Double.Parse(masterItem.IGST) / 100).ToString("#.##");
                    //invoice amount 
                    InvoiceAmount = RateBasic + DeliveryCharge + Double.Parse(IGST);
                }
                

                //add row to data table
                dt.Rows.Add(invoice.increment_id, invoice.created_at, "POS Invoice", "Main Location", customerName + " " + customerLastName, stringBuilder.ToString(),
                    "", "", "", billingAddress.country_id, billingAddress.region, "", "", "POS Sales", item.name, "", TaxRate, "", "", item.qty_ordered, "NO",
                    item.base_price_incl_tax, RateBasic.ToString("#.##"), item.discount_percent, LineAmount, invoice.shipping_amount, CGST.ToString("#.##"),
                    SGST.ToString("#.##"), IGST, "", InvoiceAmount.ToString("#.##"), "", "","",sku);
                
                // set data grid view data source
                grid.DataSource = dt;
                grid.Columns["SKU"].Visible = false;
                grid.AllowUserToAddRows = false;
                

            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message,"Error");
            }
            

        }

        
        private static List<MasterItem> ReadFromExcelFile(string searchItem)
        {
            int i = 0;
            var ep = new ExcelPackage(new FileInfo(@"C:\MagentoSetting\ItemMaster\ItemMaster.xlsx"));
            var ws = ep.Workbook.Worksheets["Sheet1"];
            try
            {               
                for (int rw = 1; rw <= ws.Dimension.End.Row; rw++)
                {
                    if (rw > 1)
                    {
                        masterItem.Item_Code = ws.Cells[rw, 1].Value.ToString();
                        masterItem.Product_Name = ws.Cells[rw, 2].Value.ToString();
                        masterItem.Packing_Size = ws.Cells[rw, 3].Value.ToString();
                        masterItem.MRP = Double.Parse(ws.Cells[rw, 4].Value.ToString());
                        masterItem.IGST = ws.Cells[rw, 5].Value.ToString();
                        masterItem.CGST = Double.Parse(ws.Cells[rw, 6].Value.ToString());
                        masterItem.SGST = Double.Parse(ws.Cells[rw, 7].Value.ToString());

                        if (masterItem.Item_Code.Equals(searchItem))
                        {
                            masterItemList.Insert(i, masterItem);
                            return masterItemList;

                        }
                    }
                }
                
                return masterItemList;

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                ep.Dispose();

            }
            return masterItemList;
        }
        
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            GetOrderById(Token, id);
        }

        private void BtnGetOrderByDate_Click(object sender, EventArgs e)
        {
            string order_date = dtpOrderDate.Text;
            string order_status = cbStatus.SelectedItem.ToString();
            string date_condetion = cbCondetion.SelectedItem.ToString();
            GetOrderByDate(Token,order_date, order_status, date_condetion);
        }

        private void BtnGetOrderByFromToDate_Click(object sender, EventArgs e)
        {
            string from_date = dtpFromDate.Text;
            string to_date = dtpToDate.Text;
            string order_status = cbFTStatus.SelectedItem.ToString();
            GetOrderByFromDateToDate(Token, from_date, to_date, order_status);
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                //ExportToCSV(form.dgv); 
                /*DataTable dataTable = dt.Copy();
                dataSet.Tables.Add(dataTable);
                GenerateExcel(form.dgv, dataSet);*/

                ExportToExcelFile.ExportToExcel(form.dgv);
                

            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message, "Error");
            }

        }
      
        private void BtnClear_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dataSet.Tables.Clear();
        }
    
        private void BtnGeneratePDF_Click(object sender, EventArgs e)
        {
            InvoiceParameter.SalesId = "";
            PrintOrderForm printOrderForm = new PrintOrderForm();
            printOrderForm.Show();
            
        }

        private void Dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv.Columns[e.ColumnIndex].Name == "Round Off")
                {
                    DataGridViewRow row = dgv.Rows[e.RowIndex];

                    if (!string.IsNullOrEmpty(row.Cells[29].Value.ToString()))
                    {                        
                        double RoundOffcellValue = Double.Parse(row.Cells[29].Value.ToString());
                        double TotalAmtcellValue = Double.Parse(row.Cells[30].Value.ToString());
                        var newTotalAmt = TotalAmtcellValue + RoundOffcellValue;
                        row.Cells[30].Value = newTotalAmt.ToString("#.##");

                        dgv.Invalidate();
                    };                    
                }                

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            
        }

        private void Dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                var cellValue = row.Cells[0].Value;

            }

        }

        private void Dgv_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv.IsCurrentCellDirty)
            {
                dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv.Rows[e.RowIndex];
            string salesId = row.Cells[0].Value.ToString();
            InvoiceParameter.SalesId = salesId;
            PrintOrderForm printOrderForm = new PrintOrderForm();
            printOrderForm.Show();
        }
        
        private void BtnSaveToDb_Click(object sender, EventArgs e)
        {
            DataInputOperation.InserOrder(this.dgv);

        }
       
    }
    


}


