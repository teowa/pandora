// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Identity.StableV1.IdentityB2xUserFlowUserAttributeAssignment;

internal class ListIdentityB2xUserFlowByIdUserAttributeAssignmentsOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";
    public override ResourceID? ResourceId() => new IdentityB2xUserFlowId();
    public override Type NestedItemType() => typeof(IdentityUserFlowAttributeAssignmentCollectionResponseModel);
    public override string? UriSuffix() => "/userAttributeAssignments";
}
