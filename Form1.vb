Imports System.Threading
Imports System.Text.RegularExpressions
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        'chkShowAffected.Checked = True
        'chkShowLineNo.Checked = True

    End Sub
    Private Sub cmdParse_Click(sender As Object, e As EventArgs) Handles cmdParse.Click

        If txtInput.Text = "" Then Exit Sub

        Try
            txtOutput.Clear()
            Dim strInput As String = txtInput.Text
            Dim strPattern As String = txtRegExPattern.Text '  "\s.*=.*\"""
            Dim strReplaceWith As String = txtReplaceWith.Text
            Dim strOutput As String = ""
            Dim strResult As String
            Dim intLineNo As Integer = 0
            Dim strLinePrefix As String

            For Each strLine As String In strInput.Split(vbLf)
                intLineNo = intLineNo + 1
                strLinePrefix = IIf(chkShowLineNo.Checked, CStr(intLineNo).PadLeft(4, "0") & ":  ", "")
                If chkShowAffected.Checked Then
                    If Regex.IsMatch(strLine, strPattern) Then
                        strResult = Regex.Replace(strLine, strPattern, strReplaceWith)
                        strOutput = strOutput & strLinePrefix & strResult & vbLf
                    End If
                Else
                    strResult = Regex.Replace(strLine, strPattern, strReplaceWith)
                    strOutput = strOutput & strLinePrefix & strResult & vbLf    'Environment.NewLine
                End If
            Next
            ShowOutput(strOutput)
        Catch ex As Exception
            ShowOutput(ex.Message)
        Finally
            'Nothing to do here.
        End Try

    End Sub
    Private Sub ShowOutput(ByVal strOutput As String)

        strOutput = strOutput & vbLf    'Environment.NewLine

        txtOutput.Text = txtOutput.Text + strOutput

    End Sub

End Class
