Public Class Dog
    Inherits Animal

    Sub New(Name As String)
        MyBase.New(Name)
    End Sub

    Public Overrides Sub makeSound()
        MsgBox("Woof! I'm " + Name)
    End Sub
End Class
