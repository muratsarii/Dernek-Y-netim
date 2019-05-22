using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DernekYonetim.DAL.Entities;
using System.Data;


namespace DernekYonetim.DAL.Repositories
{
    public class HareketTipRepo : RepoBase, IRepo<HareketTip>
    {
        public int Add(HareketTip item)
        {
            var cmdText = "INSERT INTO HareketTip (Tanim) VALUES(@Tanim); SELECT SCOPE_IDENTITY()";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Tanim", item.Tanim);
            return provider.ExecuteScalar<int>(cmdText,parameters);
        }

        public List<HareketTip> GetAll()
        {
            var cmdText = string.Format("SELECT * FROM HareketTip");
            DataTable dt = provider.ExecuteAdapter(cmdText, null);
            List<HareketTip> result = new List<HareketTip>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                result.Add(new HareketTip()
                {
                    Id = Convert.ToInt32(dt.Rows[i]["Id"]),
                    Tanim = dt.Rows[i]["Tanim"].ToString()
                });
            }
            return result;
        }

        public HareketTip GetById(int Id)
        {
            var cmdText = "SELECT * FROM HareketTip WHERE Id =@Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", Id);
            DataTable dt = provider.ExecuteAdapter(cmdText, parameters);
            HareketTip result = null;
            if (dt.Rows.Count>0)
            {
                result = new HareketTip()
                {
                    Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                    Tanim = dt.Rows[0]["Tanim"].ToString()
                };
            }
            return result;
        }

        public void Remove(HareketTip item)
        {
            var cmdText = "DELETE * FROM HareketTip WHERE Id=@Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", item.Id);
            try { provider.ExecuteNonQuery(cmdText, parameters); }
            catch { throw new Exception(string.Format("{0} Id' li Kişi silinirken hata meydana geldi. İlişkili olduğu satırları gözden geçirin.", item.Id)); }
        }

        public HareketTip Update(HareketTip item)
        {
            var cmdText = "UPDATE HareketTip SET Tanim=@Tanim WHERE Id=@Id";
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

        public HareketTip GetByTanim (string tanim)
        {
            var cmdText = "SELECT * FROM HareketTip WHERE Tanim =@Tanim";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Tanim", tanim);
            DataTable dt = provider.ExecuteAdapter(cmdText, parameters);
            HareketTip result = null;
            if (dt.Rows.Count>0)
            {
                result = new HareketTip()
                {
                    Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                    Tanim = dt.Rows[0]["Tanim"].ToString()
                };
            }
            return result;
        }
    }
}
