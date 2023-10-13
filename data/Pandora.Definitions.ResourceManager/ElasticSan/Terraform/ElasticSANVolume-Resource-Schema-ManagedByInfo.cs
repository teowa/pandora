using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANVolumeResourceManagedByInfoSchema
{

    [HclName("resource_id")]
    [Optional]
    public string ResourceId { get; set; }

}
