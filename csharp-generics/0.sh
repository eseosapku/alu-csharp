#!/usr/bin/env bash

mkdir -p 0-queue
cd 0-queue

cat << 'EOF' > 0-queue.csproj
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp2.1</TargetFramework>
    <ImplicitUsings>disable</ImplicitUsings>
    <Nullable>disable</Nullable>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
  </PropertyGroup>

</Project>
EOF

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

echo "Project configuration generated for netcoreapp2.1."