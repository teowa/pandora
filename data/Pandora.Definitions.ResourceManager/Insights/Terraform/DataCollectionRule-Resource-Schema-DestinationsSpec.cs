using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResourceDestinationsSpecSchema
{

    [HclName("azure_monitor_metrics")]
    [Optional]
    public DataCollectionRuleResourceAzureMonitorMetricsDestinationSchema AzureMonitorMetrics { get; set; }


    [HclName("event_hub")]
    [Optional]
    public List<DataCollectionRuleResourceEventHubDestinationSchema> EventHub { get; set; }


    [HclName("event_hubs_direct")]
    [Optional]
    public List<DataCollectionRuleResourceEventHubDirectDestinationSchema> EventHubsDirect { get; set; }


    [HclName("log_analytic")]
    [Optional]
    public List<DataCollectionRuleResourceLogAnalyticsDestinationSchema> LogAnalytic { get; set; }


    [HclName("monitoring_account")]
    [Optional]
    public List<DataCollectionRuleResourceMonitoringAccountDestinationSchema> MonitoringAccount { get; set; }


    [HclName("storage_account")]
    [Optional]
    public List<DataCollectionRuleResourceStorageBlobDestinationSchema> StorageAccount { get; set; }


    [HclName("storage_blobs_direct")]
    [Optional]
    public List<DataCollectionRuleResourceStorageBlobDestinationSchema> StorageBlobsDirect { get; set; }


    [HclName("storage_tables_direct")]
    [Optional]
    public List<DataCollectionRuleResourceStorageTableDestinationSchema> StorageTablesDirect { get; set; }

}
