using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MagentoApp.ReadFromExcel;

namespace MagentoApp.Model.Db
{
    class DataInputOperation
    {        
        private static SqlConnection connection;
        private static SqlCommand command;

        public static  void InserOrder(DataGridView dataGridView)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                connection = new SqlConnection();

                try
                {
                    DialogResult result = MessageBox.Show("Do you want to save selected record?", "Save Record To Database", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        connection.ConnectionString = ConfigurationManager.ConnectionStrings["MagentoAPIConnect"].ConnectionString;

                        string query = "INSERT INTO [dbo].[M2SalesOrder] ([BillNo],[BillDate],[VoucherType],[Godown],[CustomerName],[Address1],[Address2],[Address3],[Address4]" +
                            ",[Country],[State],[GSTRegistrationType],[GSTNo],[SalesLedger],[ProductName],SKU,[BatchNo],[TaxRate],[ManufacturingDate],[ExpiryDate],[Quantity],[Unit]" +
                            ",[RateInclusiveOfTax],[RateBasic],[DiscPercent],[Amount],[DeliveryCharges],[CGST],[SGST],[IGST],[RoundOff],[TotalAmount],[CreditDebitCardLedgerName]" +
                            ",[CashLedgerName],[Narration],[HSN])" +
                            "VALUES(@BillNo,@BillDate,@VoucherType,@Godown,@CustomerName,@Address1,@Address2,@Address3,@Address4,@Country,@State,@GSTRegistrationType,@GSTNo,@SalesLedger" +
                            ",@ProductName,@SKU,@BatchNo,@TaxRate,@ManufacturingDate,@ExpiryDate,@Quantity,@Unit,@RateInclusiveOfTax,@RateBasic,@DiscPercent,@Amount,@DeliveryCharges" +
                            ",@CGST,@SGST,@IGST,@RoundOff,@TotalAmount,@CreditDebitCardLedgerName,@CashLedgerName,@Narration,@HSN)";

                        command = new SqlCommand(query, connection);
                        SqlParameter parmBillNo = new SqlParameter("@BillNo", SqlDbType.VarChar, 50);
                        SqlParameter parmBillDate = new SqlParameter("@BillDate", SqlDbType.DateTime);
                        SqlParameter parmVoucherType = new SqlParameter("@VoucherType", SqlDbType.VarChar, 50);
                        SqlParameter parmGodown = new SqlParameter("@Godown", SqlDbType.VarChar, 50);
                        SqlParameter parmCustomerName = new SqlParameter("@CustomerName", SqlDbType.VarChar, 250);
                        SqlParameter parmAddress1 = new SqlParameter("@Address1", SqlDbType.Text);
                        SqlParameter parmAddress2 = new SqlParameter("@Address2", SqlDbType.Text);
                        SqlParameter parmAddress3 = new SqlParameter("@Address3", SqlDbType.Text);
                        SqlParameter parmAddress4 = new SqlParameter("@Address4", SqlDbType.Text);
                        SqlParameter parmCountry = new SqlParameter("@Country", SqlDbType.VarChar, 50);
                        SqlParameter parmState = new SqlParameter("@State", SqlDbType.VarChar, 50);
                        SqlParameter parmGSTRegistrationType = new SqlParameter("@GSTRegistrationType", SqlDbType.VarChar, 50);
                        SqlParameter parmGSTNo = new SqlParameter("@GSTNo", SqlDbType.VarChar, 50);
                        SqlParameter parmSalesLedger = new SqlParameter("@SalesLedger", SqlDbType.VarChar, 50);
                        SqlParameter parmProductName = new SqlParameter("@ProductName", SqlDbType.VarChar, 250);
                        SqlParameter parmSku = new SqlParameter("@SKU", SqlDbType.VarChar, 50);
                        SqlParameter parmBatchNo = new SqlParameter("@BatchNo", SqlDbType.VarChar, 50);
                        SqlParameter parmTaxRate = new SqlParameter("@TaxRate", SqlDbType.VarChar, 50);
                        SqlParameter parmManufacturingDate = new SqlParameter("@ManufacturingDate", SqlDbType.DateTime);
                        SqlParameter parmExpiryDate = new SqlParameter("@ExpiryDate", SqlDbType.DateTime);
                        SqlParameter parmQuantity = new SqlParameter("@Quantity", SqlDbType.SmallInt);
                        SqlParameter parmUnit = new SqlParameter("@Unit", SqlDbType.VarChar, 50);
                        SqlParameter parmRateInclusiveOfTax = new SqlParameter("@RateInclusiveOfTax", SqlDbType.Money);
                        SqlParameter parmRateBasic = new SqlParameter("@RateBasic", SqlDbType.Money);
                        SqlParameter parmDiscPercent = new SqlParameter("@DiscPercent", SqlDbType.VarChar, 50);
                        SqlParameter parmAmount = new SqlParameter("@Amount", SqlDbType.Money);
                        SqlParameter parmDeliveryCharges = new SqlParameter("@DeliveryCharges", SqlDbType.Money);
                        SqlParameter parmCGST = new SqlParameter("@CGST", SqlDbType.Money);
                        SqlParameter parmSGST = new SqlParameter("@SGST", SqlDbType.Money);
                        SqlParameter parmIGST = new SqlParameter("@IGST", SqlDbType.Money);
                        SqlParameter parmRoundOff = new SqlParameter("@RoundOff", SqlDbType.Money);
                        SqlParameter parmTotalAmount = new SqlParameter("@TotalAmount", SqlDbType.Money);
                        SqlParameter parmCreditDebitCardLedgerName = new SqlParameter("@CreditDebitCardLedgerName", SqlDbType.VarChar, 250);
                        SqlParameter parmCashLedgerName = new SqlParameter("@CashLedgerName", SqlDbType.VarChar, 250);
                        SqlParameter parmNarration = new SqlParameter("@Narration", SqlDbType.VarChar, 250);
                        SqlParameter parmHSN = new SqlParameter("@HSN", SqlDbType.VarChar, 50);

                        command.Parameters.Add(parmBillNo);
                        command.Parameters.Add(parmBillDate);
                        command.Parameters.Add(parmVoucherType);
                        command.Parameters.Add(parmGodown);
                        command.Parameters.Add(parmCustomerName);
                        command.Parameters.Add(parmAddress1);
                        command.Parameters.Add(parmAddress2);
                        command.Parameters.Add(parmAddress3);
                        command.Parameters.Add(parmAddress4);
                        command.Parameters.Add(parmCountry);
                        command.Parameters.Add(parmState);
                        command.Parameters.Add(parmGSTRegistrationType);
                        command.Parameters.Add(parmGSTNo);
                        command.Parameters.Add(parmSalesLedger);
                        command.Parameters.Add(parmProductName);
                        command.Parameters.Add(parmSku);
                        command.Parameters.Add(parmBatchNo);
                        command.Parameters.Add(parmTaxRate);
                        command.Parameters.Add(parmManufacturingDate);
                        command.Parameters.Add(parmExpiryDate);
                        command.Parameters.Add(parmQuantity);
                        command.Parameters.Add(parmUnit);
                        command.Parameters.Add(parmRateInclusiveOfTax);
                        command.Parameters.Add(parmRateBasic);
                        command.Parameters.Add(parmDiscPercent);
                        command.Parameters.Add(parmAmount);
                        command.Parameters.Add(parmDeliveryCharges);
                        command.Parameters.Add(parmCGST);
                        command.Parameters.Add(parmSGST);
                        command.Parameters.Add(parmIGST);
                        command.Parameters.Add(parmRoundOff);
                        command.Parameters.Add(parmTotalAmount);
                        command.Parameters.Add(parmCreditDebitCardLedgerName);
                        command.Parameters.Add(parmCashLedgerName);
                        command.Parameters.Add(parmNarration);
                        command.Parameters.Add(parmHSN);

                        foreach (DataGridViewRow row in dataGridView.SelectedRows)
                        {
                            parmBillNo.Value = row.Cells[0].Value.ToString();
                            parmBillDate.Value = Convert.ToDateTime(row.Cells[1].Value.ToString());
                            parmVoucherType.Value = row.Cells[2].Value;
                            parmGodown.Value = row.Cells[3].Value;
                            parmCustomerName.Value = row.Cells[4].Value;
                            parmAddress1.Value = row.Cells[5].Value;
                            parmAddress2.Value = row.Cells[6].Value;
                            parmAddress3.Value = row.Cells[7].Value;
                            parmAddress4.Value = row.Cells[8].Value;
                            parmCountry.Value = row.Cells[9].Value;
                            parmState.Value = row.Cells[10].Value;
                            parmGSTRegistrationType.Value = row.Cells[11].Value;
                            parmGSTNo.Value = row.Cells[12].Value;
                            parmSalesLedger.Value = row.Cells[13].Value;
                            parmProductName.Value = row.Cells[14].Value;
                            parmBatchNo.Value = row.Cells[15].Value;
                            parmTaxRate.Value = row.Cells[16].Value.ToString();

                            string ManufacturingDate = row.Cells[17].Value.ToString();
                            if (ManufacturingDate.Equals(""))
                            {
                                parmManufacturingDate.Value = DBNull.Value;
                            }
                            else
                            {
                                parmManufacturingDate.Value = DateTime.Parse(ManufacturingDate);
                            }


                            string ExpiryDate = row.Cells[18].Value.ToString();
                            if (ExpiryDate.Equals(""))
                            {
                                parmExpiryDate.Value = DBNull.Value;
                            }
                            else
                            {
                                parmExpiryDate.Value = DateTime.Parse(ExpiryDate);
                            }

                            parmQuantity.Value = row.Cells[19].Value;
                            parmUnit.Value = row.Cells[20].Value;

                            string RateInclusiveOfTax = row.Cells[21].Value.ToString();
                            if (RateInclusiveOfTax.Equals(""))
                            {
                                RateInclusiveOfTax = "0";
                            }
                            parmRateInclusiveOfTax.Value = Convert.ToDouble(RateInclusiveOfTax);

                            string RateBasic = row.Cells[22].Value.ToString();
                            if (RateBasic.Equals("0"))
                            {
                                RateBasic = "0";
                            }
                            parmRateBasic.Value = Convert.ToDouble(RateBasic);

                            string DiscPercent = row.Cells[23].Value.ToString();
                            if (DiscPercent.Equals(""))
                            {
                                DiscPercent = "0";
                            }
                            parmDiscPercent.Value = Convert.ToDouble(DiscPercent);

                            string Amount = row.Cells[24].Value.ToString();
                            if (Amount.Equals(""))
                            {
                                Amount = "0";
                            }
                            parmAmount.Value = Convert.ToDouble(Amount);

                            string DeliveryCharges = row.Cells[25].Value.ToString();
                            if (DeliveryCharges.Equals(""))
                            {
                                DeliveryCharges = "0";
                            }
                            parmDeliveryCharges.Value = Convert.ToDouble(DeliveryCharges);

                            string CGST = row.Cells[26].Value.ToString();
                            if (CGST.Equals(""))
                            {
                                CGST = "0";
                            }
                            parmCGST.Value = Convert.ToDouble(CGST);

                            string SGST = row.Cells[27].Value.ToString();
                            if (SGST.Equals(""))
                            {
                                SGST = "0";
                            }
                            parmSGST.Value = Convert.ToDouble(SGST);

                            string IGST = row.Cells[28].Value.ToString();
                            if (IGST.Equals(""))
                            {
                                IGST = "0";
                            }
                            parmIGST.Value = Convert.ToDouble(IGST);

                            string RoundOff = row.Cells[29].Value.ToString();
                            if (RoundOff.Equals(""))
                            {
                                RoundOff = "0";
                            }
                            parmRoundOff.Value = Convert.ToDouble(RoundOff);
                            string TotalAmount = row.Cells[30].Value.ToString();
                            if (TotalAmount.Equals(""))
                            {
                                TotalAmount = "0";
                            }
                            parmTotalAmount.Value = Convert.ToDouble(TotalAmount);

                            parmCreditDebitCardLedgerName.Value = row.Cells[31].Value;
                            parmCashLedgerName.Value = row.Cells[32].Value;
                            parmNarration.Value = row.Cells[33].Value;

                            string sku = row.Cells[34].Value.ToString();
                            string hsn = ReadFromExcelFile.ReadExcelFile(sku);
                            parmHSN.Value = hsn;
                            parmSku.Value = sku;

                            if (connection.State != ConnectionState.Open)
                            {
                                connection.Open();
                            }

                            command.ExecuteNonQuery();

                        }

                        MessageBox.Show("Data saved successfully");
                    }
                    
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
                finally
                {
                    if (connection != null)
                    {
                        connection.Close();
                    }
                    if (command != null)
                    {
                        command.Dispose();
                    }
                }

            }
            else
            {
                if (dataGridView.Rows.Count > 0)
                {
                    connection = new SqlConnection();

                    try
                    {
                        DialogResult result = MessageBox.Show("Do you want to save all the record?", "Save Record To Database", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {

                            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MagentoAPIConnect"].ConnectionString;

                            string query = "INSERT INTO [dbo].[M2SalesOrder] ([BillNo],[BillDate],[VoucherType],[Godown],[CustomerName],[Address1],[Address2],[Address3],[Address4]" +
                                ",[Country],[State],[GSTRegistrationType],[GSTNo],[SalesLedger],[ProductName],SKU,[BatchNo],[TaxRate],[ManufacturingDate],[ExpiryDate],[Quantity],[Unit]" +
                                ",[RateInclusiveOfTax],[RateBasic],[DiscPercent],[Amount],[DeliveryCharges],[CGST],[SGST],[IGST],[RoundOff],[TotalAmount],[CreditDebitCardLedgerName]" +
                                ",[CashLedgerName],[Narration],[HSN])" +
                                "VALUES(@BillNo,@BillDate,@VoucherType,@Godown,@CustomerName,@Address1,@Address2,@Address3,@Address4,@Country,@State,@GSTRegistrationType,@GSTNo,@SalesLedger" +
                                ",@ProductName,@SKU,@BatchNo,@TaxRate,@ManufacturingDate,@ExpiryDate,@Quantity,@Unit,@RateInclusiveOfTax,@RateBasic,@DiscPercent,@Amount,@DeliveryCharges" +
                                ",@CGST,@SGST,@IGST,@RoundOff,@TotalAmount,@CreditDebitCardLedgerName,@CashLedgerName,@Narration,@HSN)";

                            command = new SqlCommand(query, connection);
                            SqlParameter parmBillNo = new SqlParameter("@BillNo", SqlDbType.VarChar, 50);
                            SqlParameter parmBillDate = new SqlParameter("@BillDate", SqlDbType.DateTime);
                            SqlParameter parmVoucherType = new SqlParameter("@VoucherType", SqlDbType.VarChar, 50);
                            SqlParameter parmGodown = new SqlParameter("@Godown", SqlDbType.VarChar, 50);
                            SqlParameter parmCustomerName = new SqlParameter("@CustomerName", SqlDbType.VarChar, 250);
                            SqlParameter parmAddress1 = new SqlParameter("@Address1", SqlDbType.Text);
                            SqlParameter parmAddress2 = new SqlParameter("@Address2", SqlDbType.Text);
                            SqlParameter parmAddress3 = new SqlParameter("@Address3", SqlDbType.Text);
                            SqlParameter parmAddress4 = new SqlParameter("@Address4", SqlDbType.Text);
                            SqlParameter parmCountry = new SqlParameter("@Country", SqlDbType.VarChar, 50);
                            SqlParameter parmState = new SqlParameter("@State", SqlDbType.VarChar, 50);
                            SqlParameter parmGSTRegistrationType = new SqlParameter("@GSTRegistrationType", SqlDbType.VarChar, 50);
                            SqlParameter parmGSTNo = new SqlParameter("@GSTNo", SqlDbType.VarChar, 50);
                            SqlParameter parmSalesLedger = new SqlParameter("@SalesLedger", SqlDbType.VarChar, 50);
                            SqlParameter parmProductName = new SqlParameter("@ProductName", SqlDbType.VarChar, 250);
                            SqlParameter parmSku = new SqlParameter("@SKU", SqlDbType.VarChar, 50);
                            SqlParameter parmBatchNo = new SqlParameter("@BatchNo", SqlDbType.VarChar, 50);
                            SqlParameter parmTaxRate = new SqlParameter("@TaxRate", SqlDbType.VarChar, 50);
                            SqlParameter parmManufacturingDate = new SqlParameter("@ManufacturingDate", SqlDbType.DateTime);
                            SqlParameter parmExpiryDate = new SqlParameter("@ExpiryDate", SqlDbType.DateTime);
                            SqlParameter parmQuantity = new SqlParameter("@Quantity", SqlDbType.SmallInt);
                            SqlParameter parmUnit = new SqlParameter("@Unit", SqlDbType.VarChar, 50);
                            SqlParameter parmRateInclusiveOfTax = new SqlParameter("@RateInclusiveOfTax", SqlDbType.Money);
                            SqlParameter parmRateBasic = new SqlParameter("@RateBasic", SqlDbType.Money);
                            SqlParameter parmDiscPercent = new SqlParameter("@DiscPercent", SqlDbType.VarChar, 50);
                            SqlParameter parmAmount = new SqlParameter("@Amount", SqlDbType.Money);
                            SqlParameter parmDeliveryCharges = new SqlParameter("@DeliveryCharges", SqlDbType.Money);
                            SqlParameter parmCGST = new SqlParameter("@CGST", SqlDbType.Money);
                            SqlParameter parmSGST = new SqlParameter("@SGST", SqlDbType.Money);
                            SqlParameter parmIGST = new SqlParameter("@IGST", SqlDbType.Money);
                            SqlParameter parmRoundOff = new SqlParameter("@RoundOff", SqlDbType.Money);
                            SqlParameter parmTotalAmount = new SqlParameter("@TotalAmount", SqlDbType.Money);
                            SqlParameter parmCreditDebitCardLedgerName = new SqlParameter("@CreditDebitCardLedgerName", SqlDbType.VarChar, 250);
                            SqlParameter parmCashLedgerName = new SqlParameter("@CashLedgerName", SqlDbType.VarChar, 250);
                            SqlParameter parmNarration = new SqlParameter("@Narration", SqlDbType.VarChar, 250);
                            SqlParameter parmHSN = new SqlParameter("@HSN", SqlDbType.VarChar, 50);

                            command.Parameters.Add(parmBillNo);
                            command.Parameters.Add(parmBillDate);
                            command.Parameters.Add(parmVoucherType);
                            command.Parameters.Add(parmGodown);
                            command.Parameters.Add(parmCustomerName);
                            command.Parameters.Add(parmAddress1);
                            command.Parameters.Add(parmAddress2);
                            command.Parameters.Add(parmAddress3);
                            command.Parameters.Add(parmAddress4);
                            command.Parameters.Add(parmCountry);
                            command.Parameters.Add(parmState);
                            command.Parameters.Add(parmGSTRegistrationType);
                            command.Parameters.Add(parmGSTNo);
                            command.Parameters.Add(parmSalesLedger);
                            command.Parameters.Add(parmProductName);
                            command.Parameters.Add(parmSku);
                            command.Parameters.Add(parmBatchNo);
                            command.Parameters.Add(parmTaxRate);
                            command.Parameters.Add(parmManufacturingDate);
                            command.Parameters.Add(parmExpiryDate);
                            command.Parameters.Add(parmQuantity);
                            command.Parameters.Add(parmUnit);
                            command.Parameters.Add(parmRateInclusiveOfTax);
                            command.Parameters.Add(parmRateBasic);
                            command.Parameters.Add(parmDiscPercent);
                            command.Parameters.Add(parmAmount);
                            command.Parameters.Add(parmDeliveryCharges);
                            command.Parameters.Add(parmCGST);
                            command.Parameters.Add(parmSGST);
                            command.Parameters.Add(parmIGST);
                            command.Parameters.Add(parmRoundOff);
                            command.Parameters.Add(parmTotalAmount);
                            command.Parameters.Add(parmCreditDebitCardLedgerName);
                            command.Parameters.Add(parmCashLedgerName);
                            command.Parameters.Add(parmNarration);
                            command.Parameters.Add(parmHSN);

                            foreach (DataGridViewRow row in dataGridView.Rows)
                            {
                                parmBillNo.Value = row.Cells[0].Value.ToString();
                                parmBillDate.Value = Convert.ToDateTime(row.Cells[1].Value.ToString());
                                parmVoucherType.Value = row.Cells[2].Value;
                                parmGodown.Value = row.Cells[3].Value;
                                parmCustomerName.Value = row.Cells[4].Value;
                                parmAddress1.Value = row.Cells[5].Value;
                                parmAddress2.Value = row.Cells[6].Value;
                                parmAddress3.Value = row.Cells[7].Value;
                                parmAddress4.Value = row.Cells[8].Value;
                                parmCountry.Value = row.Cells[9].Value;
                                parmState.Value = row.Cells[10].Value;
                                parmGSTRegistrationType.Value = row.Cells[11].Value;
                                parmGSTNo.Value = row.Cells[12].Value;
                                parmSalesLedger.Value = row.Cells[13].Value;
                                parmProductName.Value = row.Cells[14].Value;
                                parmBatchNo.Value = row.Cells[15].Value;
                                parmTaxRate.Value = row.Cells[16].Value.ToString();

                                string ManufacturingDate = row.Cells[17].Value.ToString();
                                if (ManufacturingDate.Equals(""))
                                {
                                    parmManufacturingDate.Value = DBNull.Value;
                                }
                                else
                                {
                                    parmManufacturingDate.Value = DateTime.Parse(ManufacturingDate);
                                }


                                string ExpiryDate = row.Cells[18].Value.ToString();
                                if (ExpiryDate.Equals(""))
                                {
                                    parmExpiryDate.Value = DBNull.Value;
                                }
                                else
                                {
                                    parmExpiryDate.Value = DateTime.Parse(ExpiryDate);
                                }

                                parmQuantity.Value = row.Cells[19].Value;
                                parmUnit.Value = row.Cells[20].Value;

                                string RateInclusiveOfTax = row.Cells[21].Value.ToString();
                                if (RateInclusiveOfTax.Equals(""))
                                {
                                    RateInclusiveOfTax = "0";
                                }
                                parmRateInclusiveOfTax.Value = Convert.ToDouble(RateInclusiveOfTax);

                                string RateBasic = row.Cells[22].Value.ToString();
                                if (RateBasic.Equals("0"))
                                {
                                    RateBasic = "0";
                                }
                                parmRateBasic.Value = Convert.ToDouble(RateBasic);

                                string DiscPercent = row.Cells[23].Value.ToString();
                                if (DiscPercent.Equals(""))
                                {
                                    DiscPercent = "0";
                                }
                                parmDiscPercent.Value = Convert.ToDouble(DiscPercent);

                                string Amount = row.Cells[24].Value.ToString();
                                if (Amount.Equals(""))
                                {
                                    Amount = "0";
                                }
                                parmAmount.Value = Convert.ToDouble(Amount);

                                string DeliveryCharges = row.Cells[25].Value.ToString();
                                if (DeliveryCharges.Equals(""))
                                {
                                    DeliveryCharges = "0";
                                }
                                parmDeliveryCharges.Value = Convert.ToDouble(DeliveryCharges);

                                string CGST = row.Cells[26].Value.ToString();
                                if (CGST.Equals(""))
                                {
                                    CGST = "0";
                                }
                                parmCGST.Value = Convert.ToDouble(CGST);

                                string SGST = row.Cells[27].Value.ToString();
                                if (SGST.Equals(""))
                                {
                                    SGST = "0";
                                }
                                parmSGST.Value = Convert.ToDouble(SGST);

                                string IGST = row.Cells[28].Value.ToString();
                                if (IGST.Equals(""))
                                {
                                    IGST = "0";
                                }
                                parmIGST.Value = Convert.ToDouble(IGST);

                                string RoundOff = row.Cells[29].Value.ToString();
                                if (RoundOff.Equals(""))
                                {
                                    RoundOff = "0";
                                }
                                parmRoundOff.Value = Convert.ToDouble(RoundOff);
                                string TotalAmount = row.Cells[30].Value.ToString();
                                if (TotalAmount.Equals(""))
                                {
                                    TotalAmount = "0";
                                }
                                parmTotalAmount.Value = Convert.ToDouble(TotalAmount);

                                parmCreditDebitCardLedgerName.Value = row.Cells[31].Value;
                                parmCashLedgerName.Value = row.Cells[32].Value;
                                parmNarration.Value = row.Cells[33].Value;

                                string sku = row.Cells[34].Value.ToString();
                                string hsn = ReadFromExcelFile.ReadExcelFile(sku);
                                parmHSN.Value = hsn;
                                parmSku.Value = sku;

                                if (connection.State != ConnectionState.Open)
                                {
                                    connection.Open();
                                }

                                command.ExecuteNonQuery();

                            }

                            MessageBox.Show("Data saved successfully");
                        }

                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message);
                    }
                    finally
                    {
                        if (connection != null)
                        {
                            connection.Close();
                        }
                        if (command != null)
                        {
                            command.Dispose();
                        }                        
                        
                    }

                }
                else
                {
                    MessageBox.Show("There is no record.");
                }
                
            }
            
        }

    }
}
