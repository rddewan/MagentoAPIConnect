using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagentoApp.ReadWriteFromExcel
{
    class ExportToExcelFile
    {
        public static void ExportToExcel(DataGridView dataGridView)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            try
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    sfd.Filter = "Excel (*.xlsx)|*.xlsx";
                    sfd.FileName = "Output.xlsx";
                    bool fileError = false;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(sfd.FileName))
                        {
                            try
                            {
                                File.Delete(sfd.FileName);
                            }
                            catch (IOException ex)
                            {
                                fileError = true;
                                MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                            }
                        }
                        if (!fileError)
                        {
                            try
                            {
                                Microsoft.Office.Interop.Excel.Application xlApp;
                                Workbook xlWorkBook;
                                Worksheet xlWorkSheet;
                                object misValue = System.Reflection.Missing.Value;
                                int[] ColumnsToInclude = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33 };
                                Int16 i;

                                xlApp = new Microsoft.Office.Interop.Excel.Application();
                                xlWorkBook = xlApp.Workbooks.Add(misValue);                               
                                xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);
                               

                                //header
                                for (int ix = 0; ix < ColumnsToInclude.Length; ix++)
                                {
                                    xlWorkSheet.Cells[1, ix + 1] = dataGridView.Columns[ColumnsToInclude[ix]].HeaderText;                                    
                                }
                                    
                                //row
                                for (i = 0; i <= dataGridView.SelectedRows.Count - 1; i++)
                                {
                                    for (int j = 0; j < ColumnsToInclude.Length; j++)
                                    {
                                        xlWorkSheet.Cells[i + 2, j + 1] = dataGridView[ColumnsToInclude[j], i].Value.ToString();
                                    }
                                }

                                xlWorkBook.SaveAs(sfd.FileName, XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                                xlWorkBook.Close(true, misValue, misValue);
                                xlApp.Quit();
                                MessageBox.Show("Data Exported Successfully !!!", "Export To Excel");
                                
                                
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error :" + ex.Message);
                            }
                        }
                    }
                    
                }
                else
                {
                    if (dataGridView.Rows.Count > 0)
                    {
                        sfd.Filter = "Excel (*.xlsx)|*.xlsx";
                        sfd.FileName = "Output.xlsx";
                        bool fileError = false;
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            if (File.Exists(sfd.FileName))
                            {
                                try
                                {
                                    File.Delete(sfd.FileName);
                                }
                                catch (IOException ex)
                                {
                                    fileError = true;
                                    MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                                }
                            }
                            if (!fileError)
                            {
                                try
                                {
                                    Microsoft.Office.Interop.Excel.Application xlApp;
                                    Workbook xlWorkBook;
                                    Worksheet xlWorkSheet;
                                    object misValue = System.Reflection.Missing.Value;
                                    int[] ColumnsToInclude = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33 };
                                    Int16 i;

                                    xlApp = new Microsoft.Office.Interop.Excel.Application();
                                    xlWorkBook = xlApp.Workbooks.Add(misValue);
                                    xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);


                                    //header
                                    for (int ix = 0; ix < ColumnsToInclude.Length; ix++)
                                    {
                                        xlWorkSheet.Cells[1, ix + 1] = dataGridView.Columns[ColumnsToInclude[ix]].HeaderText;
                                    }

                                    //row
                                    for (i = 0; i <= dataGridView.RowCount - 1; i++)
                                    {
                                        for (int j = 0; j < ColumnsToInclude.Length; j++)
                                        {
                                            xlWorkSheet.Cells[i + 2, j + 1] = dataGridView[ColumnsToInclude[j], i].Value.ToString();
                                        }
                                    }

                                    xlWorkBook.SaveAs(sfd.FileName, XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                                    xlWorkBook.Close(true, misValue, misValue);
                                    xlApp.Quit();
                                    MessageBox.Show("Data Exported Successfully !!!", "Export To Excel");


                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error :" + ex.Message);
                                }
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("No Record To Export !!!", "Info");
                    }
                    
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

            sfd.Dispose();

        }

        public static void GenerateExcelFromDadatTable(DataGridView dataGridView, DataSet p_dsSrc)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            try
            {
                if (dataGridView.Rows.Count > 0)
                {
                    sfd.Filter = "Excel (*.xlsx)|*.xlsx";
                    sfd.FileName = "Output.xlsx";
                    bool fileError = false;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(sfd.FileName))
                        {
                            try
                            {
                                File.Delete(sfd.FileName);
                            }
                            catch (IOException ex)
                            {
                                fileError = true;
                                MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                            }
                        }
                        if (!fileError)
                        {
                            try
                            {
                                using (ExcelPackage objExcelPackage = new ExcelPackage())
                                {
                                    foreach (System.Data.DataTable dtSrc in p_dsSrc.Tables)
                                    {
                                        //Create the worksheet    
                                        ExcelWorksheet objWorksheet = objExcelPackage.Workbook.Worksheets.Add(dtSrc.TableName);
                                        //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1    
                                        objWorksheet.Cells["A1"].LoadFromDataTable(dtSrc, true);
                                        objWorksheet.Cells.Style.Font.SetFromFont(new System.Drawing.Font("Calibri", 10));
                                        objWorksheet.Cells.AutoFitColumns();
                                        //Format the header    
                                        using (ExcelRange objRange = objWorksheet.Cells["A1:XFD1"])
                                        {
                                            objRange.Style.Font.Bold = true;
                                            objRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                            objRange.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                            objRange.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                            objRange.Style.Fill.BackgroundColor.SetColor(Color.Tomato);
                                        }
                                    }

                                    //Write it back to the client    
                                    if (File.Exists(sfd.FileName))
                                        File.Delete(sfd.FileName);

                                    //Create excel file on physical disk    
                                    FileStream objFileStrm = File.Create(sfd.FileName);
                                    objFileStrm.Close();

                                    //Write content to excel file    
                                    File.WriteAllBytes(sfd.FileName, objExcelPackage.GetAsByteArray());
                                    MessageBox.Show("Data Exported Successfully !!!", "Export To Excel");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error :" + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Record To Export !!!", "Info");
                }

            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }

            sfd.Dispose();


        }

        static void ExportToCSV(DataGridView grid)
        {
            try
            {
                if (grid.Rows.Count > 0)
                {

                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "CSV (*.csv)|*.csv";
                    sfd.FileName = "Output.csv";
                    bool fileError = false;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(sfd.FileName))
                        {
                            try
                            {
                                File.Delete(sfd.FileName);
                            }
                            catch (IOException ex)
                            {
                                fileError = true;
                                MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                            }
                        }
                        if (!fileError)
                        {
                            try
                            {
                                int columnCount = grid.Columns.Count;
                                string columnNames = "";
                                string[] outputCsv = new string[grid.Rows.Count + 1];
                                for (int i = 0; i < columnCount; i++)
                                {
                                    if (i == columnCount - 1)
                                    {
                                        columnNames += grid.Columns[i].HeaderText.ToString();
                                    }
                                    else
                                    {
                                        columnNames += grid.Columns[i].HeaderText.ToString() + ",";
                                    }

                                }
                                outputCsv[0] += columnNames;

                                for (int i = 1; (i - 1) < grid.Rows.Count; i++)
                                {
                                    for (int j = 0; j < columnCount; j++)
                                    {
                                        if (j == columnCount - 1)
                                        {
                                            if (grid.Rows[i - 1].Cells[j].Value != null)
                                            {
                                                outputCsv[i] += grid.Rows[i - 1].Cells[j].Value.ToString();

                                            }

                                        }
                                        else
                                        {
                                            if (grid.Rows[i - 1].Cells[j].Value != null)
                                            {
                                                outputCsv[i] += grid.Rows[i - 1].Cells[j].Value.ToString() + ",";

                                            }
                                        }


                                    }
                                }

                                File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                                MessageBox.Show("Data Exported Successfully !!!", "Info");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error :" + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Record To Export !!!", "Info");
                }

            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }


        }
    }
}
