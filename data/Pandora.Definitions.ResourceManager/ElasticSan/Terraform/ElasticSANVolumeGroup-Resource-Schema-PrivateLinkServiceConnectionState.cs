using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANVolumeGroupResourcePrivateLinkServiceConnectionStateSchema
{

    [HclName("actions_required")]
    [Optional]
    public string ActionsRequired { get; set; }


    [HclName("description")]
    [Optional]
    public string Description { get; set; }


    [HclName("status")]
    [Optional]
    [PossibleValuesFromConstant(typeof(v2023_01_01.VolumeGroups.PrivateEndpointServiceConnectionStatusConstant))]
    public string Status { get; set; }

}
