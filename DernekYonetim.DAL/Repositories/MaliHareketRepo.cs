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
    public class MaliHareketRepo : RepoBase, IRepo<MaliHareket>
    {
        public int Add(MaliHareket item)
        {
            var cmdText = "INSERT INTO MaliHareket (DonemId,TipiId,Miktar) VALUES (@DonemId,@TipiId,@Miktar); SELECT SCOPE_IDENTITY()";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@TipiId", item.TipiId);
            parameters.Add("@TipiId", item.TipiId);
            parameters.Add("@Miktar", item.Miktar);
            return provider.ExecuteScalar<int>(cmdText, parameters);
        }

        public List<MaliHareket> GetAll()
        {
            var cmdText = string.Format("SELECT * FROM MaliHareket");
            DataTable dt = provider.ExecuteAdapter(cmdText,null);
            List<MaliHareket> result = new List<MaliHareket>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                result.Add(new MaliHareket()
                {
                    Id = Convert.ToInt32(dt.Rows[i]["Id"]),
                    KisiId = Convert.ToInt32(dt.Rows[i]["KisiId"]),
                    TipiId = Convert.ToInt32(dt.Rows[i]["TipId"]),
                    Miktar = Convert.ToDecimal(dt.Rows[i]["Miktar"])
                });
            }
            return result;
        }

        public MaliHareket GetById(int Id)
        {
            var cmdTxt = string.Format("SELECT * FROM Aidat WHERE Id=@Id");
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", Id);
            DataTable dt = provider.ExecuteAdapter(cmdTxt, parameters);
            MaliHareket result = null;
            if (dt.Rows.Count > 0)
            {
                result = new MaliHareket()
                {
                    Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                    KisiId = Convert.ToInt32(dt.Rows[0]["KisiId"]),
                    TipiId = Convert.ToInt32(dt.Rows[0]["TipId"]),
                    Miktar = Convert.ToDecimal(dt.Rows[0]["Miktar"])
                };
            }
            return result;
        }

        public void Remove(MaliHareket item)
        {
            var cmdText = "DELETE * FROM Aidat WHERE Id=@Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", item.Id);
            try { provider.ExecuteNonQuery(cmdText, parameters); }
            catch { throw new Exception(string.Format("{0} Id' li Kişi silinirken hata meydana geldi. İlişkili olduğu satırları gözden geçirin.", item.Id)); }
        }

        public MaliHareket Update(MaliHareket item)
        {
            var cmdText = "UPDATE Aidat SET DonemId=@DonemId, KisiId=@KisiId, HareketId=@HareketId WHERE Id =@Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", item.Id);
            parameters.Add("@KisiId", item.KisiId);
            parameters.Add("@TipId", item.TipiId);
            parameters.Add("@Miktar", item.Miktar);
            try
            {
                provider.ExecuteNonQuery(cmdText, parameters);
                return GetById(item.Id);
            }
            catch { throw new Exception(string.Format("{0} Id' li Kişi silinirken hata meydana geldi. İlişkili olduğu satırları gözden geçirin.", item.Id)); }
        }
        public List<MaliHareket> GetMaliHareketsByKisiId(int KisiId)
        {
            var cmdText = string.Format("SELECT * FROM MaliHareket WHERE KisiId=@KisiId");
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@KisiId", KisiId);
            DataTable dt = provider.ExecuteAdapter(cmdText, parameters);
            List<MaliHareket> result = new List<MaliHareket>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                result.Add(new MaliHareket()
                {
                    Id = Convert.ToInt32(dt.Rows[i]["Id"]),
                    KisiId = Convert.ToInt32(dt.Rows[i]["KisiId"]),
                    TipiId = Convert.ToInt32(dt.Rows[i]["TipiId"]),
                    Miktar = Convert.ToDecimal(dt.Rows[i]["Miktar"])
                });
            }
            return result;
        }
    }
}
