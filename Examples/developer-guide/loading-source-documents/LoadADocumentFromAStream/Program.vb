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
            ' Load the source document from the stream
            Dim splitter As New SplitPdf(stream, {1, 2})

            ' Save one document per page
            splitter.Save("output/page.pdf")
        End Using
    End Sub
End Module
