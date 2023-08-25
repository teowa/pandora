service "Resources" {
  terraform_package = "resource"

  api "2020-05-01" {
    package "ResourceManagementPrivateLink" {
      definition "resource_management_private_link" {
        id = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Authorization/resourceManagementPrivateLinks/{resourceManagementPrivateLinkName}"
        display_name = "Resource Management Private Link"
        website_subcategory = "Network"
        description = "Manages a Resource Management Private Link"
      }
    }

    package "PrivateLinkAssociation" {
      definition "resource_management_private_link_association" {
        id = "/providers/Microsoft.Management/managementGroups/{groupId}/providers/Microsoft.Authorization/privateLinkAssociations/{plaId}"
        display_name = "Resource Management Private Link Association"
        website_subcategory = "Network"
        description = "Manages a Resource Management Private Link Association"
      }
    }
  }
}
