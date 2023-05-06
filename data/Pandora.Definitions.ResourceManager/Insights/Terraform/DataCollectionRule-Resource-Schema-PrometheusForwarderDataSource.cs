using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResourcePrometheusForwarderDataSourceSchema
{

    [HclName("label_include_filter")]
    [Optional]
    public Dictionary<string, string> LabelIncludeFilter { get; set; }


    [HclName("name")]
    [Optional]
    public string Name { get; set; }


    [HclName("stream")]
    [Optional]
    [PossibleValuesFromConstant(typeof(v2022_06_01.DataCollectionRules.KnownPrometheusForwarderDataSourceStreamsConstant))]
    public List<string> Stream { get; set; }

}
