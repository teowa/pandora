using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResourceExtensionDataSourceSchema
{

    [HclName("extension_name")]
    [Required]
    public string ExtensionName { get; set; }


    [HclName("input_data_source")]
    [Optional]
    public List<string> InputDataSource { get; set; }


    [HclName("name")]
    [Optional]
    public string Name { get; set; }


    [HclName("stream")]
    [Optional]
    [PossibleValuesFromConstant(typeof(v2022_06_01.DataCollectionRules.KnownExtensionDataSourceStreamsConstant))]
    public List<string> Stream { get; set; }

}
