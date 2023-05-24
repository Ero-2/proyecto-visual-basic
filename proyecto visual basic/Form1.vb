Imports System.IO
Partial Public Class Form1
    Inherits Form
    Private form2 As Form2

    Public Property Form2Instance As Form2
        Get
            Return form2
        End Get
        Private Set(ByVal value As Form2)
            form2 = value
        End Set
    End Property

    Private Function ObtenerForm2Instance() As Form2
        If form2 Is Nothing OrElse form2.IsDisposed Then
            form2 = New Form2()
        End If

        Return form2
    End Function

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        form2 = New Form2()
        Form2Instance = form2
        form2.ShowDialog()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim codigo As String = TEXTBOX.Text
        Dim rutaArchivo As String = "C:\Users\erick garcia\Desktop\datosdelagente.txt"
        Dim lineas As String() = File.ReadAllLines(rutaArchivo)

        For Each linea As String In lineas
            If linea.Contains("Código:") Then
                Dim codigoRegistrado As String = linea.Substring(linea.IndexOf(":") + 1).Trim()

                If codigoRegistrado = codigo Then
                    CodeVerified(Me, codigo)
                    Return
                End If
            End If
        Next

        MessageBox.Show("Código no encontrado.")
    End Sub

    Public Sub CodeVerified(ByVal sender As Object, ByVal codigo As String)
        MessageBox.Show("¡Bienvenido!")
    End Sub

End Class