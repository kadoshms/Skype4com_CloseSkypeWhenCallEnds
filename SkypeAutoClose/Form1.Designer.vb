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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxSkype1 = New AxSKYPE4COMLib.AxSkype()
        CType(Me.AxSkype1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxSkype1
        '
        Me.AxSkype1.Enabled = True
        Me.AxSkype1.Location = New System.Drawing.Point(0, 0)
        Me.AxSkype1.Name = "AxSkype1"
        Me.AxSkype1.OcxState = CType(resources.GetObject("AxSkype1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxSkype1.Size = New System.Drawing.Size(288, 205)
        Me.AxSkype1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 244)
        Me.Controls.Add(Me.AxSkype1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AxSkype1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxSkype1 As AxSKYPE4COMLib.AxSkype

End Class
