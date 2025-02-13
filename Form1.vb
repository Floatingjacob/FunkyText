Imports System.Text

Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        UpdateOutput()
    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        UpdateOutput()
    End Sub

    Private Sub cmbMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMode.SelectedIndexChanged
        UpdateOutput()
    End Sub

    Private Sub UpdateOutput()
        Dim inputText = txtInput.Text
        Dim selectedMode = cmbMode.SelectedItem?.ToString()

        If String.IsNullOrEmpty(inputText) OrElse String.IsNullOrEmpty(selectedMode) Then
            lblOutput.Text = "Please enter text and select a mode."
            Return
        End If

        Select Case selectedMode
            Case "Leet Speak"
                lblOutput.Text = ConvertLeet(inputText)
            Case "Symbolic"
                lblOutput.Text = ConvertSymbolic(inputText)
            Case "Reverse"
                lblOutput.Text = StrReverse(inputText)
            Case Else
                lblOutput.Text = inputText
        End Select
    End Sub

    Private Function ConvertLeet(input As String) As String
        Dim dict As New Dictionary(Of Char, String) From {
            {"a"c, "4"}, {"b"c, "B"}, {"c"c, "C"}, {"d"c, "D"}, {"e"c, "3"},
            {"f"c, "F"}, {"g"c, "G"}, {"h"c, "H"}, {"i"c, "1"}, {"j"c, "J"},
            {"k"c, "K"}, {"l"c, "L"}, {"m"c, "M"}, {"n"c, "N"}, {"o"c, "0"},
            {"p"c, "P"}, {"q"c, "Q"}, {"r"c, "R"}, {"s"c, "$"}, {"t"c, "7"},
            {"u"c, "U"}, {"v"c, "V"}, {"w"c, "W"}, {"x"c, "X"}, {"y"c, "Y"},
            {"z"c, "Z"}
        }

        Return TransformText(input, dict)
    End Function

    Private Function ConvertSymbolic(input As String) As String
        Dim dict As New Dictionary(Of Char, String) From {
            {"a"c, "@"}, {"b"c, "ß"}, {"c"c, "¢"}, {"d"c, "Ð"}, {"e"c, "£"},
            {"f"c, "ƒ"}, {"g"c, "Ǥ"}, {"h"c, "Ħ"}, {"i"c, "¡"}, {"j"c, "J"},
            {"k"c, "Ҝ"}, {"l"c, "Ł"}, {"m"c, "M"}, {"n"c, "Ñ"}, {"o"c, "°"},
            {"p"c, "Þ"}, {"q"c, "Q"}, {"r"c, "®"}, {"s"c, "§"}, {"t"c, "†"},
            {"u"c, "µ"}, {"v"c, "V"}, {"w"c, "₩"}, {"x"c, "×"}, {"y"c, "¥"},
            {"z"c, "Ƶ"}, {" "c, "  "}
        }

        Return TransformText(input, dict)
    End Function

    Private Function TransformText(input As String, dict As Dictionary(Of Char, String)) As String
        Dim result As New StringBuilder()
        For Each c In input
            Dim lowerChar = Char.ToLower(c)
            result.Append(If(dict.ContainsKey(lowerChar), dict(lowerChar), c))
        Next
        Return result.ToString()
    End Function

    ' Copy to clipboard
    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Clipboard.SetText(lblOutput.Text)
    End Sub
End Class
