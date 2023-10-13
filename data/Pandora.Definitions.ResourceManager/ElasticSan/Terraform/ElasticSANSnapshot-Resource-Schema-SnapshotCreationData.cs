using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANSnapshotResourceSnapshotCreationDataSchema
{

    [HclName("source_id")]
    [Required]
    public string SourceId { get; set; }

}
