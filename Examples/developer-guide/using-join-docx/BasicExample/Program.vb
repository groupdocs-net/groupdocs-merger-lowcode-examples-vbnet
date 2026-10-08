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

        ' Append the documents to the source document
        Dim merger As New JoinDocx("chapter-1.docx", {"chapter-2.docx"}, New JoinOptions())

        ' Save the merged document
        merger.Save("output/chapters-1-2.docx")
    End Sub
End Module
