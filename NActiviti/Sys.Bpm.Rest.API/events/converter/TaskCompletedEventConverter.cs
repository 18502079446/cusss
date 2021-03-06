﻿/*
 * Copyright 2018 Alfresco, Inc. and/or its affiliates.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *       http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Sys.Workflow.Cloud.Services.Api.Events;
using Sys.Workflow.Cloud.Services.Api.Model.Converters;
using Sys.Workflow.Cloud.Services.Events.Configurations;
using Sys.Workflow.Engine.Delegate.Events;
using Sys.Workflow.Engine.Tasks;

namespace Sys.Workflow.Cloud.Services.Events.Converters
{

    /// <summary>
    /// 
    /// </summary>
    public class TaskCompletedEventConverter : AbstractEventConverter
    {
        private readonly TaskConverter taskConverter;


        /// <summary>
        /// 
        /// </summary>
        public TaskCompletedEventConverter(TaskConverter taskConverter, RuntimeBundleProperties runtimeBundleProperties) : base(runtimeBundleProperties)
        {
            this.taskConverter = taskConverter;
        }


        /// <summary>
        /// 
        /// </summary>
        public override IProcessEngineEvent From(IActivitiEvent @event)
        {
            return new TaskCompletedEventImpl(RuntimeBundleProperties.AppName, RuntimeBundleProperties.AppVersion, RuntimeBundleProperties.ServiceName, RuntimeBundleProperties.ServiceFullName, RuntimeBundleProperties.ServiceType, RuntimeBundleProperties.ServiceVersion, @event.ExecutionId, @event.ProcessDefinitionId, @event.ProcessInstanceId, taskConverter.From((ITask)((IActivitiEntityEvent)@event).Entity));
        }


        /// <summary>
        /// 
        /// </summary>
        public override string HandledType()
        {
            return "Task:" + ActivitiEventType.TASK_COMPLETED.ToString();
        }
    }

}