using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportDemo
{
    class TLKP_CUSTOMER_CON_TYPE_DATA_ACCESS: IDisposable
    {
        DBDataContext _context = null;
        public void Dispose()
        {

        }
        public DataTable ShowAllConnectionTypeToComboBox()
        {
            _context = new DBDataContext();
            var result = from s in _context.TLKP_CUSTOMER_CONNECTION_TYPEs
                         select s;
            DataTable dt = new DataTable();
            dt.Columns.Add("CUSTOMER_CONNECTION_TYPE_ID");
            dt.Columns.Add("CUSTOMER_CONNECTION_TYPE_NAME");
            DataRow row1 = dt.NewRow();
            row1["CUSTOMER_CONNECTION_TYPE_ID"] = 0;
            row1["CUSTOMER_CONNECTION_TYPE_NAME"] = Properties.Resources.ALL_CUSTOMER_CON_TYPE;
            dt.Rows.Add(row1);
            foreach (var q in result)
            {
                DataRow row = dt.NewRow();
                row["CUSTOMER_CONNECTION_TYPE_ID"] = q.CUSTOMER_CONNECTION_TYPE_ID;
                row["CUSTOMER_CONNECTION_TYPE_NAME"] = q.CUSTOMER_CONNECTION_TYPE_NAME;
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
