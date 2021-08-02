Option Strict Off
Option Explicit On

Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports NAudio.Wave

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        PopulateInputDevicesCombo()
        PopulateCodecsCombo(NAudioLibrary.Common.codecs)
        comboBoxProtocol.Items.Add("UDP")
        comboBoxProtocol.Items.Add("TCP")
        comboBoxProtocol.SelectedIndex = 0
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        NAudioLibrary.Common.ClientDisconnect()
    End Sub

    Private Sub PopulateInputDevicesCombo()
        For n As Integer = 0 To WaveIn.DeviceCount - 1
            Dim capabilities As WaveInCapabilities = WaveIn.GetCapabilities(n)
            comboBoxInputDevices.Items.Add(capabilities.ProductName)
        Next
        If comboBoxInputDevices.Items.Count > 0 Then
            comboBoxInputDevices.SelectedIndex = 0
        End If
    End Sub

    Private Sub PopulateCodecsCombo(ByVal codecs As IEnumerable(Of NAudioLibrary.INetworkChatCodec))
        Dim sorted = From codec In codecs Where codec.IsAvailable Order By codec.BitsPerSecond Select codec

        For Each codec In sorted
            Dim bitRate = If(codec.BitsPerSecond = -1, "VBR", $"{codec.BitsPerSecond / 1000.0}kbps")
            Dim text = $"{codec.Name} ({bitRate})"
            comboBoxCodecs.Items.Add(New CodecComboItem With {.Text = text, .Codec = codec})
        Next

        comboBoxCodecs.SelectedIndex = 0
    End Sub

    Class CodecComboItem
        Public Property Text As String
        Public Property Codec As NAudioLibrary.INetworkChatCodec

        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

    Private Sub buttonStartConnect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonStartConnect.Click
        If Not NAudioLibrary.Common.connected Then
            Dim inputDeviceNumber As Integer = comboBoxInputDevices.SelectedIndex
            NAudioLibrary.Common.StartClient(comboBoxProtocol.SelectedIndex, textBoxIPAddressS.Text, Integer.Parse(textBoxPortS.Text), inputDeviceNumber, (CType(comboBoxCodecs.SelectedItem, CodecComboItem)).Codec)

            If NAudioLibrary.Common.connected Then
                buttonStartConnect.Text = "Disconnect"
                buttonStartStreamingLong.Enabled = True
            End If
        Else
            NAudioLibrary.Common.ClientDisconnect()

            If Not NAudioLibrary.Common.connected Then
                buttonStartConnect.Text = "Connect"
                buttonStartStreamingLong.Enabled = False
            End If
        End If
    End Sub

    Private Sub buttonStartStreamingLong_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonStartStreamingLong.Click
        If buttonStartStreamingLong.Text = "Turn Mic On" Then
            NAudioLibrary.Common.UnMuteAudio()
            buttonStartStreamingLong.Text = "Turn Mic Off"
        Else
            NAudioLibrary.Common.MuteAudio()
            buttonStartStreamingLong.Text = "Turn Mic On"
        End If
    End Sub

    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
        lblSentData.Text = NAudioLibrary.Common.getAudioSent().ToString()
        lblReceivedData.Text = NAudioLibrary.Common.getAudioReceived().ToString()
    End Sub
End Class