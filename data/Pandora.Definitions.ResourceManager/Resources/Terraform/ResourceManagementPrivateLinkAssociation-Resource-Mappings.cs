using System.Collections.Generic;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Mappings;
using Pandora.Definitions.ResourceManager.Resources.v2020_05_01.PrivateLinkAssociation;

namespace Pandora.Definitions.ResourceManager.Resources.Terraform;

public class ResourceManagementPrivateLinkAssociationResourceMappings : TerraformMappingDefinition
{
    public List<MappingType> Mappings => new List<MappingType>
    {
        Mapping.FromSchema<ResourceManagementPrivateLinkAssociationResourceSchema>(s => s.GroupId).ToResourceIdSegmentNamed("groupId"),
        Mapping.FromSchema<ResourceManagementPrivateLinkAssociationResourceSchema>(s => s.Name).ToResourceIdSegmentNamed("plaId"),

        Mapping.FromSchema<ResourceManagementPrivateLinkAssociationResourceSchema>(s => s.PrivateLink).ToSdkField<PrivateLinkAssociationPropertiesExpandedModel>(m => m.PrivateLink).Direct(),
        Mapping.FromSchema<ResourceManagementPrivateLinkAssociationResourceSchema>(s => s.PrivateLink).ToSdkField<PrivateLinkAssociationPropertiesModel>(m => m.PrivateLink).Direct(),
        Mapping.FromSchema<ResourceManagementPrivateLinkAssociationResourceSchema>(s => s.PublicNetworkAccess).ToSdkField<PrivateLinkAssociationPropertiesExpandedModel>(m => m.PublicNetworkAccess).Direct(),
        Mapping.FromSchema<ResourceManagementPrivateLinkAssociationResourceSchema>(s => s.PublicNetworkAccess).ToSdkField<PrivateLinkAssociationPropertiesModel>(m => m.PublicNetworkAccess).Direct(),
        Mapping.FromSchema<ResourceManagementPrivateLinkAssociationResourceSchema>(s => s.Scope).ToSdkField<PrivateLinkAssociationPropertiesExpandedModel>(m => m.Scope).Direct(),
        Mapping.FromSchema<ResourceManagementPrivateLinkAssociationResourceSchema>(s => s.TenantID).ToSdkField<PrivateLinkAssociationPropertiesExpandedModel>(m => m.TenantID).Direct(),
        Mapping.FromSchemaModel<ResourceManagementPrivateLinkAssociationResourceSchema>().ToSdkField<PrivateLinkAssociationModel>(m => m.Properties).ModelToModel(),
        Mapping.FromSchemaModel<ResourceManagementPrivateLinkAssociationResourceSchema>().ToSdkField<PrivateLinkAssociationObjectModel>(m => m.Properties).ModelToModel(),
    };
}
