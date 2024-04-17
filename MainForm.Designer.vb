<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        SendCommand = New Button()
        CommandSend = New TextBox()
        ReturnedVoltage = New TextBox()
        ReadVoltKraftTimer = New Timer(components)
        ReturnedAmpere = New TextBox()
        ReturnedWatt = New TextBox()
        PowerTypeModel = New TextBox()
        PowerSwitch = New Button()
        SuspendLayout()
        ' 
        ' SendCommand
        ' 
        SendCommand.Location = New Point(848, 547)
        SendCommand.Name = "SendCommand"
        SendCommand.Size = New Size(162, 86)
        SendCommand.TabIndex = 0
        SendCommand.Text = "SEND"
        SendCommand.UseVisualStyleBackColor = True
        ' 
        ' CommandSend
        ' 
        CommandSend.Location = New Point(105, 188)
        CommandSend.Name = "CommandSend"
        CommandSend.Size = New Size(358, 31)
        CommandSend.TabIndex = 1
        ' 
        ' ReturnedVoltage
        ' 
        ReturnedVoltage.BackColor = Color.Black
        ReturnedVoltage.Font = New Font("Consolas", 28.0F, FontStyle.Bold, GraphicsUnit.Point)
        ReturnedVoltage.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        ReturnedVoltage.Location = New Point(105, 295)
        ReturnedVoltage.Name = "ReturnedVoltage"
        ReturnedVoltage.ReadOnly = True
        ReturnedVoltage.Size = New Size(300, 73)
        ReturnedVoltage.TabIndex = 2
        ReturnedVoltage.TextAlign = HorizontalAlignment.Center
        ' 
        ' ReadVoltKraftTimer
        ' 
        ReadVoltKraftTimer.Enabled = True
        ReadVoltKraftTimer.Interval = 500
        ' 
        ' ReturnedAmpere
        ' 
        ReturnedAmpere.BackColor = Color.Black
        ReturnedAmpere.Font = New Font("Consolas", 28.0F, FontStyle.Bold, GraphicsUnit.Point)
        ReturnedAmpere.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        ReturnedAmpere.Location = New Point(105, 374)
        ReturnedAmpere.Name = "ReturnedAmpere"
        ReturnedAmpere.Size = New Size(300, 73)
        ReturnedAmpere.TabIndex = 3
        ReturnedAmpere.TextAlign = HorizontalAlignment.Center
        ' 
        ' ReturnedWatt
        ' 
        ReturnedWatt.BackColor = Color.Black
        ReturnedWatt.Font = New Font("Consolas", 28.0F, FontStyle.Bold, GraphicsUnit.Point)
        ReturnedWatt.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        ReturnedWatt.Location = New Point(105, 453)
        ReturnedWatt.Name = "ReturnedWatt"
        ReturnedWatt.Size = New Size(300, 73)
        ReturnedWatt.TabIndex = 4
        ReturnedWatt.TextAlign = HorizontalAlignment.Center
        ' 
        ' PowerTypeModel
        ' 
        PowerTypeModel.Font = New Font("Consolas", 16.0F, FontStyle.Bold, GraphicsUnit.Point)
        PowerTypeModel.ForeColor = Color.Red
        PowerTypeModel.Location = New Point(82, 12)
        PowerTypeModel.Name = "PowerTypeModel"
        PowerTypeModel.Size = New Size(883, 45)
        PowerTypeModel.TabIndex = 6
        PowerTypeModel.Text = "BLABLA"
        PowerTypeModel.TextAlign = HorizontalAlignment.Center
        ' 
        ' PowerSwitch
        ' 
        PowerSwitch.BackColor = Color.Red
        PowerSwitch.Font = New Font("Consolas", 24.0F, FontStyle.Bold, GraphicsUnit.Point)
        PowerSwitch.ForeColor = Color.Black
        PowerSwitch.Location = New Point(827, 198)
        PowerSwitch.Name = "PowerSwitch"
        PowerSwitch.Size = New Size(114, 94)
        PowerSwitch.TabIndex = 7
        PowerSwitch.Text = "OFF"
        PowerSwitch.UseVisualStyleBackColor = False
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1040, 667)
        Controls.Add(PowerSwitch)
        Controls.Add(PowerTypeModel)
        Controls.Add(ReturnedWatt)
        Controls.Add(ReturnedAmpere)
        Controls.Add(ReturnedVoltage)
        Controls.Add(CommandSend)
        Controls.Add(SendCommand)
        Name = "MainForm"
        Text = "VolKraft Power Controller"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SendCommand As Button
    Friend WithEvents CommandSend As TextBox
    Friend WithEvents ReturnedVoltage As TextBox
    Friend WithEvents ReadVoltKraftTimer As Timer
    Friend WithEvents ReturnedAmpere As TextBox
    Friend WithEvents ReturnedWatt As TextBox
    Friend WithEvents PowerTypeModel As TextBox
    Friend WithEvents PowerSwitch As Button

End Class
