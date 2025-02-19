using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataBoxEdge.v2022_03_01.Roles;


internal class SubscriptionPropertiesModel
{
    [JsonPropertyName("locationPlacementId")]
    public string? LocationPlacementId { get; set; }

    [JsonPropertyName("quotaId")]
    public string? QuotaId { get; set; }

    [JsonPropertyName("registeredFeatures")]
    public List<SubscriptionRegisteredFeaturesModel>? RegisteredFeatures { get; set; }

    [JsonPropertyName("serializedDetails")]
    public string? SerializedDetails { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}
