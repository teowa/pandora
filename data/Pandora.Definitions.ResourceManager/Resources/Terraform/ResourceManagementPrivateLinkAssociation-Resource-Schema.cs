using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Resources.Terraform;

public class ResourceManagementPrivateLinkAssociationResourceSchema
{

    [Documentation("Specifies the Group Id within which this Resource Management Private Link Association should exist.")]
    [ForceNew]
    [HclName("group_id")]
    [Required]
    public string GroupId { get; set; }


    [Documentation("Specifies the name of this Resource Management Private Link Association.")]
    [ForceNew]
    [HclName("name")]
    [Required]
    public string Name { get; set; }


    [Documentation("The rmpl Resource ID.")]
    [ForceNew]
    [HclName("private_link")]
    [Optional]
    public string PrivateLink { get; set; }


    [ForceNew]
    [HclName("public_network_access")]
    [Optional]
    [PossibleValuesFromConstant(typeof(v2020_05_01.PrivateLinkAssociation.PublicNetworkAccessOptionsConstant))]
    public string PublicNetworkAccess { get; set; }


    [Computed]
    [Documentation("The scope of the private link association.")]
    [HclName("scope")]
    public string Scope { get; set; }


    [Computed]
    [Documentation("The TenantID.")]
    [HclName("tenant_id")]
    public string TenantID { get; set; }

}
