Public Class Detfact
    Private _IDDetFact As Integer
    Private _IDproducto As Integer
    Private _IDFactura As Integer
    Private _cantidad As Integer
    Private _Precio As Integer
    Private _Descuento As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal idDestFact As Integer, ByVal IdProducto As Integer, ByVal idFactura As Integer,
                   ByVal cantidad As String, ByVal precio As Integer, ByVal descuento As Integer)
        Me.IDDetFact = idDestFact
        Me.IDproducto = IdProducto
        Me.IDFactura = idFactura
        Me.Cantidad = cantidad
        Me.Precio = precio
        Me.Descuento = descuento


    End Sub

    Public Property IDDetFact As Integer
        Get
            Return _IDDetFact
        End Get
        Set(value As Integer)
            _IDDetFact = value
        End Set
    End Property

    Public Property IDproducto As Integer
        Get
            Return _IDproducto
        End Get
        Set(value As Integer)
            _IDproducto = value
        End Set
    End Property

    Public Property IDFactura As Integer
        Get
            Return _IDFactura
        End Get
        Set(value As Integer)
            _IDFactura = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
        End Set
    End Property

    Public Property Precio As Integer
        Get
            Return _Precio
        End Get
        Set(value As Integer)
            _Precio = value
        End Set
    End Property

    Public Property Descuento As Integer
        Get
            Return _Descuento
        End Get
        Set(value As Integer)
            _Descuento = value
        End Set
    End Property
End Class
