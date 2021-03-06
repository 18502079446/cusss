﻿/*
 * Copyright 2018 Alfresco and/or its affiliates.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
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
 *
 */

namespace Sys.Workflow.Cloud.Services.Events
{
    using Sys.Workflow.Cloud.Services.Api.Model;

    /// <summary>
    /// 
    /// </summary>
    public class TaskSuspendedEventImpl : AbstractProcessEngineEvent, ITaskSuspendedEvent
    {

        private readonly TaskModel task;


        /// <summary>
        /// 
        /// </summary>
        public TaskSuspendedEventImpl()
        {
        }


        /// <summary>
        /// 
        /// </summary>
        public TaskSuspendedEventImpl(string appName, string appVersion, string serviceName, string serviceFullName, string serviceType, string serviceVersion, string executionId, string processDefinitionId, string processInstanceId, TaskModel task) : base(appName, appVersion, serviceName, serviceFullName, serviceType, serviceVersion, executionId, processDefinitionId, processInstanceId)
        {
            this.task = task;
        }


        /// <summary>
        /// 
        /// </summary>
        public virtual TaskModel Task
        {
            get
            {
                return task;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public override string EventType
        {
            get
            {
                return "TaskSuspendedEvent";
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            return "TaskSuspendedEventImpl{" +
                    "task=" + task +
                    ", appName='" + AppName + '\'' +
                    ", appVersion='" + AppVersion + '\'' +
                    ", serviceName='" + ServiceName + '\'' +
                    ", serviceFullName='" + ServiceFullName + '\'' +
                    ", serviceType='" + ServiceType + '\'' +
                    ", serviceVersion='" + ServiceVersion + '\'' +
                    ", executionId='" + ExecutionId + '\'' +
                    ", processDefinitionId='" + ProcessDefinitionId + '\'' +
                    ", processInstanceId='" + ProcessInstanceId + '\'' +
                    ", timestamp=" + Timestamp +
                    '}';
        }
    }

}