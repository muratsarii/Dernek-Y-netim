using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DernekYonetim.DAL.Entities;
using System.Data.SqlClient;
using System.Data;

namespace DernekYonetim.DAL.Repositories
{
    public class AidatRepo:RepoBase,IRepo<Aidat>
    {
        IQueryBuilder _queryBuilder;
        public AidatRepo(IQueryBuilder qBuilder)
        {
            _queryBuilder = new SqlQueryBuilder();
        }
        public int Add(Aidat item)
        {
            var cmdTxt = string.Format("INSERT INTO Aidat(DonemId,KisiId,HareketId) VALUES(@DonemId,@KisiId,@HareketId); SELECT SCOPE_IDENTITY()");

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@DonemId", item.DonemId);
            parameters.Add("@KisiId", item.KisiId);
            parameters.Add("@HareketId", item.HareketId);
            return provider.ExecuteScalar<int>(cmdTxt, parameters);
        }

        public List<Aidat> GetAll()
        {
            var cmdText1 = _queryBuilder.SelectQuery<Aidat>();
            var cmdText = string.Format("SELECT * FROM Aidat");
            DataTable dt = provider.ExecuteAdapter(cmdText);
            List<Aidat> result = new List<Aidat>();
            for(int i =0; i<dt.Rows.Count; i++)
            {
                result.Add(new Aidat()
                {
                    Id= Convert.ToInt32(dt.Rows[i]["Id"]),
                    DonemId = Convert.ToInt32(dt.Rows[i]["DonemId"]),
                    KisiId = Convert.ToInt32(dt.Rows[i]["KisiId"]),
                    HareketId = Convert.ToInt32(dt.Rows[i]["HareketId"])
                });
            }
            return result;
        }

        public Aidat GetById(int Id)
        {
            var cmdText = "SELECT * FROM Aidat WHERE Id=@Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", Id);
            DataTable dt = provider.ExecuteAdapter(cmdText, parameters);
            Aidat result = null;
            if (dt.Rows.Count>0)
            {
                result = new Aidat()
                {
                    Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                    DonemId = Convert.ToInt32(dt.Rows[0]["DonemId"]),
                    KisiId = Convert.ToInt32(dt.Rows[0]["KisiId"]),
                    HareketId = Convert.ToInt32(dt.Rows[0]["HareketId"])
                };
            }
            return result;
        }

        public void Remove(Aidat item)
        {
            var cmdText = string.Format("DELETE * FROM Aidat WHERE Id=@Id");
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", item.Id);
            try { provider.ExecuteNonQuery(cmdText,parameters); }
            catch { throw new Exception(string.Format("{0} Id' li Kişi silinirken hata meydana geldi. İlişkili olduğu satırları gözden geçirin.", item.Id)); }
        }

        public Aidat Update(Aidat item)
        {
            var cmdText = "UPDATE Aidat SET DonemId=@DonemId, KisiId=@KisiId, HareketId=@HareketId WHERE Id =@Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", item.Id);
            parameters.Add("@DonemId", item.DonemId);
            parameters.Add("@KisiId", item.KisiId);
            parameters.Add("@HareketId", item.HareketId);
            try
            {
                provider.ExecuteNonQuery(cmdText,parameters);
                return GetById(item.Id);
            }
            catch { throw new Exception(string.Format("{0} Id' li Kişi silinirken hata meydana geldi. İlişkili olduğu satırları gözden geçirin.", item.Id)); }
        }
        public List<Aidat> GetAidatsByDonemId(int donemId)
        {
            var cmdText = "SELECT * FROM Aidat WHERE DonemId=@donemId";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@donemId", donemId);
            DataTable dt = provider.ExecuteAdapter(cmdText, parameters);
            List<Aidat> result = new List<Aidat>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                result.Add(new Aidat()
                {
                    Id = Convert.ToInt32(dt.Rows[i]["Id"]),
                    DonemId = Convert.ToInt32(dt.Rows[i]["DonemId"]),
                    KisiId = Convert.ToInt32(dt.Rows[i]["KisiId"]),
                    HareketId = Convert.ToInt32(dt.Rows[i]["HareketId"])
                });
            }
            return result;
        }
        public List<Aidat> KisiyeGoreAidatGetir(int kisiId)
        {
            var cmdText = string.Format("SELECT * FROM Aidat WHERE KisiId =@KisiId");
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@KisiId", kisiId);
            DataTable dt = provider.ExecuteAdapter(cmdText, parameters);
            List<Aidat> result = new List<Aidat>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                result.Add(new Aidat()
                {
                    Id = Convert.ToInt32(dt.Rows[i]["Id"]),
                    DonemId = Convert.ToInt32(dt.Rows[i]["DonemId"]),
                    KisiId = Convert.ToInt32(dt.Rows[i]["KisiId"]),
                    HareketId = Convert.ToInt32(dt.Rows[i]["HareketId"])
                });
            }
            return result;
        }
    }
}
