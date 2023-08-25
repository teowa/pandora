using System.Collections.Generic;
using Pandora.Definitions.Helpers;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.Resources.Terraform;

public class ResourceManagementPrivateLinkResourceTests : TerraformResourceTestDefinition
{
    public string BasicTestConfig => @"
provider 'azurerm' {
  features {}
}

resource 'azurerm_resource_management_private_link' 'test' {
  location            = azurerm_resource_group.test.location
  name                = 'acctestrmpl-${var.random_string}'
  resource_group_name = azurerm_resource_group.test.name
}
    ".AsTerraformTestConfig();

    public string RequiresImportConfig => @"
resource 'azurerm_resource_management_private_link' 'import' {
  location            = azurerm_resource_management_private_link.test.location
  name                = azurerm_resource_management_private_link.test.name
  resource_group_name = azurerm_resource_management_private_link.test.resource_group_name
}
    ".AsTerraformTestConfig();

    public string? CompleteConfig => @"
provider 'azurerm' {
  features {}
}

resource 'azurerm_resource_management_private_link' 'test' {
  location            = azurerm_resource_group.test.location
  name                = 'acctestrmpl-${var.random_string}'
  resource_group_name = azurerm_resource_group.test.name
}
".AsTerraformTestConfig();
    public string? TemplateConfig => @"
variable 'primary_location' {}
variable 'random_integer' {}
variable 'random_string' {}

resource 'azurerm_resource_group' 'test' {
  name     = 'acctestrg-${var.random_integer}'
  location = var.primary_location
}
".AsTerraformTestConfig();

    public Dictionary<string, List<string>> OtherTests => new Dictionary<string, List<string>>();
}
