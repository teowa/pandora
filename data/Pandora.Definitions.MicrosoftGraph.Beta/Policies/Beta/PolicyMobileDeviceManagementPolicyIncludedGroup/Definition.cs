// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Policies.Beta.PolicyMobileDeviceManagementPolicyIncludedGroup;

internal class Definition : ResourceDefinition
{
    public string Name => "PolicyMobileDeviceManagementPolicyIncludedGroup";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new AddPolicyMobileDeviceManagementPolicyByIdIncludedGroupRefOperation(),
        new GetPolicyMobileDeviceManagementPolicyByIdIncludedGroupCountOperation(),
        new ListPolicyMobileDeviceManagementPolicyByIdIncludedGroupRefsOperation(),
        new ListPolicyMobileDeviceManagementPolicyByIdIncludedGroupsOperation(),
        new RemovePolicyMobileDeviceManagementPolicyByIdIncludedGroupByIdRefOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
