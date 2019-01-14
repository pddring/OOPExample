Public MustInherit Class Animal
    Protected _name As String

    Public ReadOnly Property Name As String
        Get
            Return _name
        End Get
    End Property

    Public Sub New(Name As String)
        _name = Name
    End Sub

    MustOverride Sub makeSound()

    Public Overrides Function ToString() As String
        Return Me.GetType().ToString & ":" & Name
    End Function
End Class
