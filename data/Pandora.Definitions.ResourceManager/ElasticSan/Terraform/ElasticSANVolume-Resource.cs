using System;
using Pandora.Definitions.Helpers;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANVolumeResource : TerraformResourceDefinition
{
    public string DisplayName => "Elastic SAN Volume";
    public ResourceID ResourceId => new v2023_01_01.Volumes.VolumeId();
    public string ResourceLabel => "elastic_san_volume";
    public string ResourceCategory => "Elastic SAN";
    public string ResourceDescription => @"manages an Elastic SAN Volume";
    public string ResourceExampleUsage => @"resource 'azurerm_elastic_san_volume' 'example' {
  name            = 'example'
  size_gib        = 'example-value'
  volume_group_id = 'example-value'
}".AsTerraformTestConfig();
    public Type? SchemaModel => typeof(ElasticSANVolumeResourceSchema);
    public TerraformMappingDefinition SchemaMappings => new ElasticSANVolumeResourceMappings();
    public TerraformResourceTestDefinition Tests => new ElasticSANVolumeResourceTests();

    public bool GenerateIDValidationFunction => true;
    public bool GenerateModel => true;
    public bool GenerateSchema => true;

    public MethodDefinition CreateMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2023_01_01.Volumes.CreateOperation),
        TimeoutInMinutes = 30,
    };
    public MethodDefinition DeleteMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2023_01_01.Volumes.DeleteOperation),
        TimeoutInMinutes = 30,
    };
    public MethodDefinition ReadMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2023_01_01.Volumes.GetOperation),
        TimeoutInMinutes = 5,
    };
    public MethodDefinition? UpdateMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2023_01_01.Volumes.UpdateOperation),
        TimeoutInMinutes = 30,
    };
}
