Imports System

Module Program
    Sub Main(args As String())
    Dim index As Integer = 1
    Dim total As Double = 0
    Dim numTimesThousandEntered As Integer = 0
    
    Do
        Console.Write("Enter a price: ")
        Dim currentPrice As Double = Console.ReadLine()
        total += currentPrice

        If currentPrice = 1000 Then
            numTimesThousandEntered += 1
        End If

        index += 1
    Loop Until index > 6

    Console.WriteLine()
    Console.WriteLine("Average price: " & total / 6)    
    Console.WriteLine("Number of 1000's: " & numTimesThousandEntered)    
    
    End Sub
End Module
