Imports System.Windows.Forms

Public Class StickyNotesContext
    Inherits ApplicationContext

    Private notes As New List(Of StickyNote)

    Public Sub New()
        AddNote()
    End Sub

    Public Sub AddNote()
        Dim note As New StickyNote(Me)
        AddHandler note.FormClosed, AddressOf OnNoteClosed
        notes.Add(note)
        note.Show()
    End Sub

    Private Sub OnNoteClosed(sender As Object, e As FormClosedEventArgs)
        Dim note As StickyNote = DirectCast(sender, StickyNote)
        notes.Remove(note)
        If notes.Count = 0 Then
            ExitThread()
        End If
    End Sub
End Class
