using System.Collections.Generic;
using Pandora.Definitions.Helpers;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSANSnapshotResourceTests : TerraformResourceTestDefinition
{
    public string BasicTestConfig => @"
provider 'azurerm' {
  features {}
}

resource 'azurerm_elastic_san_snapshot' 'test' {
  name            = 'acctestess-${var.random_string}'
  volume_group_id = TODO
  creation_data {
    source_id = TODO
  }
}
    ".AsTerraformTestConfig();

    public string RequiresImportConfig => @"
resource 'azurerm_elastic_san_snapshot' 'import' {
  name            = azurerm_elastic_san_snapshot.test.name
  volume_group_id = azurerm_elastic_san_snapshot.test.volume_group_id
  creation_data {
    source_id = azurerm_elastic_san_snapshot.test.creation_data.0.source_id
  }
}
    ".AsTerraformTestConfig();

    public string? CompleteConfig => @"
provider 'azurerm' {
  features {}
}

resource 'azurerm_elastic_san_snapshot' 'test' {
  name            = 'acctestess-${var.random_string}'
  volume_group_id = TODO
  creation_data {
    source_id = TODO
  }
}
".AsTerraformTestConfig();
    public string? TemplateConfig => @"
variable 'random_string' {}
".AsTerraformTestConfig();

    public Dictionary<string, List<string>> OtherTests => new Dictionary<string, List<string>>();
}
