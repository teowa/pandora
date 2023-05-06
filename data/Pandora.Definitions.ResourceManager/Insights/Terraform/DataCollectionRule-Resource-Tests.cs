using System.Collections.Generic;
using Pandora.Definitions.Helpers;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.Insights.Terraform;

public class DataCollectionRuleResourceTests : TerraformResourceTestDefinition
{
    public string BasicTestConfig => @"
resource 'azurerm_data_collection_rule' 'test' {
  location            = azurerm_resource_group.test.location
  name                = 'acctest-${local.random_integer}'
  resource_group_name = azurerm_resource_group.test.name
}
    ".AsTerraformTestConfig();

    public string RequiresImportConfig => @"
resource 'azurerm_data_collection_rule' 'import' {

  data_sources {

    extension {
      extension_name = 'foo'
    }


    iis_log {

      stream = ['foo', 'baz']

    }


    log_file {

      file_pattern = ['foo', 'baz']

      format = 'foo'

      settings {

        text {
          record_start_timestamp_format = 'foo'
        }

      }


      stream = ['foo', 'baz']

    }


    platform_telemetry {

      stream = ['foo', 'baz']

    }


    windows_firewall_log {

      stream = ['foo', 'baz']

    }

  }

  location            = azurerm_resource_group.test.location
  name                = 'acctest-${local.random_integer}'
  resource_group_name = azurerm_resource_group.test.name
}
    ".AsTerraformTestConfig();

    public string? CompleteConfig => @"
resource 'azurerm_data_collection_rule' 'test' {
  location                    = azurerm_resource_group.test.location
  name                        = 'acctest-${local.random_integer}'
  resource_group_name         = azurerm_resource_group.test.name
  data_collection_endpoint_id = 'foo'

  data_flow {
    built_in_transform = 'foo'

    destination = ['foo', 'baz']

    output_stream = 'foo'

    stream = ['foo', 'baz']

    transform_kql = 'foo'
  }


  data_sources {

    data_imports {

      event_hub {
        consumer_group = 'foo'
        name           = 'acctest-${local.random_integer}'
        stream         = 'foo'
      }

    }


    extension {
      extension_name = 'foo'

      input_data_source = ['foo', 'baz']

      name = 'acctest-${local.random_integer}'

      stream = ['foo', 'baz']

    }


    iis_log {

      stream = ['foo', 'baz']


      log_directory = ['foo', 'baz']

      name = 'acctest-${local.random_integer}'
    }


    log_file {

      file_pattern = ['foo', 'baz']

      format = 'foo'

      stream = ['foo', 'baz']

      name = 'acctest-${local.random_integer}'

      settings {

        text {
          record_start_timestamp_format = 'foo'
        }

      }

    }


    performance_counter {

      counter_specifier = ['foo', 'baz']

      name                          = 'acctest-${local.random_integer}'
      sampling_frequency_in_seconds = 15

      stream = ['foo', 'baz']

    }


    platform_telemetry {

      stream = ['foo', 'baz']

      name = 'acctest-${local.random_integer}'
    }


    prometheus_forwarder {
      name = 'acctest-${local.random_integer}'

      stream = ['foo', 'baz']

    }


    syslog {

      facility_name = ['foo', 'baz']


      log_level = ['foo', 'baz']

      name = 'acctest-${local.random_integer}'

      stream = ['foo', 'baz']

    }


    windows_event_log {
      name = 'acctest-${local.random_integer}'

      stream = ['foo', 'baz']


      xpath_query = ['foo', 'baz']

    }


    windows_firewall_log {

      stream = ['foo', 'baz']

      name = 'acctest-${local.random_integer}'
    }

  }

  description = 'foo'

  destinations {

    azure_monitor_metrics {
      name = 'acctest-${local.random_integer}'
    }


    event_hub {
      event_hub_resource_id = 'foo'
      name                  = 'acctest-${local.random_integer}'
    }


    event_hubs_direct {
      event_hub_resource_id = 'foo'
      name                  = 'acctest-${local.random_integer}'
    }


    log_analytic {
      name                  = 'acctest-${local.random_integer}'
      workspace_resource_id = 'foo'
    }


    monitoring_account {
      account_resource_id = 'foo'
      name                = 'acctest-${local.random_integer}'
    }


    storage_account {
      container_name              = 'foo'
      name                        = 'acctest-${local.random_integer}'
      storage_account_resource_id = 'foo'
    }


    storage_blobs_direct {
      container_name              = 'foo'
      name                        = 'acctest-${local.random_integer}'
      storage_account_resource_id = 'foo'
    }


    storage_tables_direct {
      name                        = 'acctest-${local.random_integer}'
      storage_account_resource_id = 'foo'
      table_name                  = 'foo'
    }

  }


  identity {
    type         = 'SystemAssigned, UserAssigned'
    identity_ids = [azurerm_user_assigned_identity.test.id]
  }

  tags = {
    env  = 'Production'
    test = 'Acceptance'
  }
}
".AsTerraformTestConfig();
    public string? TemplateConfig => @"
provider 'azurerm' {
  features {}
}

locals {
  random_integer   = %[1]d
  primary_location = %[2]q
}


resource 'azurerm_resource_group' 'test' {
  name     = 'acctestrg-${local.random_integer}'
  location = local.primary_location
}



resource 'azurerm_user_assigned_identity' 'test' {
  name                = 'acctest-${local.random_integer}'
  resource_group_name = azurerm_resource_group.test.name
  location            = azurerm_resource_group.test.location
}
".AsTerraformTestConfig();

    public Dictionary<string, List<string>> OtherTests => new Dictionary<string, List<string>>();
}
