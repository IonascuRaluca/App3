Imports System.IO

Public Class Form1
    Dim dt As New DataTable
    Dim dv As New DataView(dt)

    Dim numarApasari = 0
    Dim filtru As String

    Dim startupPath As String = Application.StartupPath
    Dim filePath As String = Path.Combine(startupPath, "detalii.xml")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        If File.Exists(filePath) Then

            MsgBox("Fisierul a fost gasit la: " & filePath)

            dt.ReadXml(Application.StartupPath & "detalii.xml")

        Else
            MsgBox("Fisierul nu a fost gasit")

            dt.Columns.Add("Id", Type.GetType("System.Int32"))
            dt.Columns.Add("Nume", Type.GetType("System.String"))
            dt.Columns.Add("Prenume", Type.GetType("System.String"))

            dt.Rows.Add("1", "Ion", "Alexandra")
            dt.Rows.Add("2", "Ionascu", "Iulia")
            dt.Rows.Add("3", "Ciobotaru", "Narcis")
            dt.Rows.Add("4", "Constantin", "Paul")
            dt.Rows.Add("5", "Silion", "Gabriel")
            dt.Rows.Add("6", "Pruteanu", "Alexandru")
            dt.Rows.Add("7", "Serban", "Christin")
            dt.Rows.Add("8", "Mehedinti", "Oana")
            dt.Rows.Add("9", "Nanau", "Georgiana")
            dt.Rows.Add("10", "Neculache", "Maria")

        End If

        dgv.DataSource = dt
        dgv.DataSource = dv

        'dt.TableName = "Detalii"

    End Sub
    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick

        txtId.Text = dgv.CurrentRow.Cells(0).Value.ToString
        txtNume.Text = dgv.CurrentRow.Cells(1).Value.ToString
        TxtPrenume.Text = dgv.CurrentRow.Cells(2).Value.ToString

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If Not txtId.Text = "" And txtNume.Text = "" And TxtPrenume.Text = "" Then

            dt.Rows.Add(txtId.Text, txtNume.Text, TxtPrenume.Text)

            txtId.Clear()
            txtNume.Clear()
            TxtPrenume.Clear()
        Else
            MsgBox("Adauga valori in toate casetele")
        End If

    End Sub
    Private Sub BtnSterge_Click(sender As Object, e As EventArgs) Handles BtnSterge.Click

        If dgv.CurrentRow.Selected Then

            dgv.Rows.Remove(dgv.CurrentRow)
            txtId.Text = Nothing
            txtNume.Text = Nothing
            TxtPrenume.Text = Nothing
        Else
            MsgBox("Selecteaza un rand")
        End If

    End Sub
    Private Sub BtnIncarca_Click(sender As Object, e As EventArgs) Handles BtnIncarca.Click
        dt.ReadXml(Application.StartupPath & "detalii.xml")
    End Sub
    Private Sub BtnSalveaza_Click(sender As Object, e As EventArgs) Handles BtnSalveaza.Click
        dt.WriteXml(Application.StartupPath & "detalii.xml", XmlWriteMode.WriteSchema)
    End Sub

    Private Sub BtnModifica_Click(sender As Object, e As EventArgs) Handles BtnModifica.Click

        If Not dgv.CurrentRow.Selected Then
            MsgBox("Selecteaza un rand")
        ElseIf txtId.Text = "" Or txtNume.Text = "" Or TxtPrenume.Text = "" Then
            MsgBox("Scrie valori in toate casetele")
        Else
            dgv.SelectedRows(0).Cells(0).Value = txtId.Text
            dgv.SelectedRows(0).Cells(1).Value = txtNume.Text
            dgv.SelectedRows(0).Cells(2).Value = TxtPrenume.Text
        End If

    End Sub
    Private Sub BtnSorteaza_Click(sender As Object, e As EventArgs) Handles BtnSorteaza.Click

        numarApasari += 1

        If numarApasari = 1 Then
            dv.Sort = "Nume ASC"
        ElseIf numarApasari = 2 Then
            dv.Sort = "Id ASC"
        End If

    End Sub
    Private Sub TxtFiltreaza_TextChanged(sender As Object, e As EventArgs) Handles TxtFiltreaza.TextChanged
        filtru = TxtFiltreaza.Text
        dv.RowFilter = $"Prenume LIKE '%{filtru}%'"
    End Sub


End Class
