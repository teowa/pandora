using System.Collections.Generic;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Mappings;
using Pandora.Definitions.ResourceManager.Resources.v2020_05_01.ResourceManagementPrivateLink;

namespace Pandora.Definitions.ResourceManager.Resources.Terraform;

public class ResourceManagementPrivateLinkResourceMappings : TerraformMappingDefinition
{
    public List<MappingType> Mappings => new List<MappingType>
    {
        Mapping.FromSchema<ResourceManagementPrivateLinkResourceSchema>(s => s.Name).ToResourceIdSegmentNamed("resourceManagementPrivateLinkName"),
        Mapping.FromSchema<ResourceManagementPrivateLinkResourceSchema>(s => s.ResourceGroupName).ToResourceIdSegmentNamed("resourceGroupName"),

        Mapping.FromSchema<ResourceManagementPrivateLinkResourceSchema>(s => s.Location).ToSdkField<ResourceManagementPrivateLinkLocationModel>(m => m.Location).Direct(),
        Mapping.FromSchema<ResourceManagementPrivateLinkResourceSchema>(s => s.PrivateEndpointConnections).ToSdkField<ResourceManagementPrivateLinkEndpointConnectionsModel>(m => m.PrivateEndpointConnections).Direct(),
        Mapping.FromSchemaModel<ResourceManagementPrivateLinkResourceSchema>().ToSdkField<ResourceManagementPrivateLinkModel>(m => m.Properties).ModelToModel(),
    };
}
