//Đề Tài Quản Lý Món Ăn Ngon
//Sinh Viên Thực Hiện: Nguyễn Hoàng Vũ - 10200681 - NCTH4A
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;  

//using System.Windows.Forms;
//using System.Data;
//using Excel = Microsoft.Office.Interop.Excel;  
// => NAMESPACE NÀY SỬ DỤNG CHO EXPORT EXCEL
public class PHAN_MEM
{     
    static public bool exportDataToExcel(string tieude, DataTable dt)
    {
        System.Globalization.CultureInfo oldCI = System.Threading.Thread.CurrentThread.CurrentCulture;
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        bool result = false;
        //khoi tao cac doi tuong Com Excel de lam viec
        Excel.Application xlApp;
        Excel.Worksheet xlSheet;
        Excel.Workbook xlBook;
        //doi tuong Trống để thêm  vào xlApp sau đó lưu lại sau
        object missValue = System.Reflection.Missing.Value;
        //khoi tao doi tuong Com Excel moi
        xlApp = new Excel.Application();
        xlBook = xlApp.Workbooks.Add(missValue);
        //su dung Sheet dau tien de thao tac
        xlSheet = (Excel.Worksheet)xlBook.Worksheets.get_Item(1);
        //không cho hiện ứng dụng Excel lên để tránh gây đơ máy
        xlApp.Visible = false;
        int socot = dt.Columns.Count;
        int sohang = dt.Rows.Count;
        int i, j;

        SaveFileDialog f = new SaveFileDialog();
        f.Filter = "Excel file (*.xls)|*.xls";
        f.InitialDirectory = Application.StartupPath;
        if (f.ShowDialog() == DialogResult.OK)
        {

            //set thuoc tinh cho tieu de
            xlSheet.get_Range("A1", Convert.ToChar(socot + 65) + "1").Merge(false);
            Excel.Range caption = xlSheet.get_Range("A1", Convert.ToChar(socot + 65) + "1");
            caption.Select();
            caption.FormulaR1C1 = tieude;
            //căn lề cho tiêu đề
            caption.HorizontalAlignment = Excel.Constants.xlCenter;
            caption.Font.Bold = true;
            caption.VerticalAlignment = Excel.Constants.xlCenter;
            caption.Font.Size = 15;
            //màu nền cho tiêu đề
            caption.Interior.ColorIndex = 20;
            caption.RowHeight = 30;
            //set thuoc tinh cho cac header
            Excel.Range header = xlSheet.get_Range("A2", Convert.ToChar(socot + 65) + "2");
            header.Select();

            header.HorizontalAlignment = Excel.Constants.xlCenter;
            header.Font.Bold = true;
            header.Font.Size = 10;
            //điền tiêu đề cho các cột trong file excel
            for (i = 0; i < socot; i++)
                xlSheet.Cells[2, i + 2] = dt.Columns[i].ColumnName;
            //dien cot stt
            xlSheet.Cells[2, 1] = "STT";
            for (i = 0; i < sohang; i++)
                xlSheet.Cells[i + 3, 1] = i + 1;
            //dien du lieu vao sheet
            try
            {
                for (i = 0; i < sohang; i++)
                    for (j = 0; j < socot; j++)
                    {
                        xlSheet.Cells[i + 3, j + 2] = dt.Rows[i][j];

                    }
            }
            catch
            {
                // Lỗi out of memory.
            }
            //autofit độ rộng cho các cột
            for (i = 0; i < sohang; i++)
                ((Excel.Range)xlSheet.Cells[1, i + 1]).EntireColumn.AutoFit();

            //save file
            xlBook.SaveAs(f.FileName, Excel.XlFileFormat.xlWorkbookNormal, missValue, missValue, missValue, missValue, Excel.XlSaveAsAccessMode.xlExclusive, missValue, missValue, missValue, missValue, missValue);
            xlBook.Close(true, missValue, missValue);
            xlApp.Quit();

            // release cac doi tuong COM                                       
            releaseObject(xlSheet);
            releaseObject(xlBook);
            releaseObject(xlApp);
            result = true;
        }
        return result;
    }

    static public void releaseObject(object obj)
    {
        try
        {
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
            obj = null;
        }
        catch (Exception ex)
        {
            obj = null;
            throw new Exception("Exception Occured while releasing object " + ex.ToString());
        }
        finally
        {            
            GC.GetTotalMemory(false);
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.GetTotalMemory(true);
        }
    }    
}
