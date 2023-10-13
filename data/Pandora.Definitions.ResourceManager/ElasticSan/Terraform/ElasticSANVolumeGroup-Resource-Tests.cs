using System.Collections.Generic;
using Pandora.Definitions.Helpers;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANVolumeGroupResourceTests : TerraformResourceTestDefinition
{
    public string BasicTestConfig => @"
provider 'azurerm' {
  features {}
}

resource 'azurerm_elastic_san_volume_group' 'test' {
  elastic_san_id = TODO
  name           = 'acctestesvg-${var.random_string}'
}
    ".AsTerraformTestConfig();

    public string RequiresImportConfig => @"
resource 'azurerm_elastic_san_volume_group' 'import' {
  elastic_san_id = azurerm_elastic_san_volume_group.test.elastic_san_id
  name           = azurerm_elastic_san_volume_group.test.name
}
    ".AsTerraformTestConfig();

    public string? CompleteConfig => @"
provider 'azurerm' {
  features {}
}

resource 'azurerm_elastic_san_volume_group' 'test' {
  elastic_san_id = TODO
  name           = 'acctestesvg-${var.random_string}'
  encryption     = 'EncryptionAtRestWithPlatformKey'
  encryption_properties {
    key_name      = 'val-${var.random_string}'
    key_vault_uri = 'val-${var.random_string}'
    key_version   = 'val-${var.random_string}'
    identity {
      user_assigned_identity = 'val-${var.random_string}'
    }
  }
  identity {
    type         = 'SystemAssigned'
    identity_ids = []
  }
  network_acls {
    virtual_network_rule {
      id     = 'val-${var.random_string}'
      action = 'Allow'
    }
  }
}
".AsTerraformTestConfig();
    public string? TemplateConfig => @"
variable 'random_string' {}
".AsTerraformTestConfig();

    public Dictionary<string, List<string>> OtherTests => new Dictionary<string, List<string>>();
}
