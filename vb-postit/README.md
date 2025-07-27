# Sticky Notes in Visual Basic

This folder contains a minimal example of a desktop "post-it" application written in Visual Basic for Windows Forms. Each note is a small topmost window with a context menu that lets you create new notes or delete the current one.

## Files
- `Program.vb` – entry point of the application
- `StickyNotesContext.vb` – manages multiple note windows
- `StickyNote.vb` – form representing an individual note

## Building
Compile the files using a VB compiler that supports Windows Forms, for example with the .NET SDK:

```bash
vbc Program.vb StickyNotesContext.vb StickyNote.vb /t:winexe /r:System.Windows.Forms.dll /r:System.Drawing.dll
```

Run the resulting executable to start the application.
