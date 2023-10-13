using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANVolumeGroupResourceNetworkRuleSetSchema
{

    [HclName("virtual_network_rule")]
    [Optional]
    public List<ElasticSANVolumeGroupResourceVirtualNetworkRuleSchema> VirtualNetworkRule { get; set; }

}
