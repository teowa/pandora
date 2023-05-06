using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResourceLogFileTextSettingsSchema
{

    [HclName("record_start_timestamp_format")]
    [PossibleValuesFromConstant(typeof(v2022_06_01.DataCollectionRules.KnownLogFileTextSettingsRecordStartTimestampFormatConstant))]
    [Required]
    public string RecordStartTimestampFormat { get; set; }

}
