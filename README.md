[![](https://img.shields.io/nuget/v/Soenneker.Utils.Method.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Utils.Method/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.method/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.method/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Utils.Method.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Utils.Method/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.method/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.utils.method/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.Method
Returns the calling member's name through C#'s `CallerMemberName` compiler feature.

## Installation

```bash
dotnet add package Soenneker.Utils.Method
```

## Quick start

```csharp
using Soenneker.Utils.Method;
```

Call the static `MethodUtil` methods directly; no dependency-injection registration is required.

## Usage

```csharp
public void ProcessOrder()
{
    string memberName = MethodUtil.Get();
    // "ProcessOrder"
}

public string DiagnosticName => MethodUtil.Get();
// "DiagnosticName"
```

`Get` uses C#'s `CallerMemberName` attribute. The compiler supplies the containing member's name at
the call site, so the utility does not inspect a stack trace and the result follows ordinary
symbol renames. It can report methods, properties, and other supported member contexts.

The optional parameter is public because `CallerMemberName` requires it, but normal calls should
omit it. Passing a value explicitly returns that value instead of the caller's name:

```csharp
string name = MethodUtil.Get("custom"); // "custom"
```

This helper returns only the member name. It does not include the declaring type, namespace,
signature, source path, or line number.
