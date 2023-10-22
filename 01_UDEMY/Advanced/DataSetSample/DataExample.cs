using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.DataSetSample
{
    class DataExample
    {
        public void DataSetTest()
        {
            DataTable table = new DataTable("MyTable");
            DataColumn dcolumn = new DataColumn("asdasd");

            table.Columns.Add(dcolumn);

            DataRow drow = table.NewRow();
            DataRow drow1 = table.NewRow();
            drow[0] = "ONE";
            drow1[0] = "TWO";


            table.Rows.Add(drow);
            table.Rows.Add(drow1);

            DataSet dataSet = new DataSet("set");
            dataSet.Tables.Add(table);

            Console.WriteLine(dataSet.Tables[0].Rows[0][0]);
        }
    }
}
