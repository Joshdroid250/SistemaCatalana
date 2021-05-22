Public Class Factura
    Private _idFactura As Integer
    Private _idUsuario As Integer
    Private _idCliente As Integer
    Private _fecha As DateTime



    Public Sub New()

    End Sub

    Public Sub New(ByVal IdFact As Integer, ByVal IdUser As Integer, ByVal IdCliente As Integer, ByVal fechaF As DateTime)
        Me.IdFactura = IdFact
        Me.IdUsuario = IdUser
        Me.IdCliente = IdCliente
        Me.Fecha = fechaF
    End Sub

    Public Property IdFactura As Integer
        Get
            Return _idFactura
        End Get
        Set(value As Integer)
            _idFactura = value
        End Set
    End Property

    Public Property IdUsuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(value As Integer)
            _idUsuario = value
        End Set
    End Property

    Public Property IdCliente As Integer
        Get
            Return _idCliente
        End Get
        Set(value As Integer)
            _idCliente = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
End Class
