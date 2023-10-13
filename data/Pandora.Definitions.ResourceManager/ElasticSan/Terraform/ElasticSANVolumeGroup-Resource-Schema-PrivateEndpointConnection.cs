using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANVolumeGroupResourcePrivateEndpointConnectionSchema
{

    [Computed]
    [HclName("id")]
    public string Id { get; set; }


    [Computed]
    [HclName("name")]
    public string Name { get; set; }


    [HclName("properties")]
    [Required]
    public ElasticSANVolumeGroupResourcePrivateEndpointConnectionPropertiesSchema Properties { get; set; }


    [Computed]
    [HclName("type")]
    public string Type { get; set; }

}
