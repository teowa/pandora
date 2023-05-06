using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResourceEventHubDestinationSchema
{

    [HclName("event_hub_resource_id")]
    [Optional]
    public string EventHubResourceId { get; set; }


    [HclName("name")]
    [Optional]
    public string Name { get; set; }

}
