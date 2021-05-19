Imports System.Data.OleDb
Imports System.IO

Public Class New_Image

    Private Sub btn_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_load.Click
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        Dim SaveMesa As String = Application.StartupPath & "\Fotos_Catalogo\Mesa"
        Dim SaveGift As String = Application.StartupPath & "\Fotos_Catalogo\Gift"
        Dim fso = My.Computer.FileSystem

        If (CB_COL.Text = Nothing) Then
            MsgBox("Please complete all fields!")
        Else
            With OpenFileDialog1

                .Filter = "All Graphic Files|*.bmp;*.gif;*.jpg;*.jpeg;*.png;|" &
                "Graphic Interchange Format (*.gif)|*.gif|" &
                "Portable Network Graphics (*.png)|*.png|" &
                "JPEG File Interchange Format (*.jpg;*.jpeg)|*.jpg;*.jpeg|" &
                "Windows Bitmap (*.bmp)|*.bmp"
                .FilterIndex = 1
                .FileName = ""

                'Se não existe pasta
                If Not fso.DirectoryExists(SaveMesa & "\" & CB_COL.Text) Then
                    Try
                        'Cria pasta
                        fso.CreateDirectory(SaveMesa & "\" & CB_COL.Text)
                    Catch ex As Exception
                        MessageBox.Show("Unable to create folder '" & SaveMesa.ToLower &
                            "'.  Images will be saved in '" & Application.StartupPath.ToLower &
                            "'.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        SaveMesa = Application.StartupPath
                    End Try
                End If

                'Escolhida a imagem
                'If .ShowDialog = Windows.Forms.DialogResult.OK Then
                If .ShowDialog = DialogResult.OK Then
                    'A Imagem é mostrada na Picturebox
                    PictureBox1.Image = System.Drawing.Bitmap.FromFile(.FileName)

                    If .FileName.ToUpper = (SaveMesa & "\" & CB_COL.Text & "\" & fso.GetName(.FileName)).ToUpper Then
                        MessageBox.Show("The file '" & fso.GetName(.FileName).ToLower & "' cannot be copied onto itself.",
                            Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub

                        'Imagem já existe!
                    ElseIf fso.FileExists(SaveMesa & "\" & CB_COL.Text & "\" & fso.GetName(.FileName)) Then
                        Dim Response As DialogResult

                        Response = MessageBox.Show("The file '" & fso.GetName(.FileName).ToLower & "' already exist in the destination folder '" &
                                 SaveMesa & "'" & vbCrLf & vbCrLf & "Do you want to overwite it?", Text, MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

                        If Response = DialogResult.No Then Exit Sub
                    End If

                    'Copiar
                    Try
                        fso.CopyFile(.FileName, SaveMesa & "\" & CB_COL.Text & "\" & fso.GetName(.FileName), True)
                        MsgBox("Saved Successfully!")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                End If
            End With

        End If

    End Sub

End Class