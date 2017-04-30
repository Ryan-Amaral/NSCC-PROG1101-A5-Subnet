Option Strict On

Imports SubnetCalcLibrary.SubnetCalcLib
Imports System.IO

''' <summary>
''' A variety of subnet calculations results can be displayed with this class
''' </summary>
''' <remarks></remarks>
Public Class FormSubnetCalculator

    'store all of the text boxes in an appropriate order
    Dim netTextBoxes(11) As TextBox

    'store these so blanked text boxes don't change saving file
    Dim ipAddressStore As String
    Dim hostsPerSubnetStore As Integer

    ''' <summary>
    ''' Fill the textbox array at startup.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub FormSubnetCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateTextBoxArray()

    End Sub

    ''' <summary>
    ''' Load the text boxes into an array for easy indexing.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PopulateTextBoxArray()

        netTextBoxes(0) = TextBoxInputNetworkAddress
        netTextBoxes(1) = TextBoxInputHostsPerSubnet
        netTextBoxes(2) = TextBoxCalculatedSubnetSize
        netTextBoxes(3) = TextBoxDecimalOctets
        netTextBoxes(4) = TextBoxDecimalAddress
        netTextBoxes(5) = TextBoxBinaryOctets
        netTextBoxes(6) = TextBoxHexOctets
        netTextBoxes(7) = TextBoxNetworkClass
        netTextBoxes(8) = TextBoxIpAddresses
        netTextBoxes(9) = TextBoxSubnetMask
        netTextBoxes(10) = TextBoxBinaryMask
        netTextBoxes(11) = TextBoxSubnets

    End Sub

    ''' <summary>
    ''' Open a saved results text file.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        If OpenFileDialogSubnetForm.ShowDialog = Windows.Forms.DialogResult.OK Then
            OpenFile(OpenFileDialogSubnetForm.FileName)
        End If

    End Sub

    ''' <summary>
    ''' Save results to a text file.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click

        If SaveFileDialogSubnetForm.ShowDialog = Windows.Forms.DialogResult.OK Then
            SaveFile(SaveFileDialogSubnetForm.FileName)
        End If

    End Sub

    ''' <summary>
    ''' Quit the application.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Application.Exit()

    End Sub

    ''' <summary>
    ''' Loads contents of a file to the application.
    ''' </summary>
    ''' <param name="filePath"></param>
    ''' <remarks></remarks>
    Private Sub OpenFile(filePath As String)

        Dim reader As StreamReader = File.OpenText(filePath)

        'put contents of the text file into the text boxes
        For index = 0 To 11
            netTextBoxes(index).Text = reader.ReadLine
        Next

        'clear the list box
        ListBoxIpRanges.Items.Clear()

        'fill the list box
        While Not reader.EndOfStream
            ListBoxIpRanges.Items.Add(reader.ReadLine)
        End While

        reader.Close()

    End Sub

    ''' <summary>
    ''' Saves contents of the application into a text file
    ''' </summary>
    ''' <param name="filePath"></param>
    ''' <remarks></remarks>
    Private Sub SaveFile(filePath As String)

        Dim writer As StreamWriter = File.CreateText(filePath)

        'instead of saving first two from text boxes, save from variables because the boxes could be erased
        writer.WriteLine(ipAddressStore)
        writer.WriteLine(hostsPerSubnetStore.ToString)

        'put contents of the text boxes into the text file
        For index = 2 To 11
            writer.WriteLine(netTextBoxes(index).Text)
        Next

        'save from the list box
        Dim listAmount As Integer = ListBoxIpRanges.Items.Count

        For itemIndex = 0 To listAmount - 1
            writer.WriteLine(ListBoxIpRanges.Items(itemIndex).ToString)
        Next

        writer.Close()

    End Sub

    ''' <summary>
    ''' Clear all text boxes and list box.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click

        ClearEverything(True)

    End Sub

    ''' <summary>
    ''' Clears all text boxes and the list box.
    ''' </summary>
    ''' <remarks></remarks>
    Sub ClearEverything(clearAll As Boolean)

        Dim clearStart As Integer

        If clearAll = True Then
            clearStart = 0
        Else
            clearStart = 2
        End If

        For index = clearStart To 11
            netTextBoxes(index).Text = vbNullString
        Next

        ListBoxIpRanges.Items.Clear()

    End Sub

    ''' <summary>
    ''' One way of starting all of the network calculations.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CalculateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateToolStripMenuItem.Click

        'go to method to do stuff, unless there is an error in the amount of hosts
        If IsNumeric(TextBoxInputHostsPerSubnet.Text) And TextBoxInputHostsPerSubnet.Text.Length < 9 Then
            FillAllTheBoxes(TextBoxInputNetworkAddress.Text, Convert.ToInt32(TextBoxInputHostsPerSubnet.Text))
        Else
            ClearEverything(False)
            MessageBox.Show("Number of hosts must be a valid number", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    ''' <summary>
    ''' One way of starting all of the network calculations.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click

        'go to method to do stuff, unless there is an error in the amount of hosts
        If IsNumeric(TextBoxInputHostsPerSubnet.Text) And TextBoxInputHostsPerSubnet.Text.Length < 9 Then
            FillAllTheBoxes(TextBoxInputNetworkAddress.Text, Convert.ToInt32(TextBoxInputHostsPerSubnet.Text))
        Else
            ClearEverything(False)
            MessageBox.Show("Number of hosts must be a valid number", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    ''' <summary>
    ''' Fill all of the text boxes and list box with information.
    ''' </summary>
    ''' <remarks></remarks>
    Sub FillAllTheBoxes(ipAddress As String, numberOfHostsPerSubnet As Integer)

        Dim subnetLib As New SubnetCalcLibrary.SubnetCalcLib

        'check for valid input of ip address first first
        If subnetLib.IsValidIpAddress(ipAddress) Then

            'get network class
            Dim netClass As String = subnetLib.CalculateNetworkClass(ipAddress)

            If subnetLib.IsValidHostsPerSubnet(numberOfHostsPerSubnet, netClass) Then

                'save values in variables
                ipAddressStore = TextBoxInputNetworkAddress.Text
                hostsPerSubnetStore = Convert.ToInt32(TextBoxInputHostsPerSubnet.Text)

                'at this point inputs are good, now calculations

                TextBoxCalculatedSubnetSize.Text = subnetLib.CalculateSubnetSize(numberOfHostsPerSubnet).ToString
                TextBoxDecimalOctets.Text = subnetLib.CalculateDecimalOctets(ipAddress)
                TextBoxDecimalAddress.Text = subnetLib.CalculateDecimalAddress(ipAddress).ToString
                TextBoxBinaryOctets.Text = subnetLib.CalculateBinaryAddress(ipAddress).ToString
                TextBoxHexOctets.Text = subnetLib.CalculateHexAddress(ipAddress)
                TextBoxNetworkClass.Text = netClass
                TextBoxIpAddresses.Text = subnetLib.CalculateNumberOfIPAddresses(ipAddress).ToString
                TextBoxSubnetMask.Text = subnetLib.CalculateSubnetMask(numberOfHostsPerSubnet)
                TextBoxBinaryMask.Text = subnetLib.CalculateBinaryMask(numberOfHostsPerSubnet)
                TextBoxSubnets.Text = subnetLib.CalculateNumberOfSubnets(ipAddress, numberOfHostsPerSubnet).ToString

                ListBoxIpRanges.Items.Clear()
                ListBoxIpRanges.Items.AddRange(subnetLib.CalculateSubnetList(ipAddress, numberOfHostsPerSubnet))

            Else
                ClearEverything(False)
                MessageBox.Show("Number of hosts is invalid for this class of network", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ClearEverything(False)
            MessageBox.Show("IP address must be a valid IPv4 address", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

End Class
