Imports GroupDocs.Merger.LowCode

Module Program
    Sub Main()
        ' The path to the license file. The path can be relative or absolute.
        Dim licensePath As String = "GroupDocs.Merger.LowCode.lic"

        ' Apply the license
        License.Set(licensePath)
    End Sub
End Module
