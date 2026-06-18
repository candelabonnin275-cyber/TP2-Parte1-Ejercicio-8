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
        cmdEjecutar = New Button()
        lblMostrar = New Label()
        txtIngreso = New TextBox()
        SuspendLayout()
        ' 
        ' cmdEjecutar
        ' 
        cmdEjecutar.Font = New Font("Times New Roman", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmdEjecutar.Location = New Point(278, 185)
        cmdEjecutar.Name = "cmdEjecutar"
        cmdEjecutar.Size = New Size(222, 56)
        cmdEjecutar.TabIndex = 0
        cmdEjecutar.Text = "Ejecutar"
        cmdEjecutar.UseVisualStyleBackColor = True
        ' 
        ' lblMostrar
        ' 
        lblMostrar.AutoSize = True
        lblMostrar.Font = New Font("Times New Roman", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMostrar.Location = New Point(278, 152)
        lblMostrar.Name = "lblMostrar"
        lblMostrar.Size = New Size(0, 19)
        lblMostrar.TabIndex = 1
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
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtIngreso)
        Controls.Add(lblMostrar)
        Controls.Add(cmdEjecutar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents lblMostrar As Label
    Friend WithEvents txtIngreso As TextBox

End Class
