Public Class Form1
    Dim esMou As Boolean = False
    Dim peces() As PictureBox
    Dim cuadres() As PictureBox
    Dim premuda As Int32
    Dim victories1 As Int32 = 0
    Dim victories2 As Int32 = 0
    Dim torn As Int32 = 0 '0=Blanc 1=Negre
    Dim guanyat As Boolean = False
    Dim esPot As Boolean = False
    Dim posicio As Int32

    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - ex, MousePosition.Y - Me.Location.Y - ey))
    End Sub

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
        guanyat = False
        esPot = False
        torn = 0
        Label_Jug2.BackColor = Color.Transparent
        Label_Jug1.BackColor = Color.Crimson

        'Peons Negres
        PeoNegre1.Parent = Cuadre49
        PeoNegre1.Dock = DockStyle.Fill
        PeoNegre1.Parent.Tag = "O"
        PeoNegre2.Parent = Cuadre50
        PeoNegre2.Dock = DockStyle.Fill
        PeoNegre2.Parent.Tag = "O"
        PeoNegre3.Parent = Cuadre51
        PeoNegre3.Dock = DockStyle.Fill
        PeoNegre3.Parent.Tag = "O"
        PeoNegre4.Parent = Cuadre52
        PeoNegre4.Dock = DockStyle.Fill
        PeoNegre4.Parent.Tag = "O"
        PeoNegre5.Parent = Cuadre53
        PeoNegre5.Dock = DockStyle.Fill
        PeoNegre5.Parent.Tag = "O"
        PeoNegre6.Parent = Cuadre54
        PeoNegre6.Dock = DockStyle.Fill
        PeoNegre6.Parent.Tag = "O"
        PeoNegre7.Parent = Cuadre55
        PeoNegre7.Dock = DockStyle.Fill
        PeoNegre7.Parent.Tag = "O"
        PeoNegre8.Parent = Cuadre56
        PeoNegre8.Dock = DockStyle.Fill
        PeoNegre8.Parent.Tag = "O"
        'Peons Blancs
        PeoBlanc1.Parent = Cuadre9
        PeoBlanc1.Dock = DockStyle.Fill
        PeoBlanc1.Parent.Tag = "O"
        PeoBlanc2.Parent = Cuadre10
        PeoBlanc2.Dock = DockStyle.Fill
        PeoBlanc2.Parent.Tag = "O"
        PeoBlanc3.Parent = Cuadre11
        PeoBlanc3.Dock = DockStyle.Fill
        PeoBlanc3.Parent.Tag = "O"
        PeoBlanc4.Parent = Cuadre12
        PeoBlanc4.Dock = DockStyle.Fill
        PeoBlanc4.Parent.Tag = "O"
        PeoBlanc5.Parent = Cuadre13
        PeoBlanc5.Dock = DockStyle.Fill
        PeoBlanc5.Parent.Tag = "O"
        PeoBlanc6.Parent = Cuadre14
        PeoBlanc6.Dock = DockStyle.Fill
        PeoBlanc6.Parent.Tag = "O"
        PeoBlanc7.Parent = Cuadre15
        PeoBlanc7.Dock = DockStyle.Fill
        PeoBlanc7.Parent.Tag = "O"
        PeoBlanc8.Parent = Cuadre16
        PeoBlanc8.Dock = DockStyle.Fill
        PeoBlanc8.Parent.Tag = "O"
        'Torres
        TorreBlanc1.Parent = Cuadre1
        TorreBlanc1.Dock = DockStyle.Fill
        TorreBlanc1.Parent.Tag = "O"
        TorreBlanc2.Parent = Cuadre8
        TorreBlanc2.Dock = DockStyle.Fill
        TorreBlanc2.Parent.Tag = "O"
        TorreNegre1.Parent = Cuadre57
        TorreNegre1.Dock = DockStyle.Fill
        TorreNegre1.Parent.Tag = "O"
        TorreNegre2.Parent = Cuadre64
        TorreNegre2.Dock = DockStyle.Fill
        TorreNegre2.Parent.Tag = "O"
        'Cavalls
        CavallBlanc1.Parent = Cuadre2
        CavallBlanc1.Dock = DockStyle.Fill
        CavallBlanc1.Parent.Tag = "O"
        CavallBlanc2.Parent = Cuadre7
        CavallBlanc2.Dock = DockStyle.Fill
        CavallBlanc2.Parent.Tag = "O"
        CavallNegre1.Parent = Cuadre58
        CavallNegre1.Dock = DockStyle.Fill
        CavallNegre1.Parent.Tag = "O"
        CavallNegre2.Parent = Cuadre63
        CavallNegre2.Dock = DockStyle.Fill
        CavallNegre2.Parent.Tag = "O"
        'Alfil
        AlfilBlanc1.Parent = Cuadre3
        AlfilBlanc1.Dock = DockStyle.Fill
        AlfilBlanc1.Parent.Tag = "O"
        AlfilBlanc2.Parent = Cuadre6
        AlfilBlanc2.Dock = DockStyle.Fill
        AlfilBlanc2.Parent.Tag = "O"
        AlfilNegre1.Parent = Cuadre59
        AlfilNegre1.Dock = DockStyle.Fill
        AlfilNegre1.Parent.Tag = "O"
        AlfilNegre2.Parent = Cuadre62
        AlfilNegre2.Dock = DockStyle.Fill
        AlfilNegre2.Parent.Tag = "O"
        'Reina i rei
        ReinaBlanc.Parent = Cuadre5
        ReinaBlanc.Dock = DockStyle.Fill
        ReinaBlanc.Parent.Tag = "O"
        ReinaNegre.Parent = Cuadre61
        ReinaNegre.Dock = DockStyle.Fill
        ReinaNegre.Parent.Tag = "O"
        ReiBlanc.Parent = Cuadre4
        ReiBlanc.Dock = DockStyle.Fill
        ReiBlanc.Parent.Tag = "O"
        ReiNegre.Parent = Cuadre60
        ReiNegre.Dock = DockStyle.Fill
        ReiNegre.Parent.Tag = "O"

        peces = New PictureBox() {PeoNegre1, PeoNegre2, PeoNegre3, PeoNegre4, PeoNegre5, PeoNegre6, PeoNegre7, PeoNegre8, PeoBlanc1, PeoBlanc2, PeoBlanc3, PeoBlanc4, PeoBlanc5, PeoBlanc6, PeoBlanc7, PeoBlanc8, TorreBlanc1, TorreBlanc2, TorreNegre1, TorreNegre2, CavallBlanc1, CavallBlanc2, CavallNegre1, CavallNegre2, AlfilBlanc1, AlfilBlanc2, AlfilNegre1, AlfilNegre2, ReinaBlanc, ReinaNegre, ReiBlanc, ReiNegre}
        cuadres = New PictureBox() {Cuadre1, Cuadre2, Cuadre3, Cuadre4, Cuadre5, Cuadre6, Cuadre7, Cuadre8, Cuadre9, Cuadre10, Cuadre11, Cuadre12, Cuadre13, Cuadre14, Cuadre15, Cuadre16, Cuadre17, Cuadre18, Cuadre19, Cuadre20, Cuadre21, Cuadre22, Cuadre23, Cuadre24, Cuadre25, Cuadre26, Cuadre27, Cuadre28, Cuadre29, Cuadre30, Cuadre31, Cuadre32, Cuadre33, Cuadre34, Cuadre35, Cuadre36, Cuadre37, Cuadre38, Cuadre39, Cuadre40, Cuadre41, Cuadre42, Cuadre43, Cuadre44, Cuadre45, Cuadre46, Cuadre47, Cuadre48, Cuadre49, Cuadre50, Cuadre51, Cuadre52, Cuadre53, Cuadre54, Cuadre55, Cuadre56, Cuadre57, Cuadre58, Cuadre59, Cuadre60, Cuadre61, Cuadre62, Cuadre63, Cuadre64}

        Captures1.Text = 0
        Captures2.Text = 0

    End Sub

    Private Sub ClickPeça_MouseClick(sender As Object, e As MouseEventArgs) Handles PeoNegre1.MouseClick, PeoNegre2.MouseClick, PeoNegre3.MouseClick, PeoNegre4.MouseClick, PeoNegre5.MouseClick, PeoNegre6.MouseClick, PeoNegre7.MouseClick, PeoNegre8.MouseClick, PeoBlanc1.MouseClick, PeoBlanc2.MouseClick, PeoBlanc3.MouseClick, PeoBlanc4.MouseClick, PeoBlanc5.MouseClick, PeoBlanc6.MouseClick, PeoBlanc7.MouseClick, PeoBlanc8.MouseClick, TorreBlanc1.MouseClick, TorreBlanc2.MouseClick, TorreNegre1.MouseClick, TorreNegre2.MouseClick, CavallBlanc1.MouseClick, CavallBlanc2.MouseClick, CavallNegre1.MouseClick, CavallNegre2.MouseClick, AlfilBlanc1.MouseClick, AlfilBlanc2.MouseClick, AlfilNegre1.MouseClick, AlfilNegre2.MouseClick, ReinaBlanc.MouseClick, ReinaNegre.MouseClick, ReiBlanc.MouseClick, ReiNegre.MouseClick
        If esMou = False Then
            comprovarTorn()
            premuda = Array.IndexOf(peces, sender)
            sender.BackColor = Color.AliceBlue
            esMou = True
            bloquejarTorn()
            comprovarMoviment(sender) 'mostra caselles disponibles
        Else
            comprovarMoviment(sender) 'per trobar la casella que s'ha de fer no disponible
            desfer()
            premuda = -1
        End If
    End Sub

    Private Sub MovimentCuadres_Click(sender As Object, e As EventArgs) Handles Cuadre64.Click, Cuadre62.Click, Cuadre60.Click, Cuadre58.Click, Cuadre55.Click, Cuadre53.Click, Cuadre51.Click, Cuadre49.Click, Cuadre48.Click, Cuadre46.Click, Cuadre44.Click, Cuadre42.Click, Cuadre39.Click, Cuadre37.Click, Cuadre35.Click, Cuadre33.Click, Cuadre32.Click, Cuadre30.Click, Cuadre28.Click, Cuadre26.Click, Cuadre23.Click, Cuadre21.Click, Cuadre19.Click, Cuadre17.Click, Cuadre16.Click, Cuadre14.Click, Cuadre12.Click, Cuadre10.Click, Cuadre7.Click, Cuadre5.Click, Cuadre3.Click, Cuadre1.Click, Cuadre63.Click, Cuadre61.Click, Cuadre59.Click, Cuadre57.Click, Cuadre56.Click, Cuadre54.Click, Cuadre52.Click, Cuadre50.Click, Cuadre47.Click, Cuadre45.Click, Cuadre43.Click, Cuadre41.Click, Cuadre40.Click, Cuadre38.Click, Cuadre36.Click, Cuadre34.Click, Cuadre31.Click, Cuadre29.Click, Cuadre27.Click, Cuadre25.Click, Cuadre24.Click, Cuadre22.Click, Cuadre20.Click, Cuadre18.Click, Cuadre15.Click, Cuadre13.Click, Cuadre11.Click, Cuadre9.Click, Cuadre8.Click, Cuadre6.Click, Cuadre4.Click, Cuadre2.Click
        Dim temp = Array.IndexOf(cuadres, sender)
        If esMou = True And cuadres(temp).Tag = "S" Then
            peces(premuda).Parent.Tag = "N"
            peces(premuda).Parent = sender
            peces(premuda).Parent.Tag = "O"
            desfer()
            comprovarTorn()
        End If
    End Sub
    Private Sub AtraparPeces_Click(sender As Object, e As EventArgs) Handles PeoNegre1.Click, PeoNegre2.Click, PeoNegre3.Click, PeoNegre4.Click, PeoNegre5.Click, PeoNegre6.Click, PeoNegre7.Click, PeoNegre8.Click, PeoBlanc1.Click, PeoBlanc2.Click, PeoBlanc3.Click, PeoBlanc4.Click, PeoBlanc5.Click, PeoBlanc6.Click, PeoBlanc7.Click, PeoBlanc8.Click, TorreBlanc1.Click, TorreBlanc2.Click, TorreNegre1.Click, TorreNegre2.Click, CavallBlanc1.Click, CavallBlanc2.Click, CavallNegre1.Click, CavallNegre2.Click, AlfilBlanc1.Click, AlfilBlanc2.Click, AlfilNegre1.Click, AlfilNegre2.Click, ReinaBlanc.Click, ReinaNegre.Click, ReiBlanc.Click, ReiNegre.Click
        If sender.Parent.Tag <> "O" Then
            atrapar(sender)
        End If
    End Sub
    Public Sub atrapar(atrapat As Object)
        If esMou = True Then
            If peces(premuda).Tag = "blanc" And atrapat.Tag = "negre" Then
                peces(premuda).Parent = atrapat.Parent
                atrapat.Dock = DockStyle.None
                atrapat.Left = 1129
                atrapat.Top = 1618
                Captures1.Text = Captures1.Text + 1
                cuadres(posicio).BorderStyle = BorderStyle.None
                If atrapat.Equals(ReiNegre) Then
                    victories1 += 1
                    Dim response As MsgBoxResult = MsgBox("Guanya el jugador 1!", MsgBoxStyle.Information, "Resultat")
                    guanyat = True
                End If
                comprovarTorn()
            ElseIf peces(premuda).Tag = "negre" And atrapat.Tag = "blanc" Then
                peces(premuda).Parent = atrapat.Parent
                atrapat.Dock = DockStyle.None
                atrapat.Left = 1129
                atrapat.Top = 1618
                Captures2.Text = Captures2.Text + 1
                cuadres(posicio).BorderStyle = BorderStyle.None
                If atrapat.Equals(ReiBlanc) Then
                    victories2 += 1
                    Dim response As MsgBoxResult = MsgBox("Guanya el jugador 2!", MsgBoxStyle.Information, "Resultat")
                    guanyat = True
                End If
                comprovarTorn()
            End If
        End If
    End Sub
    Public Sub comprovarTorn()
        If premuda >= 0 Then
            If peces(premuda).Tag = "negre" Then
                torn = 0
                Label_Jug2.BackColor = Color.Transparent
                Label_Jug1.BackColor = Color.Crimson
            Else
                torn = 1
                Label_Jug1.BackColor = Color.Transparent
                Label_Jug2.BackColor = Color.Crimson
            End If
        End If
    End Sub
    Public Sub bloquejarTorn()
        If guanyat = False Then
            If torn = 0 And peces(premuda).Tag = "negre" Then
                Dim response As MsgBoxResult = MsgBox("Es el torn del jugador 1!", MsgBoxStyle.Information, "Torn")
                desfer()
            End If
            If torn = 1 And peces(premuda).Tag = "blanc" Then
                Dim response As MsgBoxResult = MsgBox("Es el torn del jugador 2!", MsgBoxStyle.Information, "Torn")
                desfer()
            End If
        Else
            Dim response As MsgBoxResult = MsgBox("Fi de la partida!", MsgBoxStyle.Information, "Torn")
            desfer()
        End If
    End Sub
    Public Sub desfer()
        peces(premuda).BackColor = Color.Transparent
        cuadres(posicio).BorderStyle = BorderStyle.None
        For Each PictureBox In cuadres
            If PictureBox.Tag <> "O" Then
                PictureBox.Tag = "N"
                PictureBox.BorderStyle = BorderStyle.None
            End If
        Next
        esMou = False
    End Sub
    Public Sub comprovarMoviment(peca As Object) 'nomes fa peons
        If esMou = True Then
            'Peons
            If peca.Equals(PeoBlanc1) Or peca.Equals(PeoBlanc2) Or peca.Equals(PeoBlanc3) Or peca.Equals(PeoBlanc4) Or peca.Equals(PeoBlanc5) Or peca.Equals(PeoBlanc6) Or peca.Equals(PeoBlanc7) Or peca.Equals(PeoBlanc8) Or peca.Equals(PeoNegre1) Or peca.Equals(PeoNegre2) Or peca.Equals(PeoNegre3) Or peca.Equals(PeoNegre4) Or peca.Equals(PeoNegre5) Or peca.Equals(PeoNegre6) Or peca.Equals(PeoNegre7) Or peca.Equals(PeoNegre8) Then
                posicio = Array.IndexOf(cuadres, peca.Parent)
                If peca.Tag = "blanc" Then
                    posicio += 8
                End If
                If peca.Tag = "negre" Then
                    posicio -= 8
                End If
                If cuadres(posicio).Tag <> "O" Then
                    cuadres(posicio).BorderStyle = BorderStyle.Fixed3D
                    cuadres(posicio).Tag = "S"
                Else
                    If cuadres(posicio + 1).Tag = "O" Then
                        posicio += 1
                        cuadres(posicio).BorderStyle = BorderStyle.Fixed3D
                        cuadres(posicio).Tag = "S"
                    ElseIf cuadres(posicio - 1).Tag = "O" Then
                        posicio -= 1
                        cuadres(posicio).BorderStyle = BorderStyle.Fixed3D
                        cuadres(posicio).Tag = "S"
                    End If
                End If

            End If
            'Torres

            'Cavalls

            'Alfils

            'Reines

            'Reis

            'Comprovar caselles disponibles:
            '   -Les caselles ocupades tenen un tag "O"
            '   -Dona tag de "S" a totes les caselles (que compleixin les normes de la peca) menys les ocupades
            '   -Quan una peca canvia de Parent, aquest rep el tag d'O, i la casella anterior rep un tag de "N"
        End If
    End Sub
End Class
