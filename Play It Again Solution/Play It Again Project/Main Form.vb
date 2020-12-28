Option Explicit On
Option Infer Off
Option Strict On

' Name:         Play It Again Project
' Purpose:      Calculates the total number
'               of discs sold and the total
'               sales amount
' Programmer:   <your name> on <current date>

Public Class frmMain
    Dim strClerk As String

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare screen for the next sale

        txtDvds.Text = String.Empty
        txtBluRays.Text = String.Empty
        lblTotalDiscs.Text = String.Empty
        lblTotalSales.Text = String.Empty
        lblMessage.Text = String.Empty
        ' send the focus to the DVDs box
        txtDvds.Focus()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' print the sales receipt

        Me.Width = Me.Width - 165
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
        Me.Width = Me.Width + 165

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate number of discs sold and total sales
        Const decDISC_PRICE As Decimal = 7D
        Const decTAX_RATE As Decimal = 0.03D
        Dim intDvds As Integer
        Dim intBluRays As Integer
        Dim intTotalDiscs As Integer
        Dim decSubtotal As Decimal
        Dim decSalesTax As Decimal
        Dim decTotalSales As Decimal

        Integer.TryParse(txtDvds.Text, intDvds)
        Integer.TryParse(txtBluRays.Text, intBluRays)
        intTotalDiscs = intDvds + intBluRays
        decSubtotal = intTotalDiscs * decDISC_PRICE
        decSalesTax = decSubtotal * decTAX_RATE
        decTotalSales = decSubtotal + decSalesTax
        lblTotalDiscs.Text = Convert.ToString(intTotalDiscs)
        lblTotalSales.Text = decTotalSales.ToString("C2")
        lblMessage.Text = "The sales tax was " & Convert.ToString(decSalesTax) & "." &
            ControlChars.NewLine & strClerk



    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Const strPROMPT As String = "Salescleck's name:"
        Const strTITLE As String = "Name Entry"
        strClerk = InputBox(strPROMPT, strTITLE)
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles _
        txtDvds.TextChanged, txtBluRays.TextChanged
        lblTotalDiscs.Text = String.Empty
        lblTotalSales.Text = String.Empty
        lblMessage.Text = String.Empty

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblText_Link.Click
        lblText_Link.Text = "Icons made by <a href='https://www.flaticon.com/authors/darius-dan'>Darius Dan</a> 
from <a href='https://www.flaticon.com/'> www.flaticon.com</a>"

    End Sub

    Private Sub LinkLabel_Darius_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_Darius.LinkClicked
        LinkLabel_Darius.LinkVisited = True
        System.Diagnostics.Process.Start("https://www.flaticon.com/authors/darius-dan")
    End Sub
End Class
