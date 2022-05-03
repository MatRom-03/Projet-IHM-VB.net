Imports System.Xml
Public Class Settings
    Public XmlSettings As XmlDocument = New XmlDocument()
    Public ActiveTrace As Boolean
    Public LastGamer As String
    Public CurrentPlayer As DataGamer
    Public ColumnsCount As Integer = 8
    Public LinesCount As Integer = 8
    Public MinesCount = 10
    Public GamersList As List(Of DataGamer) = New List(Of DataGamer)
    Public GameTime As Integer = 60
    Public CountdownEnabled As Boolean = True
    Public StoragePathXMLFile As String = Application.StartupPath


    'faire un autre fichier dans Application.StartupPath pour stocker l'emplacement choisi par l'utilisateur



    Public Sub Load()
        Try

            XmlSettings.Load(Application.StartupPath & "\Demineur.xml")

            Dim NodesList As XmlNodeList = XmlSettings.GetElementsByTagName("EnableTraces")
            For Each Node As XmlNode In NodesList

                If (Not Boolean.TryParse(Node.InnerText, ActiveTrace)) Then
                    ActiveTrace = False
                End If
                Exit For

            Next

            NodesList = XmlSettings.GetElementsByTagName("LastGamer")
            For Each Node As XmlNode In NodesList

                LastGamer = Node.InnerText
                Exit For

            Next

            NodesList = XmlSettings.GetElementsByTagName("ColumnsCount")
            For Each Node As XmlNode In NodesList

                ColumnsCount = Node.InnerText
                Exit For

            Next

            NodesList = XmlSettings.GetElementsByTagName("LinesCount")
            For Each Node As XmlNode In NodesList

                LinesCount = Node.InnerText
                Exit For

            Next

            NodesList = XmlSettings.GetElementsByTagName("MinesCount")
            For Each Node As XmlNode In NodesList

                MinesCount = Node.InnerText
                Exit For

            Next

            NodesList = XmlSettings.GetElementsByTagName("CountdownEnabled")
            For Each Node As XmlNode In NodesList

                If (Not Boolean.TryParse(Node.InnerText, CountdownEnabled)) Then
                    CountdownEnabled = False
                End If
                Exit For

            Next

            NodesList = XmlSettings.GetElementsByTagName("GameTime")
            For Each Node As XmlNode In NodesList

                GameTime = Node.InnerText
                Exit For

            Next


            NodesList = XmlSettings.GetElementsByTagName("Gamer")
            For Each Node As XmlNode In NodesList
                Dim name As String
                Dim CellDiscoveredMax As Integer
                Dim TimeGame As Integer
                Dim GameCount As Integer
                Dim TimeCount As Integer
                For Each ChildNode As XmlNode In Node.ChildNodes
                    If ChildNode.Name.CompareTo("Name") = 0 Then
                        name = ChildNode.InnerText
                    End If
                    If ChildNode.Name.CompareTo("BestResult") = 0 Then
                        CellDiscoveredMax = ChildNode.InnerText
                        TimeGame = ChildNode.Attributes("Time").InnerText
                    End If
                    If ChildNode.Name.CompareTo("GameCount") = 0 Then
                        GameCount = ChildNode.InnerText
                    End If
                    If ChildNode.Name.CompareTo("TimeCount") = 0 Then
                        TimeCount = ChildNode.InnerText
                    End If

                Next
                Dim gamer As DataGamer = New DataGamer(name, CellDiscoveredMax, TimeGame, GameCount, TimeCount)
                GamersList.Add(gamer)

            Next


        Catch ex As Exception
            TraceFile("No xml file found, assume default settings values")

            ActiveTrace = False

        End Try
        TraceFile("Settings loading complete")
    End Sub

    Public Sub save()
        Try

            XmlSettings.RemoveAll()

            Dim declarationElement As XmlDeclaration = XmlSettings.CreateXmlDeclaration("1.0", "UTF-8", Nothing)
            XmlSettings.AppendChild(declarationElement)

            Dim rootElement As XmlElement = XmlSettings.CreateElement("Settings")
            XmlSettings.AppendChild(rootElement)

            Dim enableTracesElement As XmlElement = XmlSettings.CreateElement("EnableTraces")
            enableTracesElement.InnerText = ActiveTrace
            rootElement.AppendChild(enableTracesElement)

            Dim LastGamerElement As XmlElement = XmlSettings.CreateElement("LastGamer")
            LastGamerElement.InnerText = LastGamer
            rootElement.AppendChild(LastGamerElement)

            Dim ColumnsCountElement As XmlElement = XmlSettings.CreateElement("ColumnsCount")
            ColumnsCountElement.InnerText = ColumnsCount
            rootElement.AppendChild(ColumnsCountElement)

            Dim LinesCountElement As XmlElement = XmlSettings.CreateElement("LinesCount")
            LinesCountElement.InnerText = LinesCount
            rootElement.AppendChild(LinesCountElement)

            Dim MinesCountElement As XmlElement = XmlSettings.CreateElement("MinesCount")
            MinesCountElement.InnerText = MinesCount
            rootElement.AppendChild(MinesCountElement)

            Dim CountdownEnabledElement As XmlElement = XmlSettings.CreateElement("CountdownEnabled")
            CountdownEnabledElement.InnerText = CountdownEnabled
            rootElement.AppendChild(CountdownEnabledElement)

            Dim GameTimeElement As XmlElement = XmlSettings.CreateElement("GameTime")
            GameTimeElement.InnerText = GameTime
            rootElement.AppendChild(GameTimeElement)

            Dim StoragePathXMLFileElement As XmlElement = XmlSettings.CreateElement("StoragePathXMLFile")
            StoragePathXMLFileElement.InnerText = StoragePathXMLFile
            rootElement.AppendChild(StoragePathXMLFileElement)


            Dim gamersElement As XmlElement = XmlSettings.CreateElement("Gamers")
            rootElement.AppendChild(gamersElement)

            For Each gamer As DataGamer In GamersList

                Dim gamerElement As XmlElement = XmlSettings.CreateElement("Gamer")
                gamersElement.AppendChild(gamerElement)

                Dim NameElement As XmlElement = XmlSettings.CreateElement("Name")
                NameElement.InnerText = gamer.name
                gamerElement.AppendChild(NameElement)

                Dim BestResultElement As XmlElement = XmlSettings.CreateElement("BestResult")
                BestResultElement.InnerText = gamer.CellDiscoveredMax
                Dim xmlTimeAttribute As XmlAttribute = XmlSettings.CreateAttribute("Time")
                xmlTimeAttribute.InnerText = gamer.TimeGame
                BestResultElement.Attributes.Append(xmlTimeAttribute)
                gamerElement.AppendChild(BestResultElement)

                Dim GameCountElement As XmlElement = XmlSettings.CreateElement("GameCount")
                GameCountElement.InnerText = gamer.GameCount
                gamerElement.AppendChild(GameCountElement)

                Dim TimeCountElement As XmlElement = XmlSettings.CreateElement("TimeCount")
                TimeCountElement.InnerText = gamer.TimeCount
                gamerElement.AppendChild(TimeCountElement)
            Next

            XmlSettings.Save(Application.StartupPath & "\Demineur.xml")


        Catch ex As Exception

            TraceFile("Impossible to write xml file")

        End Try
        TraceFile("Settings backup done")
    End Sub

End Class
