#!/usr/bin/env bash

# Create and enter the task directory
mkdir -p 0-queue
cd 0-queue

# Create the .csproj configured to eliminate the warning and route the XML file perfectly
cat << 'EOF' > 0-queue.csproj
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net7.0</TargetFramework>
    <ImplicitUsings>disable</ImplicitUsings>
    <Nullable>disable</Nullable>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
    <DocumentationFile>bin\Debug\netcoreapp2.1\0-queue.xml</DocumentationFile>
  </PropertyGroup>

</Project>
EOF

# Create queue.cs with clean XML documentation
cat << 'EOF' > queue.cs
using System;

/// <summary>
/// Represents a custom first-in, first-out generic collection.
/// </summary>
/// <typeparam name="T">The type of elements in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Gets the type of the generic Queue.
    /// </summary>
    /// <returns>The Type of the generic parameter.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}
EOF

echo "Project files generated successfully."
