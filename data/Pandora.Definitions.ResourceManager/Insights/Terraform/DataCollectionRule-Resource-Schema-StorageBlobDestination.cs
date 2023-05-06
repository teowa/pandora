using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResourceStorageBlobDestinationSchema
{

    [HclName("container_name")]
    [Optional]
    public string ContainerName { get; set; }


    [HclName("name")]
    [Optional]
    public string Name { get; set; }


    [HclName("storage_account_resource_id")]
    [Optional]
    public string StorageAccountResourceId { get; set; }

}
