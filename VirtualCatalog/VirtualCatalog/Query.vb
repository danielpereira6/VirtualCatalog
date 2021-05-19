Imports System.Data.OleDb

Public Class Query
    Dim ConnectionString As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & Application.StartupPath & "\" & Main.conName & "; Extended Properties=Excel 12.0;")

    Private Sub Consulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CB_Col.Text = CB_Col.Items(0)
    End Sub

    'Search by NAME
    Private Sub TB_Consulta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Consulta.TextChanged
        Dim BindingSource1 As New BindingSource()
        BindingSource1.DataSource = DataGridView1.DataSource

        If CB_Col.SelectedItem = "ALL" Then
            BindingSource1.Filter = "[Designation] like '%" & TB_Consulta.Text & "%' or [Designation] like '%" & TB_Consulta.Text & "%'"
            DataGridView1.DataSource = BindingSource1
        ElseIf CB_Col.SelectedItem = CB_Col.Text Then
            BindingSource1.Filter = "[Decoration] like '%" & CB_Col.SelectedItem & "%' and [Designation] like '%" & TB_Consulta.Text & "%' or [Decoration] like '%" & CB_Col.SelectedItem & "%' and [Designation] like '%" & TB_Consulta.Text & "%'"
            DataGridView1.DataSource = BindingSource1
        End If
    End Sub

    'Search by CODE
    Private Sub TB_ref_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_ref.TextChanged
        Dim BindingSource1 As New BindingSource()
        BindingSource1.DataSource = DataGridView1.DataSource

        BindingSource1.Filter = "(Convert(Code, 'System.String') like '" & TB_ref.Text & "%')"
        DataGridView1.DataSource = BindingSource1
    End Sub

    'Add to Shopping List
    Private Sub Add_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add_btn.Click
        Dim i As Integer = DataGridView1.CurrentRow.Index
        Dim sum, qnt As Decimal
        sum = 0
        qnt = 0

        If TB_qt.Text = Nothing Then
            MsgBox("Insert quantity!")
        Else
            If CheckBox1.Checked = True Then

                Simulation.TB_desc.Text = ""
                Simulation.ListBox7.Items.Clear()
                Simulation.ListBox8.Items.Clear()
                Simulation.ListBox9.Items.Clear()

                Dim lvi As ListViewItem
                Dim itm(5) As String

                Dim value As Integer = (DataGridView1.Item(0, i).Value)
                itm(0) = value.ToString("D9")

                itm(1) = (DataGridView1.Item(1, i).Value)

                itm(2) = (DataGridView1.Item(2, i).Value)

                itm(3) = (DataGridView1.Item(3, i).Value & " €")

                itm(4) = (TB_qt.Text)

                itm(5) = (DataGridView1.Item(3, i).Value * TB_qt.Text) & " €"

                lvi = New ListViewItem(itm)
                Simulation.ListView1.Items.Add(lvi)

                Simulation.Show()

                For x = 0 To Simulation.ListView1.Items.Count - 1
                    sum += CDbl(Simulation.ListView1.Items(x).SubItems(5).Text)
                Next
                Simulation.ListBox7.Items.Add(sum)

                Simulation.ListBox8.Items.Add(CDbl(Simulation.ListBox7.Items(0)) * (Val(Simulation.TB_desc.Text) / 100))
                Simulation.ListBox9.Items.Add(CDbl(Simulation.ListBox7.Items(0)) - (CDbl(Simulation.ListBox7.Items(0)) * (Val(Simulation.TB_desc.Text) / 100)))

                For x = 0 To Simulation.ListView1.Items.Count - 1
                    qnt = qnt + CDbl(Simulation.ListView1.Items(x).SubItems(4).Text)
                Next
                Simulation.n_items.Text = "Linhas: " & Simulation.ListView1.Items.Count
                Simulation.n_artigos.Text = "Produtos: " & qnt
            Else

                Cart.TB_desc.Text = ""
                Cart.ListBox7.Items.Clear()
                Cart.ListBox8.Items.Clear()
                Cart.ListBox9.Items.Clear()

                Dim lvi As ListViewItem
                Dim itm(5) As String

                Dim value As Integer = (DataGridView1.Item(0, i).Value)
                itm(0) = value.ToString("D9")

                itm(1) = (DataGridView1.Item(1, i).Value)

                itm(2) = (DataGridView1.Item(2, i).Value)

                itm(3) = (DataGridView1.Item(3, i).Value & " €")

                itm(4) = (TB_qt.Text)

                itm(5) = (DataGridView1.Item(3, i).Value * TB_qt.Text) & " €"

                lvi = New ListViewItem(itm)
                Cart.ListView1.Items.Add(lvi)

                Cart.Show()

                For x = 0 To Cart.ListView1.Items.Count - 1
                    sum += CDbl(Cart.ListView1.Items(x).SubItems(5).Text)
                Next
                Cart.ListBox7.Items.Add(sum)

                Cart.ListBox8.Items.Add(CDbl(Cart.ListBox7.Items(0)) * (Val(Cart.TB_desc.Text) / 100))
                Cart.ListBox9.Items.Add(CDbl(Cart.ListBox7.Items(0)) - (CDbl(Cart.ListBox7.Items(0)) * (Val(Cart.TB_desc.Text) / 100)))

                For x = 0 To Cart.ListView1.Items.Count - 1
                    qnt = qnt + CDbl(Cart.ListView1.Items(x).SubItems(4).Text)
                Next
                Cart.n_items.Text = "Linhas: " & Cart.ListView1.Items.Count
                Cart.n_artigos.Text = "Produtos: " & qnt

            End If
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim n = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        TB_ref.Text = n
    End Sub

    'Limpar
    Private Sub limp_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limp_btn.Click
        TB_qt.Text = ""
        TB_ref.Text = ""
        TB_Consulta.Text = ""
        CB_Col.Text = "ALL"
    End Sub

    'Coleção
    Private Sub CB_Col_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Col.SelectedIndexChanged
        Dim BindingSource1 As New BindingSource()
        BindingSource1.DataSource = DataGridView1.DataSource

        If CB_Col.SelectedItem = "ALL" Then
            BindingSource1.Filter = "[Designation] like '%" & TB_Consulta.Text & "%' or [Designation] like '%" & TB_Consulta.Text & "%'"
            DataGridView1.DataSource = BindingSource1
        ElseIf CB_Col.SelectedItem = CB_Col.Text Then
            BindingSource1.Filter = "[Decoration] like '%" & CB_Col.SelectedItem & "%'"
            BindingSource1.Filter = "[Decoration] like '%" & CB_Col.SelectedItem & "%' and [Designation] like '%" & TB_Consulta.Text & "%' or [Decoration] like '%" & CB_Col.SelectedItem & "%' and [Designation] like '%" & TB_Consulta.Text & "%'"
            DataGridView1.DataSource = BindingSource1

            If TB_Consulta.TextLength > 0 Then
                Dim s As String = TB_Consulta.Text
                TB_Consulta.Text = Nothing
                TB_Consulta.Text = s
            End If
        End If
    End Sub

End Class