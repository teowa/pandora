using Pandora.Definitions.Interfaces;
using System.Collections.Generic;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Authorization;

public partial class Service : ServiceDefinition
{
    public string Name => "Authorization";
    public string? ResourceProvider => "Microsoft.Authorization";
    public string? TerraformPackageName => "network";

    public IEnumerable<TerraformResourceDefinition> TerraformResources => new List<TerraformResourceDefinition>
    {

    };
}
