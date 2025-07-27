Imports System
Imports System.Windows.Forms

Module Program
    <STAThread>
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Dim ctx As New StickyNotesContext()
        Application.Run(ctx)
    End Sub
End Module
