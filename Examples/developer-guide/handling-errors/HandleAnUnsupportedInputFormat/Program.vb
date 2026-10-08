Imports System
Imports GroupDocs.Merger.Exceptions
Imports GroupDocs.Merger.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply the license
        License.Set(publicKey, privateKey)

        Try
            ' A DOCX document passed to the PDF plugin
            Dim splitter As New SplitPdf("business-plan.docx", {1})
            splitter.Save("output/page.pdf")
        Catch ex As FileTypeNotSupportedException
            ' Input format does not match the expected format 'PDF'; the supplied file is ...
            Console.WriteLine(ex.Message)
        End Try
    End Sub
End Module
