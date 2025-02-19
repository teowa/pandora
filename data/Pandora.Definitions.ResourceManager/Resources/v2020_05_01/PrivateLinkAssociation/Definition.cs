using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Resources.v2020_05_01.PrivateLinkAssociation;

internal class Definition : ResourceDefinition
{
    public string Name => "PrivateLinkAssociation";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
        new PutOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(PublicNetworkAccessOptionsConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(PrivateLinkAssociationModel),
        typeof(PrivateLinkAssociationGetResultModel),
        typeof(PrivateLinkAssociationObjectModel),
        typeof(PrivateLinkAssociationPropertiesModel),
        typeof(PrivateLinkAssociationPropertiesExpandedModel),
    };
}
