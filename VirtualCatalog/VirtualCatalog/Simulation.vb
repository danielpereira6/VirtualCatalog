Imports System.Data.OleDb
'Imports Excel = Microsoft.Office.Interop.Excel

Public Class Simulation
    Dim sum, qnt As Decimal
    Dim ConnectionString As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & Application.StartupPath & "\" & Main.conName & "; Extended Properties=Excel 12.0;")

    Private Sub ConsultaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaToolStripMenuItem.Click
        Query.Show()
        Query.BringToFront()
    End Sub

    Private Sub Mudar_Colecao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConnectionString.Open()

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da = New OleDbDataAdapter("SELECT DISTINCT [Decoration] FROM [Products$]", ConnectionString)
        da.Fill(dt)

        For i As Integer = 0 To dt.Rows.Count - 1
            CB_col.Items.Add(dt.Rows(i)(0))
        Next

        ConnectionString.Close()
    End Sub

    Private Sub TB_desc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_desc.TextChanged
        ListBox8.Items.Clear()
        ListBox9.Items.Clear()
    End Sub

    Private Sub add_cart_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_cart_btn.Click

        For i = 0 To ListView1.Items.Count - 1

            Dim str(5) As String
            Dim itm As ListViewItem

            str(0) = ListView1.Items(i).SubItems(0).Text
            str(1) = ListView1.Items(i).SubItems(1).Text
            str(2) = ListView1.Items(i).SubItems(2).Text
            str(3) = ListView1.Items(i).SubItems(3).Text
            str(4) = ListView1.Items(i).SubItems(4).Text
            str(5) = ListView1.Items(i).SubItems(5).Text
            itm = New ListViewItem(Str)
            Cart.ListView1.Items.Add(itm)

        Next

        Cart.ListBox7.Items.Clear()
        Cart.ListBox8.Items.Clear()
        Cart.ListBox9.Items.Clear()
        sum = 0
        qnt = 0

        For x = 0 To Cart.ListView1.Items.Count - 1
            sum += CDbl(Cart.ListView1.Items(x).SubItems(5).Text)
        Next

        Cart.ListBox7.Items.Add(sum)

        Cart.ListBox8.Items.Add(CDbl(Cart.ListBox7.Items(0)) * (Val(Cart.TB_desc.Text) / 100))
        Cart.ListBox9.Items.Add(CDbl(Cart.ListBox7.Items(0)) - (CDbl(Cart.ListBox7.Items(0)) * (Val(Cart.TB_desc.Text) / 100)))

        For x = 0 To Cart.ListView1.Items.Count - 1
            qnt = qnt + CDbl(Cart.ListView1.Items(x).SubItems(4).Text)
        Next

        Cart.n_items.Text = "Lines: " & Cart.ListView1.Items.Count
        Cart.n_artigos.Text = "Products: " & qnt
    End Sub

    Private Sub eliminar_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminar_btn.Click
        Try
            ListView1.Items.Remove(ListView1.SelectedItems(0))

            ListBox7.Items.Clear()
            ListBox8.Items.Clear()
            ListBox9.Items.Clear()
            sum = 0
            qnt = 0

            For x = 0 To ListView1.Items.Count - 1
                sum += CDbl(ListView1.Items(x).SubItems(5).Text)
            Next
            ListBox7.Items.Add(sum)

            ListBox8.Items.Add(CDbl(ListBox7.Items(0)) * (Val(TB_desc.Text) / 100))
            ListBox9.Items.Add(CDbl(ListBox7.Items(0)) - (CDbl(ListBox7.Items(0)) * (Val(TB_desc.Text) / 100)))

            For x = 0 To ListView1.Items.Count - 1
                qnt = qnt + CDbl(ListView1.Items(x).SubItems(4).Text)
            Next
            n_items.Text = "Lines: " & ListView1.Items.Count
            n_artigos.Text = "Products: " & qnt
        Catch
            MsgBox("Select the line.")
        End Try

    End Sub

    Private Sub At_qt_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles At_qt_btn.Click
         Try
            Dim slist = ListView1.SelectedItems(0)
            Dim objInputBox As Object = InputBox("Change quantity: ", "Edit", slist.SubItems(4).Text)
            If Not objInputBox = Nothing Then
                slist.SubItems(4).Text = objInputBox
            End If

            slist.SubItems(5).Text = (slist.SubItems(3).Text * slist.SubItems(4).Text) & " €"

            ListBox7.Items.Clear()
            ListBox8.Items.Clear()
            ListBox9.Items.Clear()
            sum = 0
            qnt = 0

            For x = 0 To ListView1.Items.Count - 1
                sum += CDbl(ListView1.Items(x).SubItems(5).Text)
            Next
            ListBox7.Items.Add(sum)

            ListBox8.Items.Add(CDbl(ListBox7.Items(0)) * (Val(TB_desc.Text) / 100))
            ListBox9.Items.Add(CDbl(ListBox7.Items(0)) - (CDbl(ListBox7.Items(0)) * (Val(TB_desc.Text) / 100)))

            For x = 0 To ListView1.Items.Count - 1
                qnt = qnt + CDbl(ListView1.Items(x).SubItems(4).Text)
            Next
            n_items.Text = "Lines: " & ListView1.Items.Count
            n_artigos.Text = "Products: " & qnt
        Catch
            MsgBox("Select the line.")
        End Try
    End Sub

    Private Sub FecharJanelaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharJanelaToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FecharAplicaçãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharAplicaçãoToolStripMenuItem.Click
        Dim result = MessageBox.Show("Are you sure you want to close the app?", " Close App", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub CB_col_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_col.SelectedIndexChanged
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        ListView1.Items.Clear()
        TB_desc.Text = ""
        ListBox7.Items.Clear()
        ListBox8.Items.Clear()
        ListBox9.Items.Clear()
        sum = 0
        qnt = 0

        ConnectionString.Open()
        Dim j As Integer = 0
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As OleDbDataAdapter

        Dim conta As Integer = 0

        For i = 0 To Cart.ListView1.Items.Count - 1

            Dim str As String = Cart.ListView1.Items(i).SubItems(0).Text
            Dim col As String = str.Substring(2, 3)

            da = New OleDbDataAdapter("SELECT * FROM [Products$] WHERE [Decoration] = '" & CB_col.Text & "' and Format([Code], ""000000000"") like '__" & col & "____'", ConnectionString)
            conta = dt.Rows.Count

            da.Fill(dt)

            'Compras.ListView1.Items(i).Selected = False

            Try
                Dim lvi As ListViewItem
                Dim itm(5) As String

                Dim value As Integer = (dt.Rows(j).Item(0))
                itm(0) = value.ToString("D9")

                itm(1) = (dt.Rows(j).Item(1))

                itm(2) = (dt.Rows(j).Item(2))

                itm(3) = (dt.Rows(j).Item(3) & " €")

                itm(4) = (Cart.ListView1.Items(j).SubItems(4).Text)

                itm(5) = (itm(3) * itm(4)) & " €"

                lvi = New ListViewItem(itm)
                ListView1.Items.Add(lvi)

                j += 1
            Catch ex As Exception


                Dim str2(5) As String
                Dim itm As ListViewItem

                str2(0) = "---------"
                str2(1) = ""
                str2(2) = ""
                str2(3) = "0 €"
                str2(4) = "0"
                str2(5) = "0 €"

                itm = New ListViewItem(str2)
                ListView1.Items.Add(itm)

            End Try
        Next

        If ListView1.Items.Count = 0 Then
            MsgBox("Decoration without common products.")
        End If

        For x = 0 To ListView1.Items.Count - 1
            sum += CDbl(ListView1.Items(x).SubItems(5).Text)
        Next
        ListBox7.Items.Add(sum)

        ListBox8.Items.Add(CDbl(ListBox7.Items(0)) * (Val(TB_desc.Text) / 100))
        ListBox9.Items.Add(CDbl(ListBox7.Items(0)) - (CDbl(ListBox7.Items(0)) * (Val(TB_desc.Text) / 100)))

        For x = 0 To ListView1.Items.Count - 1
            qnt = qnt + CDbl(ListView1.Items(x).SubItems(4).Text)
        Next
        n_items.Text = "Lines: " & ListView1.Items.Count
        n_artigos.Text = "Products: " & qnt

        ConnectionString.Close()
    End Sub

    Private Sub TB_desc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TB_desc.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListBox8.Items.Add(CDbl(ListBox7.Items(0)) * (Val(TB_desc.Text) / 100))
            ListBox9.Items.Add(CDbl(ListBox7.Items(0)) - (CDbl(ListBox7.Items(0)) * (Val(TB_desc.Text) / 100)))
        End If
    End Sub

    Private Sub btn_edit_Click(sender As System.Object, e As System.EventArgs) Handles btn_edit.Click
        For i = 0 To ListView1.Items.Count - 1
            If ListView1.Items(i).Selected = True Then
                Fill.id = i
                Fill.ShowDialog()
                Fill.id = -1
            End If
        Next
    End Sub
End Class