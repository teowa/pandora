// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Policies.StableV1.PolicyHomeRealmDiscoveryPolicy;

internal class Definition : ResourceDefinition
{
    public string Name => "PolicyHomeRealmDiscoveryPolicy";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreatePolicyHomeRealmDiscoveryPolicyOperation(),
        new DeletePolicyHomeRealmDiscoveryPolicyByIdOperation(),
        new GetPolicyHomeRealmDiscoveryPolicyByIdOperation(),
        new GetPolicyHomeRealmDiscoveryPolicyCountOperation(),
        new ListPolicyHomeRealmDiscoveryPoliciesOperation(),
        new UpdatePolicyHomeRealmDiscoveryPolicyByIdOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
