Public Class ShippingSchedule
    Dim w As IO.StreamWriter
    Dim r As IO.StreamReader

    'TEXTBOX VARIABLES
    Dim d As String = Nothing
    Dim wo As String = Nothing
    Dim job As String = Nothing
    Dim deck As String = Nothing


    'ADD TEXT TO LISTBOX
    Private Sub addItem_Click(sender As System.Object, e As System.EventArgs) Handles addItem.Click
        Dim selectedIndex As Integer
        selectedIndex = ListBox1.SelectedIndex
        ListBox1.Items.Insert(selectedIndex + 1, tbAddText.Text)
        'SHOW RED SAVE BUTTON
        changesMade()
    End Sub

    'REMOVE TEXT FROM LISTBOX
    Private Sub deleteItem_Click(sender As System.Object, e As System.EventArgs) Handles deleteItem.Click
        Try
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        Catch
            MessageBox.Show("PLEASE SELECT AN ITEM TO DELETE")
        End Try
        'SHOW RED SAVE BUTTON
        changesMade()

    End Sub

    'WRITE TEXT TO READABLE FILE
    Private Sub sItems_Click(sender As System.Object, e As System.EventArgs) Handles sItems.Click
        Try
            Dim i As Integer
            w = New IO.StreamWriter("S:\Product Development\Shipping Schedule.txt")
            For i = 0 To ListBox1.Items.Count - 1
                w.WriteLine(ListBox1.Items.Item(i))
            Next
            w.Close()
            'CHANGE SAVE BUTTON BACK TO NORMAL AFTER SAVING
            sItems.ForeColor = Color.Black

        Catch
            MsgBox("ERROR")
        End Try
    End Sub

    'SELECT TEXT AND PUT IN TEXTBOX
    Private Sub lb1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseClick
        tbAddText.Text = ListBox1.SelectedItem

    End Sub


    Private Sub ShippingSchedule_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Read list file
        r = New System.IO.StreamReader("S:\Product Development\Shipping Schedule.txt")
        While (r.Peek() > -1)
            ListBox1.Items.Add(r.ReadLine)
        End While
        r.Close()
       
    End Sub

    'MOVE LISTBOX TEXT UP
    Private Sub btnMoveUp_Click(sender As System.Object, e As System.EventArgs) Handles btnMoveUp.Click

        If ListBox1.SelectedIndex > 0 Then

            Dim I = ListBox1.SelectedIndex - 1

            ListBox1.Items.Insert(I, ListBox1.SelectedItem)

            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)

            ListBox1.SelectedIndex = I

        End If
        changesMade()

    End Sub

    Private Sub btnMoveD_Click(sender As System.Object, e As System.EventArgs) Handles btnMoveD.Click 

        If ListBox1.SelectedIndex < ListBox1.Items.Count - 1 Then

            Dim I = ListBox1.SelectedIndex + 2

            ListBox1.Items.Insert(I, ListBox1.SelectedItem)

            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)

            ListBox1.SelectedIndex = I - 1

        End If
        'SHOW RED SAVE BUTTON
        changesMade()

    End Sub
    'ADD WO TO TEXT IN FIELD
    Private Sub tbwo_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbwo.TextChanged

        wo = "WO# " & tbwo.Text
        emptyTextBox()

    End Sub


    'ADDS TEXT TO MAIN TEXTBOX
    Private Sub tbDate_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbDate.TextChanged

        d = tbDate.Text
        emptyTextBox()

    End Sub
    'ADDS TEXT TO MAIN TEXTBOX
    Private Sub tbjob_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbjob.TextChanged

        job = tbjob.Text
        emptyTextBox()

    End Sub
    'ADDS TEXT TO MAIN TEXTBOX
    Private Sub tbdeck_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbdeck.TextChanged

        deck = tbdeck.Text
        emptyTextBox()

    End Sub

    'CLOSE FORM
    Private Sub btnclose_Click(sender As System.Object, e As System.EventArgs) Handles btnclose.Click
        Close()

    End Sub
    'GETS INDEX AND REMOVES OLD TEXT AND INSERT NEW TEXT
    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        Try
            Dim selectedIndex As Integer
            selectedIndex = ListBox1.SelectedIndex
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            ListBox1.Items.Insert(selectedIndex, tbAddText.Text)
            changesMade()
        Catch
            MessageBox.Show("PLEASE SELECT AN ITEM TO EDIT")
        End Try
    End Sub
    ' GETS RID OF SPACE IN FRONT OF TEXT IF NOTHING IS IN TBDATE.TEXT
    Private Sub emptyTextBox()
        If tbDate.Text = "" Then
            tbAddText.Text = wo & " " & job & " " & deck
        Else
            tbAddText.Text = d & " " & wo & " " & job & " " & deck
        End If
    End Sub
    'MAKE FORECOLOR OF SAVE BUTTON RED
    Private Sub changesMade()
        sItems.ForeColor = Color.Red
    End Sub
End Class
 