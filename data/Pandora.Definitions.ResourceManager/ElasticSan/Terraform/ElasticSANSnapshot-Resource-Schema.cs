using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANSnapshotResourceSchema
{

    [Documentation("Data used when creating a volume snapshot.")]
    [ForceNew]
    [HclName("creation_data")]
    [Required]
    public ElasticSANSnapshotResourceSnapshotCreationDataSchema CreationData { get; set; }


    [Documentation("Specifies the name of this Elastic SAN Snapshot.")]
    [ForceNew]
    [HclName("name")]
    [Required]
    public string Name { get; set; }


    [Computed]
    [Documentation("Size of Source Volume.")]
    [HclName("source_volume_size_gib")]
    public int SourceVolumeSizeGiB { get; set; }


    [Documentation("Specifies the Volume Group Id within which this Elastic SAN Snapshot should exist.")]
    [ForceNew]
    [HclName("volume_group_id")]
    [Required]
    public string VolumeGroupId { get; set; }


    [Computed]
    [Documentation("Source Volume Name of a snapshot.")]
    [HclName("volume_name")]
    public string VolumeName { get; set; }

}
