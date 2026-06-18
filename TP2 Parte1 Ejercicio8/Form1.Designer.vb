<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmdEjecutar = New Button()
        Me.lblMostrar = New Label()
        txtIngreso = New TextBox()
        SuspendLayout()
        ' 
        ' cmdEjecutar
        ' 
        Me.cmdEjecutar.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Me.cmdEjecutar.Location = New Point(278, 190)
        Me.cmdEjecutar.Name = "cmdEjecutar"
        Me.cmdEjecutar.Size = New Size(222, 56)
        Me.cmdEjecutar.TabIndex = 0
        Me.cmdEjecutar.Text = "Ejecutar"
        Me.cmdEjecutar.UseVisualStyleBackColor = True
        ' 
        ' lblMostrar
        ' 
        Me.lblMostrar.AutoSize = True
        Me.lblMostrar.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Me.lblMostrar.Location = New Point(278, 152)
        Me.lblMostrar.Name = "lblMostrar"
        Me.lblMostrar.Size = New Size(0, 19)
        Me.lblMostrar.TabIndex = 1
        ' 
        ' txtIngreso
        ' 
        txtIngreso.Location = New Point(278, 98)
        txtIngreso.Name = "txtIngreso"
        txtIngreso.Size = New Size(234, 23)
        txtIngreso.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtIngreso)
        Controls.Add(Me.lblMostrar)
        Controls.Add(Me.cmdEjecutar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents lblMostrar As Label
    Friend WithEvents txtIngreso As TextBox

End Class
