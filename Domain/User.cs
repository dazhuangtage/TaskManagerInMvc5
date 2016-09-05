using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User:EntityBase
    {
        /// <summary>
        ///真实姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 用户帐号
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 是否锁定0否1是
        /// </summary>
        public int IsCanlogin { get; set; }

        /// <summary>
        /// 部门类的排序
        /// </summary>
        public int ShowOrder1 { get; set; }

        /// <summary>
        /// 公司内的排序
        /// </summary>
        public int ShowOrder2 { get; set; }

        /// <summary>
        /// 姓名全拼
        /// </summary>
        public string PINYIN1 { get; set; }

        /// <summary>
        /// 姓名首字符
        /// </summary>
        public string PINYIN2 { get; set; }


        /// <summary>
        /// 用户头像
        /// </summary>
        public string Face_Img { get; set; }

        /// <summary>
        /// 用户级别
        /// </summary>
        public string Levels { get; set; }

        /// <summary>
        /// 主部门ID，用户所在的部门
        /// </summary>
        public int Dptid { get; set; }

        /// <summary>
        /// 创建设
        /// </summary>
        public int Createper { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 修改者
        /// </summary>
        public string UpdateUser { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateData { get; set; }

        /// <summary>
        /// 最后一次登录IP
        /// </summary>
        public string LastLoginIP { get; set; }
    }
}
