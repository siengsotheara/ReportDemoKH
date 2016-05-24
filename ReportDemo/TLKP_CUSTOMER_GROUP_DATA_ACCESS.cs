using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportDemo
{
    class TLKP_CUSTOMER_GROUP_DATA_ACCESS : IDisposable
    {
        DBDataContext _context = null;
        public void Dispose()
        {

        }
        public DataTable ShowAllGroupToComboBox()
        {
            _context = new DBDataContext();
            var result = from s in _context.TLKP_CUSTOMER_GROUPs
                         select s;
            DataTable dt = new DataTable();
            dt.Columns.Add("CUSTOMER_GROUP_ID");
            dt.Columns.Add("CUSTOMER_GROUP_NAME");
            DataRow row1 = dt.NewRow();
            row1["CUSTOMER_GROUP_ID"] = 0;
            row1["CUSTOMER_GROUP_NAME"] = Properties.Resources.ALL_CUSTOMER_GROUP;
            dt.Rows.Add(row1);
            foreach (var q in result)
            {
                DataRow row = dt.NewRow();
                row["CUSTOMER_GROUP_ID"] = q.CUSTOMER_GROUP_ID;
                row["CUSTOMER_GROUP_NAME"] = q.CUSTOMER_GROUP_NAME;
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
