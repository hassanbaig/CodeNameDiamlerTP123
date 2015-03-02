 using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DiamlerTP.DAL
{
    public class QueryCreater
    {   
     
        public static string SelectQuery(string table/*T_Emplyee*/, string[] columns = null, string where = null /* id=67 and name='ahsan' */, string orderby = null /* Name desc */, string optional = "")
        {
            //SELECT * FROM T_Emplyeee WHERE id=67 orderby lastname desc
            return string.Format("SELECT {0} FROM {1} {2} {3} {4}", (columns == null) ? "*" : string.Join(",", columns), table, (where == null) ? "" : ("WHERE " + where), (orderby == null) ? "" : ("orderby " + orderby), optional);
        }

        public static string SelectPagingQuery(string table, int pageNo = 1, int pageSize = 20)
        {
            return string.Format(@"with query as

                                (
                                    select *, ROW_NUMBER() OVER(ORDER BY id DESC) as line from {0}
                                )
                                select top ({1}) *, (SELECT COUNT(*) FROM {0}) AS total from query
                                where line > ({2} - 1) * {1}", table, pageSize, pageNo);

        }

        public static string InsertQuery(string table, string[] columns, string[] values)
        {
            return string.Format("INSERT INTO {0} ({1}) VALUES ({2})", table, string.Join(",", columns), string.Join(",", values));
        }

        public static string UpdateQuery(string table, string[] columns, string[] values, int id)
        {
            string [] query = new string[columns.Length];

            for (int i = 0; i < columns.Length; i++)
            {
                query[i] = columns[i] + " = " + values[i];
            }

            return string.Format("UPDATE {0} SET {1} WHERE [ID] = {2}", table, string.Join(",", query), id);
        }

        public static string DeleteQuery(string table, string where = null)
        {
            return string.Format("DELETE FROM {0} {1} ", table, (where == null) ? "" : ("WHERE " + where));
        }
    }
}