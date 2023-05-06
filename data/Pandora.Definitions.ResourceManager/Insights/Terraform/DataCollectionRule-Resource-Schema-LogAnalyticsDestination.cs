using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResourceLogAnalyticsDestinationSchema
{

    [HclName("name")]
    [Optional]
    public string Name { get; set; }


    [Computed]
    [HclName("workspace_id")]
    public string WorkspaceId { get; set; }


    [HclName("workspace_resource_id")]
    [Optional]
    public string WorkspaceResourceId { get; set; }

}
