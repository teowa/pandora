using System.Collections.Generic;
using Pandora.Definitions.Helpers;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.GraphServices.Terraform;

public class AccountResourceTests : TerraformResourceTestDefinition
{
    public string BasicTestConfig => @"
provider 'azurerm' {
  features {}
}

resource 'azurerm_account' 'test' {
  app_id              = TODO
  location            = azurerm_resource_group.test.location
  name                = 'acctesta-${var.random_integer}'
  resource_group_name = azurerm_resource_group.test.name
}
    ".AsTerraformTestConfig();

    public string RequiresImportConfig => @"
resource 'azurerm_account' 'import' {
  app_id              = azurerm_account.test.app_id
  location            = azurerm_account.test.location
  name                = azurerm_account.test.name
  resource_group_name = azurerm_account.test.resource_group_name
}
    ".AsTerraformTestConfig();

    public string? CompleteConfig => @"
provider 'azurerm' {
  features {}
}

resource 'azurerm_account' 'test' {
  app_id              = TODO
  location            = azurerm_resource_group.test.location
  name                = 'acctesta-${var.random_integer}'
  resource_group_name = azurerm_resource_group.test.name
  tags = {
    environment = 'terraform-acctests'
    some_key    = 'some-value'
  }
}
".AsTerraformTestConfig();
    public string? TemplateConfig => @"
variable 'primary_location' {}
variable 'random_integer' {}

resource 'azurerm_resource_group' 'test' {
  name     = 'acctestrg-${var.random_integer}'
  location = var.primary_location
}
".AsTerraformTestConfig();

    public Dictionary<string, List<string>> OtherTests => new Dictionary<string, List<string>>();
}
