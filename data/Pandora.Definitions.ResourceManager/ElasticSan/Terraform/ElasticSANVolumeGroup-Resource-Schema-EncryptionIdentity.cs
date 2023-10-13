using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANVolumeGroupResourceEncryptionIdentitySchema
{

    [HclName("user_assigned_identity")]
    [Optional]
    public string UserAssignedIdentity { get; set; }

}
