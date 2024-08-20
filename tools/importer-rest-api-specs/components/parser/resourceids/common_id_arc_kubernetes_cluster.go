package resourceids

import (
	sdkModels "github.com/hashicorp/pandora/tools/data-api-sdk/v1/models"
)

var _ commonIdMatcher = commonIdArcKubernetesCluster{}

type commonIdArcKubernetesCluster struct{}

func (c commonIdArcKubernetesCluster) id() sdkModels.ResourceID {
	name := "commonIdArcKubernetesCluster"
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
		},
	}
}
