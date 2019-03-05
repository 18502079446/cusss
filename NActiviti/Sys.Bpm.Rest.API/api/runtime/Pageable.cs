﻿
using Newtonsoft.Json;

namespace org.activiti.api.runtime.shared.query
{
    /// <summary>
    /// 分页
    /// </summary>
    public class Pageable
    {
        public Pageable()
        {

        }

        /// <summary>
        /// 排序
        /// </summary>
        public Sort Sort { get; set; }

        /// <summary>
        /// 起始位置
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        public int PageSize { get; set; }
    }
}