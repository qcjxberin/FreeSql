﻿//using FreeSql.DataAnnotations;
using FreeSql.DataAnnotations;
using System;

namespace FreeSql.Site.Entity
{
    /// <summary>
    /// 数据库实体
    /// </summary>
    public class DocumentContent : BaseEntity
    {
        /// <summary>
        /// 类型编号
        /// </summary>
        public int TypeID { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string DocTitle { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        public string DocAbstract { get; set; }

        /// <summary>
        /// 文档内容
        /// </summary>
        [Column(DbType = "text")]
        public string DocContent { get; set; }

        /// <summary>
        /// 查看次数
        /// </summary>
        public int WatchCount { get; set; }

        /// <summary>
        /// Star统计
        /// </summary>
        public int StarCount { get; set; }


        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? UpdateDt { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public string UpdateBy { get; set; }
    }

    /// <summary>
    /// 返回实体内容
    /// </summary>
    public class DocumentContentView : DocumentContent
    {

    }
}