using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.AppConfiguration.Terraform;

public class AppConfigurationReplicaResourceSchema
{

    [Documentation("Specifies the name of the Configuration Store within which this App Configuration Replica should exist.")]
    [ForceNew]
    [HclName("configuration_store_name")]
    [Required]
    public string ConfigurationStoreName { get; set; }


    [Computed]
    [Documentation("The URI of the replica where the replica API will be available.")]
    [HclName("endpoint")]
    public string Endpoint { get; set; }


    [Documentation("The Azure Region where the App Configuration Replica should exist.")]
    [ForceNew]
    [HclName("location")]
    [Required]
    public CommonSchema.Location Location { get; set; }


    [Documentation("Specifies the name of this App Configuration Replica.")]
    [ForceNew]
    [HclName("name")]
    [Required]
    public string Name { get; set; }


    [Documentation("Specifies the name of the Resource Group within which this App Configuration Replica should exist.")]
    [ForceNew]
    [HclName("resource_group_name")]
    [Required]
    public CommonSchema.ResourceGroupName ResourceGroupName { get; set; }

}
