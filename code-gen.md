# code gen terraform steps

## write resource config 
See examples in config/resources/Insights:
```hcl
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
```

**Note:** 
1. see config/resources/README.md for more details
2. id must be in strict format with parsed resource Ids of tools/importer-rest-api-specs

## run tools/importer-rest-api-specs
```bash
SERVICES=AppConfiguration make import
```

or to debug with Goland
```bash
cd tools/importer-rest-api-specs
go build -gcflags="all=-N -l" -o importer-rest-api-specs
./generator-terraform generate --services=AppConfiguration
```

## run data API
TODO: speed up data API to only start single service
```bash
cd data
make run
```

## run tools/generator-terraform
This step should run at same time with data API running.
```bash
make build
./generator-terraform generate --services=AppConfiguration
```