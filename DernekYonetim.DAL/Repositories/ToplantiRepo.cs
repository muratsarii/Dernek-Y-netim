using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DernekYonetim.DAL.Entities;

namespace DernekYonetim.DAL.Repositories
{
    public class ToplantiRepo : RepoBase, IRepo<Toplanti>
    {
        public ToplantiRepo()
        {

        }
        
        public int Add(Toplanti item)
        {
            var cmdText = "INSERT INTO Toplanti (ToplantiTarihi,Konum)  VALUES (@ToplantiTarihi,@Konum); SELECT SCOPE_IDENTITY()";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ToplantiTarihi", item.ToplantiTarihi);
            parameters.Add("@Konum", item.Konum);
            return provider.ExecuteScalar<int>(cmdText, parameters);
        }

        public List<Toplanti> GetAll()
        {
            var cmdText = string.Format("SELECT * FROM Toplanti");
            DataTable dt = provider.ExecuteAdapter(cmdText,null);
            List<Toplanti> result = new List<Toplanti>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                result.Add(new Toplanti()
                {
                    Id = Convert.ToInt32(dt.Rows[i]["Id"]),
                    ToplantiTarihi = Convert.ToDateTime(dt.Rows[i]["ToplantiTarihi"]),
                    Konum = dt.Rows[i]["Konum"].ToString()
                });
            }
            return result;
        }

        public Toplanti GetById(int Id)
        {
            var cmdText = "SELECT * FROM Toplanti WHERE Id=@Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", Id);
            DataTable dt = provider.ExecuteAdapter(cmdText, parameters);
            Toplanti result = null;
            if (dt.Rows.Count > 0)
            {
                result = new Toplanti()
                {
                    Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                    ToplantiTarihi = Convert.ToDateTime(dt.Rows[0]["ToplantiTarihi"]),
                    Konum = dt.Rows[0]["Konum"].ToString()
                };
            }
            return result;
        }

        public void Remove(Toplanti item)
        {
            var cmdText = "DELETE * FROM Toplanti WHERE Id=@Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", item.Id);
            try { provider.ExecuteNonQuery(cmdText, parameters); }
            catch { throw new Exception(string.Format("{0} Id' li Kişi silinirken hata meydana geldi. İlişkili olduğu satırları gözden geçirin.", item.Id)); }
        }

        public Toplanti Update(Toplanti item)
        {
            var cmdText = string.Format("UPDATE Toplanti SET ToplantiTarihi=@ToplantiTarihi, Konum=@Konum, WHERE Id =@Id");
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", item.Id);
            parameters.Add("@ToplantiTarihi", item.ToplantiTarihi);
            parameters.Add("@Konum", item.Konum);
            try
            {
                provider.ExecuteNonQuery(cmdText, parameters);
                return GetById(item.Id);
            }
            catch { throw new Exception(string.Format("{0} Id' li Kişi silinirken hata meydana geldi. İlişkili olduğu satırları gözden geçirin.", item.Id)); }
        }
    }
}
