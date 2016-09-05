using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// 数据库连接字符串提取操作
    /// 字符串对应应用程序中配置文件
    /// 模型对应Domain中的数据库模型Context.cs构造函数
    /// </summary>
    public class MyConfig : Entitiys
    {
        public System.Data.Entity.DbContext db { get; private set; }

        public MyConfig()
        {
            db = new Entitiys();
        }


        #region 配置数据库连接
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public static string DefaultConnectionString = "";

        public static IDbConnection DefaulrConnection
        {
            get
            {
                IDbConnection defaultConn = null;
                //数据库类型
                var action = System.Configuration.ConfigurationManager.AppSettings["RespotioyType"];
                switch (action)
                {
                    case "mssql":
                        defaultConn = new System.Data.SqlClient.SqlConnection();
                        DefaultConnectionString = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
                        break;
                    default:
                        break;
                }
                return defaultConn;
            }
        }


        public static string DataBaseConnectionString(string EntityName)
        {
            IDbConnection con = DefaulrConnection;
            return EFConnectionStringModle(EntityName, DefaultConnectionString);
        }


        /// <summary>
        /// 构造EF使用数据库连接字符串
        /// </summary>
        /// <param name="EntityName">数据上下文坏境</param>
        /// <param name="DBsoure">数据字符串</param>
        static string EFConnectionStringModle(string EntityName, string DBsoure)
        {
            return string.Concat("metadata=res://*/",
                EntityName, ".csdl|res://*/",
                EntityName, ".ssdl|res://*/",
                EntityName, ".msl;provider=System.Data.SqlClient;provider connection string='",
                DBsoure, "'");
        }
        #endregion
    }
}
