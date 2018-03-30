Public Class Form1
    Dim salida As String
    Dim entrada As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        salida = ""
        entrada = ""
        conectar.Enabled = False
    End Sub
    Private Sub buscar_puerto_Click(sender As Object, e As EventArgs) Handles buscar_puerto.Click
        puerto.Items.Clear()
        For Each puertoDisponible As String In My.Computer.Ports.SerialPortNames
            puerto.Items.Add(puertoDisponible)
        Next
        If puerto.Items.Count > 0 Then
            puerto.Text = puerto.Items(0)
            'MessageBox.Show("Elige el Puerto")
            conectar.Enabled = True
        Else
            MessageBox.Show("No hay Puertos Disponibles")
            conectar.Enabled = False
            puerto.Items.Clear()
            puerto.Text = (" ")
        End If
    End Sub
    Private Sub conectar_Click(sender As Object, e As EventArgs) Handles conectar.Click
        If conectar.Text = "CONECTAR" Then
            serial.PortName = puerto.Text
            conectar.Text = "DESCONECTAR"
            Timer1.Enabled = True
            serial.Open()
        ElseIf conectar.Text = "DESCONECTAR" Then
            conectar.Text = "CONECTAR"
            Timer1.Enabled = False
            serial.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        entrada = serial.ReadExisting
        If entrada <> "" Then
            temperatura.Text = entrada + " °C"
            entrada = ""
            serial.DiscardInBuffer()
        End If
    End Sub

End Class
