service "AppConfiguration" {
  terraform_package = "appconfiguration"

  api "2023-03-01" {
    package "Replicas" {
      definition "app_configuration_replicas" {
        id = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configurationStoreName}/replicas/{replicaName}"
        display_name = "App Configuration Replica"
        website_subcategory = "App Configuration"
        description = "Manages a App Configuration Replica"
      }
    }
  }
}
