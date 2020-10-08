Public Class Form1
    Dim esMou As Boolean = False
    Dim peces() As PictureBox
    Dim premuda As Int32
    Dim victories1 As Int32 = 0
    Dim victories2 As Int32 = 0

    Private Sub Boto_NovaP_Click(sender As Object, e As EventArgs) Handles Boto_NovaP.Click
        Application.Restart()
        Me.Refresh()
    End Sub
    Private Sub Boto_SegJoc_Click(sender As Object, e As EventArgs) Handles Boto_SegJoc.Click
        Form1_Load()
    End Sub
    Private Sub Boto_Sortir_Click(sender As Object, e As EventArgs) Handles Boto_Sortir.Click
        Me.Close()
    End Sub
    Private Sub Boto_Resultats_Click(sender As Object, e As EventArgs) Handles Boto_Resultats.Click
        Dim response As MsgBoxResult
        response = MsgBox("Jugador 1: " + victories1.ToString + vbNewLine + "Jugador 2: " + victories2.ToString, MsgBoxStyle.OkOnly, "Resultats")
    End Sub

    Private Sub Form1_Load() Handles MyBase.Load
        esMou = False
        'Peons Negres
        PeoNegre1.Parent = CuadreClar8
        PeoNegre1.Dock = DockStyle.Fill
        PeoNegre2.Parent = CuadreObscur8
        PeoNegre2.Dock = DockStyle.Fill
        PeoNegre3.Parent = CuadreClar7
        PeoNegre3.Dock = DockStyle.Fill
        PeoNegre4.Parent = CuadreObscur7
        PeoNegre4.Dock = DockStyle.Fill
        PeoNegre5.Parent = CuadreClar6
        PeoNegre5.Dock = DockStyle.Fill
        PeoNegre6.Parent = CuadreObscur6
        PeoNegre6.Dock = DockStyle.Fill
        PeoNegre7.Parent = CuadreClar5
        PeoNegre7.Dock = DockStyle.Fill
        PeoNegre8.Parent = CuadreObscur5
        PeoNegre8.Dock = DockStyle.Fill
        'Peons Blancs
        PeoBlanc1.Parent = CuadreObscur28
        PeoBlanc1.Dock = DockStyle.Fill
        PeoBlanc2.Parent = CuadreClar28
        PeoBlanc2.Dock = DockStyle.Fill
        PeoBlanc3.Parent = CuadreObscur27
        PeoBlanc3.Dock = DockStyle.Fill
        PeoBlanc4.Parent = CuadreClar27
        PeoBlanc4.Dock = DockStyle.Fill
        PeoBlanc5.Parent = CuadreObscur26
        PeoBlanc5.Dock = DockStyle.Fill
        PeoBlanc6.Parent = CuadreClar26
        PeoBlanc6.Dock = DockStyle.Fill
        PeoBlanc7.Parent = CuadreObscur25
        PeoBlanc7.Dock = DockStyle.Fill
        PeoBlanc8.Parent = CuadreClar25
        PeoBlanc8.Dock = DockStyle.Fill
        'Torres
        TorreBlanc1.Parent = CuadreClar32
        TorreBlanc1.Dock = DockStyle.Fill
        TorreBlanc2.Parent = CuadreObscur29
        TorreBlanc2.Dock = DockStyle.Fill
        TorreNegre1.Parent = CuadreObscur4
        TorreNegre1.Dock = DockStyle.Fill
        TorreNegre2.Parent = CuadreClar1
        TorreNegre2.Dock = DockStyle.Fill
        'Cavalls
        CavallBlanc1.Parent = CuadreObscur32
        CavallBlanc1.Dock = DockStyle.Fill
        CavallBlanc2.Parent = CuadreClar29
        CavallBlanc2.Dock = DockStyle.Fill
        CavallNegre1.Parent = CuadreClar4
        CavallNegre1.Dock = DockStyle.Fill
        CavallNegre2.Parent = CuadreObscur1
        CavallNegre2.Dock = DockStyle.Fill
        'Alfil
        AlfilBlanc1.Parent = CuadreClar31
        AlfilBlanc1.Dock = DockStyle.Fill
        AlfilBlanc2.Parent = CuadreObscur30
        AlfilBlanc2.Dock = DockStyle.Fill
        AlfilNegre1.Parent = CuadreObscur3
        AlfilNegre1.Dock = DockStyle.Fill
        AlfilNegre2.Parent = CuadreClar2
        AlfilNegre2.Dock = DockStyle.Fill
        'Reina i rei
        ReinaBlanc.Parent = CuadreClar30
        ReinaBlanc.Dock = DockStyle.Fill
        ReinaNegre.Parent = CuadreObscur2
        ReinaNegre.Dock = DockStyle.Fill
        ReiBlanc.Parent = CuadreObscur31
        ReiBlanc.Dock = DockStyle.Fill
        ReiNegre.Parent = CuadreClar3
        ReiNegre.Dock = DockStyle.Fill

        peces = New PictureBox() {PeoNegre1, PeoNegre2, PeoNegre3, PeoNegre4, PeoNegre5, PeoNegre6, PeoNegre7, PeoNegre8, PeoBlanc1, PeoBlanc2, PeoBlanc3, PeoBlanc4, PeoBlanc5, PeoBlanc6, PeoBlanc7, PeoBlanc8, TorreBlanc1, TorreBlanc2, TorreNegre1, TorreNegre2, CavallBlanc1, CavallBlanc2, CavallNegre1, CavallNegre2, AlfilBlanc1, AlfilBlanc2, AlfilNegre1, AlfilNegre2, ReinaBlanc, ReinaNegre, ReiBlanc, ReiNegre}

        Captures1.Text = 0
        Captures2.Text = 0
    End Sub

    Private Sub ClickPeça_MouseClick(sender As Object, e As MouseEventArgs) Handles PeoNegre1.MouseClick, PeoNegre2.MouseClick, PeoNegre3.MouseClick, PeoNegre4.MouseClick, PeoNegre5.MouseClick, PeoNegre6.MouseClick, PeoNegre7.MouseClick, PeoNegre8.MouseClick, PeoBlanc1.MouseClick, PeoBlanc2.MouseClick, PeoBlanc3.MouseClick, PeoBlanc4.MouseClick, PeoBlanc5.MouseClick, PeoBlanc6.MouseClick, PeoBlanc7.MouseClick, PeoBlanc8.MouseClick, TorreBlanc1.MouseClick, TorreBlanc2.MouseClick, TorreNegre1.MouseClick, TorreNegre2.MouseClick, CavallBlanc1.MouseClick, CavallBlanc2.MouseClick, CavallNegre1.MouseClick, CavallNegre2.MouseClick, AlfilBlanc1.MouseClick, AlfilBlanc2.MouseClick, AlfilNegre1.MouseClick, AlfilNegre2.MouseClick, ReinaBlanc.MouseClick, ReinaNegre.MouseClick, ReiBlanc.MouseClick, ReiNegre.MouseClick
        If esMou = False Then
            premuda = Array.IndexOf(peces, sender)
            sender.BackColor = Color.AliceBlue
            esMou = True
        Else
            peces(premuda).BackColor = Color.Transparent
            esMou = False
        End If
    End Sub

    Private Sub MovimentCuadres_Click(sender As Object, e As EventArgs) Handles CuadreClar1.Click, CuadreClar2.Click, CuadreClar3.Click, CuadreClar4.Click, CuadreClar5.Click, CuadreClar6.Click, CuadreClar7.Click, CuadreClar8.Click, CuadreClar9.Click, CuadreClar10.Click, CuadreClar11.Click, CuadreClar12.Click, CuadreClar13.Click, CuadreClar14.Click, CuadreClar15.Click, CuadreClar16.Click, CuadreClar17.Click, CuadreClar18.Click, CuadreClar19.Click, CuadreClar20.Click, CuadreClar21.Click, CuadreClar22.Click, CuadreClar23.Click, CuadreClar24.Click, CuadreClar25.Click, CuadreClar26.Click, CuadreClar27.Click, CuadreClar28.Click, CuadreClar29.Click, CuadreClar30.Click, CuadreClar31.Click, CuadreClar32.Click, CuadreObscur1.Click, CuadreObscur2.Click, CuadreObscur3.Click, CuadreObscur4.Click, CuadreObscur5.Click, CuadreObscur6.Click, CuadreObscur7.Click, CuadreObscur8.Click, CuadreObscur9.Click, CuadreObscur10.Click, CuadreObscur11.Click, CuadreObscur12.Click, CuadreObscur13.Click, CuadreObscur14.Click, CuadreObscur15.Click, CuadreObscur16.Click, CuadreObscur17.Click, CuadreObscur18.Click, CuadreObscur19.Click, CuadreObscur20.Click, CuadreObscur21.Click, CuadreObscur22.Click, CuadreObscur23.Click, CuadreObscur24.Click, CuadreObscur25.Click, CuadreObscur26.Click, CuadreObscur27.Click, CuadreObscur28.Click, CuadreObscur29.Click, CuadreObscur30.Click, CuadreObscur31.Click, CuadreObscur32.Click
        If esMou = True Then
            peces(premuda).Parent = sender
            peces(premuda).BackColor = Color.Transparent
            esMou = False
        End If
    End Sub
    Private Sub AtraparPeces_Click(sender As Object, e As EventArgs) Handles PeoNegre1.Click, PeoNegre2.Click, PeoNegre3.Click, PeoNegre4.Click, PeoNegre5.Click, PeoNegre6.Click, PeoNegre7.Click, PeoNegre8.Click, PeoBlanc1.Click, PeoBlanc2.Click, PeoBlanc3.Click, PeoBlanc4.Click, PeoBlanc5.Click, PeoBlanc6.Click, PeoBlanc7.Click, PeoBlanc8.Click, TorreBlanc1.Click, TorreBlanc2.Click, TorreNegre1.Click, TorreNegre2.Click, CavallBlanc1.Click, CavallBlanc2.Click, CavallNegre1.Click, CavallNegre2.Click, AlfilBlanc1.Click, AlfilBlanc2.Click, AlfilNegre1.Click, AlfilNegre2.Click, ReinaBlanc.Click, ReinaNegre.Click, ReiBlanc.Click, ReiNegre.Click
        If esMou = True Then
            If peces(premuda).Tag = "blanc" And sender.Tag = "negre" Then
                peces(premuda).Parent = sender.Parent
                sender.Dock = DockStyle.None
                sender.Left = 1129
                sender.Top = 1618
                Captures1.Text = Captures1.Text + 1
                If sender.Equals(ReiNegre) Then
                    victories1 += 1
                End If
            ElseIf peces(premuda).Tag = "negre" And sender.Tag = "blanc" Then
                peces(premuda).Parent = sender.Parent
                sender.Dock = DockStyle.None
                sender.Left = 1129
                sender.Top = 1618
                Captures2.Text = Captures2.Text + 1
                If sender.Equals(ReiBlanc) Then
                    victories2 += 1
                End If
            End If
        End If
    End Sub
End Class
