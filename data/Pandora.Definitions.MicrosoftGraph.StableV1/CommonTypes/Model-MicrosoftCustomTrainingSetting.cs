// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

internal class MicrosoftCustomTrainingSettingModel
{
    [JsonPropertyName("completionDateTime")]
    public DateTime? CompletionDateTime { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("settingType")]
    public MicrosoftCustomTrainingSettingSettingTypeConstant? SettingType { get; set; }

    [JsonPropertyName("trainingAssignmentMappings")]
    public List<MicrosoftTrainingAssignmentMappingModel>? TrainingAssignmentMappings { get; set; }

    [JsonPropertyName("trainingCompletionDuration")]
    public MicrosoftCustomTrainingSettingTrainingCompletionDurationConstant? TrainingCompletionDuration { get; set; }
}
