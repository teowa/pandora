using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResourceDataFlowSchema
{

    [HclName("built_in_transform")]
    [Optional]
    public string BuiltInTransform { get; set; }


    [HclName("destination")]
    [Optional]
    public List<string> Destination { get; set; }


    [HclName("output_stream")]
    [Optional]
    public string OutputStream { get; set; }


    [HclName("stream")]
    [Optional]
    [PossibleValuesFromConstant(typeof(v2022_06_01.DataCollectionRules.KnownDataFlowStreamsConstant))]
    public List<string> Stream { get; set; }


    [HclName("transform_kql")]
    [Optional]
    public string TransformKql { get; set; }

}
