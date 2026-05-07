using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace pr29_bartova.Classes.Common
{
    public class Config
    {
        public static string ConnectionConfig = "server=127.0.0.1; uid=root; pwd=; database=pcClub;";
        public static MySqlServerVersion Version = new MySqlServerVersion(new Version(8, 0, 11));
    }
}
