Public Class Membresia
    Public Property Saldo As Integer
    Public Property FechaInicio As DateTime

    Public Overridable Function TiempoRestante() As TimeSpan
        ' Cálculo del tiempo restante basado en la fecha de inicio y el período de la membresía
        Return TimeSpan.Zero ' Implementa el cálculo real en las clases derivadas
    End Function

    Public Function FechaFin() As DateTime
        ' Lógica para calcular la fecha de finalización según la duración de la membresía
        ' Ejemplo para MembresiaSemana:
        Return FechaInicio.AddDays(7) ' La membresía de una semana dura 7 días
    End Function
End Class

Public Class MembresiaSemana
    Inherits Membresia

    Public Sub New()
        Saldo = 100
    End Sub

    Public Overrides Function TiempoRestante() As TimeSpan
        Dim fechaVencimiento As DateTime = FechaInicio.AddDays(7) ' La membresía dura una semana
        Dim TIiempoRestante As TimeSpan = fechaVencimiento - DateTime.Now
        Return tiempoRestante
    End Function
End Class

Public Class MembresiaMes
    Inherits Membresia

    Public Sub New()
        Saldo = 300
    End Sub

    Public Overrides Function TiempoRestante() As TimeSpan
        Dim fechaVencimiento As DateTime = FechaInicio.AddMonths(1) ' La membresía dura un mes
        Dim tiiiempoRestante As TimeSpan = fechaVencimiento - DateTime.Now
        Return tiempoRestante
    End Function
End Class

Public Class MembresiaAño
    Inherits Membresia

    Public Sub New()
        Saldo = 3200
    End Sub

    Public Overrides Function TiempoRestante() As TimeSpan
        Dim fechaVencimiento As DateTime = FechaInicio.AddYears(1) ' La membresía dura un año
        Dim tiiiempoRestante As TimeSpan = fechaVencimiento - DateTime.Now
        Return tiempoRestante
    End Function
End Class
