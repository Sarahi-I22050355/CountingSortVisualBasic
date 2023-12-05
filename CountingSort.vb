Public Class CountingSort
    Public Shared Function Sort(inputArray As Integer()) As Integer()
        Dim M As Integer = 0

        For Each num As Integer In inputArray
            If num > M Then
                M = num
            End If
        Next

        Dim countArray(M + 1) As Integer

        For Each num As Integer In inputArray
            countArray(num) += 1
        Next

        For i As Integer = 1 To M + 1
            countArray(i) += countArray(i - 1)
        Next

        Dim outputArray(inputArray.Length - 1) As Integer

        For i As Integer = inputArray.Length - 1 To 0 Step -1
            outputArray(countArray(inputArray(i)) - 1) = inputArray(i)
            countArray(inputArray(i)) -= 1
        Next

        Return outputArray
    End Function

    Public Shared Function SortStrings(inputArray As String()) As String()
            Dim maxLength As Integer = 0

            For Each str As String In inputArray
                If str.Length > maxLength Then
                    maxLength = str.Length
                End If
            Next

            Dim range As Integer = 256
            Dim countArray(inputArray.Length - 1)() As Integer

            For i As Integer = 0 To inputArray.Length - 1
                countArray(i) = New Integer(range - 1) {}
            Next

            For i As Integer = 0 To inputArray.Length - 1
                For Each c As Char In inputArray(i)
                    countArray(i)(AscW(c)) += 1
                Next
            Next

            For i As Integer = 0 To inputArray.Length - 1
                For j As Integer = 1 To range - 1
                    countArray(i)(j) += countArray(i)(j - 1)
                Next
            Next

            Dim outputArray(inputArray.Length - 1) As String

            For i As Integer = 0 To inputArray.Length - 1
                Dim sortedString(maxLength - 1) As Char

                For j As Integer = inputArray(i).Length - 1 To 0 Step -1
                    Dim index As Integer = countArray(i)(AscW(inputArray(i)(j))) - 1
                    sortedString(index) = inputArray(i)(j)
                    countArray(i)(AscW(inputArray(i)(j))) -= 1
                Next

                outputArray(i) = New String(sortedString)
            Next

            Return outputArray
        End Function
    End Class