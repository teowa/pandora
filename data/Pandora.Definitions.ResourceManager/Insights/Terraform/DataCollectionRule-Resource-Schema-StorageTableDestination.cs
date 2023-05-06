using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResourceStorageTableDestinationSchema
{

    [HclName("name")]
    [Optional]
    public string Name { get; set; }


    [HclName("storage_account_resource_id")]
    [Optional]
    public string StorageAccountResourceId { get; set; }


    [HclName("table_name")]
    [Optional]
    public string TableName { get; set; }

}
