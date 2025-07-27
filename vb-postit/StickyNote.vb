Imports System.Windows.Forms

Public Class StickyNote
    Inherits Form

    Private ReadOnly ctx As StickyNotesContext
    Private txt As RichTextBox
    Private menu As ContextMenuStrip

    Public Sub New(context As StickyNotesContext)
        ctx = context
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.txt = New RichTextBox()
        Me.menu = New ContextMenuStrip()

        Dim newItem As New ToolStripMenuItem("New Note")
        Dim deleteItem As New ToolStripMenuItem("Delete Note")

        AddHandler newItem.Click, AddressOf Me.OnNewNote
        AddHandler deleteItem.Click, AddressOf Me.OnDeleteNote

        Me.menu.Items.AddRange(New ToolStripItem() {newItem, deleteItem})
        Me.txt.Dock = DockStyle.Fill
        Me.txt.ContextMenuStrip = Me.menu

        Me.Controls.Add(Me.txt)
        Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
        Me.TopMost = True
        Me.Width = 200
        Me.Height = 200
        Me.Text = "Sticky Note"
    End Sub

    Private Sub OnNewNote(sender As Object, e As EventArgs)
        ctx.AddNote()
    End Sub

    Private Sub OnDeleteNote(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class
