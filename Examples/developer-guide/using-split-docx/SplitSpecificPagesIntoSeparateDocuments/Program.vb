Imports System
Imports GroupDocs.Merger.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply the license
        License.Set(publicKey, privateKey)

        ' Select pages 1, 2, and 3
        Dim splitter As New SplitDocx("business-plan.docx", {1, 2, 3})

        ' Save one document per part
        splitter.Save("output/page.docx")
    End Sub
End Module
