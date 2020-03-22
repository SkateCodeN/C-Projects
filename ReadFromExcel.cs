//Alias of Excel to referece the COM Object library
using Excel = Microsoft.Office.Interop.Excel;
class testExcel
    {

        ///This class is responsible for gathering data from an excel sheet to convert so that my program 
        ///can update itself on entries of various WS, switches and printers. 
        ///Because we are not in a static env, ip addresses, names or devices change, the excel is the best way 
        ///For a user to keep it up to date
        ///

        //This following code was referenced from the web:
        //https://coderwall.com/p/app3ya/read-excel-file-in-c


        //Create COM obj's. Create a COM object for all the references
        

        public static void Load(string loc)
        {
            Excel.Application xLApp2 = new Excel.Application();
            Excel.Workbook xlworkbook2 = xLApp2.Workbooks.Open(loc, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            Excel.Worksheet _WrkSheet = (Excel.Worksheet)xlworkbook2.Worksheets.get_Item(1);

            //xlWorkbook = xLApp2.Workbooks.Open("test.xls");

        }

       

    }
