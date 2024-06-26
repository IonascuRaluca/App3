Public Class Form1
    Dim dt As New DataTable
    Dim dv As New DataView(dt)
    Dim numarApasari = 0
    Dim filtru As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        dt.Rows.Add(txtId.Text, txtNume.Text, TxtPrenume.Text)

        txtId.Clear()
        txtNume.Clear()
        TxtPrenume.Clear()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

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

        DataGridView1.DataSource = dt
        dt.TableName = "Detalii"

    End Sub
    Private Sub BtnIncarca_Click(sender As Object, e As EventArgs) Handles BtnIncarca.Click
        dt.WriteXml("D:\detalii.xml", XmlWriteMode.WriteSchema)
    End Sub
    Private Sub BtnSalveaza_Click(sender As Object, e As EventArgs) Handles BtnSalveaza.Click
        dt.ReadXml("D:\detalii.xml")
    End Sub

    Private Sub BtnSterge_Click(sender As Object, e As EventArgs) Handles BtnSterge.Click

        If DataGridView1.CurrentRow.Selected Then
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            txtId.Text = Nothing
            txtNume.Text = Nothing
            TxtPrenume.Text = Nothing
        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        txtId.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtNume.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        TxtPrenume.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString

    End Sub

    Private Sub BtnModifica_Click(sender As Object, e As EventArgs) Handles BtnModifica.Click

        DataGridView1.SelectedRows(0).Cells(0).Value = txtId.Text
        DataGridView1.SelectedRows(0).Cells(1).Value = txtNume.Text
        DataGridView1.SelectedRows(0).Cells(2).Value = TxtPrenume.Text

    End Sub
    Private Sub BtnSorteaza_Click(sender As Object, e As EventArgs) Handles BtnSorteaza.Click

        numarApasari += 1

        If numarApasari = 1 Then
            dv.Sort = "Nume ASC"
        ElseIf numarApasari = 2 Then
            dv.Sort = "Id ASC"
        End If

        DataGridView1.DataSource = dv

    End Sub
    Private Sub TxtFiltreaza_TextChanged(sender As Object, e As EventArgs) Handles TxtFiltreaza.TextChanged

        filtru = TxtFiltreaza.Text
        dv.RowFilter = $"Prenume LIKE '%{filtru}%'"

        DataGridView1.DataSource = dv

    End Sub


End Class
