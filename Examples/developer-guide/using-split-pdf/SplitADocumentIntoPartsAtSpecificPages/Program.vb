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

        ' Start a new part at pages 7 and 13
        Dim splitter As New SplitPdf("business-plan.pdf", {7, 13}, SplitMode.Interval)

        ' Save one document per part
        splitter.Save("output/chapter.pdf")
    End Sub
End Module
