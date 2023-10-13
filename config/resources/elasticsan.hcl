service "ElasticSan" {
  terraform_package = "elasticsan"

  api "2023-01-01" {
    package "ElasticSans" {
      definition "elastic_san" {
        id = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}"
        display_name = "Elastic SAN"
        website_subcategory = "Elastic SAN"
        description = "manages an Elastic SAN instance"
      }
    }

    // data/Pandora.Definitions.ResourceManager/ElasticSan/Terraform/ElasticSANVolumeGroup-Resource-Mappings.cs:18 ElasticSANVolumeGroupResourceKeyVaultPropertiesSchema
    package "VolumeGroups" {
      definition "elastic_san_volume_group" {
        id = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumeGroups/{volumeGroupName}"
        display_name = "Elastic SAN Volume Group"
        website_subcategory = "Elastic SAN"
        description = "manages an Elastic SAN Volume Group"
      }
    }

    package "Volumes" {
      definition "elastic_san_volume" {
        id = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumeGroups/{volumeGroupName}/volumes/{volumeName}"
        display_name = "Elastic SAN Volume"
        website_subcategory = "Elastic SAN"
        description = "manages an Elastic SAN Volume"
      }
    }

    package "Snapshots" {
      definition "elastic_san_snapshot" {
        id = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumeGroups/{volumeGroupName}/snapshots/{snapshotName}"
        display_name = "Elastic SAN Snapshot"
        website_subcategory = "Elastic SAN"
        description = "manages an Elastic SAN Snapshot"
      }
    }
  }
}
