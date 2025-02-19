// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Users.StableV1.UserAuthenticationPasswordMethod;

internal class Definition : ResourceDefinition
{
    public string Name => "UserAuthenticationPasswordMethod";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateUserByIdAuthenticationPasswordMethodOperation(),
        new GetUserByIdAuthenticationPasswordMethodByIdOperation(),
        new GetUserByIdAuthenticationPasswordMethodCountOperation(),
        new ListUserByIdAuthenticationPasswordMethodsOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
