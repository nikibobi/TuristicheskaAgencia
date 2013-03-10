Public Class frmTouristAgency
    'ekskurzii
    Dim Continent(40) As String
    Dim Country(40) As String
    Dim Description(40) As String
    Dim DateBegin(40) As Date
    Dim Days(40) As Integer
    Dim DateEnd(40) As Date
    Dim Transport(40) As String
    Dim Price(40) As Double
    Dim Discount As Double
    Dim DaysRez As Integer

    Dim K As Integer
    Dim I As Integer
    'rezervacii

    Private Sub frmTouristAgency_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitArrays()
        K = 40
        I = 0
        cmbContinent.SelectedIndex = 0
        cmbContinentRez.SelectedIndex = 0
    End Sub

    Private Sub InitArrays()
        Continent(0) = "Европа"
        Country(0) = "Ирландия"
        Description(0) = "В Ирландия е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(0) = "24.3.2013 г. 22:36:18"
        Days(0) = 5
        DateEnd(0) = "29.3.2013 г. 22:36:18"
        Transport(0) = "Самолет"
        Price(0) = 1714
        Continent(1) = "Европа"
        Country(1) = "Франция"
        Description(1) = "В Франция е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(1) = "10.5.2013 г. 22:36:18"
        Days(1) = 16
        DateEnd(1) = "26.5.2013 г. 22:36:18"
        Transport(1) = "Самолет"
        Price(1) = 183
        Continent(2) = "Европа"
        Country(2) = "Швейцария"
        Description(2) = "В Швейцария е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(2) = "24.3.2013 г. 22:36:18"
        Days(2) = 3
        DateEnd(2) = "27.3.2013 г. 22:36:18"
        Transport(2) = "Самолет"
        Price(2) = 2295
        Continent(3) = "Европа"
        Country(3) = "Полша"
        Description(3) = "В Полша е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(3) = "09.11.2013 г. 22:36:18"
        Days(3) = 3
        DateEnd(3) = "12.11.2013 г. 22:36:18"
        Transport(3) = "Кораб"
        Price(3) = 1861
        Continent(4) = "Европа"
        Country(4) = "Норвегия"
        Description(4) = "В Норвегия е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(4) = "08.4.2013 г. 22:36:18"
        Days(4) = 7
        DateEnd(4) = "15.4.2013 г. 22:36:18"
        Transport(4) = "Кораб"
        Price(4) = 105
        Continent(5) = "Европа"
        Country(5) = "Испания"
        Description(5) = "В Испания е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(5) = "25.3.2013 г. 22:36:18"
        Days(5) = 15
        DateEnd(5) = "09.4.2013 г. 22:36:18"
        Transport(5) = "Влак"
        Price(5) = 4699
        Continent(6) = "Европа"
        Country(6) = "Италия"
        Description(6) = "В Италия е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(6) = "25.4.2013 г. 22:36:18"
        Days(6) = 11
        DateEnd(6) = "06.5.2013 г. 22:36:18"
        Transport(6) = "Влак"
        Price(6) = 4510
        Continent(7) = "Европа"
        Country(7) = "Шотландия"
        Description(7) = "В Шотландия е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(7) = "17.10.2013 г. 22:36:18"
        Days(7) = 16
        DateEnd(7) = "02.11.2013 г. 22:36:18"
        Transport(7) = "Автобус"
        Price(7) = 3508
        Continent(8) = "Европа"
        Country(8) = "Гърция"
        Description(8) = "В Гърция е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(8) = "02.11.2013 г. 22:36:18"
        Days(8) = 5
        DateEnd(8) = "07.11.2013 г. 22:36:18"
        Transport(8) = "Кораб"
        Price(8) = 4696
        Continent(9) = "Европа"
        Country(9) = "Ромъния"
        Description(9) = "В Ромъния е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(9) = "31.5.2013 г. 22:36:18"
        Days(9) = 20
        DateEnd(9) = "20.6.2013 г. 22:36:18"
        Transport(9) = "Автобус"
        Price(9) = 2627
        Continent(10) = "Азия"
        Country(10) = "Русия"
        Description(10) = "В Русия е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(10) = "26.8.2013 г. 22:36:18"
        Days(10) = 5
        DateEnd(10) = "31.8.2013 г. 22:36:18"
        Transport(10) = "Автобус"
        Price(10) = 2360
        Continent(11) = "Азия"
        Country(11) = "Китай"
        Description(11) = "В Китай е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(11) = "02.9.2013 г. 22:36:18"
        Days(11) = 19
        DateEnd(11) = "21.9.2013 г. 22:36:18"
        Transport(11) = "Автобус"
        Price(11) = 4035
        Continent(12) = "Азия"
        Country(12) = "Индия"
        Description(12) = "В Индия е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(12) = "09.5.2013 г. 22:36:18"
        Days(12) = 19
        DateEnd(12) = "28.5.2013 г. 22:36:18"
        Transport(12) = "Автобус"
        Price(12) = 3045
        Continent(13) = "Азия"
        Country(13) = "Тайланд"
        Description(13) = "В Тайланд е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(13) = "12.7.2013 г. 22:36:18"
        Days(13) = 9
        DateEnd(13) = "21.7.2013 г. 22:36:18"
        Transport(13) = "Кораб"
        Price(13) = 1664
        Continent(14) = "Азия"
        Country(14) = "Индонезия"
        Description(14) = "В Индонезия е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(14) = "25.11.2013 г. 22:36:18"
        Days(14) = 4
        DateEnd(14) = "29.11.2013 г. 22:36:18"
        Transport(14) = "Самолет"
        Price(14) = 3504
        Continent(15) = "Азия"
        Country(15) = "Виетнам"
        Description(15) = "В Виетнам е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(15) = "12.7.2013 г. 22:36:18"
        Days(15) = 7
        DateEnd(15) = "19.7.2013 г. 22:36:18"
        Transport(15) = "Автобус"
        Price(15) = 1810
        Continent(16) = "Азия"
        Country(16) = "Северна Корея"
        Description(16) = "В Северна Корея е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(16) = "04.9.2013 г. 22:36:18"
        Days(16) = 8
        DateEnd(16) = "12.9.2013 г. 22:36:18"
        Transport(16) = "Влак"
        Price(16) = 3301
        Continent(17) = "Азия"
        Country(17) = "Южна Корея"
        Description(17) = "В Южна Корея е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(17) = "06.9.2013 г. 22:36:18"
        Days(17) = 19
        DateEnd(17) = "25.9.2013 г. 22:36:18"
        Transport(17) = "Самолет"
        Price(17) = 3832
        Continent(18) = "Азия"
        Country(18) = "Япония"
        Description(18) = "В Япония е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(18) = "21.7.2013 г. 22:36:18"
        Days(18) = 12
        DateEnd(18) = "02.8.2013 г. 22:36:18"
        Transport(18) = "Самолет"
        Price(18) = 656
        Continent(19) = "Азия"
        Country(19) = "Монголия"
        Description(19) = "В Монголия е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(19) = "31.5.2013 г. 22:36:18"
        Days(19) = 12
        DateEnd(19) = "12.6.2013 г. 22:36:18"
        Transport(19) = "Самолет"
        Price(19) = 2362
        Continent(20) = "Америка"
        Country(20) = "Монтана"
        Description(20) = "В Монтана е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(20) = "27.5.2013 г. 22:36:18"
        Days(20) = 8
        DateEnd(20) = "04.6.2013 г. 22:36:18"
        Transport(20) = "Кораб"
        Price(20) = 3615
        Continent(21) = "Америка"
        Country(21) = "Ню Хемпшир"
        Description(21) = "В Ню Хемпшир е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(21) = "24.10.2013 г. 22:36:18"
        Days(21) = 6
        DateEnd(21) = "30.10.2013 г. 22:36:18"
        Transport(21) = "Автобус"
        Price(21) = 2379
        Continent(22) = "Америка"
        Country(22) = "Небраска"
        Description(22) = "В Небраска е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(22) = "23.10.2013 г. 22:36:18"
        Days(22) = 12
        DateEnd(22) = "04.11.2013 г. 22:36:18"
        Transport(22) = "Автобус"
        Price(22) = 3414
        Continent(23) = "Америка"
        Country(23) = "Канзас"
        Description(23) = "В Канзас е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(23) = "12.11.2013 г. 22:36:18"
        Days(23) = 13
        DateEnd(23) = "25.11.2013 г. 22:36:18"
        Transport(23) = "Самолет"
        Price(23) = 1480
        Continent(24) = "Америка"
        Country(24) = "Колорадо"
        Description(24) = "В Колорадо е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(24) = "19.5.2013 г. 22:36:18"
        Days(24) = 7
        DateEnd(24) = "26.5.2013 г. 22:36:18"
        Transport(24) = "Автобус"
        Price(24) = 1907
        Continent(25) = "Америка"
        Country(25) = "Аляска"
        Description(25) = "В Аляска е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(25) = "06.9.2013 г. 22:36:18"
        Days(25) = 20
        DateEnd(25) = "26.9.2013 г. 22:36:18"
        Transport(25) = "Влак"
        Price(25) = 3664
        Continent(26) = "Америка"
        Country(26) = "Юта"
        Description(26) = "В Юта е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(26) = "27.8.2013 г. 22:36:18"
        Days(26) = 10
        DateEnd(26) = "06.9.2013 г. 22:36:18"
        Transport(26) = "Влак"
        Price(26) = 1810
        Continent(27) = "Америка"
        Country(27) = "Минесота"
        Description(27) = "В Минесота е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(27) = "17.5.2013 г. 22:36:18"
        Days(27) = 8
        DateEnd(27) = "25.5.2013 г. 22:36:18"
        Transport(27) = "Кораб"
        Price(27) = 3009
        Continent(28) = "Америка"
        Country(28) = "Северна Дакота"
        Description(28) = "В Северна Дакота е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(28) = "07.11.2013 г. 22:36:18"
        Days(28) = 11
        DateEnd(28) = "18.11.2013 г. 22:36:18"
        Transport(28) = "Кораб"
        Price(28) = 1654
        Continent(29) = "Америка"
        Country(29) = "Хавай"
        Description(29) = "В Хавай е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(29) = "18.10.2013 г. 22:36:18"
        Days(29) = 15
        DateEnd(29) = "02.11.2013 г. 22:36:18"
        Transport(29) = "Самолет"
        Price(29) = 446
        Continent(30) = "Африка"
        Country(30) = "Либия"
        Description(30) = "В Либия е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(30) = "22.11.2013 г. 22:36:18"
        Days(30) = 5
        DateEnd(30) = "27.11.2013 г. 22:36:18"
        Transport(30) = "Влак"
        Price(30) = 3359
        Continent(31) = "Африка"
        Country(31) = "Египет"
        Description(31) = "В Египет е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(31) = "24.9.2013 г. 22:36:18"
        Days(31) = 19
        DateEnd(31) = "13.10.2013 г. 22:36:18"
        Transport(31) = "Самолет"
        Price(31) = 2311
        Continent(32) = "Африка"
        Country(32) = "Мароко"
        Description(32) = "В Мароко е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(32) = "06.7.2013 г. 22:36:18"
        Days(32) = 5
        DateEnd(32) = "11.7.2013 г. 22:36:18"
        Transport(32) = "Автобус"
        Price(32) = 4502
        Continent(33) = "Африка"
        Country(33) = "Чад"
        Description(33) = "В Чад е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(33) = "02.5.2013 г. 22:36:18"
        Days(33) = 18
        DateEnd(33) = "20.5.2013 г. 22:36:18"
        Transport(33) = "Влак"
        Price(33) = 4439
        Continent(34) = "Африка"
        Country(34) = "Южна Африка"
        Description(34) = "В Южна Африка е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(34) = "21.7.2013 г. 22:36:18"
        Days(34) = 12
        DateEnd(34) = "02.8.2013 г. 22:36:18"
        Transport(34) = "Автобус"
        Price(34) = 851
        Continent(35) = "Африка"
        Country(35) = "Конго"
        Description(35) = "В Конго е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(35) = "19.8.2013 г. 22:36:18"
        Days(35) = 11
        DateEnd(35) = "30.8.2013 г. 22:36:18"
        Transport(35) = "Автобус"
        Price(35) = 2286
        Continent(36) = "Африка"
        Country(36) = "Судан"
        Description(36) = "В Судан е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(36) = "11.11.2013 г. 22:36:18"
        Days(36) = 6
        DateEnd(36) = "17.11.2013 г. 22:36:18"
        Transport(36) = "Влак"
        Price(36) = 3071
        Continent(37) = "Африка"
        Country(37) = "Кения"
        Description(37) = "В Кения е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(37) = "31.5.2013 г. 22:36:18"
        Days(37) = 12
        DateEnd(37) = "12.6.2013 г. 22:36:18"
        Transport(37) = "Автобус"
        Price(37) = 232
        Continent(38) = "Африка"
        Country(38) = "Нигер"
        Description(38) = "В Нигер е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(38) = "13.11.2013 г. 22:36:18"
        Days(38) = 5
        DateEnd(38) = "18.11.2013 г. 22:36:18"
        Transport(38) = "Влак"
        Price(38) = 901
        Continent(39) = "Африка"
        Country(39) = "Зимбабве"
        Description(39) = "В Зимбабве е много хубаво. Времето е прекрасно и има много забележителности!"
        DateBegin(39) = "01.9.2013 г. 22:36:18"
        Days(39) = 20
        DateEnd(39) = "21.9.2013 г. 22:36:18"
        Transport(39) = "Самолет"
        Price(39) = 1656

    End Sub

    Private Sub cmbContinent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbContinent.SelectedIndexChanged
        cmbDestination.Items.Clear()
        For n = 0 To K
            If cmbContinent.Text = Continent(n) Then
                cmbDestination.Items.Add(Country(n))
            End If
        Next
        cmbDestination.SelectedIndex = 0
    End Sub

    Private Sub cmbDestination_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbDestination.SelectedIndexChanged
        For n = 0 To K
            If cmbDestination.Text = Country(n) Then
                I = n
            End If
        Next
        lblResult.Text = String.Format("Описание: {1}{0}Начална дата: {2:d}{0}Крайна дата: {3:d}{0}Дни: {4}{0}Вид транспорт: {5}{0}Цена: {6:c}", vbNewLine, Description(I), DateBegin(I), DateEnd(I), Days(I), Transport(I), Price(I))
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAdd.Click
        For n = 0 To K
            If cmbDestinationRez.Text = Country(n) Then
                I = n
            End If
        Next

        If numReservations.Value >= 5 Then
            Discount = 0.15
        ElseIf numReservations.Value >= 3 Then
            Discount = 0.1
        ElseIf numReservations.Value >= 2 Then
            Discount = 0.05
        Else
            Discount = 1
        End If

        lblPrice.Text = String.Format("Цена: {1:c}{0}Отстъпка:{2}%{0}Крайна Цена:{3:c}{0}", vbNewLine, Price(I) * numReservations.Value, Discount * 100, Price(I) * numReservations.Value - (Price(I) * numReservations.Value * Discount))
    End Sub

    Private Sub cmbContinentRez_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbContinentRez.SelectedIndexChanged
        cmbDestinationRez.Items.Clear()
        For n = 0 To K
            If cmbContinentRez.Text = Continent(n) Then
                cmbDestinationRez.Items.Add(Country(n))
            End If
        Next
        cmbDestinationRez.SelectedIndex = 0
    End Sub

    Private Sub cmbDestinationRez_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbDestinationRez.SelectedIndexChanged
        For n = 0 To K
            If cmbDestinationRez.Text = Country(n) Then
                I = n
            End If
        Next
        lblDestinationInfoRez.Text = String.Format("Описание: {1}{0}Начална дата: {2:d}{0}Вид транспорт: {3}{0}Цена за транспорт: {4:c}", vbNewLine, Description(I), DateBegin(I), Transport(I), Price(I))
    End Sub
End Class
