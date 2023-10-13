using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANVolumeGroupResourcePrivateEndpointConnectionPropertiesSchema
{

    [HclName("group_ids")]
    [Optional]
    public List<string> GroupIds { get; set; }


    [HclName("private_endpoint_id")]
    [Optional]
    public string PrivateEndpointId { get; set; }


    [HclName("private_link_service_connection_state")]
    [Required]
    public ElasticSANVolumeGroupResourcePrivateLinkServiceConnectionStateSchema PrivateLinkServiceConnectionState { get; set; }


    [Computed]
    [HclName("provisioning_state")]
    [PossibleValuesFromConstant(typeof(v2023_01_01.VolumeGroups.ProvisioningStatesConstant))]
    public string ProvisioningState { get; set; }

}
