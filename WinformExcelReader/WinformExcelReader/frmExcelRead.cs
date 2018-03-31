using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace WinformExcelReader
{
    public partial class frmExcelRead : Form
    {

        public frmExcelRead()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtFilePath.Text = Application.StartupPath + "\\TestBook.xls";
        }

        private void BtnBrowseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel files|*.xls;*.xlsx";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.SafeFileName;
            }
        }

        private void BtnReadExcel_Click(object sender, EventArgs e)
        {
            GetExcelFile();
        }

        private string GetExcelColumnName(int columnNumber)
        {
            int dividend = columnNumber;
            string columnName = String.Empty;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                dividend = (int)((dividend - modulo) / 26);
            }

            return columnName;
        }

        private void GetExcelFile()
        {
            object misValue = System.Reflection.Missing.Value;

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(txtFilePath.Text, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range last = xlWorksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            string dss = GetExcelColumnName(last.Column) + last.Row;
            Excel.Range xlRange = xlWorksheet.get_Range("A1:" +dss, misValue);
            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            DataTable dt = new DataTable("dtExcel");
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            DataRow dr;

            lblInfo.Text = rowCount + " satır " + colCount + " kolon okunacak";
            for (int j = 1; j <= colCount; j++)
            {
                dt.Columns.Add(GetExcelColumnName(j), Type.GetType("System.String"));
            }

            Excel.Range oRng;
            for (int i = 1; i <= rowCount; i++)
            {
                if (i == 1 && chkFirstRowHeader.Checked)
                    continue;

                dr = ds.Tables["dtExcel"].NewRow();
                for (int j = 1; j <= colCount; j++)
                {
                    oRng = (Excel.Range)xlWorksheet.Cells[i, j];
                    string strValue = oRng.Text.ToString();
                    dr[GetExcelColumnName(j)] = strValue;
                }
                ds.Tables["dtExcel"].Rows.Add(dr);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            dataGridView1.DataSource = dt;
        }
    }
}
