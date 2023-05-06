using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResourceEventHubDataSourceSchema
{

    [HclName("consumer_group")]
    [Optional]
    public string ConsumerGroup { get; set; }


    [HclName("name")]
    [Optional]
    public string Name { get; set; }


    [HclName("stream")]
    [Optional]
    public string Stream { get; set; }

}
