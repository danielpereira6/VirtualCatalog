Imports System.Data.OleDb
Imports System.IO

Public Class Main
    Public Shared conName = "productData.xlsx"

    Dim ConnectionString As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & Application.StartupPath & "\" & conName & "; Extended Properties=Excel 12.0;")
    'Public Shared lang As Integer = 0

    'DESIGN
    Dim IMG As PictureBox
    Dim lbl_n As Label
    Dim lbl_pr As Label
    Dim lbl_ref As Label
    Dim lbl_dim As Label
    Dim lbl_col As Label
    Dim btn_add As Button
    Dim btn_rmv As Button
    Dim tb_qt As TextBox

    'MENU - Open
    Private Sub ConsultaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaToolStripMenuItem1.Click
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Query.Show()
    End Sub

    Private Sub ListaDeComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaDeComprasToolStripMenuItem.Click
        Cart.Show()
    End Sub

    ' LOAD
    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Product
        ConnectionString.Open()

        Dim dsProduct As New DataSet
        Dim dtProduct As New DataTable
        dsProduct.Tables.Add(dtProduct)

        Dim da As New OleDbDataAdapter("SELECT DISTINCT [Decoration] FROM [Products$]", ConnectionString)
        da.Fill(dtProduct)

        For i As Integer = 0 To dtProduct.Rows.Count - 1
            DBList.Items.Add(dtProduct.Rows(i)(0))
        Next

        ConnectionString.Close()

    End Sub


    'New image by colletion
    Private Sub InserirImagemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InserirImagemToolStripMenuItem.Click
        New_Image.ShowDialog()
    End Sub


    'List product data
    Public Sub DBList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBList.SelectedIndexChanged
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        ConnectionString.Open()

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter("select * from [Products$] where [Decoration] = '" & DBList.SelectedItem & "'", ConnectionString)
        da.Fill(dt)

        'Last
        Dim IMGorg = 10
        Dim LeftIMG = 10
        Dim TopIMG = 50

        Dim Norg = 10
        Dim LeftN = 10
        Dim TopN = 18

        Dim PRorg = 10
        Dim LeftPR = 10
        Dim TopPR = 150

        Dim REForg = 115
        Dim LeftREF = 115
        Dim TopREF = 50

        Dim Dimorg = 115
        Dim LeftDim = 115
        Dim TopDim = 75

        Dim Colorg = 115
        Dim LeftCol = 115
        Dim TopCol = 100

        Dim Qntorg = 115
        Dim LeftQnt = 115
        Dim TopQnt = 125

        Dim Rmvorg = 115
        Dim LeftRmv = 115
        Dim TopRmv = 145

        Dim Addorg = 135
        Dim LeftAdd = 135
        Dim TopAdd = 145

        Dim spc = 170

        Panel2.Controls.Clear()

        For i As Integer = 0 To dt.Rows.Count - 1
            'IMG
            Dim IMG As New PictureBox
            With IMG
                Try
                    Dim path As String
                    path = Application.StartupPath & "\img\" '& DBList.SelectedItem

                    .Image = Drawing.Image.FromFile(path & "\" & dt.Rows(i).Item(1) & ".jpg")
                Catch
                End Try

                .Cursor = Cursors.Hand
                .Size = New Size(100, 100)
                .Top = TopIMG
                .Left = LeftIMG
                LeftIMG = .Left + .Width + 120
                .SizeMode = PictureBoxSizeMode.StretchImage
                '.BorderStyle = BorderStyle.FixedSingle
                .Name = "IMG" & i.ToString
                .Tag = i.ToString

                If .Left + .Width + 100 >= Panel2.Width Then
                    TopIMG = .Top + spc
                    .Top = TopIMG
                    .Left = IMGorg
                    LeftIMG = IMGorg
                    LeftIMG = .Left + .Width + 120
                End If
            End With
            Panel2.Controls.Add(IMG)
            AddHandler IMG.Click, AddressOf IMG_Click

            'Name
            lbl_n = New Label
            With lbl_n
                .Size = New Size(200, 30)
                .Top = TopN
                .Left = LeftN
                LeftN = .Left + .Width + 20
                '.BorderStyle = BorderStyle.FixedSingle
                .Name = "lbl_n" & i.ToString
                .Tag = i.ToString

                .Text = dt.Rows(i).Item(2)

                If .Left + .Width >= Panel2.Width Then
                    TopN = .Top + spc
                    .Top = TopN
                    .Left = Norg
                    LeftN = Norg
                    LeftN = .Left + .Width + 20
                End If
            End With
            Panel2.Controls.Add(lbl_n)

            'Price
            lbl_pr = New Label
            With lbl_pr
                .Size = New Size(100, 20)
                .Top = TopPR
                .Left = LeftPR
                LeftPR = .Left + .Width + 120
                '.BorderStyle = BorderStyle.FixedSingle
                .Name = "lbl_pr" & i.ToString
                .Tag = i.ToString
                .Font = New Drawing.Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                .TextAlign = ContentAlignment.TopRight
                .Text = dt.Rows(i).Item(3) & " €"

                If .Left + .Width + 100 >= Panel2.Width Then
                    TopPR = .Top + spc
                    .Top = TopPR
                    .Left = PRorg
                    LeftPR = PRorg
                    LeftPR = .Left + .Width + 120
                End If
            End With
            Panel2.Controls.Add(lbl_pr)

            'Code
            lbl_ref = New Label
            With lbl_ref
                .Size = New Size(70, 20)
                .Top = TopREF
                .Left = LeftREF
                LeftREF = .Left + .Width + 150
                '.BorderStyle = BorderStyle.FixedSingle
                .Name = "lbl_ref" & i.ToString
                .Tag = i.ToString
                Dim value As Integer = dt.Rows(i).Item(0)
                .Text = value.ToString("D9")

                If .Left + .Width + 20 >= Panel2.Width Then
                    TopREF = .Top + spc
                    .Top = TopREF
                    .Left = REForg
                    LeftREF = REForg
                    LeftREF = .Left + .Width + 150
                End If
            End With
            Panel2.Controls.Add(lbl_ref)

            'Dimension
            lbl_dim = New Label
            With lbl_dim
                .Size = New Size(100, 20)
                .Top = TopDim
                .Left = LeftDim
                LeftDim = .Left + .Width + 120
                '.BorderStyle = BorderStyle.FixedSingle
                .Name = "lbl_dim" & i.ToString
                .Tag = i.ToString
                .Font = New Drawing.Font("", 6)
                Try
                    .Text = dt.Rows(i).Item(4)
                Catch
                End Try

                If .Left + .Width >= Panel2.Width Then
                    TopDim = .Top + spc
                    .Top = TopDim
                    .Left = Dimorg
                    LeftDim = Dimorg
                    LeftDim = .Left + .Width + 120
                End If
            End With
            Panel2.Controls.Add(lbl_dim)

            'Collection
            lbl_col = New Label
            With lbl_col
                .Size = New Size(100, 20)
                .Top = TopCol
                .Left = LeftCol
                LeftCol = .Left + .Width + 120
                '.BorderStyle = BorderStyle.FixedSingle
                .Text = dt.Rows(i).Item(1)
                .Name = "lbl_col" & i.ToString
                .Tag = i.ToString

                If .Left + .Width >= Panel2.Width Then
                    TopCol = .Top + spc
                    .Top = TopCol
                    .Left = Colorg
                    LeftCol = Colorg
                    LeftCol = .Left + .Width + 120
                End If
            End With
            Panel2.Controls.Add(lbl_col)

            'Quantity
            tb_qt = New TextBox
            With tb_qt
                .Size = New Size(40, 20)
                .Top = TopQnt
                .Left = LeftQnt
                LeftQnt = .Left + .Width + 180
                .Text = "0"
                .Name = "tb_qt" & i.ToString
                .Tag = i.ToString

                If .Left + .Width + 50 >= Panel2.Width Then
                    TopQnt = .Top + spc
                    .Top = TopQnt
                    .Left = Qntorg
                    LeftQnt = Qntorg
                    LeftQnt = .Left + .Width + 180
                End If
            End With
            Panel2.Controls.Add(tb_qt)

            'ADD
            btn_add = New Button
            With btn_add
                .Size = New Size(20, 20)
                .Top = TopAdd
                .Left = LeftAdd
                LeftAdd = .Left + .Width + 200
                .Text = "+"
                .Name = "btn_add" & i.ToString
                .Tag = i.ToString

                If .Left + .Width + 50 >= Panel2.Width Then
                    TopAdd = .Top + spc
                    .Top = TopAdd
                    .Left = Addorg
                    LeftAdd = Addorg
                    LeftAdd = .Left + .Width + 200
                End If
            End With
            Panel2.Controls.Add(btn_add)
            AddHandler btn_add.Click, AddressOf btn_add_Click

            'RMV
            btn_rmv = New Button
            With btn_rmv
                .Size = New Size(20, 20)
                .Top = TopRmv
                .Left = LeftRmv
                LeftRmv = .Left + .Width + 200
                .Text = "-"
                .Name = "btn_rmv" & i.ToString
                .Tag = i.ToString

                If .Left + .Width + 70 >= Panel2.Width Then
                    TopRmv = .Top + spc
                    .Top = TopRmv
                    .Left = Rmvorg
                    LeftRmv = Rmvorg
                    LeftRmv = .Left + .Width + 200
                End If
            End With
            Panel2.Controls.Add(btn_rmv)
            AddHandler btn_rmv.Click, AddressOf btn_rmv_Click
        Next
        ConnectionString.Close()
    End Sub

    '/////////////////////////////////////////////////// ZOOM ///////////////////////////////////////////////
    Private Sub IMG_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim IMG As PictureBox = sender
        Image.Close()
        Image.PictureBox1.Image = IMG.Image
        Image.Show()
    End Sub


    '//////////////////////////////////////////////////ADICIONAR////////////////////////////////////////////
    Public Sub btn_add_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim btn As Button = DirectCast(sender, Button)  'detect which button clicked. You can add line: MsgBox(btn.Name) to see what happening
        Dim txt As TextBox = Panel2.Controls.Find("tb_qt" & btn.Tag.ToString, True)(0) 'find textbox which belong to this button. this is why set .Tag into buttons
        txt.Text = CInt(txt.Text) + 1 'just do math and change value, by adding one(1), in textbox (by this way I avoid using Your Dim c(40) As Integer)
    End Sub

    '//////////////////////////////////////////////////REMOVER/////////////////////////////////////////////
    Public Sub btn_rmv_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim txt As TextBox = Panel2.Controls.Find("tb_qt" & btn.Tag.ToString, True)(0)
        If txt.Text > 0 Then
            txt.Text = CInt(txt.Text) - 1
        Else
            txt.Text = 0
        End If
    End Sub


    'Cart
    Private Sub cmp_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmp_btn.Click
        ConnectionString.Open()

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter("select * from [Products$] where [Decoration] = '" & DBList.SelectedItem & "'", ConnectionString)

        da.Fill(dt)

        For i = 0 To dt.Rows.Count - 1

            Dim ref As Label = Panel2.Controls.Find("lbl_ref" & i.ToString, True)(0)
            Dim col As Label = Panel2.Controls.Find("lbl_col" & i.ToString, True)(0)
            Dim n As Label = Panel2.Controls.Find("lbl_n" & i.ToString, True)(0)
            Dim pr As Label = Panel2.Controls.Find("lbl_pr" & i.ToString, True)(0)
            Dim txt As TextBox = Panel2.Controls.Find("tb_qt" & i.ToString, True)(0)

            Dim str(5) As String
            Dim itm As ListViewItem

            If CDec(txt.Text) > 0 Then
                str(0) = ref.Text
                str(1) = col.Text
                str(2) = n.Text
                str(3) = pr.Text
                str(4) = Val(txt.Text)
                str(5) = Val(Val(txt.Text) * pr.Text) & " €"
                itm = New ListViewItem(str)
                Cart.ListView1.Items.Add(itm)
            End If
            'txt.Text = 0
        Next

        Dim sum, qnt As Decimal
        For x = 0 To Cart.ListView1.Items.Count - 1
            sum += CDbl(Cart.ListView1.Items(x).SubItems(5).Text)
        Next

        Cart.ListBox7.Items.Clear()
        Cart.ListBox7.Items.Add(sum)

        Cart.ListBox8.Items.Clear()
        Cart.ListBox8.Items.Add(CDbl(Cart.ListBox7.Items(0)) * (Val(Cart.TB_desc.Text) / 100))
        Cart.ListBox9.Items.Clear()
        Cart.ListBox9.Items.Add(CDbl(Cart.ListBox7.Items(0)) - (CDbl(Cart.ListBox7.Items(0)) * (Val(Cart.TB_desc.Text) / 100)))

        For x = 0 To Cart.ListView1.Items.Count - 1
            qnt = qnt + CDbl(Cart.ListView1.Items(x).SubItems(4).Text)
        Next
        Cart.n_items.Text = "Lines: " & Cart.ListView1.Items.Count
        Cart.n_artigos.Text = "Products: " & qnt

        Cart.Show()
        Cart.BringToFront()

        ConnectionString.Close()
    End Sub

    'Clear
    Private Sub clr_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clr_btn.Click
        Dim result = MessageBox.Show("Are you sure you want to clear values?", "Clear quantities", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ConnectionString.Open()

            Dim ds As New DataSet
            Dim dt As New DataTable
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter("select * from [Products$] where [Decoration] = '" & DBList.SelectedItem & "'", ConnectionString)

            da.Fill(dt)

            For i = 0 To dt.Rows.Count - 1
                Dim txt As TextBox = Panel2.Controls.Find("tb_qt" & i.ToString, True)(0)
                txt.Text = 0
            Next

            ConnectionString.Close()
        End If
    End Sub
End Class