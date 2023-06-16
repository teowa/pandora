using System;
using Pandora.Definitions.Helpers;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.GraphServices.Terraform;

public class AccountResource : TerraformResourceDefinition
{
    public string DisplayName => "Account";
    public ResourceID ResourceId => new v2023_04_13.Graphservicesprods.AccountId();
    public string ResourceLabel => "account";
    public string ResourceCategory => "Graph";
    public string ResourceDescription => @"Manages a Graph Account";
    public string ResourceExampleUsage => @"resource 'azurerm_resource_group' 'example' {
  name     = 'example-resources'
  location = 'West Europe'
}
resource 'azurerm_account' 'example' {
  app_id              = 'example-value'
  location            = azurerm_resource_group.example.location
  name                = 'example'
  resource_group_name = azurerm_resource_group.example.name
}".AsTerraformTestConfig();
    public Type? SchemaModel => typeof(AccountResourceSchema);
    public TerraformMappingDefinition SchemaMappings => new AccountResourceMappings();
    public TerraformResourceTestDefinition Tests => new AccountResourceTests();

    public bool GenerateIDValidationFunction => true;
    public bool GenerateModel => true;
    public bool GenerateSchema => true;

    public MethodDefinition CreateMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2023_04_13.Graphservicesprods.AccountsCreateAndUpdateOperation),
        TimeoutInMinutes = 30,
    };
    public MethodDefinition DeleteMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2023_04_13.Graphservicesprods.AccountsDeleteOperation),
        TimeoutInMinutes = 30,
    };
    public MethodDefinition ReadMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2023_04_13.Graphservicesprods.AccountsGetOperation),
        TimeoutInMinutes = 5,
    };
    public MethodDefinition? UpdateMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2023_04_13.Graphservicesprods.AccountsCreateAndUpdateOperation),
        TimeoutInMinutes = 30,
    };
}
