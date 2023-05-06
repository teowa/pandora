using System;
using Pandora.Definitions.Helpers;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResource : TerraformResourceDefinition
{
    public string DisplayName => "Data Collection Rule";
    public ResourceID ResourceId => new v2022_06_01.DataCollectionRules.DataCollectionRuleId();
    public string ResourceLabel => "data_collection_rule";
    public string ResourceCategory => "Monitor";
    public string ResourceDescription => @"Manages a Data Collection Rule";
    public string ResourceExampleUsage => @"resource 'azurerm_data_collection_rule' 'example' {
  location            = azurerm_resource_group.example.location
  name                = 'example'
  resource_group_name = azurerm_resource_group.example.name
}".AsTerraformTestConfig();
    public Type? SchemaModel => typeof(DataCollectionRuleResourceSchema);
    public TerraformMappingDefinition SchemaMappings => new DataCollectionRuleResourceMappings();
    public TerraformResourceTestDefinition Tests => new DataCollectionRuleResourceTests();

    public bool GenerateIDValidationFunction => true;
    public bool GenerateModel => true;
    public bool GenerateSchema => true;

    public MethodDefinition CreateMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2022_06_01.DataCollectionRules.CreateOperation),
        TimeoutInMinutes = 30,
    };
    public MethodDefinition DeleteMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2022_06_01.DataCollectionRules.DeleteOperation),
        TimeoutInMinutes = 30,
    };
    public MethodDefinition ReadMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2022_06_01.DataCollectionRules.GetOperation),
        TimeoutInMinutes = 5,
    };
    public MethodDefinition? UpdateMethod => null;
}
