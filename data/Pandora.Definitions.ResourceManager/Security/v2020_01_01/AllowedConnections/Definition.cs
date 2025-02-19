using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Security.v2020_01_01.AllowedConnections;

internal class Definition : ResourceDefinition
{
    public string Name => "AllowedConnections";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new GetOperation(),
        new ListOperation(),
        new ListByHomeRegionOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ConnectionTypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(AllowedConnectionsResourceModel),
        typeof(AllowedConnectionsResourcePropertiesModel),
        typeof(ConnectableResourceModel),
        typeof(ConnectedResourceModel),
    };
}
