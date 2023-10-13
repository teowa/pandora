using System.Collections.Generic;
using Pandora.Definitions.Helpers;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANVolumeResourceTests : TerraformResourceTestDefinition
{
    public string BasicTestConfig => @"
provider 'azurerm' {
  features {}
}

resource 'azurerm_elastic_san_volume' 'test' {
  name            = 'acctestesv-${var.random_string}'
  size_gib        = 21
  volume_group_id = TODO
}
    ".AsTerraformTestConfig();

    public string RequiresImportConfig => @"
resource 'azurerm_elastic_san_volume' 'import' {
  name            = azurerm_elastic_san_volume.test.name
  size_gib        = azurerm_elastic_san_volume.test.size_gib
  volume_group_id = azurerm_elastic_san_volume.test.volume_group_id
}
    ".AsTerraformTestConfig();

    public string? CompleteConfig => @"
provider 'azurerm' {
  features {}
}

resource 'azurerm_elastic_san_volume' 'test' {
  name            = 'acctestesv-${var.random_string}'
  size_gib        = 21
  volume_group_id = TODO
  creation_data {
    create_source = 'Disk'
    source_id     = TODO
  }
  managed_by {
    resource_id = TODO
  }
  storage_target {
    provisioning_state = 'Deleting'
    status             = 'Stopped'
  }
}
".AsTerraformTestConfig();
    public string? TemplateConfig => @"
variable 'random_string' {}
".AsTerraformTestConfig();

    public Dictionary<string, List<string>> OtherTests => new Dictionary<string, List<string>>();
}
