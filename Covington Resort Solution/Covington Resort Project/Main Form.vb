' Name:         Covington Resort Project
' Purpose:      Display the total room charge, tax, 
'               total resort fee, and total due
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtRooms_Enter(sender As Object, e As EventArgs) Handles txtRooms.Enter
        txtRooms.SelectAll()
    End Sub

    Private Sub txtAdults_Enter(sender As Object, e As EventArgs) Handles txtAdults.Enter
        txtAdults.SelectAll()
    End Sub

    Private Sub txtNights_Enter(sender As Object, e As EventArgs) Handles txtNights.Enter
        txtNights.SelectAll()
    End Sub

    Private Sub txtChildren_Enter(sender As Object, e As EventArgs) Handles txtChildren.Enter
        txtChildren.SelectAll()
    End Sub

    Private Sub onlyyou(sender As Object, e As KeyPressEventArgs) Handles txtAdults.KeyPress,
        txtChildren.KeyPress, txtNights.KeyPress, txtRooms.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) _
        Handles txtRooms.TextChanged, txtNights.TextChanged,
        txtAdults.TextChanged, txtChildren.TextChanged
        ' clear calculated amounts

        lblRoomChg.Text = String.Empty
        lblTax.Text = String.Empty
        lblResortFee.Text = String.Empty
        lblTotalDue.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const intMAX_PER_ROOM As Integer = 6
        Const intDAILY_ROOM_CHG As Integer = 284
        Const dblTAX_RATE As Decimal = 0.1525D
        Const intDAILY_RESORT_REE As Integer = 15
        Const strMSG As String = "You have exceeded the maximum guests per room."

        Dim intRoomsReserved As Integer
        Dim intNights As Integer
        Dim intAdults As Integer
        Dim intChildren As Integer
        Dim intNumGuests As Integer
        Dim dblRoomsRequired As Double
        Dim intTotalRoomChg As Integer
        Dim dblTax As Double
        Dim intTotalResortFree As Integer
        Dim dblTotalDue As Double

        Integer.TryParse(txtRooms.Text, intRoomsReserved)
        Integer.TryParse(txtNights.Text, intNights)
        Integer.TryParse(txtAdults.Text, intAdults)
        Integer.TryParse(txtChildren.Text, intChildren)
        intNumGuests = intAdults + intChildren
        dblRoomsRequired = intNumGuests / intMAX_PER_ROOM

        If intRoomsReserved < dblRoomsRequired Then
            MessageBox.Show(strMSG, "Convingtion Resort",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Else
            intTotalRoomChg = intRoomsReserved * intNights * intDAILY_ROOM_CHG
            dblTax = intTotalRoomChg * dblTAX_RATE
            intTotalResortFree = intRoomsReserved * intNights * intDAILY_RESORT_REE
            dblTotalDue = intTotalRoomChg + dblTax + intTotalResortFree

            lblRoomChg.Text = intTotalRoomChg.ToString("N2")
            lblTax.Text = dblTax.ToString("N2")
            lblResortFee.Text = intTotalResortFree.ToString("N2")
            lblTotalDue.Text = dblTotalDue.ToString("C2")
        End If

    End Sub

    
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
