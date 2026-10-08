Imports System
Imports System.IO
Imports GroupDocs.Merger.Domain.Options
Imports GroupDocs.Merger.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply the license
        License.Set(publicKey, privateKey)

        ' Open the source document as a stream
        Using stream = File.OpenRead("chapter-1.pdf")
            ' The documents to append are file paths
            Dim merger As New JoinPdf(stream, {"chapter-2.pdf", "chapter-3.pdf"}, New JoinOptions())

            ' Save the merged document
            merger.Save("output/merged-chapters.pdf")
        End Using
    End Sub
End Module
