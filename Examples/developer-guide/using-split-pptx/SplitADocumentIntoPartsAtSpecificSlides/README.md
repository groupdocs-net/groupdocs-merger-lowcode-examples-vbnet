# Split a Document into Parts at Specific Slides

In `SplitMode.Interval`, the slides you list mark where each new part starts. The following example cuts a 13-slide presentation before slide 8: `deck_0.pptx` holds slides 1 to 7 and `deck_1.pptx` holds slides 8 to 13. Interval parts are numbered from 0.

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

        ' Start a new part at slide 8
        Dim splitter As New SplitPptx("presentation.pptx", {8}, SplitMode.Interval)

        ' Save one document per part
        splitter.Save("output/deck.pptx")
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

- `presentation.pptx`

## Learn More

- [Using SplitPptx to Split PPTX Documents](https://docs.groupdocs.net/merger/developer-guide/using-split-pptx/) in the GroupDocs.Merger.LowCode documentation
- [GroupDocs.Merger.LowCode](https://www.nuget.org/packages/GroupDocs.Merger.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
