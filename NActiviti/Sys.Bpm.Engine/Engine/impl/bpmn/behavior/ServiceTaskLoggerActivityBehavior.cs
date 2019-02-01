﻿using System;

/* Licensed under the Apache License, Version 2.0 (the "License");
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

namespace org.activiti.engine.impl.bpmn.behavior
{
    using Microsoft.Extensions.FileProviders;
    using Microsoft.Extensions.Logging;
    using Newtonsoft.Json.Linq;
    using org.activiti.engine.@delegate;
    using org.activiti.engine.impl.bpmn.helper;
    using org.activiti.engine.impl.context;
    using org.activiti.engine.impl.persistence.entity;
    using org.activiti.engine.runtime;
    using Sys;
    using System.IO;

    /// <summary>
    /// ActivityBehavior that evaluates an expression when executed. Optionally, it sets the result of the expression as a variable on the execution.
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// </summary>
    [Serializable]
    public class ServiceTaskLoggerActivityBehavior : TaskActivityBehavior
    {
        private const long serialVersionUID = 1L;

        private static readonly ILogger logger = ProcessEngineServiceProvider.LoggerService<ServiceTaskLoggerActivityBehavior>();

        public override void execute(IExecutionEntity execution)
        {
            try
            {
                execution.WriteDebugLog();

                leave(execution);
            }
            catch (Exception exc)
            {
                logger.LogError($"execution {execution.ActivityId} failed,exception: {exc.Message}");
            }
        }
    }
}