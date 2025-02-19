using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerRegistry.v2023_06_01_preview.CredentialSets;

internal class Definition : ResourceDefinition
{
    public string Name => "CredentialSets";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(CredentialHealthStatusConstant),
        typeof(CredentialNameConstant),
        typeof(ProvisioningStateConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(AuthCredentialModel),
        typeof(CredentialHealthModel),
        typeof(CredentialSetModel),
        typeof(CredentialSetPropertiesModel),
        typeof(CredentialSetUpdateParametersModel),
        typeof(CredentialSetUpdatePropertiesModel),
    };
}
