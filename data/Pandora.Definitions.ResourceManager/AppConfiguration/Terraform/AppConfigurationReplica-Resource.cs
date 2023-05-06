using System;
using Pandora.Definitions.Helpers;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.AppConfiguration.Terraform;

public class AppConfigurationReplicaResource : TerraformResourceDefinition
{
    public string DisplayName => "App Configuration Replica";
    public ResourceID ResourceId => new v2023_03_01.Replicas.ReplicaId();
    public string ResourceLabel => "app_configuration_replicas";
    public string ResourceCategory => "App Configuration";
    public string ResourceDescription => @"Manages a App Configuration Replica";
    public string ResourceExampleUsage => @"resource 'azurerm_app_configuration_replicas' 'example' {
  configuration_store_name = 'foo'
  location                 = azurerm_resource_group.example.location
  name                     = 'example'
  resource_group_name      = azurerm_resource_group.example.name
}".AsTerraformTestConfig();
    public Type? SchemaModel => typeof(AppConfigurationReplicaResourceSchema);
    public TerraformMappingDefinition SchemaMappings => new AppConfigurationReplicaResourceMappings();
    public TerraformResourceTestDefinition Tests => new AppConfigurationReplicaResourceTests();

    public bool GenerateIDValidationFunction => true;
    public bool GenerateModel => true;
    public bool GenerateSchema => true;

    public MethodDefinition CreateMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2023_03_01.Replicas.CreateOperation),
        TimeoutInMinutes = 30,
    };
    public MethodDefinition DeleteMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2023_03_01.Replicas.DeleteOperation),
        TimeoutInMinutes = 30,
    };
    public MethodDefinition ReadMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2023_03_01.Replicas.GetOperation),
        TimeoutInMinutes = 5,
    };
    public MethodDefinition? UpdateMethod => null;
}
