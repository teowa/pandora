using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResourceWindowsEventLogDataSourceSchema
{

    [HclName("name")]
    [Optional]
    public string Name { get; set; }


    [HclName("stream")]
    [Optional]
    [PossibleValuesFromConstant(typeof(v2022_06_01.DataCollectionRules.KnownWindowsEventLogDataSourceStreamsConstant))]
    public List<string> Stream { get; set; }


    [HclName("xpath_query")]
    [Optional]
    public List<string> XPathQuery { get; set; }

}
