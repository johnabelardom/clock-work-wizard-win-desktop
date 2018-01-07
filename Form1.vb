Imports MaterialSkin

Partial Class Login

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Teal800, Primary.Teal900, Primary.Teal500, Accent.LightGreen700, TextShade.WHITE)
    End Sub

End Class
