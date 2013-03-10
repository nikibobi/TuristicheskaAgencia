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

    Dim K As Integer
    Dim I As Integer
    'rezervacii

    Private Sub frmTouristAgency_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "destinations.txt", OpenMode.Input)
        K = 0
        Do While Not EOF(1)
            Continent(K) = LineInput(1)
            Country(K) = LineInput(1)
            Description(K) = LineInput(1)
            DateBegin(K) = LineInput(1)
            Days(K) = LineInput(1)
            DateEnd(K) = LineInput(1)
            Transport(K) = LineInput(1)
            Price(K) = LineInput(1)
            K += 1
        Loop
        FileClose(1)
        I = 0
        cmbContinent.SelectedIndex = 0
        cmbContinentRez.SelectedIndex = 0
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
        lblDestinationInfoRez.Text = String.Format("Описание: {1}{0}Начална дата: {2:d}{0}Крайна дата: {3:d}{0}Дни: {4}{0}Вид транспорт: {5}{0}Цена: {6:c}", vbNewLine, Description(I), DateBegin(I), DateEnd(I), Days(I), Transport(I), Price(I))
    End Sub

    Private Sub lboxReservations_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
