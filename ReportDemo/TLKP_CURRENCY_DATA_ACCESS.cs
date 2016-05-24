using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportDemo
{
    class TLKP_CURRENCY_DATA_ACCESS : IDisposable
    {
        DBDataContext _context=null;
        public void Dispose()
        {

        }
        public DataTable ShowAllCurrencyToComboBox()
        {
            _context = new DBDataContext();
            var result = from s in _context.TLKP_CURRENCies
                         select s;
            DataTable dt = new DataTable();
            dt.Columns.Add("CURRENCY_ID");
            dt.Columns.Add("CURRENCY_NAME");
            DataRow row1 = dt.NewRow();
            row1["CURRENCY_ID"] = 0;
            row1["CURRENCY_NAME"] = Properties.Resources.ALL_CURRENCY;
            dt.Rows.Add(row1);
            foreach (var q in result)
            {
                DataRow row = dt.NewRow();
                row["CURRENCY_ID"] = q.CURRENCY_ID;
                row["CURRENCY_NAME"] = q.CURRENCY_NAME;
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
