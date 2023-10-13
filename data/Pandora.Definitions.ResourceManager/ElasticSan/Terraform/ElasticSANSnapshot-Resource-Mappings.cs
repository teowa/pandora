using System.Collections.Generic;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Mappings;
using Pandora.Definitions.ResourceManager.ElasticSan.v2023_01_01.Snapshots;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANSnapshotResourceMappings : TerraformMappingDefinition
{
    public List<MappingType> Mappings => new List<MappingType>
    {
        Mapping.FromSchema<ElasticSANSnapshotResourceSchema>(s => s.Name).ToResourceIdSegmentNamed("snapshotName"),
        Mapping.FromSchema<ElasticSANSnapshotResourceSchema>(s => s.VolumeGroupId).ToCommonIdSegmentNamed("elasticSanName"),
        Mapping.FromSchema<ElasticSANSnapshotResourceSchema>(s => s.VolumeGroupId).ToCommonIdSegmentNamed("resourceGroupName"),
        Mapping.FromSchema<ElasticSANSnapshotResourceSchema>(s => s.VolumeGroupId).ToCommonIdSegmentNamed("volumeGroupName"),

        Mapping.FromSchema<ElasticSANSnapshotResourceSchema>(s => s.CreationData).ToSdkField<SnapshotPropertiesModel>(m => m.CreationData).Direct(),
        Mapping.FromSchema<ElasticSANSnapshotResourceSchema>(s => s.SourceVolumeSizeGiB).ToSdkField<SnapshotPropertiesModel>(m => m.SourceVolumeSizeGiB).Direct(),
        Mapping.FromSchema<ElasticSANSnapshotResourceSchema>(s => s.VolumeName).ToSdkField<SnapshotPropertiesModel>(m => m.VolumeName).Direct(),
        Mapping.FromSchema<ElasticSANSnapshotResourceSnapshotCreationDataSchema>(s => s.SourceId).ToSdkField<SnapshotCreationDataModel>(m => m.SourceId).Direct(),
        Mapping.FromSchemaModel<ElasticSANSnapshotResourceSchema>().ToSdkField<SnapshotModel>(m => m.Properties).ModelToModel(),
        Mapping.FromSchemaModel<ElasticSANSnapshotResourceSnapshotCreationDataSchema>().ToSdkField<SnapshotPropertiesModel>(m => m.CreationData).ModelToModel(),
    };
}
