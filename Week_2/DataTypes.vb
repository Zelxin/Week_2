Module DataTypes
    Sub Main()
        '1 byte, 0-255
        Dim b As Byte
        '4 bytes	-2,147,483,648 through 2,147,483,647 (signed)
        Dim n As Integer
        '4 bytes 	-3.4028235E+38 through -1.401298E-45 for negative values; 1.401298E-45 through 3.4028235E+38 for positive values
        Dim si As Single
        '8 bytes	-1.79769313486231570E+308 through -4.94065645841246544E-324, for negative values ; 4.94065645841246544E-324 through 1.79769313486231570E+308, for positive values
        Dim d As Double
        '8 bytes	0:00:00 (midnight) on January 1, 0001 through 11:59:59 PM on December 31, 9999
        Dim da As Date
        '2 bytes 0-65535
        Dim c As Char
        '	Depends on implementing platform - 	0 to approximately 2 billion Unicode characters
        Dim s As String
        Dim bl As Boolean
        '	16 bytes	0 through +/-79,228,162,514,264,337,593,543,950,335 (+/-7.9...E+28) with no decimal point; 0 through +/-7.9228162514264337593543950335 with 28 places to the right of the decimal
        Dim dec As Decimal
        '4 bytes on 32bit 8 on 64bit , Any type can be stored (all objects inherit from this)
        Dim obj As Object
        b = 1
        n = 1234567
        si = 0.12345678901234566
        d = 0.12345678901234566
        da = Today
        c = "U"c
        s = "Me"

        If ScriptEngine = "VB" Then
            bl = True
        Else
            bl = False
        End If

        If bl Then
            'the oath taking
            Console.Write(c & " and," & s & vbCrLf)
            Console.WriteLine("declaring on the day of: {0}", da)
            Console.WriteLine("We will learn VB.Net seriously")
            Console.WriteLine("Lets see what happens to the floating point variables:")
            Console.WriteLine("The Single: {0}, The Double: {1}", si, d)
        End If
        Console.ReadKey()

    End Sub
End Module
