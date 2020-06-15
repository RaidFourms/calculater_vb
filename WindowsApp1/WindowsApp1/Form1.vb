Public Class Form1
    Dim FirstNum As Decimal
    Dim SecondNum As Decimal
    Dim Operator_Selector As Boolean = False
    Dim operations As Integer







    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Console.WriteLine("Hello")
    End Sub


    ''
    ''Start of number button
    ''


    Private Sub BtnNum0_Click(sender As Object, e As EventArgs) Handles BtnNum0.Click
        If MainBox.Text <> "0" Then
            MainBox.Text += "0"
        Else
            MainBox.Text = "0"
        End If

    End Sub
    Private Sub BtnNum1_Click(sender As Object, e As EventArgs) Handles BtnNum1.Click
        If MainBox.Text <> "0" Then
            MainBox.Text += "1"
        Else
            MainBox.Text = "1"
        End If
    End Sub
    Private Sub BtnNum2_Click(sender As Object, e As EventArgs) Handles BtnNum2.Click
        If MainBox.Text <> "0" Then
            MainBox.Text += "2"
        Else
            MainBox.Text = "2"
        End If
    End Sub

    Private Sub BtnNum3_Click(sender As Object, e As EventArgs) Handles BtnNum3.Click
        If MainBox.Text <> "0" Then
            MainBox.Text += "3"
        Else
            MainBox.Text = "3"
        End If
    End Sub
    Private Sub BtnNum4_Click(sender As Object, e As EventArgs) Handles BtnNum4.Click
        If MainBox.Text <> "0" Then
            MainBox.Text += "4"
        Else
            MainBox.Text = "4"
        End If
    End Sub

    Private Sub BtnNum5_Click(sender As Object, e As EventArgs) Handles BtnNum5.Click
        If MainBox.Text <> "0" Then
            MainBox.Text += "5"
        Else
            MainBox.Text = "5"
        End If
    End Sub

    Private Sub BtnNum6_Click(sender As Object, e As EventArgs) Handles BtnNum6.Click
        If MainBox.Text <> "0" Then
            MainBox.Text += "6"
        Else
            MainBox.Text = "6"
        End If
    End Sub

    Private Sub BtnNum7_Click(sender As Object, e As EventArgs) Handles BtnNum7.Click
        If MainBox.Text <> "0" Then
            MainBox.Text += "7"
        Else
            MainBox.Text = "7"
        End If
    End Sub

    Private Sub BtnNum8_Click(sender As Object, e As EventArgs) Handles BtnNum8.Click
        If MainBox.Text <> "0" Then
            MainBox.Text += "8"
        Else
            MainBox.Text = "8"
        End If
    End Sub

    Private Sub BtnNum9_Click(sender As Object, e As EventArgs) Handles BtnNum9.Click
        If MainBox.Text <> "0" Then
            MainBox.Text += "9"
        Else
            MainBox.Text = "9"
        End If
    End Sub
    ''
    ''






    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)
        Form2.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        AboutBox1.Show()
    End Sub
    ''
    ''
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Name - Oliver's Calculator RE-WRITE; Hash - "
        Label2.AppendText(My.Application.GetHashCode)

        Label2.AppendText(";" + vbNewLine + " OS Edition - ")
        Label2.AppendText(My.Computer.Info.OSFullName)

    End Sub

    Private Sub BtnDecimal_Click(sender As Object, e As EventArgs) Handles BtnDecimal.Click
        If Not (MainBox.Text.Contains(".")) Then
            MainBox.Text += "."
        End If
    End Sub

    Private Sub BtnPlus_Click(sender As Object, e As EventArgs) Handles BtnPlus.Click
        FirstNum = MainBox.Text
        MainBox.Text = "0"
        Operator_Selector = True
        operations = 1 '=1
        BtnPi.Enabled = True
    End Sub

    Private Sub BtnMinus_Click(sender As Object, e As EventArgs) Handles BtnMinus.Click
        FirstNum = MainBox.Text
        MainBox.Text = "0"
        Operator_Selector = True
        operations = 2 ' =-
        BtnPi.Enabled = True
    End Sub

    Private Sub BtnTimes_Click(sender As Object, e As EventArgs) Handles BtnTimes.Click
        Try
            FirstNum = MainBox.Text
        Catch
        End Try
        MainBox.Text = "0"
        Operator_Selector = True
        operations = 3 ' =*
        BtnPi.Enabled = True
    End Sub

    Private Sub BtnDivision_Click(sender As Object, e As EventArgs) Handles BtnDivision.Click
        FirstNum = MainBox.Text
        MainBox.Text = "0"
        Operator_Selector = True
        operations = 4 ' /
        BtnPi.Enabled = True
    End Sub

    Private Sub BtnEquals_Click(sender As Object, e As EventArgs) Handles BtnEquals.Click

        If Operator_Selector = True Then
            SecondNum = MainBox.Text

            If operations = 1 Then
                MainBox.Text = FirstNum + SecondNum
            ElseIf operations = 2 Then
                MainBox.Text = FirstNum - SecondNum
            ElseIf operations = 3 Then
                MainBox.Text = FirstNum * SecondNum
            Else
                '
                If SecondNum = 0 Then
                    MainBox.Text = "Error"
                Else
                    MainBox.Text = FirstNum / SecondNum

                End If
                '
                Operator_Selector = False
            End If
        End If
        BtnPi.Enabled = True
    End Sub



    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Operator_Selector = False
        operations = 0
        MainBox.Text = ""
    End Sub

    Private Sub BtnPi_Click(sender As Object, e As EventArgs) Handles BtnPi.Click


        If MainBox.Text <> "0" Then
            MainBox.Text += "3.1415926535"
        Else
            MainBox.Text = "3.1415926535"
        End If
        BtnPi.Enabled = False
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

    End Sub




    ''
    ''



End Class
