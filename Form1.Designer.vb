<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnIncarca = New System.Windows.Forms.Button()
        Me.BtnSalveaza = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPrenume = New System.Windows.Forms.TextBox()
        Me.txtNume = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.BtnSterge = New System.Windows.Forms.Button()
        Me.BtnModifica = New System.Windows.Forms.Button()
        Me.TxtFiltreaza = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnSorteaza = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnIncarca
        '
        Me.BtnIncarca.Location = New System.Drawing.Point(394, 202)
        Me.BtnIncarca.Name = "BtnIncarca"
        Me.BtnIncarca.Size = New System.Drawing.Size(142, 27)
        Me.BtnIncarca.TabIndex = 3
        Me.BtnIncarca.Text = "Incarca date"
        Me.BtnIncarca.UseVisualStyleBackColor = True
        '
        'BtnSalveaza
        '
        Me.BtnSalveaza.Location = New System.Drawing.Point(394, 302)
        Me.BtnSalveaza.Name = "BtnSalveaza"
        Me.BtnSalveaza.Size = New System.Drawing.Size(142, 27)
        Me.BtnSalveaza.TabIndex = 5
        Me.BtnSalveaza.Text = "Salveaza"
        Me.BtnSalveaza.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(394, 253)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(142, 27)
        Me.BtnAdd.TabIndex = 4
        Me.BtnAdd.Text = "Adauga"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Prenume"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nume"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Id"
        '
        'TxtPrenume
        '
        Me.TxtPrenume.Location = New System.Drawing.Point(94, 101)
        Me.TxtPrenume.Name = "TxtPrenume"
        Me.TxtPrenume.Size = New System.Drawing.Size(129, 20)
        Me.TxtPrenume.TabIndex = 2
        '
        'txtNume
        '
        Me.txtNume.Location = New System.Drawing.Point(94, 61)
        Me.txtNume.Name = "txtNume"
        Me.txtNume.Size = New System.Drawing.Size(129, 20)
        Me.txtNume.TabIndex = 1
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(94, 23)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(129, 20)
        Me.txtId.TabIndex = 0
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(36, 142)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(341, 242)
        Me.dgv.TabIndex = 13
        '
        'BtnSterge
        '
        Me.BtnSterge.Location = New System.Drawing.Point(563, 202)
        Me.BtnSterge.Name = "BtnSterge"
        Me.BtnSterge.Size = New System.Drawing.Size(142, 27)
        Me.BtnSterge.TabIndex = 6
        Me.BtnSterge.Text = "Sterge"
        Me.BtnSterge.UseVisualStyleBackColor = True
        '
        'BtnModifica
        '
        Me.BtnModifica.Location = New System.Drawing.Point(563, 253)
        Me.BtnModifica.Name = "BtnModifica"
        Me.BtnModifica.Size = New System.Drawing.Size(142, 27)
        Me.BtnModifica.TabIndex = 7
        Me.BtnModifica.Text = "Modifica"
        Me.BtnModifica.UseVisualStyleBackColor = True
        '
        'TxtFiltreaza
        '
        Me.TxtFiltreaza.Location = New System.Drawing.Point(150, 399)
        Me.TxtFiltreaza.Name = "TxtFiltreaza"
        Me.TxtFiltreaza.Size = New System.Drawing.Size(171, 20)
        Me.TxtFiltreaza.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 402)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Filtreaza dupa:"
        '
        'BtnSorteaza
        '
        Me.BtnSorteaza.Location = New System.Drawing.Point(563, 305)
        Me.BtnSorteaza.Name = "BtnSorteaza"
        Me.BtnSorteaza.Size = New System.Drawing.Size(142, 23)
        Me.BtnSorteaza.TabIndex = 8
        Me.BtnSorteaza.Text = "Sorteaza"
        Me.BtnSorteaza.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnSorteaza)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtFiltreaza)
        Me.Controls.Add(Me.BtnModifica)
        Me.Controls.Add(Me.BtnSterge)
        Me.Controls.Add(Me.BtnIncarca)
        Me.Controls.Add(Me.BtnSalveaza)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPrenume)
        Me.Controls.Add(Me.txtNume)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.dgv)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnIncarca As Button
    Friend WithEvents BtnSalveaza As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPrenume As TextBox
    Friend WithEvents txtNume As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents BtnSterge As Button
    Friend WithEvents BtnModifica As Button
    Friend WithEvents TxtFiltreaza As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnSorteaza As Button
End Class
