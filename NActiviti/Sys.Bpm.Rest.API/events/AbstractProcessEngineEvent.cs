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

namespace org.activiti.cloud.services.events
{
    using IProcessEngineEvent = org.activiti.cloud.services.api.events.IProcessEngineEvent;

    public abstract class AbstractProcessEngineEvent : IProcessEngineEvent
    {
        public abstract string EventType { get; }

        private string appName;
        private string appVersion;
        private string serviceName;
        private string serviceFullName;
        private string serviceType;
        private string serviceVersion;
        private string executionId;
        private string processDefinitionId;
        private string processInstanceId;
        private long? timestamp;

        public AbstractProcessEngineEvent()
        {
        }

        public AbstractProcessEngineEvent(string appName, string appVersion, string serviceName, string serviceFullName, string serviceType, string serviceVersion, string executionId, string processDefinitionId, string processInstanceId)
        {
            this.appName = appName;
            this.appVersion = appVersion;
            this.serviceName = serviceName;
            this.serviceFullName = serviceFullName;
            this.serviceType = serviceType;
            this.serviceVersion = serviceVersion;
            this.executionId = executionId;
            this.processDefinitionId = processDefinitionId;
            this.processInstanceId = processInstanceId;
            this.timestamp = DateTimeHelper.CurrentUnixTimeMillis();
        }

        public AbstractProcessEngineEvent(string appName, string appVersion, string serviceName, string serviceFullName, string serviceType, string serviceVersion, string executionId, string processDefinitionId, string processInstanceId, long? timestamp)
        {
            this.appName = appName;
            this.appVersion = appVersion;
            this.serviceName = serviceName;
            this.serviceFullName = serviceFullName;
            this.serviceType = serviceType;
            this.serviceVersion = serviceVersion;
            this.executionId = executionId;
            this.processDefinitionId = processDefinitionId;
            this.processInstanceId = processInstanceId;
            this.timestamp = timestamp;
        }

        public virtual string ExecutionId
        {
            get
            {
                return executionId;
            }
        }

        public virtual string ProcessDefinitionId
        {
            get
            {
                return processDefinitionId;
            }
        }

        public virtual string ProcessInstanceId
        {
            get
            {
                return processInstanceId;
            }
        }

        public virtual long? Timestamp
        {
            get
            {
                return timestamp;
            }
        }

        public virtual string AppName
        {
            get
            {
                return appName;
            }
        }

        public virtual string AppVersion
        {
            get
            {
                return appVersion;
            }
        }

        public virtual string ServiceName
        {
            get
            {
                return serviceName;
            }
        }

        public virtual string ServiceFullName
        {
            get
            {
                return serviceFullName;
            }
        }

        public virtual string ServiceType
        {
            get
            {
                return serviceType;
            }
        }

        public virtual string ServiceVersion
        {
            get
            {
                return serviceVersion;
            }
        }
    }

}