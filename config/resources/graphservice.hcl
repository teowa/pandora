service "GraphServices" {
  terraform_package = "graph"

  api "2023-04-13" {
    package "Account" {
      definition "account" {
        id = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.GraphServices/accounts/{accountName}"
        display_name = "Account"
        website_subcategory = "Graph"
        description = "Manages a Graph Account"
      }
    }
  }
}
