using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANVolumeGroupResourceSchema
{

    [Documentation("Specifies the Elastic San Id within which this Elastic SAN Volume Group should exist.")]
    [ForceNew]
    [HclName("elastic_san_id")]
    [Required]
    public string ElasticSanId { get; set; }


    [Documentation("Type of encryption.")]
    [HclName("encryption")]
    [Optional]
    [PossibleValuesFromConstant(typeof(v2023_01_01.VolumeGroups.EncryptionTypeConstant))]
    public string Encryption { get; set; }


    [Documentation("Encryption Properties describing Key Vault and Identity information.")]
    [HclName("encryption_properties")]
    [Optional]
    public ElasticSANVolumeGroupResourceEncryptionPropertiesSchema EncryptionProperties { get; set; }


    [Documentation("Specifies the Managed Identity which should be assigned to this Elastic SAN Volume Group.")]
    [HclName("identity")]
    [Optional]
    public CommonSchema.SystemOrUserAssignedIdentity Identity { get; set; }


    [Documentation("Specifies the name of this Elastic SAN Volume Group.")]
    [ForceNew]
    [HclName("name")]
    [Required]
    public string Name { get; set; }


    [Documentation("A collection of rules governing the accessibility from specific network locations.")]
    [HclName("network_acls")]
    [Optional]
    public ElasticSANVolumeGroupResourceNetworkRuleSetSchema NetworkAcls { get; set; }


    [Computed]
    [Documentation("The list of Private Endpoint Connections.")]
    [HclName("private_endpoint_connection")]
    public List<ElasticSANVolumeGroupResourcePrivateEndpointConnectionSchema> PrivateEndpointConnection { get; set; }

}
