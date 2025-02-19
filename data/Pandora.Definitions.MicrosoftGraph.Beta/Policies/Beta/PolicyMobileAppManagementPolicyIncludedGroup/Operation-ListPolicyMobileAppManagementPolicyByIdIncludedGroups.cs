// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Policies.Beta.PolicyMobileAppManagementPolicyIncludedGroup;

internal class ListPolicyMobileAppManagementPolicyByIdIncludedGroupsOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";
    public override ResourceID? ResourceId() => new PolicyMobileAppManagementPolicyId();
    public override Type NestedItemType() => typeof(GroupCollectionResponseModel);
    public override string? UriSuffix() => "/includedGroups";
}
