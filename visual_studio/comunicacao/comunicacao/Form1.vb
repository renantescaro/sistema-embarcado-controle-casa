Public Class Form1
    Dim xbox As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo saidaErro

        If SerialPort1.IsOpen = False Then
            SerialPort1.Open()
            Timer1.Enabled = True
        End If
        Exit Sub

saidaErro:
        xbox = MsgBox("Erro ao abrir comunicação", vbOKOnly+ vbCritical, "Erro no Sistema")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim recebidoSerial As String
        If SerialPort1.IsOpen Then
            SerialPort1.Write(Chr(5))
            txtMensagem.Text = ""
            If SerialPort1.BytesToRead > 0 Then
                recebidoSerial = SerialPort1.ReadExisting()
                txtMensagem.Text = recebidoSerial

                ' quarto
                If Mid(recebidoSerial, 1, 1) = "1" Then
                    imgLampQuarto.BackColor = Color.Yellow
                Else
                    imgLampQuarto.BackColor = Color.Gray
                End If

                ' banheiro
                If Mid(recebidoSerial, 2, 1) = "1" Then
                    imgLampBanheiro.BackColor = Color.Yellow
                Else
                    imgLampBanheiro.BackColor = Color.Gray
                End If

                ' sala
                If Mid(recebidoSerial, 3, 1) = "1" Then
                    imgLampSala.BackColor = Color.Yellow
                Else
                    imgLampSala.BackColor = Color.Gray
                End If

                ' cozinha
                If Mid(recebidoSerial, 4, 1) = "1" Then
                    imgLampCozinha.BackColor = Color.Yellow
                Else
                    imgLampCozinha.BackColor = Color.Gray
                End If

                ' lavanderia
                If Mid(recebidoSerial, 5, 1) = "1" Then
                    imgLampLavanderia.BackColor = Color.Yellow
                Else
                    imgLampLavanderia.BackColor = Color.Gray
                End If

                lblTemperatura.Text = Mid(recebidoSerial, 10, 2) + "º C"
            End If
        End If
    End Sub

    Private Sub imgLampQuarto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgLampQuarto.Click
        If imgLampQuarto.BackColor = Color.Yellow Then

        Else

        End If
    End Sub
End Class
