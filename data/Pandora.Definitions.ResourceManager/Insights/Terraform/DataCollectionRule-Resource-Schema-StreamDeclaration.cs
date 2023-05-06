using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResourceStreamDeclarationSchema
{

    [HclName("column")]
    [Optional]
    public List<DataCollectionRuleResourceColumnDefinitionSchema> Column { get; set; }

}
