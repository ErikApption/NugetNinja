﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.NugetNinja;

public class Package
{
    public Package(string name, string versionText)
    {
        Name = name;
        VersionText = versionText;
        Version = StringExtensions.ConvertToVersion(versionText); 
    }

    public string Name { get; set; }

    public Version Version { get; set; }
    public string VersionText { get; set; }

    public override string ToString()
    {
        return Name;
    }
}