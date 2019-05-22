using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data;
using DernekYonetim.DAL.Entities;

namespace DernekYonetim.DAL.Repositories
{
    public class DonemRepo : RepoBase, IRepo<Donem>
    {
        private AdoProvider provider;
        public DonemRepo()
        {

        }

        public int Add(Donem item)
        {
            var komutText = "INSERT INTO Donem (Ay,Yil,Tanim) VALUES (@Ay, @Yil, @Tanim); SELECT SCOPE_IDENTITY()";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Ay", item.Ay);
            parameters.Add("@Yil", item.Yil);
            parameters.Add("@Tanim", item.Tanim);
            return provider.ExecuteScalar<int>(komutText, parameters);
        }

        public List<Donem> GetAll()
        {
            var komutText = string.Format("SELECT * FROM Donem");
            DataTable dt = provider.ExecuteAdapter(komutText);
            List<Donem> result = new List<Donem>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                result.Add(new Donem()
                {
                    Id = Convert.ToInt32(dt.Rows[i]["Id"]),
                    Ay = Convert.ToInt32(dt.Rows[i]["Ay"]),
                    Yil = Convert.ToInt32(dt.Rows[i]["Yil"]),
                    Tanim = Convert.ToString(dt.Rows[i]["Tanim"])
                });
            }
            return result;
        }

        public Donem GetById(int Id)
        {
            var komutText = "SELECT * FROM Donem WHERE Id =@Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", Id);
            DataTable dt = provider.ExecuteAdapter(komutText, parameters);
            Donem result = null;
            if (dt.Rows.Count>0)
            {
                result = new Donem()
                {
                    Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                    Ay = Convert.ToInt32(dt.Rows[0]["Ay"]),
                    Yil = Convert.ToInt32(dt.Rows[0]["Yil"]),
                    Tanim = Convert.ToString(dt.Rows[0]["Tanim"])
                };
            }
            return result;
        }

        public void Remove(Donem item)
        {
            var komutText = "DELETE * FROM Donem WHERE Id =@Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", item.Id);
            try { provider.ExecuteNonQuery(komutText,parameters); }
            catch { throw new Exception(string.Format("{0} Id' li Kişi silinirken hata meydana geldi. İlişkili olduğu satırları gözden geçirin.", item.Id)); }
        }

        public Donem Update(Donem item)
        {
            var komutText = "UPDATE Donem SET Ay=@Ay, Yil=@Yil, Tanim=@Tanim WHERE Id=@Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", item.Id);
            parameters.Add("@Ay", item.Ay);
            parameters.Add("@Yil", item.Yil);
            parameters.Add("@Tanim", item.Tanim);
            try
            {
                provider.ExecuteNonQuery(komutText,parameters);
                return GetById(item.Id);
            }
            catch { throw new Exception(string.Format("{0} Id' li Kişi silinirken hata meydana geldi. İlişkili olduğu satırları gözden geçirin.", item.Id)); }
        }
        public Donem GetByMonthAndYear(int ay, int yil)
        {
            var komutText = "SELECT * FROM Donem WHERE Ay =@Ay AND Yil =@Yil";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Ay", ay);
            parameters.Add("@Yil", yil);
            DataTable dt = provider.ExecuteAdapter(komutText, parameters);
            Donem result = null;
            if (dt.Rows.Count>0)
            {
                result = new Donem()
                {
                    Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                    Ay = Convert.ToInt32(dt.Rows[0]["Ay"]),
                    Yil = Convert.ToInt32(dt.Rows[0]["Yil"]),
                    Tanim = dt.Rows[0]["Tanim"].ToString()
                };
            }
            return result;
        }
    }
}
