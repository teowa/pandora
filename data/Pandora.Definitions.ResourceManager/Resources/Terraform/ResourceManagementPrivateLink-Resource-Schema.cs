using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Resources.Terraform;

public class ResourceManagementPrivateLinkResourceSchema
{

    [Documentation("The Azure Region where the Resource Management Private Link should exist.")]
    [ForceNew]
    [HclName("location")]
    [Required]
    public CommonSchema.Location Location { get; set; }


    [Documentation("Specifies the name of this Resource Management Private Link.")]
    [ForceNew]
    [HclName("name")]
    [Required]
    public string Name { get; set; }


    [Computed]
    [Documentation("The private endpoint connections.")]
    [HclName("private_endpoint_connections")]
    public List<string> PrivateEndpointConnections { get; set; }


    [Documentation("Specifies the name of the Resource Group within which this Resource Management Private Link should exist.")]
    [ForceNew]
    [HclName("resource_group_name")]
    [Required]
    public CommonSchema.ResourceGroupName ResourceGroupName { get; set; }

}
