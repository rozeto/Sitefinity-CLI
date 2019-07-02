﻿using McMaster.Extensions.CommandLineUtils;
using Sitefinity_CLI.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace Sitefinity_CLI.Commands
{
    [Command(Name = Constants.AddModuleCommandName, Description = "Adds a new module to the current project.", FullName = Constants.AddModuleCommandFullName)]
    internal class AddModuleCommand : AddToSitefinityCommandBase
    {
        protected override string FolderPath => Constants.ModuleFolderName;

        protected override string CreatedMessage => Constants.ModuleCreatedMessage;

        protected override string TemplatesFolder => Constants.ModuleTemplatesFolderName;

        protected override ICollection<FileModel> GetFileModels()
        {
            var models = base.GetFileModels();
            models.Add(new FileModel()
            {
                FilePath = Path.Combine(this.ProjectRootPath, Constants.ModuleFolderName, this.Name, string.Format("{0}{1}{2}", this.Name, "Module", Constants.CSharpFileExtension)),
                TemplatePath = Path.Combine(this.CurrentPath, Constants.TemplatesFolderName, this.Version, Constants.ModuleTemplatesFolderName, this.TemplateName, "Module.Template")
            });
            models.Add(new FileModel()
            {
                FilePath = Path.Combine(this.ProjectRootPath, Constants.ModuleFolderName, this.Name, string.Format("{0}{1}{2}", this.Name, "ModuleConfig", Constants.CSharpFileExtension)),
                TemplatePath = Path.Combine(this.CurrentPath, Constants.TemplatesFolderName, this.Version, Constants.ModuleTemplatesFolderName, this.TemplateName, "ModuleConfig.Template")
            });
            models.Add(new FileModel()
            {
                FilePath = Path.Combine(this.ProjectRootPath, Constants.ModuleFolderName, this.Name, string.Format("{0}{1}{2}", this.Name, "ModuleDataProvider", Constants.CSharpFileExtension)),
                TemplatePath = Path.Combine(this.CurrentPath, Constants.TemplatesFolderName, this.Version, Constants.ModuleTemplatesFolderName, this.TemplateName, "ModuleDataProvider.Template")
            });
            models.Add(new FileModel()
            {
                FilePath = Path.Combine(this.ProjectRootPath, Constants.ModuleFolderName, this.Name, string.Format("{0}{1}{2}", this.Name, "ModuleDefinition", Constants.CSharpFileExtension)),
                TemplatePath = Path.Combine(this.CurrentPath, Constants.TemplatesFolderName, this.Version, Constants.ModuleTemplatesFolderName, this.TemplateName, "ModuleDefinition.Template")
            });
            models.Add(new FileModel()
            {
                FilePath = Path.Combine(this.ProjectRootPath, Constants.ModuleFolderName, this.Name, string.Format("{0}{1}{2}", this.Name, "ModuleItem", Constants.CSharpFileExtension)),
                TemplatePath = Path.Combine(this.CurrentPath, Constants.TemplatesFolderName, this.Version, Constants.ModuleTemplatesFolderName, this.TemplateName, "ModuleItem.Template")
            });
            models.Add(new FileModel()
            {
                FilePath = Path.Combine(this.ProjectRootPath, Constants.ModuleFolderName, this.Name, string.Format("{0}{1}{2}", this.Name, "ModuleManager", Constants.CSharpFileExtension)),
                TemplatePath = Path.Combine(this.CurrentPath, Constants.TemplatesFolderName, this.Version, Constants.ModuleTemplatesFolderName, this.TemplateName, "ModuleManager.Template")
            });
            models.Add(new FileModel()
            {
                FilePath = Path.Combine(this.ProjectRootPath, Constants.ModuleFolderName, this.Name, string.Format("{0}{1}{2}", this.Name, "ModuleResources", Constants.CSharpFileExtension)),
                TemplatePath = Path.Combine(this.CurrentPath, Constants.TemplatesFolderName, this.Version, Constants.ModuleTemplatesFolderName, this.TemplateName, "ModuleResources.Template")
            });
            models.Add(new FileModel()
            {
                FilePath = Path.Combine(this.ProjectRootPath, Constants.ModuleFolderName, this.Name, string.Format("{0}{1}{2}", this.Name, "ModuleView", Constants.CSharpFileExtension)),
                TemplatePath = Path.Combine(this.CurrentPath, Constants.TemplatesFolderName, this.Version, Constants.ModuleTemplatesFolderName, this.TemplateName, "ModuleView.Template")
            });
            models.Add(new FileModel()
            {
                FilePath = Path.Combine(this.ProjectRootPath, Constants.ModuleFolderName, this.Name, string.Format("{0}{1}", $"OpenAccess{this.Name}ModuleProvider", Constants.CSharpFileExtension)),
                TemplatePath = Path.Combine(this.CurrentPath, Constants.TemplatesFolderName, this.Version, Constants.ModuleTemplatesFolderName, this.TemplateName, "OpenAccessModuleProvider.Template")
            });

            return models;
        }
    }
}