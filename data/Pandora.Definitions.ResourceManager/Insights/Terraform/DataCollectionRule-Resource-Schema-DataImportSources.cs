using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResourceDataImportSourcesSchema
{

    [HclName("event_hub")]
    [Optional]
    public DataCollectionRuleResourceEventHubDataSourceSchema EventHub { get; set; }

}
