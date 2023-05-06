using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResourceMetadataSchema
{

    [Computed]
    [HclName("provisioned_by")]
    public string ProvisionedBy { get; set; }


    [Computed]
    [HclName("provisioned_by_resource_id")]
    public string ProvisionedByResourceId { get; set; }

}
