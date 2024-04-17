
Imports System.IO.Ports


Public Class MainForm

    Dim WithEvents VoltKraftPort As New SerialPort
    Dim receivedData As String
    Dim voltage As String
    Dim ampere As String
    Dim watt As String
    Dim v As Decimal
    Dim a As Decimal
    Dim w As Decimal
    Dim PowerOn As Boolean




    Private Sub MainForm(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Set COM port settings
            With VoltKraftPort
                .PortName = "COM4"
                .BaudRate = 115200
                .Parity = Parity.None
                .StopBits = StopBits.One
                .DataBits = 8
                .Handshake = Handshake.None
                .Encoding = System.Text.Encoding.Default
            End With
            ' Open the serial port
            VoltKraftPort.Open()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ReadVoltKraftTimer.Stop()

        VoltKraftPort.Write("*IDN?")
        VoltKraftPort.Write(Chr(13))
        receivedData = VoltKraftPort.ReadLine()
        PowerTypeModel.Text = receivedData

        VoltKraftPort.Write("OUTPUT?")
        VoltKraftPort.Write(Chr(13))
        receivedData = VoltKraftPort.ReadLine()
        If (receivedData.Contains("1")) Then
            PowerSwitch.Text = "ON"
            PowerSwitch.BackColor = Color.Green
            PowerOn = True
        End If
        If (receivedData.Contains("0")) Then
            PowerSwitch.Text = "OFF"
            PowerSwitch.BackColor = Color.Red
            PowerOn = False
        End If

        ReadVoltKraftTimer.Start()

    End Sub

    Private Sub SendCommand_Click(sender As Object, e As EventArgs) Handles SendCommand.Click
        Try
            Dim message As String = CommandSend.Text
            ' Send the message through the serial port
            VoltKraftPort.Write(message)
            VoltKraftPort.Write(Chr(13))
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Close the serial port when the form is closing
        If VoltKraftPort.IsOpen Then
            VoltKraftPort.Close()
        End If
    End Sub

    Private Sub ReadVoltKraftTimer_Tick(sender As Object, e As EventArgs) Handles ReadVoltKraftTimer.Tick
        Dim position As Integer
        Dim previous As Integer
        VoltKraftPort.Write("MEASURE:ALL?")
        VoltKraftPort.Write(Chr(13))
        receivedData = VoltKraftPort.ReadLine()
        If (receivedData.Length() > 10) Then
            position = receivedData.IndexOf(",")
            voltage = receivedData.Substring(0, position)
            previous = position
            position = receivedData.IndexOf(",", previous + 1)
            ampere = receivedData.Substring(previous + 1, position - previous - 1)
            watt = receivedData.Substring(position + 1)
            v = CDec(voltage) / 1000
            a = CDec(ampere) / 1000
            w = CDec(watt) / 1000
            ReturnedVoltage.Text = v.ToString("F4") + " V"
            ReturnedAmpere.Text = a.ToString("F4") + " A"
            ReturnedWatt.Text = w.ToString("F4") + " W"
        End If


    End Sub

    Private Sub PowerSwitch_Click(sender As Object, e As EventArgs) Handles PowerSwitch.Click
        ReadVoltKraftTimer.Stop()
        If (PowerOn = True) Then
            PowerOn = False
            VoltKraftPort.Write("OUTP 0")
            VoltKraftPort.Write(Chr(13))
            PowerSwitch.Text = "OFF"
            PowerSwitch.BackColor = Color.Red
            PowerSwitch.Refresh()
            ReadVoltKraftTimer.Start()
            Return
        End If
        If (PowerOn = False) Then
            PowerOn = True
            VoltKraftPort.Write("OUTP 1")
            VoltKraftPort.Write(Chr(13))
            PowerSwitch.Text = "ON"
            PowerSwitch.BackColor = Color.Green
            PowerSwitch.Refresh()
            ReadVoltKraftTimer.Start()
            Return
        End If

    End Sub
End Class


