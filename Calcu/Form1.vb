
Public Class Form1

    '\\\\\\ WINDOW TOOL BAR \\\\\\\\\\\\\
    'tool window close
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Application.ExitThread()
    End Sub

    'tool window minimized
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point
    Private Sub panel1_mouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Cursor = Cursors.Default
            MoveForm_MousePosition = e.Location
        End If
    End Sub
    Private Sub panel1_mouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Cursor = Cursors.Default
        End If
    End Sub
    Private Sub panel1_mouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If MoveForm Then
            Location = Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    '\\\\\\ END OF WINDOW TOOL BAR \\\\\\\\\\\\\

    'empty display
    Private Sub empty_Click(sender As Object, e As EventArgs) Handles clearAll.Click
        display.Text = 0
        subDisplay.Text = ""
    End Sub

    'delete lastinput
    Private Sub clr_Click(sender As Object, e As EventArgs) Handles clear.Click
        If display.Text.Length > 0 Then
            If display.Text.Length = 1 Then
                display.Text = 0
            Else
                display.Text = display.Text.Substring(0, display.Text.Length - 1)
            End If
        End If
    End Sub
    Private Sub emptyHistory_Click(sender As Object, e As EventArgs) Handles emptyHistory.Click
        historyDisplay.Text = ""
    End Sub

    Private fVal, lVal As Double
    Private opr As Char
    'input number
    Private Sub inputNumber(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click, Button0.Click
        If display.Text = 0 Then
            display.Text = sender.Text
        Else
            display.Text += sender.Text
        End If
    End Sub

    'period
    Private Sub period_Click(sender As Object, e As EventArgs) Handles period.Click
        If display.Text.Contains(".") = False Then
            display.Text += "."
        End If
    End Sub

    'add remove positive negative
    Private Sub postiveNegative_Click(sender As Object, e As EventArgs) Handles postiveNegative.Click
        If display.Text.Contains("-") = False Then
            display.Text = "-" + display.Text
        Else
            display.Text = display.Text.Substring(1, display.Text.Length - 1)
        End If
    End Sub

    'add operatoor
    Private Sub operator_click(sender As Object, e As EventArgs) Handles plus.Click, multiply.Click, minus.Click, divide.Click
        opr = sender.Text
        fVal = display.Text
        display.Text = "0"
        subDisplay.Text = Convert.ToString(fVal) + opr
    End Sub


    'total
    Private Sub equals_Click(sender As Object, e As EventArgs) Handles equalBtn.Click
        lVal = display.Text
        If opr = "+" Then
            display.Text = Val(fVal) + Val(lVal)
        ElseIf opr = "-" Then
            display.Text = Val(fVal) - Val(lVal)
        ElseIf opr = "x" Then
            display.Text = Val(fVal) * Val(lVal)
        ElseIf opr = "/" Then
            display.Text = Val(fVal) / Val(lVal)
        End If

        subDisplay.Text = subDisplay.Text + Convert.ToString(lVal)

        'append to history

        If Not historyDisplay.Lines.Length = 0 Then
            historyDisplay.AppendText(Environment.NewLine)
        End If
        historyDisplay.AppendText(subDisplay.Text + "=" + display.Text)


    End Sub

End Class
