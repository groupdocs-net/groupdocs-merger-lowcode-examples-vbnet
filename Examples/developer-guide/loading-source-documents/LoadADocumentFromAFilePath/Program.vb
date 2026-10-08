Imports System
Imports GroupDocs.Merger.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply the license
        License.Set(publicKey, privateKey)

        ' Load the source document from a file path
        Dim splitter As New SplitPdf("business-plan.pdf", {1, 2})

        ' Save one document per page
        splitter.Save("output/page.pdf")
    End Sub
End Module
