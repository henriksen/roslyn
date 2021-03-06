﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Reflection;

namespace Microsoft.CodeAnalysis.Host
{
    public interface IAnalyzerService : IWorkspaceService
    {
        IAnalyzerAssemblyLoader GetLoader();
    }
}
