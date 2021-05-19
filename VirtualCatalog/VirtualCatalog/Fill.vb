Imports System.Data.OleDb

Public Class Fill
    Dim ConnectionString As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & Application.StartupPath & "\" & Main.conName & "; Extended Properties=Excel 12.0;")

    Public id As Integer

    'Linguagem
    Private Sub Preencher_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CB_Col.Text = CB_Col.Items(0)
    End Sub

    'Add
    Private Sub Add_btn_Click(sender As System.Object, e As System.EventArgs) Handles Add_btn.Click
        Dim i As Integer = DataGridView1.CurrentRow.Index
        Dim sum, qnt As Decimal
        sum = 0
        qnt = 0

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

        'If Mudar_Colecao.ListView1 = True Then
        ' Mudar_Colecao.ListView1.Items.Add(lvi)

        If (id > -1) Then
            Simulation.ListView1.Items(id) = lvi
        End If

        'End If

        ' Mudar_Colecao.Show()

        For x = 0 To Simulation.ListView1.Items.Count - 1
            sum += CDbl(Simulation.ListView1.Items(x).SubItems(5).Text)
        Next
        Simulation.ListBox7.Items.Add(sum)

        Simulation.ListBox8.Items.Add(CDbl(Simulation.ListBox7.Items(0)) * (Val(Simulation.TB_desc.Text) / 100))
        Simulation.ListBox9.Items.Add(CDbl(Simulation.ListBox7.Items(0)) - (CDbl(Simulation.ListBox7.Items(0)) * (Val(Simulation.TB_desc.Text) / 100)))

        For x = 0 To Simulation.ListView1.Items.Count - 1
            qnt = qnt + CDbl(Simulation.ListView1.Items(x).SubItems(4).Text)
        Next
        Simulation.n_items.Text = "Lines: " & Simulation.ListView1.Items.Count
        Simulation.n_artigos.Text = "Products: " & qnt

    End Sub

    'Limpar
    Private Sub limp_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limp_btn.Click
        TB_qt.Text = ""
        CB_Col.Text = "ALL"
    End Sub

    'Coleção
    Private Sub CB_Col_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Col.SelectedIndexChanged
        Dim BindingSource1 As New BindingSource()
        BindingSource1.DataSource = DataGridView1.DataSource


        BindingSource1.Filter = "[Decoration] like '%" & CB_Col.SelectedItem & "%'"
        DataGridView1.DataSource = BindingSource1

    End Sub

End Class