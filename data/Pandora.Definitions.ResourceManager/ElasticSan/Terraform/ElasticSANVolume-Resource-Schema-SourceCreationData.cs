using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANVolumeResourceSourceCreationDataSchema
{

    [HclName("create_source")]
    [Optional]
    [PossibleValuesFromConstant(typeof(v2023_01_01.Volumes.VolumeCreateOptionConstant))]
    public string CreateSource { get; set; }


    [HclName("source_id")]
    [Optional]
    public string SourceId { get; set; }

}
