<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstAnimals = New System.Windows.Forms.ListBox()
        Me.btnAddBird = New System.Windows.Forms.Button()
        Me.btnAddCat = New System.Windows.Forms.Button()
        Me.btnAddDog = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstAnimals
        '
        Me.lstAnimals.FormattingEnabled = True
        Me.lstAnimals.Location = New System.Drawing.Point(30, 206)
        Me.lstAnimals.Name = "lstAnimals"
        Me.lstAnimals.Size = New System.Drawing.Size(286, 134)
        Me.lstAnimals.TabIndex = 0
        '
        'btnAddBird
        '
        Me.btnAddBird.BackgroundImage = Global.OOPExample.My.Resources.Resources.bird
        Me.btnAddBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddBird.Location = New System.Drawing.Point(239, 27)
        Me.btnAddBird.Name = "btnAddBird"
        Me.btnAddBird.Size = New System.Drawing.Size(77, 160)
        Me.btnAddBird.TabIndex = 3
        Me.btnAddBird.Text = "Add Bird"
        Me.btnAddBird.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddBird.UseVisualStyleBackColor = True
        '
        'btnAddCat
        '
        Me.btnAddCat.BackgroundImage = Global.OOPExample.My.Resources.Resources.cat
        Me.btnAddCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddCat.Location = New System.Drawing.Point(124, 27)
        Me.btnAddCat.Name = "btnAddCat"
        Me.btnAddCat.Size = New System.Drawing.Size(93, 160)
        Me.btnAddCat.TabIndex = 2
        Me.btnAddCat.Text = "Add Cat"
        Me.btnAddCat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddCat.UseVisualStyleBackColor = True
        '
        'btnAddDog
        '
        Me.btnAddDog.BackgroundImage = Global.OOPExample.My.Resources.Resources.dog1
        Me.btnAddDog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddDog.Location = New System.Drawing.Point(30, 27)
        Me.btnAddDog.Name = "btnAddDog"
        Me.btnAddDog.Size = New System.Drawing.Size(75, 160)
        Me.btnAddDog.TabIndex = 1
        Me.btnAddDog.Text = "Add Dog"
        Me.btnAddDog.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddDog.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(102, 346)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(102, 43)
        Me.btnPlay.TabIndex = 4
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 399)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btnAddBird)
        Me.Controls.Add(Me.btnAddCat)
        Me.Controls.Add(Me.btnAddDog)
        Me.Controls.Add(Me.lstAnimals)
        Me.Name = "Form1"
        Me.Text = "Object Oriented Programming Example"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstAnimals As ListBox
    Friend WithEvents btnAddDog As Button
    Friend WithEvents btnAddCat As Button
    Friend WithEvents btnAddBird As Button
    Friend WithEvents btnPlay As Button
End Class
