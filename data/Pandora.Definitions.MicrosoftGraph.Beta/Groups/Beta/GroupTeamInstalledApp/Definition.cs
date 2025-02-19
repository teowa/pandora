// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Groups.Beta.GroupTeamInstalledApp;

internal class Definition : ResourceDefinition
{
    public string Name => "GroupTeamInstalledApp";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateGroupByIdTeamInstalledAppByIdUpgradeOperation(),
        new CreateGroupByIdTeamInstalledAppOperation(),
        new DeleteGroupByIdTeamInstalledAppByIdOperation(),
        new GetGroupByIdTeamInstalledAppByIdOperation(),
        new GetGroupByIdTeamInstalledAppCountOperation(),
        new ListGroupByIdTeamInstalledAppsOperation(),
        new UpdateGroupByIdTeamInstalledAppByIdOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(CreateGroupByIdTeamInstalledAppByIdUpgradeRequestModel)
    };
}
