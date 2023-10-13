using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANVolumeGroupResourceKeyVaultPropertiesSchema
{

    [Computed]
    [HclName("current_versioned_key_expiration_timestamp")]
    public System.DateTime CurrentVersionedKeyExpirationTimestamp { get; set; }


    [Computed]
    [HclName("current_versioned_key_identifier")]
    public string CurrentVersionedKeyIdentifier { get; set; }


    [HclName("key_name")]
    [Optional]
    public string KeyName { get; set; }


    [HclName("key_vault_uri")]
    [Optional]
    public string KeyVaultUri { get; set; }


    [HclName("key_version")]
    [Optional]
    public string KeyVersion { get; set; }


    [Computed]
    [HclName("last_key_rotation_timestamp")]
    public System.DateTime LastKeyRotationTimestamp { get; set; }

}
