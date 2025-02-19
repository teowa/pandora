using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataFactory.v2018_06_01.IntegrationRuntimeObjectMetadata;

internal class Definition : ResourceDefinition
{
    public string Name => "IntegrationRuntimeObjectMetadata";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new GetOperation(),
        new RefreshOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(SsisObjectMetadataTypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(GetSsisObjectMetadataRequestModel),
        typeof(SsisObjectMetadataModel),
        typeof(SsisObjectMetadataListResponseModel),
        typeof(SsisObjectMetadataStatusResponseModel),
    };
}
