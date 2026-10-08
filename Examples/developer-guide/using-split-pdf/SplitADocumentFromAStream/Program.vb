Imports System
Imports System.IO
Imports GroupDocs.Merger.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply the license
        License.Set(publicKey, privateKey)

        ' Open the source document as a stream
        Using stream = File.OpenRead("business-plan.pdf")
            ' Select pages 1 and 2
            Dim splitter As New SplitPdf(stream, {1, 2})

            ' Save one document per part
            splitter.Save("output/page.pdf")
        End Using
    End Sub
End Module
