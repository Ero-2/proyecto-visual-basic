Imports System.IO

Public Class fotito
    Public Property Image As Bitmap
    Public Property FilePath As String

    Public Sub SaveImage()
        If Image IsNot Nothing Then
            Dim rutaPersonalizada As String = "C:\Users\erick garcia\Desktop\datos clientes"
            Dim fileName As String = $"foto_{DateTime.Now.ToString("yyyyMMddHHmmss")}.jpg"
            Dim filePath As String = Path.Combine(rutaPersonalizada, fileName)
            Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg)
            filePath = filePath
        End If
    End Sub
End Class
