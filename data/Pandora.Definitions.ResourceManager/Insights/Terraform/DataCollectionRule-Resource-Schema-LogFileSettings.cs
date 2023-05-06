using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResourceLogFileSettingsSchema
{

    [HclName("text")]
    [Optional]
    public DataCollectionRuleResourceLogFileTextSettingsSchema Text { get; set; }

}
