using System.Collections.Generic;
using Pandora.Definitions.Helpers;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANResourceTests : TerraformResourceTestDefinition
{
    public string BasicTestConfig => @"
provider 'azurerm' {
  features {}
}

resource 'azurerm_elastic_san' 'test' {
  base_size_tib              = 21
  extended_capacity_size_tib = 21
  location                   = azurerm_resource_group.test.location
  name                       = 'acctestes-${var.random_string}'
  resource_group_name        = azurerm_resource_group.test.name
  sku {
    name = 'Premium_LRS'
  }
}
    ".AsTerraformTestConfig();

    public string RequiresImportConfig => @"
resource 'azurerm_elastic_san' 'import' {
  base_size_tib              = azurerm_elastic_san.test.base_size_tib
  extended_capacity_size_tib = azurerm_elastic_san.test.extended_capacity_size_tib
  location                   = azurerm_elastic_san.test.location
  name                       = azurerm_elastic_san.test.name
  resource_group_name        = azurerm_elastic_san.test.resource_group_name
  sku {
    name = azurerm_elastic_san.test.sku.0.name
  }
}
    ".AsTerraformTestConfig();

    public string? CompleteConfig => @"
provider 'azurerm' {
  features {}
}

resource 'azurerm_elastic_san' 'test' {
  base_size_tib              = 21
  extended_capacity_size_tib = 21
  location                   = azurerm_resource_group.test.location
  name                       = 'acctestes-${var.random_string}'
  resource_group_name        = azurerm_resource_group.test.name
  sku {
    name = 'Premium_LRS'
    tier = 'Premium'
  }
  availability_zones    = ['1', '2', '3']
  public_network_access = 'Enabled'
  tags = {
    environment = 'terraform-acctests'
    some_key    = 'some-value'
  }
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
