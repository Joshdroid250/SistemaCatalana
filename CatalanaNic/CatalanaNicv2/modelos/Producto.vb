Public Class Producto
    Private _idPro As Integer
    Private _nombreP As String
    Private _precioProducto As Integer
    Private _descripPro As String
    Private _estadoP As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As Integer, ByVal nombrePro As String, ByVal precioP As Integer, ByVal descripPro As String, ByVal estadoPro As Integer)
        Me.IdPro = id
        Me.NombreP = nombrePro
        Me.PrecioProducto = precioP
        Me.DescripPro = descripPro
        Me.EstadoP = estadoPro

    End Sub

    Public Property IdPro As Integer
        Get
            Return _idPro
        End Get
        Set(value As Integer)
            _idPro = value
        End Set
    End Property

    Public Property NombreP As String
        Get
            Return _nombreP
        End Get
        Set(value As String)
            _nombreP = value
        End Set
    End Property

    Public Property PrecioProducto As Integer
        Get
            Return _precioProducto
        End Get
        Set(value As Integer)
            _precioProducto = value
        End Set
    End Property

    Public Property EstadoP As Integer
        Get
            Return _estadoP
        End Get
        Set(value As Integer)
            _estadoP = value
        End Set
    End Property

    Public Property DescripPro As String
        Get
            Return _descripPro
        End Get
        Set(value As String)
            _descripPro = value
        End Set
    End Property
End Class
