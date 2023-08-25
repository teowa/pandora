using System.Collections.Generic;
using Pandora.Definitions.Helpers;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.Resources.Terraform;

public class ResourceManagementPrivateLinkAssociationResourceTests : TerraformResourceTestDefinition
{
    public string BasicTestConfig => @"
provider 'azurerm' {
  features {}
}

resource 'azurerm_resource_management_private_link_association' 'test' {
  group_id = TODO
  name     = 'acctestrmpla-${var.random_string}'
}
    ".AsTerraformTestConfig();

    public string RequiresImportConfig => @"
resource 'azurerm_resource_management_private_link_association' 'import' {
  group_id = azurerm_resource_management_private_link_association.test.group_id
  name     = azurerm_resource_management_private_link_association.test.name
}
    ".AsTerraformTestConfig();

    public string? CompleteConfig => @"
provider 'azurerm' {
  features {}
}

resource 'azurerm_resource_management_private_link_association' 'test' {
  group_id              = TODO
  name                  = 'acctestrmpla-${var.random_string}'
  private_link          = 'val-${var.random_string}'
  public_network_access = 'Disabled'
}
".AsTerraformTestConfig();
    public string? TemplateConfig => @"
variable 'random_string' {}
".AsTerraformTestConfig();

    public Dictionary<string, List<string>> OtherTests => new Dictionary<string, List<string>>();
}
