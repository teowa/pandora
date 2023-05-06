using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResourceDataSourcesSpecSchema
{

    [HclName("data_imports")]
    [Optional]
    public DataCollectionRuleResourceDataImportSourcesSchema DataImports { get; set; }


    [HclName("extension")]
    [Optional]
    public List<DataCollectionRuleResourceExtensionDataSourceSchema> Extension { get; set; }


    [HclName("iis_log")]
    [Optional]
    public List<DataCollectionRuleResourceIisLogsDataSourceSchema> IisLog { get; set; }


    [HclName("log_file")]
    [Optional]
    public List<DataCollectionRuleResourceLogFilesDataSourceSchema> LogFile { get; set; }


    [HclName("performance_counter")]
    [Optional]
    public List<DataCollectionRuleResourcePerfCounterDataSourceSchema> PerformanceCounter { get; set; }


    [HclName("platform_telemetry")]
    [Optional]
    public List<DataCollectionRuleResourcePlatformTelemetryDataSourceSchema> PlatformTelemetry { get; set; }


    [HclName("prometheus_forwarder")]
    [Optional]
    public List<DataCollectionRuleResourcePrometheusForwarderDataSourceSchema> PrometheusForwarder { get; set; }


    [HclName("syslog")]
    [Optional]
    public List<DataCollectionRuleResourceSyslogDataSourceSchema> Syslog { get; set; }


    [HclName("windows_event_log")]
    [Optional]
    public List<DataCollectionRuleResourceWindowsEventLogDataSourceSchema> WindowsEventLog { get; set; }


    [HclName("windows_firewall_log")]
    [Optional]
    public List<DataCollectionRuleResourceWindowsFirewallLogsDataSourceSchema> WindowsFirewallLog { get; set; }

}
