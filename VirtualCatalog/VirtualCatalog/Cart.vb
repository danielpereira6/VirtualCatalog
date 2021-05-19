'Imports Excel = Microsoft.Office.Interop.Excel
'Imports System.Net

Public Class Cart
    Dim sum, qnt As Decimal

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

    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        'Dim n_cliente As String = InputBox("Nome do Cliente")

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        'Dim oExcel As New Excel.Application
        'Dim xlBook As Excel.Workbook = oExcel.Workbooks.Add
        'Dim xlSheet As Excel.Worksheet = xlBook.Worksheets(1)

        Dim oExcel As Object
        Dim oBook As Object
        Dim xlSheet As Object

        'Start a new workbook in Excel    
        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Add

        'Add data to cells of the first worksheet in the new workbook    
        xlSheet = oBook.Worksheets(1)

        oExcel.Visible = True


        'Fill the cells
        xlSheet.Range("A1").Value = "Code"
        xlSheet.Range("B1").Value = "Product"
        xlSheet.Range("C1").Value = "Decor"
        xlSheet.Range("D1").Value = "Value"
        xlSheet.Range("E1").Value = "Quant"
        xlSheet.Range("F1").Value = "Total"

        Dim row, i As Integer
        For row = 2 To ListView1.Items.Count + 1
            xlSheet.Cells(row, 1) = ListView1.Items(i).SubItems(0).Text
            xlSheet.Cells(row, 1).NumberFormat = "000000000"
            xlSheet.Cells(row, 2) = ListView1.Items(i).SubItems(1).Text
            xlSheet.Cells(row, 3) = ListView1.Items(i).SubItems(2).Text
            xlSheet.Cells(row, 4) = ListView1.Items(i).SubItems(3).Text
            xlSheet.Cells(row, 4).NumberFormat = "#,##0.00€"
            xlSheet.Cells(row, 5) = ListView1.Items(i).SubItems(4).Text
            xlSheet.Cells(row, 6) = ListView1.Items(i).SubItems(5).Text
            xlSheet.Cells(row, 6).NumberFormat = "#,##0.00€"
            i = i + 1
        Next

        xlSheet.Cells(row, 5) = "Total"
        'xlSheet.Cells(row, 5).VerticalAlignment = Excel.Constants.xlCenter
        'xlSheet.Cells(row, 5).HorizontalAlignment = Excel.Constants.xlRight
        xlSheet.Cells(row, 6) = ListBox7.Items(0)
        xlSheet.Cells(row, 6).NumberFormat = "#,##0.00€"

        If Val(TB_desc.Text) > 0 Then
            xlSheet.Cells(row + 1, 5) = "Discount"
            'xlSheet.Cells(row + 1, 5).VerticalAlignment = Excel.Constants.xlCenter
            'xlSheet.Cells(row + 1, 5).HorizontalAlignment = Excel.Constants.xlRight
            xlSheet.Cells(row + 1, 6) = Val(TB_desc.Text)
            xlSheet.Cells(row + 1, 6).NumberFormat = "##.00%"

            xlSheet.Cells(row + 2, 5) = "Discount Value"
            'xlSheet.Cells(row + 2, 5).VerticalAlignment = Excel.Constants.xlCenter
            'xlSheet.Cells(row + 2, 5).HorizontalAlignment = Excel.Constants.xlRight
            xlSheet.Cells(row + 2, 6) = ListBox8.Items(0)
            xlSheet.Cells(row + 2, 6).NumberFormat = "#,##0.00€"

            xlSheet.Cells(row + 3, 5) = "Total with Discount"
            'xlSheet.Cells(row + 3, 5).VerticalAlignment = Excel.Constants.xlCenter
            'xlSheet.Cells(row + 3, 5).HorizontalAlignment = Excel.Constants.xlRight
            xlSheet.Cells(row + 3, 6) = ListBox9.Items(0)
            xlSheet.Cells(row + 3, 6).NumberFormat = "#,##0.00€"
        End If

        'xlSheet.Cells(row, 5) = "Nome do Cliente:"
        'xlSheet.Cells(row, 5) = n_cliente


        'Format cells
        'Dim chRange As Excel.Range
        Dim chRange As Object

        chRange = xlSheet.Range("A1:F1")
        With chRange
            .Font.Bold = True
            .Font.Size = 12
            '.HorizontalAlignment = oBook.Constants.xlCenter
            '.VerticalAlignment = oBook.Constants.xlCenter
        End With

        For row = 2 To ListView1.Items.Count + 1
            For col = 1 To 6
                xlSheet.Cells(row, col).BorderAround(oBook.XlLineStyle.xlContinuous, oBook.XlBorderWeight.xlThin)
                xlSheet.Cells(1, col).BorderAround(oBook.XlLineStyle.xlContinuous, oBook.XlBorderWeight.xlMedium)
            Next
        Next
        xlSheet.Columns("A:D").AutoFit()

        oBook.Save()
        oBook.Close()
        oExcel.Quit()
    End Sub

    Private Sub FecharAplicaçãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharAplicaçãoToolStripMenuItem.Click
        Dim result = MessageBox.Show("Are you sure?", " Close Application", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub FecharJanelaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharJanelaToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TB_desc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TB_desc.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListBox8.Items.Add(CDbl(ListBox7.Items(0)) * (Val(TB_desc.Text) / 100))
            ListBox9.Items.Add(CDbl(ListBox7.Items(0)) - (CDbl(ListBox7.Items(0)) * (Val(TB_desc.Text) / 100)))
        End If
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

    Private Sub ConsultaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaToolStripMenuItem.Click
        Query.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Simulation.Show()
    End Sub

    Private Sub TB_desc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_desc.TextChanged
        ListBox8.Items.Clear()
        ListBox9.Items.Clear()
    End Sub

    Private Sub EmailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()

        Email.ShowDialog()

    End Sub
End Class