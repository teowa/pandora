using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerApps.v2023_05_01.ContainerAppsRevisionReplicas;

internal class Definition : ResourceDefinition
{
    public string Name => "ContainerAppsRevisionReplicas";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new GetReplicaOperation(),
        new ListReplicasOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ContainerAppContainerRunningStateConstant),
        typeof(ContainerAppReplicaRunningStateConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ReplicaModel),
        typeof(ReplicaCollectionModel),
        typeof(ReplicaContainerModel),
        typeof(ReplicaPropertiesModel),
    };
}
