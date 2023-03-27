Option Strict On
Option Explicit On

Public Class frmCatering
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Set up the form for default of pre-pay checked, Gourmet cheese checked and Loyalty Point input as focus (no payment information shown yet)
        radPrePay.Checked = True
        radGourmet.Checked = True
        txtPoints.Clear()
        lblPayTotal.Text = ""
        radPinwheel.Checked = False
        radVeggie.Checked = False
        radFruit.Checked = False
        radSausageNCheese.Checked = False
        radPickup.Checked = False
        txtPoints.Focus()
    End Sub

    Private Sub frmCatering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Same as button clear
        btnClear.PerformClick()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Set up variables needed to compute payment and build our payment string
        Dim intPoints As Integer
        Dim decDiscount As Decimal
        Dim cdecDiscPercentage As Decimal = 5D
        Dim decCost As Decimal
        Dim strPlatter As String = ""
        Dim strPayment As String = ""
        Dim strLoyalty As String = ""
        Dim cdecGourmet As Decimal = 49.99D
        Dim cdecPinwheel As Decimal = 59.99D
        Dim cdecVeggie As Decimal = 29.99D
        Dim cdecSausage As Decimal = 49.99D
        Dim cdecFruit As Decimal = 29.99D

        If (IsNumeric(txtPoints.Text.ToString())) Then
            'Determine if user entered anything in the loyalty point box that isn't valid
            intPoints = Convert.ToInt32(txtPoints.Text)
            strLoyalty = " after discount of " + intPoints.ToString() + " loyalty points."
            If (intPoints >= 0) Then
                'If the points entered is negative, let the user know to try again
                'Build up the payment string (and get the cost) through a series of if statments dependent on the radio buttons
                If radGourmet.Checked Then
                    decCost = cdecGourmet
                    strPlatter = "Gourmet Cheese platter"
                ElseIf radPinwheel.Checked Then
                    decCost = cdecPinwheel
                    strPlatter = "Pinwheel Wrap platter"
                ElseIf radVeggie.Checked Then
                    decCost = cdecVeggie
                    strPlatter = "Veggie platter"
                ElseIf radSausageNCheese.Checked Then
                    decCost = cdecSausage
                    strPlatter = "Sausage and Cheese platter"
                ElseIf radFruit.Checked Then
                    decCost = cdecFruit
                    strPlatter = "Fruit platter"
                End If

                If radPrePay.Checked Then
                    'build up the payment string depending on payment radio buttons
                    strPayment = " using Pre-Pay"
                ElseIf radPickup.Checked Then
                    strPayment = " with Payment upon Pickup"
                End If

                'calculate the discount given
                intPoints = Convert.ToInt32(intPoints / 10I)

                decDiscount = (intPoints * cdecDiscPercentage) / 100

                'Max discount is 100% off
                If decDiscount > 1 Then
                    decDiscount = 1
                End If

                'Total cost
                decCost = decCost * (1 - decDiscount)

                'Our payment string being built and displayed in the correct label
                lblPayTotal.Text = "Your order " + strPlatter + " costs " + decCost.ToString("C") + strPayment + strLoyalty
            Else
                MsgBox("Please enter a positive loyalty point balance.",, "Invalid Point Balance")
                btnClear.PerformClick()
            End If
        Else
            MsgBox("Please enter a numeric value for your loyalty point balance.",, "Invalid input")
            btnClear.PerformClick()
        End If
    End Sub
End Class
