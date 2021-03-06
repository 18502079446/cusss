///////////////////////////////////////////////////////////
//  QueryBookmark.cs
//  Implementation of the Class QueryBookmark
//  Generated by Enterprise Architect
//  Created on:      30-1月-2019 8:32:00
//  Original author: 张楠
///////////////////////////////////////////////////////////

namespace Sys.Workflow.Engine.Bpmn.Rules
{
    /// <summary>
    /// 会签人员查询条件DTO
    /// </summary>
    public class QueryBookmark
    {
        public QueryBookmark()
        {

        }

        /// <summary>
        /// 规则类型
        /// </summary>
        public string RuleType { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        public string RuleName { get; set; }

        /// <summary>
        /// 查询条件
        /// </summary>
        public QueryCondition[] QueryCondition { get; set; }
    }
}