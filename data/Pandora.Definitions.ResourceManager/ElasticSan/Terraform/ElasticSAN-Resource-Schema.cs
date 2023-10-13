using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANResourceSchema
{

    [Documentation("Logical zone for Elastic San resource.")]
    [ForceNew]
    [HclName("availability_zones")]
    [Optional]
    public CommonSchema.ZonesMultiple AvailabilityZones { get; set; }


    [Documentation("Base size of the Elastic San appliance in TiB.")]
    [HclName("base_size_tib")]
    [Required]
    public int BaseSizeTiB { get; set; }


    [Documentation("Extended size of the Elastic San appliance in TiB.")]
    [HclName("extended_capacity_size_tib")]
    [Required]
    public int ExtendedCapacitySizeTiB { get; set; }


    [Documentation("The Azure Region where the Elastic SAN should exist.")]
    [ForceNew]
    [HclName("location")]
    [Required]
    public CommonSchema.Location Location { get; set; }


    [Documentation("Specifies the name of this Elastic SAN.")]
    [ForceNew]
    [HclName("name")]
    [Required]
    public string Name { get; set; }


    [Computed]
    [Documentation("The list of Private Endpoint Connections.")]
    [HclName("private_endpoint_connection")]
    public List<ElasticSANResourcePrivateEndpointConnectionSchema> PrivateEndpointConnection { get; set; }


    [Documentation("Allow or disallow public network access to ElasticSan.")]
    [HclName("public_network_access")]
    [Optional]
    [PossibleValuesFromConstant(typeof(v2023_01_01.ElasticSans.PublicNetworkAccessConstant))]
    public string PublicNetworkAccess { get; set; }


    [Documentation("Specifies the name of the Resource Group within which this Elastic SAN should exist.")]
    [ForceNew]
    [HclName("resource_group_name")]
    [Required]
    public CommonSchema.ResourceGroupName ResourceGroupName { get; set; }


    [Documentation("Resource sku.")]
    [ForceNew]
    [HclName("sku")]
    [Required]
    public ElasticSANResourceSkuSchema Sku { get; set; }


    [Documentation("A mapping of tags which should be assigned to the Elastic SAN.")]
    [HclName("tags")]
    [Optional]
    public CommonSchema.Tags Tags { get; set; }


    [Computed]
    [Documentation("Total Provisioned IOPS of the Elastic San appliance.")]
    [HclName("total_iops")]
    public int TotalIops { get; set; }


    [Computed]
    [Documentation("Total Provisioned MBps Elastic San appliance.")]
    [HclName("total_mbps")]
    public int TotalMBps { get; set; }


    [Computed]
    [Documentation("Total size of the Elastic San appliance in TB.")]
    [HclName("total_size_tib")]
    public int TotalSizeTiB { get; set; }


    [Computed]
    [Documentation("Total size of the provisioned Volumes in GiB.")]
    [HclName("total_volume_size_gib")]
    public int TotalVolumeSizeGiB { get; set; }


    [Computed]
    [Documentation("Total number of volume groups in this Elastic San appliance.")]
    [HclName("volume_group_count")]
    public int VolumeGroupCount { get; set; }

}
