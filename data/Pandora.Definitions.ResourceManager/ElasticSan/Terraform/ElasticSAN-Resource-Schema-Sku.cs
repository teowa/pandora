using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANResourceSkuSchema
{

    [HclName("name")]
    [PossibleValuesFromConstant(typeof(v2023_01_01.ElasticSans.SkuNameConstant))]
    [Required]
    public string Name { get; set; }


    [HclName("tier")]
    [Optional]
    [PossibleValuesFromConstant(typeof(v2023_01_01.ElasticSans.SkuTierConstant))]
    public string Tier { get; set; }

}
