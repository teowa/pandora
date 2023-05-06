using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResourceSyslogDataSourceSchema
{

    [HclName("facility_name")]
    [Optional]
    [PossibleValuesFromConstant(typeof(v2022_06_01.DataCollectionRules.KnownSyslogDataSourceFacilityNamesConstant))]
    public List<string> FacilityName { get; set; }


    [HclName("log_level")]
    [Optional]
    [PossibleValuesFromConstant(typeof(v2022_06_01.DataCollectionRules.KnownSyslogDataSourceLogLevelsConstant))]
    public List<string> LogLevel { get; set; }


    [HclName("name")]
    [Optional]
    public string Name { get; set; }


    [HclName("stream")]
    [Optional]
    [PossibleValuesFromConstant(typeof(v2022_06_01.DataCollectionRules.KnownSyslogDataSourceStreamsConstant))]
    public List<string> Stream { get; set; }

}
