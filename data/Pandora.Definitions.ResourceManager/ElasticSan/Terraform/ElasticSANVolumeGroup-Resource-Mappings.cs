using System.Collections.Generic;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Mappings;
using Pandora.Definitions.ResourceManager.ElasticSan.v2023_01_01.VolumeGroups;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANVolumeGroupResourceMappings : TerraformMappingDefinition
{
    public List<MappingType> Mappings => new List<MappingType>
    {
        Mapping.FromSchema<ElasticSANVolumeGroupResourceSchema>(s => s.ElasticSanId).ToCommonIdSegmentNamed("elasticSanName"),
        Mapping.FromSchema<ElasticSANVolumeGroupResourceSchema>(s => s.ElasticSanId).ToCommonIdSegmentNamed("resourceGroupName"),
        Mapping.FromSchema<ElasticSANVolumeGroupResourceSchema>(s => s.Name).ToResourceIdSegmentNamed("volumeGroupName"),

        Mapping.FromSchema<ElasticSANVolumeGroupResourceEncryptionIdentitySchema>(s => s.UserAssignedIdentity).ToSdkField<EncryptionIdentityModel>(m => m.UserAssignedIdentity).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourceEncryptionPropertiesSchema>(s => s.Identity).ToSdkField<EncryptionPropertiesModel>(m => m.Identity).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourceEncryptionPropertiesSchema>(s => s.CurrentVersionedKeyExpirationTimestamp).ToSdkField<KeyVaultPropertiesModel>(m => m.CurrentVersionedKeyExpirationTimestamp).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourceEncryptionPropertiesSchema>(s => s.CurrentVersionedKeyIdentifier).ToSdkField<KeyVaultPropertiesModel>(m => m.CurrentVersionedKeyIdentifier).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourceEncryptionPropertiesSchema>(s => s.KeyName).ToSdkField<KeyVaultPropertiesModel>(m => m.KeyName).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourceEncryptionPropertiesSchema>(s => s.KeyVaultUri).ToSdkField<KeyVaultPropertiesModel>(m => m.KeyVaultUri).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourceEncryptionPropertiesSchema>(s => s.KeyVersion).ToSdkField<KeyVaultPropertiesModel>(m => m.KeyVersion).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourceEncryptionPropertiesSchema>(s => s.LastKeyRotationTimestamp).ToSdkField<KeyVaultPropertiesModel>(m => m.LastKeyRotationTimestamp).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourceNetworkRuleSetSchema>(s => s.VirtualNetworkRule).ToSdkField<NetworkRuleSetModel>(m => m.VirtualNetworkRules).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourcePrivateEndpointConnectionPropertiesSchema>(s => s.GroupIds).ToSdkField<PrivateEndpointConnectionPropertiesModel>(m => m.GroupIds).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourcePrivateEndpointConnectionPropertiesSchema>(s => s.PrivateEndpointId).ToSdkField<PrivateEndpointConnectionPropertiesModel>(m => m.PrivateEndpoint).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourcePrivateEndpointConnectionPropertiesSchema>(s => s.PrivateLinkServiceConnectionState).ToSdkField<PrivateEndpointConnectionPropertiesModel>(m => m.PrivateLinkServiceConnectionState).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourcePrivateEndpointConnectionPropertiesSchema>(s => s.ProvisioningState).ToSdkField<PrivateEndpointConnectionPropertiesModel>(m => m.ProvisioningState).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourcePrivateEndpointConnectionSchema>(s => s.Id).ToSdkField<PrivateEndpointConnectionModel>(m => m.Id).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourcePrivateEndpointConnectionSchema>(s => s.Name).ToSdkField<PrivateEndpointConnectionModel>(m => m.Name).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourcePrivateEndpointConnectionSchema>(s => s.Properties).ToSdkField<PrivateEndpointConnectionModel>(m => m.Properties).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourcePrivateEndpointConnectionSchema>(s => s.Type).ToSdkField<PrivateEndpointConnectionModel>(m => m.Type).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourcePrivateLinkServiceConnectionStateSchema>(s => s.ActionsRequired).ToSdkField<PrivateLinkServiceConnectionStateModel>(m => m.ActionsRequired).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourcePrivateLinkServiceConnectionStateSchema>(s => s.Description).ToSdkField<PrivateLinkServiceConnectionStateModel>(m => m.Description).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourcePrivateLinkServiceConnectionStateSchema>(s => s.Status).ToSdkField<PrivateLinkServiceConnectionStateModel>(m => m.Status).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourceSchema>(s => s.Encryption).ToSdkField<VolumeGroupPropertiesModel>(m => m.Encryption).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourceSchema>(s => s.Encryption).ToSdkField<VolumeGroupUpdatePropertiesModel>(m => m.Encryption).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourceSchema>(s => s.EncryptionProperties).ToSdkField<VolumeGroupPropertiesModel>(m => m.EncryptionProperties).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourceSchema>(s => s.EncryptionProperties).ToSdkField<VolumeGroupUpdatePropertiesModel>(m => m.EncryptionProperties).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourceSchema>(s => s.Identity).ToSdkField<VolumeGroupModel>(m => m.Identity).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourceSchema>(s => s.Identity).ToSdkField<VolumeGroupUpdateModel>(m => m.Identity).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourceSchema>(s => s.NetworkAcls).ToSdkField<VolumeGroupPropertiesModel>(m => m.NetworkAcls).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourceSchema>(s => s.NetworkAcls).ToSdkField<VolumeGroupUpdatePropertiesModel>(m => m.NetworkAcls).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourceSchema>(s => s.PrivateEndpointConnection).ToSdkField<VolumeGroupPropertiesModel>(m => m.PrivateEndpointConnections).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourceVirtualNetworkRuleSchema>(s => s.Action).ToSdkField<VirtualNetworkRuleModel>(m => m.Action).Direct(),
        Mapping.FromSchema<ElasticSANVolumeGroupResourceVirtualNetworkRuleSchema>(s => s.Id).ToSdkField<VirtualNetworkRuleModel>(m => m.Id).Direct(),
        Mapping.FromSchemaModel<ElasticSANVolumeGroupResourceEncryptionPropertiesSchema>().ToSdkField<VolumeGroupPropertiesModel>(m => m.EncryptionProperties).ModelToModel(),
        Mapping.FromSchemaModel<ElasticSANVolumeGroupResourceEncryptionPropertiesSchema>().ToSdkField<VolumeGroupUpdatePropertiesModel>(m => m.EncryptionProperties).ModelToModel(),
        Mapping.FromSchemaModel<ElasticSANVolumeGroupResourceNetworkRuleSetSchema>().ToSdkField<VolumeGroupPropertiesModel>(m => m.NetworkAcls).ModelToModel(),
        Mapping.FromSchemaModel<ElasticSANVolumeGroupResourceNetworkRuleSetSchema>().ToSdkField<VolumeGroupUpdatePropertiesModel>(m => m.NetworkAcls).ModelToModel(),
        Mapping.FromSchemaModel<ElasticSANVolumeGroupResourceSchema>().ToSdkField<VolumeGroupModel>(m => m.Properties).ModelToModel(),
        Mapping.FromSchemaModel<ElasticSANVolumeGroupResourceSchema>().ToSdkField<VolumeGroupUpdateModel>(m => m.Properties).ModelToModel(),
    };
}
