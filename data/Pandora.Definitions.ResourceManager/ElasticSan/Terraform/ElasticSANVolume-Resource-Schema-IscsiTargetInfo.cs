using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANVolumeResourceIscsiTargetInfoSchema
{

    [HclName("provisioning_state")]
    [Optional]
    [PossibleValuesFromConstant(typeof(v2023_01_01.Volumes.ProvisioningStatesConstant))]
    public string ProvisioningState { get; set; }


    [HclName("status")]
    [Optional]
    [PossibleValuesFromConstant(typeof(v2023_01_01.Volumes.OperationalStatusConstant))]
    public string Status { get; set; }


    [Computed]
    [HclName("target_iqn")]
    public string TargetIqn { get; set; }


    [Computed]
    [HclName("target_portal_hostname")]
    public string TargetPortalHostname { get; set; }


    [Computed]
    [HclName("target_portal_port")]
    public int TargetPortalPort { get; set; }

}
