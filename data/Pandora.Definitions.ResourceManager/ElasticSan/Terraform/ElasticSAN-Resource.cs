using System;
using Pandora.Definitions.Helpers;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANResource : TerraformResourceDefinition
{
    public string DisplayName => "Elastic SAN";
    public ResourceID ResourceId => new v2023_01_01.ElasticSans.ElasticSanId();
    public string ResourceLabel => "elastic_san";
    public string ResourceCategory => "Elastic SAN";
    public string ResourceDescription => @"manages an Elastic SAN instance";
    public string ResourceExampleUsage => @"resource 'azurerm_resource_group' 'example' {
  name     = 'example-resources'
  location = 'West Europe'
}
resource 'azurerm_elastic_san' 'example' {
  base_size_tib              = 'example-value'
  extended_capacity_size_tib = 'example-value'
  location                   = azurerm_resource_group.example.location
  name                       = 'example'
  resource_group_name        = azurerm_resource_group.example.name
  sku {
    name = 'example-value'
  }
}".AsTerraformTestConfig();
    public Type? SchemaModel => typeof(ElasticSANResourceSchema);
    public TerraformMappingDefinition SchemaMappings => new ElasticSANResourceMappings();
    public TerraformResourceTestDefinition Tests => new ElasticSANResourceTests();

    public bool GenerateIDValidationFunction => true;
    public bool GenerateModel => true;
    public bool GenerateSchema => true;

    public MethodDefinition CreateMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2023_01_01.ElasticSans.CreateOperation),
        TimeoutInMinutes = 30,
    };
    public MethodDefinition DeleteMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2023_01_01.ElasticSans.DeleteOperation),
        TimeoutInMinutes = 30,
    };
    public MethodDefinition ReadMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2023_01_01.ElasticSans.GetOperation),
        TimeoutInMinutes = 5,
    };
    public MethodDefinition? UpdateMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2023_01_01.ElasticSans.UpdateOperation),
        TimeoutInMinutes = 30,
    };
}
