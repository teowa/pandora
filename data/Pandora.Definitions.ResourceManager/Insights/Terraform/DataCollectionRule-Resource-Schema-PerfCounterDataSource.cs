using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResourcePerfCounterDataSourceSchema
{

    [HclName("counter_specifier")]
    [Optional]
    public List<string> CounterSpecifier { get; set; }


    [HclName("name")]
    [Optional]
    public string Name { get; set; }


    [HclName("sampling_frequency_in_seconds")]
    [Optional]
    public int SamplingFrequencyInSeconds { get; set; }


    [HclName("stream")]
    [Optional]
    [PossibleValuesFromConstant(typeof(v2022_06_01.DataCollectionRules.KnownPerfCounterDataSourceStreamsConstant))]
    public List<string> Stream { get; set; }

}
