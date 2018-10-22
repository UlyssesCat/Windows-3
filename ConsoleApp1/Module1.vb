Module Module1

    Sub Main()
        Dim o = CreateObject("MyLib.MyClass")
        o.Initialize
        Console.WriteLine("1 + 2 = " & o.Add(1, 2))
        o.Dispose
        o = Nothing
    End Sub

End Module
