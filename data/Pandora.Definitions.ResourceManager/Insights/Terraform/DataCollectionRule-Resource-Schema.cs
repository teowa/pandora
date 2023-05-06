using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResourceSchema
{

    [Documentation("The resource ID of the data collection endpoint that this rule can be used with.")]
    [HclName("data_collection_endpoint_id")]
    [Optional]
    public string DataCollectionEndpointId { get; set; }


    [Documentation("The specification of data flows.")]
    [HclName("data_flow")]
    [Optional]
    public List<DataCollectionRuleResourceDataFlowSchema> DataFlow { get; set; }


    [Documentation("The specification of data sources.")]
    [HclName("data_sources")]
    [Optional]
    public DataCollectionRuleResourceDataSourcesSpecSchema DataSources { get; set; }


    [Documentation("Description of the data collection rule.")]
    [HclName("description")]
    [Optional]
    public string Description { get; set; }


    [Documentation("The specification of destinations.")]
    [HclName("destinations")]
    [Optional]
    public DataCollectionRuleResourceDestinationsSpecSchema Destinations { get; set; }


    [Documentation("Specifies the Managed Identity which should be assigned to this Data Collection Rule.")]
    [ForceNew]
    [HclName("identity")]
    [Optional]
    public CommonSchema.SystemAndUserAssignedIdentity Identity { get; set; }


    [Computed]
    [Documentation("The immutable ID of this data collection rule.")]
    [HclName("immutable_id")]
    public string ImmutableId { get; set; }


    [Documentation("The Azure Region where the Data Collection Rule should exist.")]
    [ForceNew]
    [HclName("location")]
    [Required]
    public CommonSchema.Location Location { get; set; }


    [Computed]
    [Documentation("Metadata about the resource.")]
    [HclName("metadata")]
    public DataCollectionRuleResourceMetadataSchema Metadata { get; set; }


    [Documentation("Specifies the name of this Data Collection Rule.")]
    [ForceNew]
    [HclName("name")]
    [Required]
    public string Name { get; set; }


    [Documentation("Specifies the name of the Resource Group within which this Data Collection Rule should exist.")]
    [ForceNew]
    [HclName("resource_group_name")]
    [Required]
    public CommonSchema.ResourceGroupName ResourceGroupName { get; set; }


    [Documentation("Declaration of custom streams used in this rule.")]
    [HclName("stream_declarations")]
    [Optional]
    public Dictionary<string, DataCollectionRuleResourceStreamDeclarationSchema> StreamDeclarations { get; set; }


    [Documentation("A mapping of tags which should be assigned to the Data Collection Rule.")]
    [ForceNew]
    [HclName("tags")]
    [Optional]
    public CommonSchema.Tags Tags { get; set; }

}
