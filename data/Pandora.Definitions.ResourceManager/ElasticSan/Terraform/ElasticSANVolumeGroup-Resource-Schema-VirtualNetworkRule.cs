using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANVolumeGroupResourceVirtualNetworkRuleSchema
{

    [HclName("action")]
    [Optional]
    [PossibleValuesFromConstant(typeof(v2023_01_01.VolumeGroups.ActionConstant))]
    public string Action { get; set; }


    [HclName("id")]
    [Required]
    public string Id { get; set; }

}
