// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Me.Beta.MeOnenoteSectionGroupSection;

internal class CreateMeOnenoteSectionGroupByIdSectionByIdCopyToNotebookOperation : Operations.PostOperation
{

    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
        };
    public override Type? RequestObject() => typeof(CreateMeOnenoteSectionGroupByIdSectionByIdCopyToNotebookRequestModel);
    public override ResourceID? ResourceId() => new MeOnenoteSectionGroupIdSectionId();
    public override Type? ResponseObject() => typeof(OnenoteOperationModel);
    public override string? UriSuffix() => "/copyToNotebook";
}
