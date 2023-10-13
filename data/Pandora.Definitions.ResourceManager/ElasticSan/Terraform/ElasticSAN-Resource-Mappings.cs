using System.Collections.Generic;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Mappings;
using Pandora.Definitions.ResourceManager.ElasticSan.v2023_01_01.ElasticSans;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANResourceMappings : TerraformMappingDefinition
{
    public List<MappingType> Mappings => new List<MappingType>
    {
        Mapping.FromSchema<ElasticSANResourceSchema>(s => s.Name).ToResourceIdSegmentNamed("elasticSanName"),
        Mapping.FromSchema<ElasticSANResourceSchema>(s => s.ResourceGroupName).ToResourceIdSegmentNamed("resourceGroupName"),

        Mapping.FromSchema<ElasticSANResourcePrivateEndpointConnectionPropertiesSchema>(s => s.GroupIds).ToSdkField<PrivateEndpointConnectionPropertiesModel>(m => m.GroupIds).Direct(),
        Mapping.FromSchema<ElasticSANResourcePrivateEndpointConnectionPropertiesSchema>(s => s.PrivateEndpointId).ToSdkField<PrivateEndpointConnectionPropertiesModel>(m => m.PrivateEndpoint).Direct(),
        Mapping.FromSchema<ElasticSANResourcePrivateEndpointConnectionPropertiesSchema>(s => s.PrivateLinkServiceConnectionState).ToSdkField<PrivateEndpointConnectionPropertiesModel>(m => m.PrivateLinkServiceConnectionState).Direct(),
        Mapping.FromSchema<ElasticSANResourcePrivateEndpointConnectionPropertiesSchema>(s => s.ProvisioningState).ToSdkField<PrivateEndpointConnectionPropertiesModel>(m => m.ProvisioningState).Direct(),
        Mapping.FromSchema<ElasticSANResourcePrivateEndpointConnectionSchema>(s => s.Id).ToSdkField<PrivateEndpointConnectionModel>(m => m.Id).Direct(),
        Mapping.FromSchema<ElasticSANResourcePrivateEndpointConnectionSchema>(s => s.Name).ToSdkField<PrivateEndpointConnectionModel>(m => m.Name).Direct(),
        Mapping.FromSchema<ElasticSANResourcePrivateEndpointConnectionSchema>(s => s.Properties).ToSdkField<PrivateEndpointConnectionModel>(m => m.Properties).Direct(),
        Mapping.FromSchema<ElasticSANResourcePrivateEndpointConnectionSchema>(s => s.Type).ToSdkField<PrivateEndpointConnectionModel>(m => m.Type).Direct(),
        Mapping.FromSchema<ElasticSANResourcePrivateLinkServiceConnectionStateSchema>(s => s.ActionsRequired).ToSdkField<PrivateLinkServiceConnectionStateModel>(m => m.ActionsRequired).Direct(),
        Mapping.FromSchema<ElasticSANResourcePrivateLinkServiceConnectionStateSchema>(s => s.Description).ToSdkField<PrivateLinkServiceConnectionStateModel>(m => m.Description).Direct(),
        Mapping.FromSchema<ElasticSANResourcePrivateLinkServiceConnectionStateSchema>(s => s.Status).ToSdkField<PrivateLinkServiceConnectionStateModel>(m => m.Status).Direct(),
        Mapping.FromSchema<ElasticSANResourceSchema>(s => s.AvailabilityZones).ToSdkField<ElasticSanPropertiesModel>(m => m.AvailabilityZones).Direct(),
        Mapping.FromSchema<ElasticSANResourceSchema>(s => s.BaseSizeTiB).ToSdkField<ElasticSanPropertiesModel>(m => m.BaseSizeTiB).Direct(),
        Mapping.FromSchema<ElasticSANResourceSchema>(s => s.BaseSizeTiB).ToSdkField<ElasticSanUpdatePropertiesModel>(m => m.BaseSizeTiB).Direct(),
        Mapping.FromSchema<ElasticSANResourceSchema>(s => s.ExtendedCapacitySizeTiB).ToSdkField<ElasticSanPropertiesModel>(m => m.ExtendedCapacitySizeTiB).Direct(),
        Mapping.FromSchema<ElasticSANResourceSchema>(s => s.ExtendedCapacitySizeTiB).ToSdkField<ElasticSanUpdatePropertiesModel>(m => m.ExtendedCapacitySizeTiB).Direct(),
        Mapping.FromSchema<ElasticSANResourceSchema>(s => s.Location).ToSdkField<ElasticSanModel>(m => m.Location).Direct(),
        Mapping.FromSchema<ElasticSANResourceSchema>(s => s.PrivateEndpointConnection).ToSdkField<ElasticSanPropertiesModel>(m => m.PrivateEndpointConnections).Direct(),
        Mapping.FromSchema<ElasticSANResourceSchema>(s => s.PublicNetworkAccess).ToSdkField<ElasticSanPropertiesModel>(m => m.PublicNetworkAccess).Direct(),
        Mapping.FromSchema<ElasticSANResourceSchema>(s => s.PublicNetworkAccess).ToSdkField<ElasticSanUpdatePropertiesModel>(m => m.PublicNetworkAccess).Direct(),
        Mapping.FromSchema<ElasticSANResourceSchema>(s => s.Sku).ToSdkField<ElasticSanPropertiesModel>(m => m.Sku).Direct(),
        Mapping.FromSchema<ElasticSANResourceSchema>(s => s.Tags).ToSdkField<ElasticSanModel>(m => m.Tags).Direct(),
        Mapping.FromSchema<ElasticSANResourceSchema>(s => s.Tags).ToSdkField<ElasticSanUpdateModel>(m => m.Tags).Direct(),
        Mapping.FromSchema<ElasticSANResourceSchema>(s => s.TotalIops).ToSdkField<ElasticSanPropertiesModel>(m => m.TotalIops).Direct(),
        Mapping.FromSchema<ElasticSANResourceSchema>(s => s.TotalMBps).ToSdkField<ElasticSanPropertiesModel>(m => m.TotalMBps).Direct(),
        Mapping.FromSchema<ElasticSANResourceSchema>(s => s.TotalSizeTiB).ToSdkField<ElasticSanPropertiesModel>(m => m.TotalSizeTiB).Direct(),
        Mapping.FromSchema<ElasticSANResourceSchema>(s => s.TotalVolumeSizeGiB).ToSdkField<ElasticSanPropertiesModel>(m => m.TotalVolumeSizeGiB).Direct(),
        Mapping.FromSchema<ElasticSANResourceSchema>(s => s.VolumeGroupCount).ToSdkField<ElasticSanPropertiesModel>(m => m.VolumeGroupCount).Direct(),
        Mapping.FromSchema<ElasticSANResourceSkuSchema>(s => s.Name).ToSdkField<SkuModel>(m => m.Name).Direct(),
        Mapping.FromSchema<ElasticSANResourceSkuSchema>(s => s.Tier).ToSdkField<SkuModel>(m => m.Tier).Direct(),
        Mapping.FromSchemaModel<ElasticSANResourceSchema>().ToSdkField<ElasticSanModel>(m => m.Properties).ModelToModel(),
        Mapping.FromSchemaModel<ElasticSANResourceSchema>().ToSdkField<ElasticSanUpdateModel>(m => m.Properties).ModelToModel(),
        Mapping.FromSchemaModel<ElasticSANResourceSkuSchema>().ToSdkField<ElasticSanPropertiesModel>(m => m.Sku).ModelToModel(),
    };
}
