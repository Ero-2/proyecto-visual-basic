Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO

Partial Public Class Form2
    Inherits Form


    Private videoDevices As FilterInfoCollection
    Private videoDevice As VideoCaptureDevice
    Private foto As fotito = New fotito()
    Private instanciaFotito As fotito

    Public ReadOnly Property DataGridViewClientes As DataGridView
        Get
            Return dataGridView1
        End Get
    End Property

    Private form1 As Form1

    Public Sub New(ByVal form1 As Form1)
        InitializeComponent()
        Me.form1 = form1
    End Sub

    Public Sub New()
        InitializeComponent()
        videoDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)

        If videoDevices.Count > 0 Then
            videoDevice = New VideoCaptureDevice(videoDevices(0).MonikerString)
            AddHandler videoDevice.NewFrame, AddressOf VideoDevice_NewFrame
            videoDevice.Start()
        End If
    End Sub

    Private Sub VideoDevice_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        Dim bitmap As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        If bitmap IsNot Nothing Then
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            pictureBox1.Image = bitmap
            foto.Image = bitmap
        End If
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If videoDevice IsNot Nothing AndAlso videoDevice.IsRunning Then
            videoDevice.SignalToStop()
            videoDevice.WaitForStop()
            RemoveHandler videoDevice.NewFrame, AddressOf VideoDevice_NewFrame
            videoDevice = Nothing
        End If

        For Each row As DataGridViewRow In dataGridView1.Rows
            If Not row.IsNewRow Then
                Dim nombre As String = row.Cells("NombreData").Value?.ToString()
                Dim edad As String = row.Cells("EdadData").Value?.ToString()
                Dim telefono As String = row.Cells("TelefonoData").Value?.ToString()
                Dim saldo As String = row.Cells("SaldoData").Value?.ToString()
                Dim fotoPath As String = row.Cells("FotoData").Value?.ToString()
                Dim codigo As String = row.Cells("CodigoData").Value?.ToString()

                Dim infoCliente As String = "Nombre: " & nombre & Environment.NewLine &
                                             "Edad: " & edad & Environment.NewLine &
                                             "Teléfono: " & telefono & Environment.NewLine &
                                             "Saldo: " & saldo & Environment.NewLine &
                                             "FotoPath: " & fotoPath & Environment.NewLine &
                                             "Código: " & codigo & Environment.NewLine

                Dim rutaArchivo As String = "C:\Users\erick garcia\Desktop\datosdelagente.txt"
                File.AppendAllText(rutaArchivo, infoCliente)
            End If
        Next

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        foto.SaveImage()
    End Sub

    Private saldo As Integer = 0
    Private membresia As Membresia

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        membresia = New MembresiaSemana()
        membresia.FechaInicio = DateTime.Now
        Dim tiempoRestante As TimeSpan = membresia.TiempoRestante()
        Dim fechaFin As DateTime = membresia.FechaFin()
        Dim mensaje As String = "Se ha cobrado 100 pesos por una semana de membresía." & Environment.NewLine &
                                 "Tiempo restante: " & tiempoRestante.Days & " días" & Environment.NewLine &
                                 "Fecha de finalización: " & fechaFin.ToString("dd/MM/yyyy")
        MessageBox.Show(mensaje)
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        membresia = New MembresiaMes()
        membresia.FechaInicio = DateTime.Now
        Dim tiempoRestante As TimeSpan = membresia.TiempoRestante()
        Dim fechaFin As DateTime = membresia.FechaFin()
        Dim mensaje As String = "Se ha cobrado 300 pesos por un mes de membresía." & Environment.NewLine &
                                 "Tiempo restante: " & tiempoRestante.Days & " días" & Environment.NewLine &
                                 "Fecha de finalización: " & fechaFin.ToString("dd/MM/yyyy")
        MessageBox.Show(mensaje)
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        membresia = New MembresiaAño()
        membresia.FechaInicio = DateTime.Now
        Dim tiempoRestante As TimeSpan = membresia.TiempoRestante()
        Dim fechaFin As DateTime = membresia.FechaFin()
        Dim mensaje As String = "Se ha cobrado 3200 pesos por un año de membresía." & Environment.NewLine &
                                 "Tiempo restante: " & tiempoRestante.Days & " días" & Environment.NewLine &
                                 "Fecha de finalización: " & fechaFin.ToString("dd/MM/yyyy")
        MessageBox.Show(mensaje)
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        Dim nombre As String = Nombretextbox.Text
        Dim codigo As String = If(nombre.Length >= 3, nombre.Substring(0, 3), nombre)
        Dim edad As String = Edadtextbox.Text
        Dim telefono As String = Telefonotextbox.Text
        Dim instanciaFotito As fotito = New fotito()
        instanciaFotito.Image = foto.Image
        instanciaFotito.SaveImage()
        Dim infoCliente As String = "Nombre: " & nombre & Environment.NewLine & "edad: " & edad + Environment.NewLine & "telefono: " & telefono + Environment.NewLine & "Saldo: " + saldo
        Dim dataGridView As DataGridView = dataGridView1
        Dim rowIndex As Integer = dataGridView.Rows.Add()
        dataGridView.Rows(rowIndex).Cells("NombreData").Value = nombre
        dataGridView.Rows(rowIndex).Cells("EdadData").Value = edad
        dataGridView.Rows(rowIndex).Cells("TelefonoData").Value = telefono
        dataGridView.Rows(rowIndex).Cells("SaldoData").Value = membresia.Saldo
        dataGridView.Rows(rowIndex).Cells("FotoData").Value = instanciaFotito.FilePath
        dataGridView.Rows(rowIndex).Cells("CodigoData").Value = codigo
        MessageBox.Show("Cliente registrado correctamente.")
        Nombretextbox.Text = ""
        Edadtextbox.Text = ""
        Telefonotextbox.Text = ""
        saldo = 0

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        For Each row As DataGridViewRow In dataGridView1.Rows
            If Not row.IsNewRow Then
                Dim nombre As String = row.Cells("NombreData").Value?.ToString()
                Dim edad As String = row.Cells("EdadData").Value?.ToString()
                Dim telefono As String = row.Cells("TelefonoData").Value?.ToString()
                Dim saldo As String = row.Cells("SaldoData").Value?.ToString()
                Dim fotoPath As String = row.Cells("FotoData").Value?.ToString()
                Dim codigo As String = row.Cells("CodigoData").Value?.ToString()

                Dim infoCliente As String = "Nombre: " & nombre & Environment.NewLine &
                                             "Edad: " & edad & Environment.NewLine &
                                             "Teléfono: " & telefono & Environment.NewLine &
                                             "Saldo: " & saldo & Environment.NewLine &
                                             "FotoPath: " & fotoPath & Environment.NewLine &
                                             "Código: " & codigo & Environment.NewLine

                Dim rutaArchivo As String = "C:\Users\erick garcia\Desktop\datosdelagente.txt"
                File.AppendAllText(rutaArchivo, infoCliente)
            End If
        Next
        Me.Close()
    End Sub
End Class