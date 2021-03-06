﻿using Sys.Workflow.Cloud.Services.Api.Model;
using Sys.Workflow.Cloud.Services.Rest.Api.Resources;
using Sys.Workflow.Cloud.Services.Rest.Controllers;
using Sys.Workflow.Hateoas;
using Sys.Workflow.Hateoas.Mvc;
using System;

namespace Sys.Workflow.Cloud.Services.Rest.Assemblers
{
    /// <summary>
    /// 
    /// </summary>
    public class ProcessDefinitionMetaResourceAssembler : ResourceAssemblerSupport<ProcessDefinitionMeta, ProcessDefinitionMetaResource>
    {
        /// <summary>
        /// 
        /// </summary>
        public ProcessDefinitionMetaResourceAssembler() : base(typeof(ProcessDefinitionMetaControllerImpl), typeof(ProcessDefinitionMetaResource))
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="processDefinitionMeta"></param>
        /// <returns></returns>
        public override ProcessDefinitionMetaResource ToResource(ProcessDefinitionMeta processDefinitionMeta)
        {
            //throw new NotImplementedException();
            //Link metadata = linkTo(methodOn(typeof(ProcessDefinitionMetaControllerImpl)).getProcessDefinitionMetadata(processDefinitionMeta.Id)).withRel("meta");
            //Link selfRel = linkTo(methodOn(typeof(ProcessDefinitionControllerImpl)).getProcessDefinition(processDefinitionMeta.Id)).withSelfRel();
            //Link startProcessLink = linkTo(methodOn(typeof(ProcessInstanceControllerImpl)).startProcess(null)).withRel("startProcess");
            //Link homeLink = linkTo(typeof(HomeControllerImpl)).withRel("home");

            return new ProcessDefinitionMetaResource(processDefinitionMeta, null);
        }
    }

}