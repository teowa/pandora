using System.Collections.Generic;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Mappings;
using Pandora.Definitions.ResourceManager.ElasticSan.v2023_01_01.Volumes;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANVolumeResourceMappings : TerraformMappingDefinition
{
    public List<MappingType> Mappings => new List<MappingType>
    {
        Mapping.FromSchema<ElasticSANVolumeResourceSchema>(s => s.Name).ToResourceIdSegmentNamed("volumeName"),
        Mapping.FromSchema<ElasticSANVolumeResourceSchema>(s => s.VolumeGroupId).ToCommonIdSegmentNamed("elasticSanName"),
        Mapping.FromSchema<ElasticSANVolumeResourceSchema>(s => s.VolumeGroupId).ToCommonIdSegmentNamed("resourceGroupName"),
        Mapping.FromSchema<ElasticSANVolumeResourceSchema>(s => s.VolumeGroupId).ToCommonIdSegmentNamed("volumeGroupName"),

        Mapping.FromSchema<ElasticSANVolumeResourceIscsiTargetInfoSchema>(s => s.ProvisioningState).ToSdkField<IscsiTargetInfoModel>(m => m.ProvisioningState).Direct(),
        Mapping.FromSchema<ElasticSANVolumeResourceIscsiTargetInfoSchema>(s => s.Status).ToSdkField<IscsiTargetInfoModel>(m => m.Status).Direct(),
        Mapping.FromSchema<ElasticSANVolumeResourceIscsiTargetInfoSchema>(s => s.TargetIqn).ToSdkField<IscsiTargetInfoModel>(m => m.TargetIqn).Direct(),
        Mapping.FromSchema<ElasticSANVolumeResourceIscsiTargetInfoSchema>(s => s.TargetPortalHostname).ToSdkField<IscsiTargetInfoModel>(m => m.TargetPortalHostname).Direct(),
        Mapping.FromSchema<ElasticSANVolumeResourceIscsiTargetInfoSchema>(s => s.TargetPortalPort).ToSdkField<IscsiTargetInfoModel>(m => m.TargetPortalPort).Direct(),
        Mapping.FromSchema<ElasticSANVolumeResourceManagedByInfoSchema>(s => s.ResourceId).ToSdkField<ManagedByInfoModel>(m => m.ResourceId).Direct(),
        Mapping.FromSchema<ElasticSANVolumeResourceSchema>(s => s.CreationData).ToSdkField<VolumePropertiesModel>(m => m.CreationData).Direct(),
        Mapping.FromSchema<ElasticSANVolumeResourceSchema>(s => s.ManagedBy).ToSdkField<VolumePropertiesModel>(m => m.ManagedBy).Direct(),
        Mapping.FromSchema<ElasticSANVolumeResourceSchema>(s => s.ManagedBy).ToSdkField<VolumeUpdatePropertiesModel>(m => m.ManagedBy).Direct(),
        Mapping.FromSchema<ElasticSANVolumeResourceSchema>(s => s.SizeGiB).ToSdkField<VolumePropertiesModel>(m => m.SizeGiB).Direct(),
        Mapping.FromSchema<ElasticSANVolumeResourceSchema>(s => s.SizeGiB).ToSdkField<VolumeUpdatePropertiesModel>(m => m.SizeGiB).Direct(),
        Mapping.FromSchema<ElasticSANVolumeResourceSchema>(s => s.StorageTarget).ToSdkField<VolumePropertiesModel>(m => m.StorageTarget).Direct(),
        Mapping.FromSchema<ElasticSANVolumeResourceSchema>(s => s.VolumeId).ToSdkField<VolumePropertiesModel>(m => m.VolumeId).Direct(),
        Mapping.FromSchema<ElasticSANVolumeResourceSourceCreationDataSchema>(s => s.CreateSource).ToSdkField<SourceCreationDataModel>(m => m.CreateSource).Direct(),
        Mapping.FromSchema<ElasticSANVolumeResourceSourceCreationDataSchema>(s => s.SourceId).ToSdkField<SourceCreationDataModel>(m => m.SourceId).Direct(),
        Mapping.FromSchemaModel<ElasticSANVolumeResourceIscsiTargetInfoSchema>().ToSdkField<VolumePropertiesModel>(m => m.StorageTarget).ModelToModel(),
        Mapping.FromSchemaModel<ElasticSANVolumeResourceManagedByInfoSchema>().ToSdkField<VolumePropertiesModel>(m => m.ManagedBy).ModelToModel(),
        Mapping.FromSchemaModel<ElasticSANVolumeResourceManagedByInfoSchema>().ToSdkField<VolumeUpdatePropertiesModel>(m => m.ManagedBy).ModelToModel(),
        Mapping.FromSchemaModel<ElasticSANVolumeResourceSchema>().ToSdkField<VolumeModel>(m => m.Properties).ModelToModel(),
        Mapping.FromSchemaModel<ElasticSANVolumeResourceSchema>().ToSdkField<VolumeUpdateModel>(m => m.Properties).ModelToModel(),
        Mapping.FromSchemaModel<ElasticSANVolumeResourceSourceCreationDataSchema>().ToSdkField<VolumePropertiesModel>(m => m.CreationData).ModelToModel(),
    };
}
