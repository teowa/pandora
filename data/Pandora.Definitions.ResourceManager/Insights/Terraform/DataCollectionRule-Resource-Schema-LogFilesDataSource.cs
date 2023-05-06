using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResourceLogFilesDataSourceSchema
{

    [HclName("file_pattern")]
    [Required]
    public List<string> FilePattern { get; set; }


    [HclName("format")]
    [PossibleValuesFromConstant(typeof(v2022_06_01.DataCollectionRules.KnownLogFilesDataSourceFormatConstant))]
    [Required]
    public string Format { get; set; }


    [HclName("name")]
    [Optional]
    public string Name { get; set; }


    [HclName("settings")]
    [Optional]
    public DataCollectionRuleResourceLogFileSettingsSchema Settings { get; set; }


    [HclName("stream")]
    [Required]
    public List<string> Stream { get; set; }

}
