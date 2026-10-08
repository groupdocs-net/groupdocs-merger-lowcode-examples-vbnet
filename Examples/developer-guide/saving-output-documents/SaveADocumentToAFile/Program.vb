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

        ' Append the second chapter to the first one
        Dim merger As New JoinPdf("chapter-1.pdf", {"chapter-2.pdf"}, New JoinOptions())

        ' Save to a folder that doesn't exist yet
        merger.Save("output/merged/chapters-1-2.pdf")
    End Sub
End Module
