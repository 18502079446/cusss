﻿/* Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *      http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using SmartSql;
using SmartSql.Abstractions;
using Sys;
using Sys.Data;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace org.activiti.engine.impl.db
{
    /// <summary>
    /// Use this to execute a dedicated delete statement. It
    /// is important to note there won't be any optimistic locking checks done for
    /// these kind of delete operations!
    /// 
    /// 
    /// </summary>
    public class BulkDeleteOperation
    {

        protected internal string statement;
        protected internal object parameter;

        public BulkDeleteOperation(string statement, object parameter)
        {
            this.statement = statement;
            this.parameter = parameter;
        }

        public virtual void execute(Type entityClass, ISmartSqlMapper sqlMapper)
        {
            sqlMapper.Execute(new RequestContext
            {
                Scope = entityClass.FullName,
                SqlId = statement,
                Request = parameter
            });//.delete(statement, parameter);
        }

        public override string ToString()
        {
            return "bulk delete: " + statement + "(" + parameter + ")";
        }
    }
}