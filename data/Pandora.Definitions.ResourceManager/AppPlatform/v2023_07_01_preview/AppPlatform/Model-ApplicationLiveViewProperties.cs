using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.AppPlatform.v2023_07_01_preview.AppPlatform;


internal class ApplicationLiveViewPropertiesModel
{
    [JsonPropertyName("components")]
    public List<ApplicationLiveViewComponentModel>? Components { get; set; }

    [JsonPropertyName("provisioningState")]
    public ApplicationLiveViewProvisioningStateConstant? ProvisioningState { get; set; }
}
