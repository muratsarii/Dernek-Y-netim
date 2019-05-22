using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DernekYonetim.DAL.Entities;
using System.Data;

namespace DernekYonetim.DAL.Repositories
{
    public class UnvanRepo : RepoBase, IRepo<Unvan>
    {
        public UnvanRepo()
        {
        }
        public int Add(Unvan item)
        {
            var cmdText = "INSERT INTO Unvan (Tanim) VALUES (@Tanim); SELECT SCOPE_IDENTITY()";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Tanim", item.Tanim);
            return provider.ExecuteScalar<int>(cmdText, parameters);
        }

        public List<Unvan> GetAll()
        {
            var cmdText = string.Format("SELECT * FROM Unvan");
            DataTable dt = provider.ExecuteAdapter(cmdText,null);
            List<Unvan> result = new List<Unvan>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                result.Add(new Unvan()
                {
                    Id = Convert.ToInt32(dt.Rows[i]["Id"]),
                    Tanim = dt.Rows[i]["Tanim"].ToString()
                });
            }
            return result;
        }

        public Unvan GetById(int Id)
        {
            var cmdText = "SELECT * FROM Unvan WHERE Id=@Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id",Id);
            DataTable dt = provider.ExecuteAdapter(cmdText, parameters);
            Unvan result = null;
            if (dt.Rows.Count > 0)
            {
                result = new Unvan()
                {
                    Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                    Tanim = dt.Rows[0]["Tanim"].ToString()
                };
            }
            return result;
        }

        public void Remove(Unvan item)
        {
            var cmdText = "DELETE * FROM Unvan WHERE Id=@Id ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", item.Id);
            try { provider.ExecuteNonQuery(cmdText,parameters); }
            catch { throw new Exception(string.Format("{0} Id' li Kişi silinirken hata meydana geldi. İlişkili olduğu satırları gözden geçirin.", item.Id)); }
        }

        public Unvan Update(Unvan item)
        {
            var cmdText = "UPDATE Unvan SET Id=@Id, Tanim=@Tanim";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", item.Id);
            parameters.Add("@Tanim", item.Tanim);
            try
            {
                provider.ExecuteNonQuery(cmdText,parameters);
                return GetById(item.Id);
            }
            catch { throw new Exception(string.Format("{0} Id' li Kişi silinirken hata meydana geldi. İlişkili olduğu satırları gözden geçirin.", item.Id)); }
        }
    }
}
