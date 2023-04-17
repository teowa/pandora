service "Insights" {
  terraform_package = "monitor"

  api "2022-06-01" {
    package "DataCollectionRules" {
      definition "data_collection_rule" {
        id = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules/{dataCollectionRuleName}"
        display_name = "Data Collection Rule"
        website_subcategory = "Monitor"
        description = "Manages a Data Collection Rule"
      }
    }
  }
}
