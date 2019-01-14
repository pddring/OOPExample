Public Class Form1

    Sub addDog() Handles btnAddDog.Click
        Dim dog As New Dog(InputBox("Name of dog: "))
        lstAnimals.Items.Add(dog)
    End Sub

    Private Sub btnAddDog_Click(sender As Object, e As EventArgs)

    End Sub
End Class
