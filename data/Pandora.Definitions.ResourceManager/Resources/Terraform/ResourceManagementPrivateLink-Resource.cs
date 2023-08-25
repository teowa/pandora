using System;
using Pandora.Definitions.Helpers;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.Resources.Terraform;

public class ResourceManagementPrivateLinkResource : TerraformResourceDefinition
{
    public string DisplayName => "Resource Management Private Link";
    public ResourceID ResourceId => new v2020_05_01.ResourceManagementPrivateLink.ResourceManagementPrivateLinkId();
    public string ResourceLabel => "resource_management_private_link";
    public string ResourceCategory => "Network";
    public string ResourceDescription => @"Manages a Resource Management Private Link";
    public string ResourceExampleUsage => @"resource 'azurerm_resource_group' 'example' {
  name     = 'example-resources'
  location = 'West Europe'
}
resource 'azurerm_resource_management_private_link' 'example' {
  location            = azurerm_resource_group.example.location
  name                = 'example'
  resource_group_name = azurerm_resource_group.example.name
}".AsTerraformTestConfig();
    public Type? SchemaModel => typeof(ResourceManagementPrivateLinkResourceSchema);
    public TerraformMappingDefinition SchemaMappings => new ResourceManagementPrivateLinkResourceMappings();
    public TerraformResourceTestDefinition Tests => new ResourceManagementPrivateLinkResourceTests();

    public bool GenerateIDValidationFunction => true;
    public bool GenerateModel => true;
    public bool GenerateSchema => true;

    public MethodDefinition CreateMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2020_05_01.ResourceManagementPrivateLink.PutOperation),
        TimeoutInMinutes = 30,
    };
    public MethodDefinition DeleteMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2020_05_01.ResourceManagementPrivateLink.DeleteOperation),
        TimeoutInMinutes = 30,
    };
    public MethodDefinition ReadMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2020_05_01.ResourceManagementPrivateLink.GetOperation),
        TimeoutInMinutes = 5,
    };
    public MethodDefinition? UpdateMethod => null;
}
