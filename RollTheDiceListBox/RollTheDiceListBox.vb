'Fallon Smith
'RCET0265
'Spring 2022
'Roll the Dice list box
'

Option Explicit On
Option Strict On

Public Class RollTheDiceListBox
    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click

        Dim numbers(12) As Integer
        Dim seperator As String = " |"
        Dim columnLength As Integer
        Dim lineSeperator As String = "-"
        Dim LineLength As Integer = columnLength * (UBound(numbers) + 1)


        For I = 1 To 1000
            numbers(GetRandomInteger()) += 1
        Next

        Dim TopRow As String

        For i = 1 To 12
            TopRow &= CStr(i) & "|".PadLeft(4)
        Next

        DisplayListBox.Items.Add(TopRow)

        'separator
        DisplayListBox.Items.Add(StrDup(77, lineSeperator))
        'display contentents of randomNumber() array
        Dim BottomRow As String

        For i = LBound(numbers) To UBound(numbers)

            BottomRow &= CStr(numbers(i)) & seperator.PadLeft(3)


        Next
        DisplayListBox.Items.Add(BottomRow)

        DisplayListBox.Items.Add(StrDup(77, lineSeperator))
    End Sub



    Function GetRandomInteger() As Integer
        Dim value As Integer
        Dim temp As Single

        Randomize()
        temp = (Rnd() * 12) + 1
        value = CInt(System.Math.Floor(CDbl(temp)))
        System.Math.Floor(CDbl(1))

        Return value

    End Function


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Closes the program
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'Clears out the listbox
        DisplayListBox.Items.Clear()
    End Sub
End Class
