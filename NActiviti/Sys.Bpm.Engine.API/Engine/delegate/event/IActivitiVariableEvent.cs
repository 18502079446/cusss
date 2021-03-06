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
namespace Sys.Workflow.Engine.Delegate.Events
{
    using Sys.Workflow.Engine.Impl.Variable;

    /// <summary>
    /// An <seealso cref="IActivitiEvent"/> related to a single variable.
    /// 
    /// 
    /// 
    /// </summary>
    public interface IActivitiVariableEvent : IActivitiEvent
    {

        /// <returns> the name of the variable involved. </returns>
        string VariableName { get; }

        /// <returns> the current value of the variable. </returns>
        object VariableValue { get; }

        /// <returns> The <seealso cref="VariableType"/> of the variable. </returns>
        IVariableType VariableType { get; }

        /// <returns> the id of the execution the variable is set on. </returns>
        new string ExecutionId { get; }

        /// <returns> the id of the task the variable has been set on. </returns>
        string TaskId { get; }
    }

}