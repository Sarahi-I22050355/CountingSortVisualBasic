Imports System

Module Program
    Sub Main(args As String())
        Dim rnd As New Random()
        Dim inputArray(9) As Integer

        For i As Integer = 0 To inputArray.Length - 1
            inputArray(i) = rnd.Next(101)
        Next

        Console.WriteLine("Array generado aleatoriamente:")
        For Each num As Integer In inputArray
            Console.Write(num & " ")
        Next
        Console.WriteLine()

        Dim stopwatch As New Stopwatch()
        stopwatch.Start()

        Dim outputArray As Integer() = CountingSort.Sort(inputArray)

        stopwatch.Stop()

        Console.WriteLine(vbLf & "Array ordenado:")
        For Each num As Integer In outputArray
            Console.Write(num & " ")
        Next

        Console.WriteLine($"\n\nTiempo transcurrido en ordenar: {stopwatch.Elapsed}")

        Console.WriteLine("\nIngrese una cadena para ordenarla por caracteres ASCII:")
        Dim userString As String = Console.ReadLine()

        Dim userArray() As String = {userString}
        Dim sortedUserArray() As String = CountingSort.SortStrings(userArray)

        Console.WriteLine("\nCadena ordenada:")
        Console.WriteLine(sortedUserArray(0))
    End Sub
End Module
