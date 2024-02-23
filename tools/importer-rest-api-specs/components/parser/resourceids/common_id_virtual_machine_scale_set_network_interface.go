// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

package resourceids

import (
	importerModels "github.com/hashicorp/pandora/tools/importer-rest-api-specs/models"
	"github.com/hashicorp/pandora/tools/sdk/resourcemanager"
)

var _ commonIdMatcher = commonIdVirtualMachineScaleSetNetworkInterface{}

type commonIdVirtualMachineScaleSetNetworkInterface struct{}

func (c commonIdVirtualMachineScaleSetNetworkInterface) id() importerModels.ParsedResourceId {
	name := "VirtualMachineScaleSetNetworkInterface"
	return importerModels.ParsedResourceId{
		CommonAlias: &name,
		Constants:   map[string]resourcemanager.ConstantDetails{},
		Segments: []resourcemanager.ResourceIdSegment{
			importerModels.StaticResourceIDSegment("subscriptions", "subscriptions"),
			importerModels.SubscriptionIDResourceIDSegment("subscriptionId"),
			importerModels.StaticResourceIDSegment("resourceGroups", "resourceGroups"),
			importerModels.ResourceGroupResourceIDSegment("resourceGroupName"),
			importerModels.StaticResourceIDSegment("providers", "providers"),
			importerModels.ResourceProviderResourceIDSegment("resourceProvider", "Microsoft.Compute"),
			importerModels.StaticResourceIDSegment("virtualMachineScaleSets", "virtualMachineScaleSets"),
			importerModels.UserSpecifiedResourceIDSegment("virtualMachineScaleSetName"),
			importerModels.StaticResourceIDSegment("virtualMachines", "virtualMachines"),
			importerModels.UserSpecifiedResourceIDSegment("virtualMachineIndex"),
			importerModels.StaticResourceIDSegment("networkInterfaces", "networkInterfaces"),
			importerModels.UserSpecifiedResourceIDSegment("networkInterfaceName"),
		},
	}

}
