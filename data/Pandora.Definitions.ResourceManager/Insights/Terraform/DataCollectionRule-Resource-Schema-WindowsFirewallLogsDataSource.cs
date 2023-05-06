using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResourceWindowsFirewallLogsDataSourceSchema
{

    [HclName("name")]
    [Optional]
    public string Name { get; set; }


    [HclName("stream")]
    [Required]
    public List<string> Stream { get; set; }

}
