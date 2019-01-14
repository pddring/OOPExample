Public Class Form1

    Private Sub btnAddDog_Click(sender As Object, e As EventArgs) Handles btnAddDog.Click
        Dim dog As New Dog(InputBox("Name of dog: "))
        lstAnimals.Items.Add(dog)
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        For i = 0 To lstAnimals.Items.Count - 1
            lstAnimals.SelectedIndex = i
            Dim pet As Animal = lstAnimals.Items(i)
            pet.makeSound()
        Next
    End Sub
End Class
