using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANVolumeResourceSchema
{

    [Documentation("State of the operation on the resource.")]
    [ForceNew]
    [HclName("creation_data")]
    [Optional]
    public ElasticSANVolumeResourceSourceCreationDataSchema CreationData { get; set; }


    [Documentation("Parent resource information.")]
    [HclName("managed_by")]
    [Optional]
    public ElasticSANVolumeResourceManagedByInfoSchema ManagedBy { get; set; }


    [Documentation("Specifies the name of this Elastic SAN Volume.")]
    [ForceNew]
    [HclName("name")]
    [Required]
    public string Name { get; set; }


    [Documentation("Volume size.")]
    [HclName("size_gib")]
    [Required]
    public int SizeGiB { get; set; }


    [Documentation("Storage target information.")]
    [ForceNew]
    [HclName("storage_target")]
    [Optional]
    public ElasticSANVolumeResourceIscsiTargetInfoSchema StorageTarget { get; set; }


    [Documentation("Specifies the Volume Group Id within which this Elastic SAN Volume should exist.")]
    [ForceNew]
    [HclName("volume_group_id")]
    [Required]
    public string VolumeGroupId { get; set; }


    [Computed]
    [Documentation("Unique Id of the volume in GUID format.")]
    [HclName("volume_id")]
    public string VolumeId { get; set; }

}
