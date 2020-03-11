Public Class PedidosDeliveryCalendario
    Private listFlDay As New List(Of FlowLayoutPanel)
    Dim CurrentDate As DateTime = DateTime.Today

    Private Sub DisplayCurrentDate()
        LabelCurrentDate.Text = CurrentDate.ToString("MMMM, yyyy")
        LabelCurrentDate.Text = LabelCurrentDate.Text.ToUpper
        Me.CalendariopedidosdeliveryTableAdapter.Fill(Me.ComercialDataSet.calendariopedidosdelivery)
    End Sub
    Private Function GetFirstDayOfWeekCurrentDate()
        Dim firstdayofmonth As DateTime = New Date(CurrentDate.Year, CurrentDate.Month, 1)
        Return firstdayofmonth.DayOfWeek + 1
    End Function
    Private Function GetTotalDaysOfCurrentDate()
        Dim firstdayofmonth As DateTime = New Date(CurrentDate.Year, CurrentDate.Month, 1)
        Return firstdayofmonth.AddMonths(1).AddDays(-1).Day
        'Return DateTime.DaysInMonth(Year(CurrentDate), Month(CurrentDate))
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fechaz As DateTime
        fechaz = Now()
        fechaz = fechaz.AddDays(3)
        'MonthCalendar1.AddBoldedDate(fechaz)
        'MonthCalendar1.UpdateBoldedDates()
    End Sub

    Private Sub PedidosDeliveryCalendario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = SCAPPICON
        GenerateDayPanel(42)
        DisplayCurrentDate()
        Dim firstdayatflnumber As Integer = GetFirstDayOfWeekCurrentDate()
        Dim totalday As Integer = GetTotalDaysOfCurrentDate()
        AddLabelDayToFlDay(firstdayatflnumber, totalday)
    End Sub
    Private Sub GenerateDayPanel(ByVal totaldays As Integer)
        FlowLayoutPanelDaysPanel.Controls.Clear()
        listFlDay.Clear()

        For i As Integer = 1 To totaldays
            Dim fl As New FlowLayoutPanel
            fl.Name = $"flDay{i}"
            fl.Size = New Size(87, 87)
            fl.BackColor = SCBackColorGray
            fl.BorderStyle = BorderStyle.FixedSingle
            fl.Cursor = Cursors.Hand
            AddHandler fl.Click, AddressOf SeeAppointmentDayFromFL
            FlowLayoutPanelDaysPanel.Controls.Add(fl)
            listFlDay.Add(fl)
        Next
    End Sub
    Private Sub AddLabelDayToFlDay(ByVal startday As Integer, ByVal TotalDaysInMonth As Integer)
        For Each fl As FlowLayoutPanel In listFlDay
            fl.Controls.Clear()
            fl.Tag = 0
        Next
        For i As Integer = 1 To TotalDaysInMonth
            Dim lbl As New Label
            lbl.AutoSize = True
            lbl.Dock = DockStyle.Top
            lbl.TextAlign = ContentAlignment.MiddleRight
            lbl.Size = New Size(86, 18)
            lbl.Text = i.ToString
            lbl.Font = New Font("Century Gothic", 11, FontStyle.Bold)
            lbl.BackColor = SCBackColor
            lbl.ForeColor = SCForeColorStrong
            AddHandler lbl.Click, AddressOf SeeAppointmentDayFromLBL
            listFlDay((i - 1) + (startday - 1)).Tag = i
            listFlDay((i - 1) + (startday - 1)).Controls.Add(lbl)
            AddApointmentToFlDay(i)
        Next
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        'MsgBox(Label2.Size.ToString)
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CurrentDate = CurrentDate.AddMonths(-1)
        'GenerateDayPanel(42)
        'DisplayCurrentDate()
        'AddLabelDayToFlDay(GetFirstDayOfWeekCurrentDate(), GetTotalDaysOfCurrentDate())
        GenerateDayPanel(42)
        DisplayCurrentDate()
        Dim firstdayatflnumber As Integer = GetFirstDayOfWeekCurrentDate()
        Dim totalday As Integer = GetTotalDaysOfCurrentDate()
        AddLabelDayToFlDay(firstdayatflnumber, totalday)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CurrentDate = CurrentDate.AddMonths(1)
        'GenerateDayPanel(42)
        'DisplayCurrentDate()
        'AddLabelDayToFlDay(GetFirstDayOfWeekCurrentDate(), GetTotalDaysOfCurrentDate())
        GenerateDayPanel(42)
        DisplayCurrentDate()
        Dim firstdayatflnumber As Integer = GetFirstDayOfWeekCurrentDate()
        Dim totalday As Integer = GetTotalDaysOfCurrentDate()
        AddLabelDayToFlDay(firstdayatflnumber, totalday)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CurrentDate = Today
        GenerateDayPanel(42)
        DisplayCurrentDate()
        AddLabelDayToFlDay(GetFirstDayOfWeekCurrentDate(), GetTotalDaysOfCurrentDate())
    End Sub
    Private Sub AddApointmentToFlDay(startDayAtFlNumber As Integer)
        Dim firstdayatflnumber As Integer = GetFirstDayOfWeekCurrentDate()
        Dim startDate As DateTime = New Date(CurrentDate.Year, CurrentDate.Month, startDayAtFlNumber)
        Dim filtro As String
        filtro = "fechaaentregardate = '" + startDate.ToShortDateString() + "'"
        CalendariopedidosdeliveryBindingSource.Filter = filtro
        '/********************************************************************/
        For k = 0 To CalendariopedidosdeliveryDataGridView.RowCount - 1
            Dim appDay As DateTime = DateTime.Parse(CalendariopedidosdeliveryDataGridView.Rows(k).Cells("fechaaentregardate").Value)
            Dim link As New LinkLabel
            link.Name = CalendariopedidosdeliveryDataGridView.Rows(k).Cells("idpedidodelivery").Value
            link.Text = CalendariopedidosdeliveryDataGridView.Rows(k).Cells("nombre").Value
            link.TextAlign = ContentAlignment.MiddleLeft
            link.Font = New Font("Century Gothic", 7, FontStyle.Bold)
            link.AutoSize = False
            'link.Dock = DockStyle.Top
            AddHandler link.Click, AddressOf SeeAppointment
            Dim indicefl As Integer
            If firstdayatflnumber > 0 Then
                indicefl = firstdayatflnumber - 1 + startDayAtFlNumber - 1
            Else
                indicefl = firstdayatflnumber + startDayAtFlNumber - 1
            End If
            listFlDay(indicefl).Controls.Add(link)
            If k = 2 Then
                Exit For
            End If
        Next
    End Sub
    Private Sub SeeAppointment(ByVal sender As Object, e As EventArgs)
        gidpedidodelivery = CType(sender, LinkLabel).Name
        'MsgBox(idpedidodelivery)
        Dim p As ViewerComanda
        p = New ViewerComanda
        'gidpedidodelivery = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells("idpedidodelivery").Value
        'Dim idpedidoweb As Long
        'idpedidoweb = PedidosdeliveryTableAdapter.pedidosdelivery_consultarIDPedidoWeb(gidpedidodelivery)
        p.ShowDialog()
        gidpedidodelivery = Nothing
    End Sub
    Private Sub SeeAppointmentDayFromFL(ByVal sender As Object, e As EventArgs)
        Dim text As String
        text = CType(sender, FlowLayoutPanel).Tag.ToString
        'MsgBox(text)
        gfechaaentregar = New Date(CurrentDate.Year, CurrentDate.Month, text)
        Dim Window As New VerPedidosDelDia()
        Window.ShowDialog()
        gfechaaentregar = Nothing
    End Sub
    Private Sub SeeAppointmentDayFromLBL(ByVal sender As Object, e As EventArgs)
        Dim text As String
        text = CType(sender, Label).Text
        'MsgBox(text)
        gfechaaentregar = New Date(CurrentDate.Year, CurrentDate.Month, text)
        Dim Window As New VerPedidosDelDia()
        Window.ShowDialog()
        gfechaaentregar = Nothing
    End Sub

    Private Sub PedidosDeliveryCalendario_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub
End Class