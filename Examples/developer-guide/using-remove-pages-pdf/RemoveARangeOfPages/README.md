# Remove a Range of Pages

Pass the first and the last page of a range. The following example removes the appendix: pages 15 to 18.

## Code Example

```vb
Imports System
Imports GroupDocs.Merger.Domain.Options
Imports GroupDocs.Merger.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply the license
        License.Set(publicKey, privateKey)

        ' Remove pages 15 to 18
        Dim remover As New RemovePagesPdf("business-plan.pdf", New RemoveOptions(15, 18))

        ' Save the remaining pages
        remover.Save("output/without-appendix.pdf")
    End Sub
End Module
```

## How to Run

1. Install the .NET SDK for `net10.0`.
2. Set the `GD_PUBLIC_KEY` and `GD_PRIVATE_KEY` environment variables to your license keys.
3. Open this directory and run the example:
   ```bash
   dotnet run
   ```

## Input Files

- `business-plan.pdf`

## Learn More

- [Using RemovePagesPdf to Remove Pages from PDF Documents](https://docs.groupdocs.net/merger/developer-guide/using-remove-pages-pdf/) in the GroupDocs.Merger.LowCode documentation
- [GroupDocs.Merger.LowCode](https://www.nuget.org/packages/GroupDocs.Merger.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
