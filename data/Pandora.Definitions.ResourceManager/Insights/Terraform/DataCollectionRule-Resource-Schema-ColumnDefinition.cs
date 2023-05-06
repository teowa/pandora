using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResourceColumnDefinitionSchema
{

    [HclName("name")]
    [Optional]
    public string Name { get; set; }


    [HclName("type")]
    [Optional]
    [PossibleValuesFromConstant(typeof(v2022_06_01.DataCollectionRules.KnownColumnDefinitionTypeConstant))]
    public string Type { get; set; }

}
