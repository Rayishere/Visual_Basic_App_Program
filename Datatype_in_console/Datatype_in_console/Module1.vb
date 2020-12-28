Module Module1
    Dim s1 As Single
    Dim s2 As Double
    Sub Main()
        s1 = 1.1234567 : s2 = 1.1234567
        Console.WriteLine("Orignal Data: 1.1234567")
        Console.WriteLine("Signal: {0}", s1)
        Console.WriteLine("Double: {0}", s2)
        Console.WriteLine("============")
        s1 = 1234567890 : s2 = 1234567890
        Console.WriteLine("Orignal Data: 1234567890")
        Console.WriteLine("Signal: {0}", s1)
        Console.WriteLine("Double: {0}", s2)
        Console.WriteLine("============")
        s1 = 0.123456789 : s2 = 0.123456789
        Console.WriteLine("Orignal Data: 0.123456789")
        Console.WriteLine("Signal: {0}", s1)
        Console.WriteLine("Double: {0}", s2)
        Console.WriteLine("============")
        s1 = 0.00000000123456789 : s2 = 0.00000000123456789
        Console.WriteLine("Orignal Data: 0.00000000123456789")
        Console.WriteLine("Signal: {0}", s1)
        Console.WriteLine("Double: {0}", s2)
        Console.WriteLine("============")
        s1 = 123456789012 : s2 = 123456789012
        Console.WriteLine("Orignal Data: 123456789012")
        Console.WriteLine("Signal: {0}", s1)
        Console.WriteLine("Double: {0}", s2)
        Console.WriteLine("============")
        Dim a As String = "Hello World!"
        Console.WriteLine(a)
        Dim b As Char = "B"
        Console.WriteLine(b)

        Dim bb As Date = #2/14/2007#
        bb = #2/5/2007 11:35:22 AM#
        Console.WriteLine(bb)

        'boolean

        Dim Goo As Boolean
        Goo = 35 < 25
        Console.WriteLine(Goo)
        Console.ReadLine()
    End Sub

End Module
