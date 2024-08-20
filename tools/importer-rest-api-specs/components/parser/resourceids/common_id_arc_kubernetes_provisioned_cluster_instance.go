package resourceids

import (
	sdkModels "github.com/hashicorp/pandora/tools/data-api-sdk/v1/models"
)

var _ commonIdMatcher = commonIdArcKubernetesProvisionedClusterInstance{}

type commonIdArcKubernetesProvisionedClusterInstance struct{}

func (c commonIdArcKubernetesProvisionedClusterInstance) id() sdkModels.ResourceID {
	name := "ArcKubernetesProvisionedClusterInstance"
	return sdkModels.ResourceID{
		CommonIDAlias: &name,
		ConstantNames: []string{},
		Segments: []sdkModels.ResourceIDSegment{
			sdkModels.NewStaticValueResourceIDSegment("subscriptions", "subscriptions"),
			sdkModels.NewSubscriptionIDResourceIDSegment("subscriptionId"),
			sdkModels.NewStaticValueResourceIDSegment("resourceGroups", "resourceGroups"),
			sdkModels.NewResourceGroupNameResourceIDSegment("resourceGroupName"),
			sdkModels.NewStaticValueResourceIDSegment("providers", "providers"),
			sdkModels.NewResourceProviderResourceIDSegment("resourceProvider", "Microsoft.Kubernetes"),
			sdkModels.NewStaticValueResourceIDSegment("connectedClusters", "connectedClusters"),
			sdkModels.NewUserSpecifiedResourceIDSegment("connectedClusterName", "connectedClusterName"),
			sdkModels.NewStaticValueResourceIDSegment("providers", "providers"),
			sdkModels.NewResourceProviderResourceIDSegment("resourceProvider", "Microsoft.HybridContainerService"),
			sdkModels.NewStaticValueResourceIDSegment("provisionedClusterInstances", "provisionedClusterInstances"),
			sdkModels.NewStaticValueResourceIDSegment("default", "default"),
		},
	}
}
