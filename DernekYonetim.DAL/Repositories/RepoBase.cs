using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekYonetim.DAL
{
    public abstract class RepoBase
    {
        protected string ConnectionString { get { return "Server = PC - 551; Database= DernekYonetimDb; Integrated Security = true;"; } }
        protected AdoProvider provider;
        public RepoBase()
        {
            provider = new AdoProvider(ConnectionString);

        }
    }
}
