Module Module1

    Sub Main()
        Dim Roman As String
        Console.WriteLine("Enter the roman number: ")
        Roman = Console.ReadLine()
        Roman = UCase(Roman)
        Dim currentRoman, nextRoman, add, total As Integer

        add = 0
        total = 0
        Dim array(Len(Roman) - 1) As Integer


        For index = 0 To Len(Roman) - 1

            Select Case Roman(index)
                Case "I"
                    array(index) = 1
                Case "V"
                    array(index) = 5
                Case "X"
                    array(index) = 10
                Case "L"
                    array(index) = 50
                Case "C"
                    array(index) = 100
                Case "D"
                    array(index) = 500
                Case "M"
                    array(index) = 1000
            End Select

        Next
        Dim invalid As Boolean
        invalid = False

        For index = 0 To UBound(array)
            currentRoman = array(index)
            For nextIndex = index + 1 To UBound(array)
                nextRoman = array(nextIndex)
                If (nextRoman > currentRoman) And nextIndex <> index + 1 Then
                    invalid = True
                End If
            Next
            If invalid = True Then
                Exit For
            End If
        Next

        If invalid = True Then
            Console.WriteLine("The Roman Numeral you entered is Invalid")
        Else

            currentRoman = 0
            nextRoman = 0
            For index = 0 To UBound(array)

                If index <> UBound(array) Then
                    currentRoman = array(index)
                    nextRoman = array(index + 1)

                    If currentRoman >= nextRoman Then
                        total = total + currentRoman - add
                        add = 0
                    Else
                        add = add + currentRoman
                    End If

                Else
                    currentRoman = array(index)
                    nextRoman = 0

                    If currentRoman >= nextRoman Then
                        total = total + currentRoman - add
                        add = 0
                    Else
                        add = add + currentRoman
                    End If
                End If

            Next
            Console.WriteLine(total)
        End If

    End Sub

End Module
