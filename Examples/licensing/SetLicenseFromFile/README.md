# Set License from File

The following code demonstrates setting a license from a file. `License.Set` accepts both a metered license file and a standard license file, and detects which one it was given.

## Code Example

```vb
Imports GroupDocs.Merger.LowCode

Module Program
    Sub Main()
        ' The path to the license file. The path can be relative or absolute.
        Dim licensePath As String = "GroupDocs.Merger.LowCode.lic"

        ' Apply the license
        License.Set(licensePath)
    End Sub
End Module
```

## How to Run

1. Install the .NET SDK for `net10.0`.
2. Edit `Program.vb` so that it uses your license: the path to your license file, or your public and private keys.
3. Open this directory and run the example:
   ```bash
   dotnet run
   ```

## Learn More

- [Licensing](https://docs.groupdocs.net/merger/licensing/) in the GroupDocs.Merger.LowCode documentation
- [GroupDocs.Merger.LowCode](https://www.nuget.org/packages/GroupDocs.Merger.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
