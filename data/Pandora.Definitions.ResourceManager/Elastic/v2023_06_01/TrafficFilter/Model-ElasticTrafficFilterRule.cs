using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Elastic.v2023_06_01.TrafficFilter;


internal class ElasticTrafficFilterRuleModel
{
    [JsonPropertyName("azureEndpointGuid")]
    public string? AzureEndpointGuid { get; set; }

    [JsonPropertyName("azureEndpointName")]
    public string? AzureEndpointName { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }
}
