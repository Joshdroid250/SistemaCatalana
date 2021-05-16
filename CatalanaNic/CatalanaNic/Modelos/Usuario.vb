Public Class Usuario
    Private _idUsuario As Integer
    Private _primerNombre As String
    Private _primerApellido As String
    Private _SegundoApellido As String
    Private _userName As String
    Private _userPwd As String
    Private _email As String
    Private _estado As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal idUser As Integer, ByVal primeName As String, ByVal primerApellido As String, ByVal segundoName As String, ByVal userName As String,
                   ByVal userContra As String, ByVal email As String, ByVal estado As Integer
      )
        Me.IdUsuario = idUser
        Me.PrimerNombre = primeName
        Me.PrimerApellido = primerApellido
        Me.SegundoApellido = segundoName
        Me.UserName = userName
        Me.UserPwd = userContra
        Me.Email = email
        Me.Estado = estado
    End Sub

    Public Property IdUsuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(value As Integer)
            _idUsuario = value
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

    Public Property SegundoApellido As String
        Get
            Return _SegundoApellido
        End Get
        Set(value As String)
            _SegundoApellido = value
        End Set
    End Property

    Public Property UserName As String
        Get
            Return _userName
        End Get
        Set(value As String)
            _userName = value
        End Set
    End Property

    Public Property UserPwd As String
        Get
            Return _userPwd
        End Get
        Set(value As String)
            _userPwd = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
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

    Public Property PrimerApellido As String
        Get
            Return _primerApellido
        End Get
        Set(value As String)
            _primerApellido = value
        End Set
    End Property
End Class
