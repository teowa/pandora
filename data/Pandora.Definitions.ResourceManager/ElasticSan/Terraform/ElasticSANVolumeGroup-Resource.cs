using System;
using Pandora.Definitions.Helpers;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANVolumeGroupResource : TerraformResourceDefinition
{
    public string DisplayName => "Elastic SAN Volume Group";
    public ResourceID ResourceId => new v2023_01_01.VolumeGroups.VolumeGroupId();
    public string ResourceLabel => "elastic_san_volume_group";
    public string ResourceCategory => "Elastic SAN";
    public string ResourceDescription => @"manages an Elastic SAN Volume Group";
    public string ResourceExampleUsage => @"resource 'azurerm_elastic_san_volume_group' 'example' {
  elastic_san_id = 'example-value'
  name           = 'example'
}".AsTerraformTestConfig();
    public Type? SchemaModel => typeof(ElasticSANVolumeGroupResourceSchema);
    public TerraformMappingDefinition SchemaMappings => new ElasticSANVolumeGroupResourceMappings();
    public TerraformResourceTestDefinition Tests => new ElasticSANVolumeGroupResourceTests();

    public bool GenerateIDValidationFunction => true;
    public bool GenerateModel => true;
    public bool GenerateSchema => true;

    public MethodDefinition CreateMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2023_01_01.VolumeGroups.CreateOperation),
        TimeoutInMinutes = 30,
    };
    public MethodDefinition DeleteMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2023_01_01.VolumeGroups.DeleteOperation),
        TimeoutInMinutes = 30,
    };
    public MethodDefinition ReadMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2023_01_01.VolumeGroups.GetOperation),
        TimeoutInMinutes = 5,
    };
    public MethodDefinition? UpdateMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2023_01_01.VolumeGroups.UpdateOperation),
        TimeoutInMinutes = 30,
    };
}
