# code gen terraform steps

## Step1: write resource config 
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
1. `service` is from the RP name in directory `data/Pandora.Definitions.ResourceManager/[RP]`.
2. `terraform_package` is from `terraform_provider_azurerm` repo directory `internal/services/appconfiguration`.
3. `package` must be same with the package name in `data/Pandora.Definitions.ResourceManager/[RP]/[APIVersion]/[Package]`, for example, above the `Replicas` is aligned with `Replicas` in `data/Pandora.Definitions.ResourceManager/AppConfiguration/2023-03-01/Replicas`.
4. `definition` is the azurerm resource name.
5. `id` must be in strict format with parsed resource Ids in `data/Pandora.Definitions.ResourceManager/[RP]/[APIVersion]/[Package]/ResourceId-[Package]Id.cs` file, for example, `/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configurationStoreName}/replicas/{replicaName}` in `data/Pandora.Definitions.ResourceManager/AppConfiguration/v2023_03_01/Replicas/ResourceId-ReplicaId.cs` file.
6. `display_name`, `website_subcategory` and `description` are used to generate markdown documentation.
7. see `config/resources/README.md` for more details

## Step2: run tools/importer-rest-api-specs
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

## Step3: run data API
The data API takes some time (up to tens of minutes) to build and start. After start, keeping the data API running, since step4 relies on it.

TODO: speed up data API to only start single service
```bash
cd data
make run
```

## Step4: run tools/generator-terraform
This step should run at same time with data API running.
```bash
cd tools/generator-terraform
make build
./generator-terraform generate --services=AppConfiguration
```
And the output will be in `$HOME/Desktop/generated-tf-dev`
