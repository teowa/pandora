using System.Collections.Generic;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Mappings;
using Pandora.Definitions.ResourceManager.AppConfiguration.v2023_03_01.Replicas;

namespace Pandora.Definitions.ResourceManager.AppConfiguration.Terraform;

public class AppConfigurationReplicaResourceMappings : TerraformMappingDefinition
{
    public List<MappingType> Mappings => new List<MappingType>
    {
        Mapping.FromSchema<AppConfigurationReplicaResourceSchema>(s => s.ConfigurationStoreName).ToResourceIdSegmentNamed("configurationStoreName"),
        Mapping.FromSchema<AppConfigurationReplicaResourceSchema>(s => s.Name).ToResourceIdSegmentNamed("replicaName"),
        Mapping.FromSchema<AppConfigurationReplicaResourceSchema>(s => s.ResourceGroupName).ToResourceIdSegmentNamed("resourceGroupName"),

        Mapping.FromSchema<AppConfigurationReplicaResourceSchema>(s => s.Endpoint).ToSdkField<ReplicaPropertiesModel>(m => m.Endpoint).Direct(),
        Mapping.FromSchema<AppConfigurationReplicaResourceSchema>(s => s.Location).ToSdkField<ReplicaModel>(m => m.Location).Direct(),
        Mapping.FromSchemaModel<AppConfigurationReplicaResourceSchema>().ToSdkField<ReplicaModel>(m => m.Properties).ModelToModel(),
    };
}
