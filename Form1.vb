Imports System.Xml
Public Class Form1


    Dim Countdown As Integer = 60
    Dim XmlSettings As XmlDocument = New XmlDocument()
    Dim GamersList As List(Of String) = New List(Of String)

    Public Sub Trace(TheTrace As String)

        Dim TraceDate As Date = Date.Now
        Dim trace As String
        Dim file As IO.StreamWriter = FileIO.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Demineur.txt", True)

        trace = TraceDate.ToShortDateString & " - " & TraceDate.ToLongTimeString & " : "
        trace += TheTrace

        file.WriteLine(trace)
        file.Close()

        If (Not ToolStripMenuItemTrace.Checked) Then
            Return
        End If

        TextBoxTrace.Text += trace & vbNewLine
        TextBoxTrace.SelectionStart = TextBoxTrace.TextLength - 1
        TextBoxTrace.ScrollToCaret()

    End Sub



    Private Sub Grid_MouseClick(sender As Object, e As MouseEventArgs) Handles Grid.MouseClick
        If e.Button = MouseButtons.Right Then
            MsgBox("Right", MsgBoxStyle.OkOnly)
        Else
            MsgBox("Ohter", MsgBoxStyle.OkOnly)
        End If
    End Sub


    Private Sub GenerateGrid(ColumnsCount As Integer, LinesCount As Integer)

        Dim GridWidth = ColumnsCount * MineCell.MineCellWidth
        Dim GridHeight = LinesCount * MineCell.MineCellHeight

        Grid.Width = GridWidth
        Grid.Height = GridHeight

        Dim index As Integer = 0

        For LineIndex As Integer = 0 To LinesCount - 1
            For ColumnIndex As Integer = 0 To ColumnsCount - 1

                Dim result As Integer = index Mod 12
                Grid.Controls.Add(New MineCell(ImageListPictures, result, ColumnIndex, LineIndex))
                index += 1

            Next
        Next

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            XmlSettings.Load(Application.StartupPath & "\Demineur.xml")

            Dim NodesList As XmlNodeList = XmlSettings.GetElementsByTagName("EnableTraces")
            For Each Node As XmlNode In NodesList

                If (Not Boolean.TryParse(Node.InnerText, ToolStripMenuItemTrace.Checked)) Then
                    ToolStripMenuItemTrace.Checked = False
                End If
                Exit For

            Next

            NodesList = XmlSettings.GetElementsByTagName("Gamer")
            For Each Node As XmlNode In NodesList

                GamersList.Add(Node.InnerText)

            Next




        Catch ex As Exception
            Trace("No xml file found, assume default settings values")

            ToolStripMenuItemTrace.Checked = False

        End Try

        For Each gamer As String In GamersList
            ComboBox1.Items.Add(gamer)
        Next

        GenerateCountdown(3)
            GenerateGrid(12, 12)
        TextBoxTrace.Visible = ToolStripMenuItemTrace.Checked
    End Sub

    Private Sub ToolStripMenuItemTrace_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemTrace.Click
        ToolStripMenuItemTrace.Checked = Not ToolStripMenuItemTrace.Checked

        TextBoxTrace.Visible = ToolStripMenuItemTrace.Checked

        If (TextBoxTrace.Visible) Then
            Me.Height += TextBoxTrace.Height
        Else
            Me.Height -= TextBoxTrace.Height
        End If

    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        TimerGame.Start()
    End Sub

    Private Sub TimerGame_Tick(sender As Object, e As EventArgs) Handles TimerGame.Tick

        If (Countdown > 0) Then
            Countdown -= 1
        Else
            TimerGame.Enabled = False
        End If

        CountdownSetImage(Countdown)
        Trace(Countdown)

    End Sub


    Private Sub GenerateCountdown(ColumnsCount As Integer)

        Dim CountdownWidth = ColumnsCount * CountdownCell.CountdownCellWidth
        Dim CountdownHeight = CountdownCell.CountdownCellHeight

        PanelCountdown.Width = CountdownWidth
        PanelCountdown.Height = CountdownHeight

        For ColumnIndex As Integer = 0 To ColumnsCount - 1

            PanelCountdown.Controls.Add(New CountdownCell(ImageListCountdown, 0, ColumnIndex))

        Next

    End Sub

    Private Sub CountdownSetImage(Number As Integer)

        Dim power As Integer = Math.Pow(10, PanelCountdown.Controls.Count - 1)
        Dim calcul As Integer = Number

        For Each panelindex As CountdownCell In PanelCountdown.Controls

            Dim result As Integer = Math.Truncate(calcul / power)
            panelindex.setNumber(result)
            calcul -= result * power

            power = power / 10

        Next
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Try

            XmlSettings.RemoveAll()

            Dim declarationElement As XmlDeclaration = XmlSettings.CreateXmlDeclaration("1.0", "UTF-8", Nothing)
            XmlSettings.AppendChild(declarationElement)

            Dim rootElement As XmlElement = XmlSettings.CreateElement("Settings")
            XmlSettings.AppendChild(rootElement)

            Dim enableTracesElement As XmlElement = XmlSettings.CreateElement("EnableTraces")
            enableTracesElement.InnerText = ToolStripMenuItemTrace.Checked
            rootElement.AppendChild(enableTracesElement)

            Dim gamersElement As XmlElement = XmlSettings.CreateElement("Gamers")
            rootElement.AppendChild(gamersElement)

            For Each gamer As String In GamersList

                Dim gamerElement As XmlElement = XmlSettings.CreateElement("Gamer")
                gamerElement.InnerText = gamer
                gamersElement.AppendChild(gamerElement)

            Next

            XmlSettings.Save(Application.StartupPath & "\Demineur.xml")


        Catch ex As Exception

            Trace("Impossible to write xml file")

        End Try

    End Sub

    Private Sub ComboBox1_Validated(sender As Object, e As EventArgs) Handles ComboBox1.Validated

        Dim newgamer As String = ComboBox1.Text

        Dim bFound As Boolean = False
        For Each gamer As String In GamersList

            If (String.Compare(gamer, newgamer, True) = 0) Then
                bFound = True
                Exit For
            End If
        Next

        If (Not bFound) Then
            GamersList.Add(newgamer)
            ComboBox1.Items.Add(newgamer)
        End If

    End Sub
End Class
