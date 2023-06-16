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
3. package name must be same with the package name in data/Pandora.Definitions.ResourceManager/[RP]/[APIVersion]/[Package], for example, above the `Replicas` is aligned with `Replicas` in `data/Pandora.Definitions.ResourceManager/AppConfiguration/2023-03-01/Replicas`.

## run tools/importer-rest-api-specs
```bash
SERVICES=AppConfiguration make import
```
if this step succeed, you will see the data output in `data/Pandora.Definitions.ResourceManager/AppConfiguration/Terraform/AppConfigurationReplica-Resource.cs`

to debug with Goland, run below commands and then attach the process:
```bash
cd tools/importer-rest-api-specs
go build -gcflags="all=-N -l" -o importer-rest-api-specs
DEBUG=1 ./generator-terraform generate --services=AppConfiguration
```

## run data API
The data API takes some time (up to tens of minutes) to build and start, and 
TODO: speed up data API to only start single service
```bash
cd data
make run
```

## run tools/generator-terraform
This step should run at same time with data API running.
```bash
cd tools/generator-terraform
make build
./generator-terraform generate --services=AppConfiguration
```
And the output will be in `$HOME/Desktop/generated-tf-dev`
