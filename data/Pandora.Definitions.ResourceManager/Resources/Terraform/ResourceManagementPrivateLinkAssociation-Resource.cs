using System;
using Pandora.Definitions.Helpers;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.Resources.Terraform;

public class ResourceManagementPrivateLinkAssociationResource : TerraformResourceDefinition
{
    public string DisplayName => "Resource Management Private Link Association";
    public ResourceID ResourceId => new v2020_05_01.PrivateLinkAssociation.PrivateLinkAssociationId();
    public string ResourceLabel => "resource_management_private_link_association";
    public string ResourceCategory => "Network";
    public string ResourceDescription => @"Manages a Resource Management Private Link Association";
    public string ResourceExampleUsage => @"resource 'azurerm_resource_management_private_link_association' 'example' {
  group_id = 'example-value'
  name     = 'example'
}".AsTerraformTestConfig();
    public Type? SchemaModel => typeof(ResourceManagementPrivateLinkAssociationResourceSchema);
    public TerraformMappingDefinition SchemaMappings => new ResourceManagementPrivateLinkAssociationResourceMappings();
    public TerraformResourceTestDefinition Tests => new ResourceManagementPrivateLinkAssociationResourceTests();

    public bool GenerateIDValidationFunction => true;
    public bool GenerateModel => true;
    public bool GenerateSchema => true;

    public MethodDefinition CreateMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2020_05_01.PrivateLinkAssociation.PutOperation),
        TimeoutInMinutes = 30,
    };
    public MethodDefinition DeleteMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2020_05_01.PrivateLinkAssociation.DeleteOperation),
        TimeoutInMinutes = 30,
    };
    public MethodDefinition ReadMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2020_05_01.PrivateLinkAssociation.GetOperation),
        TimeoutInMinutes = 5,
    };
    public MethodDefinition? UpdateMethod => null;
}
