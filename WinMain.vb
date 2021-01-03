Public Class WinMain
    Private BMI As Single
    Private Sub WinMain_Load() Handles MyBase.Load
        Call CalcBMI()
    End Sub
    Private Sub CalcBMI()
        BMI = Math.Round(NudWgt.Value / NudStt.Value / NudStt.Value * 10000, 1)
        LblBMI.Text = BMI.ToString
        If BMI < 10 Then LblBMI.Text = "0" & LblBMI.Text
        If Not LblBMI.Text.Contains(".".ToCharArray()(0)) Then LblBMI.Text += ".0"
        LblBMI.Text += " KG/M2"
    End Sub
    Private Sub Value_Changed() Handles NudStt.ValueChanged, NudWgt.ValueChanged
        Call CalcBMI()
    End Sub
    Private Sub NudWgt_KeyDown(sender As NumericUpDown, e As KeyEventArgs) Handles NudStt.KeyDown, NudWgt.KeyDown
        If e.KeyCode <> Keys.Enter Then Exit Sub
        If sender.Tag = "1" Then
            NudWgt.Focus()
            NudWgt.Select(0, 5)
        Else
            NudStt.Focus()
            NudStt.Select(0, 3)
        End If
    End Sub
End Class
