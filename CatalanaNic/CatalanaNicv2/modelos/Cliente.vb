Public Class Cliente
    Private _idCliente As Integer
    Private _numCedula As String
    Private _primerNombre As String
    Private _segundoNombre As String
    Private _primerApellido As String
    Private _segundoApellido As String
    Private _domicilio As String
    Private _correo As String
    Private _idCiudad As Integer
    Private _celTigo As Integer
    Private _celClaro As Integer
    Private _celCootel As Integer
    Private _estado As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal IDCliente As Integer, ByVal numeroCedu As String, ByVal primerName As String,
                   segundoName As String, ByVal primerApelli As String, ByVal segundoApelli As String, ByVal domici As String,
                   ByVal email As String, ByVal idCity As Integer, ByVal celuTigo As Integer, ByVal celuClaro As Integer, ByVal celuCoot As Integer, ByVal estado As Integer)
        Me.IdCliente = IDCliente
        Me.NumCedula = numeroCedu
        Me.PrimerNombre = primerName
        Me.SegundoNombre = segundoName
        Me.PrimerApellido = primerApelli
        Me.SegundoApellido = segundoApelli
        Me.Domicilio = domici
        Me.IdCiudad = idCity
        Me.Correo = email
        Me.CelTigo = celuTigo
        Me.CelClaro = celuClaro
        Me.CelCootel = celuCoot
        Me.Estado = estado
    End Sub

    Public Property IdCliente As Integer
        Get
            Return _idCliente
        End Get
        Set(value As Integer)
            _idCliente = value
        End Set
    End Property



    Public Property PrimerNombre As String
        Get
            Return _primerNombre
        End Get
        Set(value As String)
            _primerNombre = value
        End Set
    End Property

    Public Property SegundoNombre As String
        Get
            Return _segundoNombre
        End Get
        Set(value As String)
            _segundoNombre = value
        End Set
    End Property

    Public Property PrimerApellido As String
        Get
            Return _primerApellido
        End Get
        Set(value As String)
            _primerApellido = value
        End Set
    End Property

    Public Property SegundoApellido As String
        Get
            Return _segundoApellido
        End Get
        Set(value As String)
            _segundoApellido = value
        End Set
    End Property

    Public Property Domicilio As String
        Get
            Return _domicilio
        End Get
        Set(value As String)
            _domicilio = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Property IdCiudad As Integer
        Get
            Return _idCiudad
        End Get
        Set(value As Integer)
            _idCiudad = value
        End Set
    End Property

    Public Property CelTigo As Integer
        Get
            Return _celTigo
        End Get
        Set(value As Integer)
            _celTigo = value
        End Set
    End Property

    Public Property CelClaro As Integer
        Get
            Return _celClaro
        End Get
        Set(value As Integer)
            _celClaro = value
        End Set
    End Property

    Public Property CelCootel As Integer
        Get
            Return _celCootel
        End Get
        Set(value As Integer)
            _celCootel = value
        End Set
    End Property

    Public Property Estado As Integer
        Get
            Return _estado
        End Get
        Set(value As Integer)
            _estado = value
        End Set
    End Property

    Public Property NumCedula As String
        Get
            Return _numCedula
        End Get
        Set(value As String)
            _numCedula = value
        End Set
    End Property
End Class
