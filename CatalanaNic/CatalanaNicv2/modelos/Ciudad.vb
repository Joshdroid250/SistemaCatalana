Public Class Ciudad
    Private _idCiudad As Integer
    Private _nombreC As String
    Private _estadoC As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal idC As Integer, ByVal nombreCiu As String, ByVal estadoCiu As Integer)
        Me.IdCiudad = idC
        Me.NombreC = nombreCiu
        Me.EstadoC = estadoCiu

    End Sub

    Public Property IdCiudad As Integer
        Get
            Return _idCiudad
        End Get
        Set(value As Integer)
            _idCiudad = value
        End Set
    End Property

    Public Property NombreC As String
        Get
            Return _nombreC
        End Get
        Set(value As String)
            _nombreC = value
        End Set
    End Property

    Public Property EstadoC As Integer
        Get
            Return _estadoC
        End Get
        Set(value As Integer)
            _estadoC = value
        End Set
    End Property
End Class
