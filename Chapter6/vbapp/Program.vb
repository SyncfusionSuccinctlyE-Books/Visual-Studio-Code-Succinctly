Module Program
    Sub Main(args As String())
        Dim fileContent As String
        fileContent = System.IO.File.ReadAllText("readme.txt")
        Console.WriteLine(fileContent)
    End Sub
End Module
