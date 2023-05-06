using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResourceMonitoringAccountDestinationSchema
{

    [Computed]
    [HclName("account_id")]
    public string AccountId { get; set; }


    [HclName("account_resource_id")]
    [Optional]
    public string AccountResourceId { get; set; }


    [HclName("name")]
    [Optional]
    public string Name { get; set; }

}
