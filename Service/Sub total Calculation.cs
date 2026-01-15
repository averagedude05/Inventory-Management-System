using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class Sub_total_Calculation
    {
       static decimal total = 0;
        public static decimal getTotal(DataTable temp)
        {
            foreach (DataRow row in temp.Rows)
            {
                total += decimal.Parse(row["Sub total"].ToString());
            }
            return total;
        }
    }
}
