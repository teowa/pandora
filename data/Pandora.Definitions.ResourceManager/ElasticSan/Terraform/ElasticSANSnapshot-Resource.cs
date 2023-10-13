using System;
using Pandora.Definitions.Helpers;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANSnapshotResource : TerraformResourceDefinition
{
    public string DisplayName => "Elastic SAN Snapshot";
    public ResourceID ResourceId => new v2023_01_01.Snapshots.SnapshotId();
    public string ResourceLabel => "elastic_san_snapshot";
    public string ResourceCategory => "Elastic SAN";
    public string ResourceDescription => @"manages an Elastic SAN Snapshot";
    public string ResourceExampleUsage => @"resource 'azurerm_elastic_san_snapshot' 'example' {
  name            = 'example'
  volume_group_id = 'example-value'
  creation_data {
    source_id = 'example-value'
  }
}".AsTerraformTestConfig();
    public Type? SchemaModel => typeof(ElasticSANSnapshotResourceSchema);
    public TerraformMappingDefinition SchemaMappings => new ElasticSANSnapshotResourceMappings();
    public TerraformResourceTestDefinition Tests => new ElasticSANSnapshotResourceTests();

    public bool GenerateIDValidationFunction => true;
    public bool GenerateModel => true;
    public bool GenerateSchema => true;

    public MethodDefinition CreateMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2023_01_01.Snapshots.VolumeSnapshotsCreateOperation),
        TimeoutInMinutes = 30,
    };
    public MethodDefinition DeleteMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2023_01_01.Snapshots.VolumeSnapshotsDeleteOperation),
        TimeoutInMinutes = 30,
    };
    public MethodDefinition ReadMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2023_01_01.Snapshots.VolumeSnapshotsGetOperation),
        TimeoutInMinutes = 5,
    };
    public MethodDefinition? UpdateMethod => null;
}
