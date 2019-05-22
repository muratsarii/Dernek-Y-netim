using DernekYonetim.DAL.Entities;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekYonetim.DAL.Repositories
{
    public class KisiRepo : RepoBase, IRepo<Kisi>
    {
        public KisiRepo()
        {

        }
        public int Add(Kisi item)
        {
            var cmdText = "INSERT INTO Kisi (Ad, Soyad,Telefon, Email) VALUES(@Ad,@Soyad,@Telefon,@Email); SELECT SCOPE_IDENTITY() ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Ad", item.Ad);
            parameters.Add("@Soyad", item.Soyad);
            parameters.Add("@Telefon", item.Telefon);
            parameters.Add("@Email", item.Email);
            return provider.ExecuteScalar<int>(cmdText,parameters);
        }

        public List<Kisi> GetAll()
        {
            var cmdText = string.Format("SELECT * FROM Kisi ");
            DataTable dt = provider.ExecuteAdapter(cmdText, null);
            List<Kisi> result = new List<Kisi>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                result.Add(new Kisi()
                {
                    Id = Convert.ToInt32(dt.Rows[i]["Id"]),
                    Ad = dt.Rows[i]["Ad"].ToString(),
                    Soyad = dt.Rows[i]["Soyad"].ToString(),
                    Telefon = dt.Rows[i]["Telefon"].ToString(),
                    Email = dt.Rows[i]["EMail"].ToString()
                });
            }
            return result;
        }

        public Kisi GetById(int Id)
        {
            var cmdText = "SELECT * FROM Kisi WHERE Id= @Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", Id);
            DataTable dt = provider.ExecuteAdapter(cmdText, parameters);
            Kisi result = null;
            if (dt.Rows.Count > 0)
            {
                result = new Kisi()
                {
                    Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                    Ad = dt.Rows[0]["Ad"].ToString(),
                    Soyad = dt.Rows[0]["Soyad"].ToString(),
                    Telefon = dt.Rows[0]["Telefon"].ToString(),
                    Email = dt.Rows[0]["EMail"].ToString()
                };
            }
            return result;
        }

        public void Remove(Kisi item)
        {
            var cmdText = "DELETE * FROM Kisi WHERE Id= @Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", item.Id);
            try { provider.ExecuteNonQuery(cmdText,parameters); }
            catch { throw new Exception(string.Format("{0} Id' li Kişi silinirken hata meydana geldi. İlişkili olduğu satırları gözden geçirin.", item.Id)); }
            
        }

        public Kisi Update(Kisi item)
        {
            var cmdText = "UPDATE Kisi SET Ad=@Ad, Soyad=@Soyad, Telefon= @Telefon,Email=@Email WHERE Id= @Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", item.Id);
            parameters.Add("@Ad", item.Ad);
            parameters.Add("@Soyad", item.Soyad);
            parameters.Add("@Telefon", item.Telefon);
            parameters.Add("@Email", item.Email);
            try
            {
                provider.ExecuteNonQuery(cmdText,parameters);
                return GetById(item.Id);
            }
            catch { throw new Exception(string.Format("{0} Id' li Kişi silinirken hata meydana geldi. İlişkili olduğu satırları gözden geçirin.", item.Id)); }

        }
    }
}
