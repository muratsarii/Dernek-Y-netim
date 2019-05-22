using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekYonetim.DAL
{
    public class SqlQueryBuilder : IQueryBuilder
    {
        public string Delete<T>()
        {
            var className = typeof(T).Name;
            return string.Format("DELETE FROM {0} WHERE Id=@Id", className);
        }

        public string Insert<T>()
        {
            Type tip = typeof(T);
            var className = typeof(T).Name;
            var propInfos = tip.GetProperties();
            var strCol = "";
            var strParam = "";
            foreach (var propInfo in propInfos)
            {
                if (propInfo.Name == "Id") continue;
                if (strCol == string.Empty)
                {
                    strCol += propInfo.Name;
                    strParam += "@" + propInfo.Name;
                }
                else
                {
                    strCol += "," + propInfo.Name;
                    strParam += ",@" + propInfo.Name;
                }
            }
            return string.Format("INSERT INTO {0} ({1}) VALUES({2})", className, strCol, strParam);
        }

        public string SelectByIdQuery<T>()
        {
            return string.Format("{0} WHERE Id=@Id", this.SelectQuery<T>());
        }

        public string SelectQuery<T>()
        {
            var className = typeof(T).Name; //reflekşın
            return string.Format("SELECT * FROM {0}", className);
        }

        public string Update<T>()
        { 
            Type tip = typeof(T);
            var className = typeof(T).Name;
            var propInfos = tip.GetProperties();
            var str = "";
            foreach (var propInfo in propInfos)
            {
                if (propInfo.Name == "Id") continue;
                if (str == string.Empty) str += string.Format("{0}=@{0}", propInfo.Name);
                else
                    str += string.Format(",{0}=@{0}", propInfo.Name);
                    //str += $",{propInfo.Name}=@{propInfo.Name}";
            }
            return string.Format("UPDATE {0} SET ({1}) WHERE Id=@Id", className, str);
        }
    }
}
