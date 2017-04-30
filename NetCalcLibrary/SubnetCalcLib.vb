Option Strict On

''' <summary>
''' A bunch of functions to help with subnetting
''' </summary>
''' <remarks></remarks>
Public Class SubnetCalcLib

    'for determining class
    Private Const FAIL As String = "F"
    Private Const CLASS_A As String = "A"
    Private Const CLASS_B As String = "B"
    Private Const CLASS_C As String = "C"

    'maximum amount of hosts for each class
    Private Const CLASS_A_MAX_HOSTS As Integer = 16777214
    Private Const CLASS_B_MAX_HOSTS As Integer = 65534
    Private Const CLASS_C_MAX_HOSTS As Integer = 254

    'counters to know when to update the next octet, like digits
    Const OCTET_UPDATER As Integer = 256

    ''' <summary>
    ''' Determines weather the enterd ip address is a valid class A, B, or C network.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsValidIpAddress(ipAddress As String) As Boolean

        Dim splitIp() As String = ipAddress.Split("."c)

        'must have four octets, and total lenght must be less than 16
        If splitIp.Length = 4 And ipAddress.Length < 16 Then

            'each character must be numeric
            For octet = 0 To 3
                For character = 0 To splitIp(octet).Length - 1
                    If character = 3 Then
                        Return False
                    Else
                        If Not IsNumeric(splitIp(character)) Then
                            Return False
                        End If
                    End If
                Next
            Next

            'see if ip address is valid class
            If CalculateNetworkClass(ipAddress) = FAIL Then
                Return False
            End If

            'after rigerous testing, this ip address is deemed valid
            Return True

        Else
            Return False
        End If

    End Function

    ''' <summary>
    ''' Amount of hosts requested must be atleast one, and fit within the network class
    ''' </summary>
    ''' <param name="requestedHosts"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsValidHostsPerSubnet(requestedHosts As Integer, networkClass As String) As Boolean

        'only accept requests with more than one host, because 0 is imposible, even one is pointless but whatever
        If requestedHosts < 1 Then
            Return False
        End If

        'maximum allowed based on which class
        Dim hostCap As Integer = 0

        If networkClass = CLASS_A Then
            hostCap = CLASS_A_MAX_HOSTS
        ElseIf networkClass = CLASS_B Then
            hostCap = CLASS_B_MAX_HOSTS
        ElseIf networkClass = CLASS_C Then
            hostCap = CLASS_C_MAX_HOSTS
        End If

        'see if the rquested hosts is the appropriate amount
        If hostCap < requestedHosts Then
            Return False
        Else
            Return True
        End If

    End Function

    ''' <summary>
    ''' Calculate the power of two size that fits the required amount of hosts.
    ''' </summary>
    ''' <param name="numberOfHostsPerSubnet"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CalculateSubnetSize(numberOfHostsPerSubnet As Integer) As Integer

        'the subnet size each loop through
        Dim curSubnetSize As Integer = 4

        Do While curSubnetSize < numberOfHostsPerSubnet + 2
            curSubnetSize = curSubnetSize * 2
        Loop

        Return curSubnetSize

    End Function

    ''' <summary>
    ''' Calculate the network address as decimal octets.
    ''' </summary>
    ''' <param name="ipAddress"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CalculateDecimalOctets(ipAddress As String) As String

        'I really don't get how else this function would work
        Return ipAddress

    End Function

    ''' <summary>
    ''' Calculate the network address as decimal octets and return numeric values in an array.
    ''' </summary>
    ''' <param name="ipAddress"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CalculateDecimalOctetNumbers(ipAddress As String) As Integer()

        'the octets in base 10
        Dim decOctets(3) As Integer

        'the split ip address
        Dim splitIpAddress() As String = ipAddress.Split("."c)

        For index = 0 To 3
            decOctets(index) = Convert.ToInt16(splitIpAddress(index))
        Next

        Return decOctets

    End Function

    ''' <summary>
    ''' Calculates the sum of all binary digits in the address and represents the answer in decimal notation.
    ''' </summary>
    ''' <param name="ipAddress"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CalculateDecimalAddress(ipAddress As String) As Long

        'get the binary ip address and remove all zeros
        Dim binaryipAddress As String = CalculateBinaryAddress(ipAddress).Replace("."c, vbNullString)

        'store the running total
        Dim decAddress As Long = 0

        'value gets divided by two each loop
        Dim curValue As Long = 2147483648

        'if the binary digit is one add curValue to decAddress
        For index = 0 To 31
            If binaryipAddress.Substring(index, 1) = "1" Then
                decAddress += curValue
            End If
            curValue = curValue \ 2
        Next

        Return decAddress

    End Function

    ''' <summary>
    ''' Calculate the network address as binary octets.
    ''' </summary>
    ''' <param name="ipAddress"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CalculateBinaryAddress(ipAddress As String) As String

        Dim decIpAddressOctets As Integer() = CalculateDecimalOctetNumbers(ipAddress)

        'store the ip address in binary
        Dim binaryIpAddress As String = vbNullString

        'the number to be halfed each time
        Dim halfableNumber As Integer

        For octet = 0 To 3

            'halfable number starts at 128 for each octet
            halfableNumber = 128

            For binaryDigit = 0 To 7

                'add one or zero to binary ip
                If decIpAddressOctets(octet) >= halfableNumber Then
                    binaryIpAddress &= "1"
                    decIpAddressOctets(octet) -= halfableNumber
                Else
                    binaryIpAddress &= "0"
                End If

                'halfable number gets halved except for on last binary digit
                If binaryDigit < 7 Then
                    halfableNumber = halfableNumber \ 2
                End If

            Next

            If octet <> 3 Then
                'add the dots between octets
                binaryIpAddress &= "."
            End If

        Next

        Return binaryIpAddress

    End Function

    ''' <summary>
    ''' calculate the network address as hex octets.
    ''' </summary>
    ''' <param name="ipAddress"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CalculateHexAddress(ipAddress As String) As String

        Dim decIpAddressOctets = CalculateDecimalOctetNumbers(ipAddress)

        Dim hexIpAddress As String = vbNullString

        'convert each octet to a hex value
        For octet = 0 To 3
            hexIpAddress &= decIpAddressOctets(octet).ToString("X2")
            If octet <> 3 Then
                hexIpAddress &= "."
            End If
        Next

        Return hexIpAddress

    End Function

    ''' <summary>
    ''' Calculate the networks class, A, B, or C.
    ''' </summary>
    ''' <param name="ipAddress"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CalculateNetworkClass(ipAddress As String) As String

        Dim decIpAddressOctets() As Integer = CalculateDecimalOctetNumbers(ipAddress)

        'big messy web of determining which class the ip address is appropriate for
        If decIpAddressOctets(0) < 128 And decIpAddressOctets(0) <> 127 And decIpAddressOctets(1) = 0 And decIpAddressOctets(2) = 0 And decIpAddressOctets(3) = 0 Then 'class A
            Return CLASS_A
        ElseIf decIpAddressOctets(0) < 192 And decIpAddressOctets(1) <= 255 And decIpAddressOctets(2) = 0 And decIpAddressOctets(3) = 0 Then 'Class B
            Return CLASS_B
        ElseIf decIpAddressOctets(0) < 224 And decIpAddressOctets(1) <= 255 And decIpAddressOctets(2) <= 255 And decIpAddressOctets(3) = 0 Then 'Class C
            Return CLASS_C
        Else
            Return FAIL
        End If

    End Function

    ''' <summary>
    ''' Calculates the total number of available ip addresses in the network.
    ''' </summary>
    ''' <param name="networkIPAddress"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CalculateNumberOfIPAddresses(networkIPAddress As String) As Integer

        Dim numberOfIpAddresses As Integer

        'each class has its own amount of assignable ip addresses, all of them are the max amount of
        'hosts allowed plus two
        If CalculateNetworkClass(networkIPAddress) = CLASS_A Then
            numberOfIpAddresses = CLASS_A_MAX_HOSTS + 2
        ElseIf CalculateNetworkClass(networkIPAddress) = CLASS_B Then
            numberOfIpAddresses = CLASS_B_MAX_HOSTS + 2
        ElseIf CalculateNetworkClass(networkIPAddress) = CLASS_C Then
            numberOfIpAddresses = CLASS_C_MAX_HOSTS + 2
        End If

        Return numberOfIpAddresses

    End Function

    ''' <summary>
    ''' Calculates the appropriate subnet mask as both dotted decimal notation and cidr notation.
    ''' </summary>
    ''' <param name="numberOfHostsPerSubnet"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CalculateSubnetMask(numberOfHostsPerSubnet As Integer) As String

        'the mask in cidr notation
        Dim cidrMask As Integer = CalculateCidrSubnetMask(numberOfHostsPerSubnet)

        'the Dec subnet mask i.e. 0-255 per octet
        Dim decSubnetMask(3) As Integer

        'the amount to add to and half to get correct subnet mask octet
        Dim octetAddAmount As Integer = 128

        'start with the 255s, and build from there
        If cidrMask >= 8 And cidrMask < 16 Then
            decSubnetMask(0) = 255
            decSubnetMask(1) = GetSubnetOctet(cidrMask - 8)
            decSubnetMask(2) = 0
            decSubnetMask(3) = 0
        ElseIf cidrMask >= 16 And cidrMask < 24 Then
            decSubnetMask(0) = 255
            decSubnetMask(1) = 255
            decSubnetMask(2) = GetSubnetOctet(cidrMask - 16)
            decSubnetMask(3) = 0
        ElseIf cidrMask >= 24 Then
            decSubnetMask(0) = 255
            decSubnetMask(1) = 255
            decSubnetMask(2) = 255
            decSubnetMask(3) = GetSubnetOctet(cidrMask - 24)
        End If

        'the result, dec subnet mask plus cidr notaton
        Dim theSubnetMask As String = decSubnetMask(0).ToString & "." & decSubnetMask(1).ToString & "." & _
            decSubnetMask(2).ToString & "." & decSubnetMask(3).ToString & " or /" & cidrMask.ToString

        Return theSubnetMask

    End Function

    ''' <summary>
    ''' Calculates an octet that may not be 255 or 0.
    ''' </summary>
    ''' <param name="octetOfset"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetSubnetOctet(octetOfset As Integer) As Integer

        Dim theOctet As Integer = 0

        'the number to half after each pass
        Dim halfableNumber As Integer = 128

        'octet stays zero, if the offset is not zero
        If octetOfset > 0 Then
            For index = (8 - octetOfset) To 7
                theOctet += halfableNumber
                halfableNumber = halfableNumber \ 2
            Next
        End If

        Return theOctet

    End Function

    ''' <summary>
    ''' Calculates the cidr notation subnet mask.
    ''' </summary>
    ''' <param name="numberOfHostsPerSubnet"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CalculateCidrSubnetMask(numberOfHostsPerSubnet As Integer) As Integer

        'get the size of the subnet
        Dim subnetSize As Integer = CalculateSubnetSize(numberOfHostsPerSubnet)

        'subnet mask in cidr is 32 - n, where n is the exponent of 2 to get the subnet size
        Dim subtractFrom32 As Integer = 0

        While subnetSize > 1
            subnetSize = subnetSize \ 2
            subtractFrom32 += 1
        End While

        'the mask in cidr notation
        Dim cidrMask As Integer = 32 - subtractFrom32

        Return cidrMask

    End Function

    ''' <summary>
    ''' Calculate the binary octets of the subnet mask.
    ''' </summary>
    ''' <param name="numberOfHostsPerSubnet"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CalculateBinaryMask(numberOfHostsPerSubnet As Integer) As String

        Dim binaryMask As String = vbNullString

        'we need this to index through binary digits
        Dim cidrMask As Integer = CalculateCidrSubnetMask(numberOfHostsPerSubnet)

        For digit = 1 To 32
            If digit <= cidrMask Then
                binaryMask &= "1"
            Else
                binaryMask &= "0"
            End If
            If digit Mod 8 = 0 And digit <> 32 Then
                binaryMask &= "."
            End If
        Next

        Return binaryMask

    End Function

    ''' <summary>
    ''' Calculates how many subnets could be made.
    ''' </summary>
    ''' <param name="ipAddress"></param>
    ''' <param name="numberOfHostsPerSubnet"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CalculateNumberOfSubnets(ipAddress As String, _
                                             numberOfHostsPerSubnet As Integer) As Integer

        'get real subnet size
        Dim realSubnetSize = CalculateSubnetSize(numberOfHostsPerSubnet)

        'get the max amount of subnets for the class
        Dim maxSubnetsInClass As Integer

        Dim netClass As String = CalculateNetworkClass(ipAddress)

        If netClass = CLASS_A Then
            maxSubnetsInClass = CLASS_A_MAX_HOSTS + 2
        ElseIf netClass = CLASS_B Then
            maxSubnetsInClass = CLASS_B_MAX_HOSTS + 2
        ElseIf netClass = CLASS_C Then
            maxSubnetsInClass = CLASS_C_MAX_HOSTS + 2
        End If

        'amount of subnets is the max amount of possible subnets divided by the power of two subnet size
        Dim numberOfSubnets As Integer = Convert.ToInt32(maxSubnetsInClass / realSubnetSize)

        Return numberOfSubnets

    End Function

    ''' <summary>
    ''' List all of the ranges of ip addresses that could be used. One range per subnet.
    ''' </summary>
    ''' <param name="ipAddress"></param>
    ''' <param name="numberOfHostsPerSubnet"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CalculateSubnetList(ipAddress As String, _
                                        numberOfHostsPerSubnet As Integer) As String()

        'first we need to know how many subnets and the size of them
        Dim numberOfSubnets = CalculateNumberOfSubnets(ipAddress, numberOfHostsPerSubnet)
        Dim subnetSize = CalculateSubnetSize(numberOfHostsPerSubnet)

        Dim subnetList(numberOfSubnets - 1) As String

        'the initial ip address to start with
        Dim decIpAddressOctets() As Integer = CalculateDecimalOctetNumbers(ipAddress)

        For rangeIndex = 0 To numberOfSubnets - 1

            'first part of each range is the starting ip address
            subnetList(rangeIndex) = decIpAddressOctets(0) & "." & decIpAddressOctets(1) & "." & _
                decIpAddressOctets(2) & "." & decIpAddressOctets(3) & " - "

            'do crazy octet math to get the end of the range
            decIpAddressOctets = NetworkOctetAdding(decIpAddressOctets, subnetSize, False)

            'second part of each range is updated ip address
            subnetList(rangeIndex) &= decIpAddressOctets(0) & "." & decIpAddressOctets(1) & "." & _
                decIpAddressOctets(2) & "." & decIpAddressOctets(3)

            'setup the ip address to be good for next loop
            decIpAddressOctets = NetworkOctetAdding(decIpAddressOctets, 1, True)

        Next

        Return subnetList

    End Function

    ''' <summary>
    ''' Handles the complex adding with octets.
    ''' </summary>
    ''' <param name="decIpAddress"></param>
    ''' <param name="amountToAdd"></param>
    ''' <param name="isStartOfRange"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function NetworkOctetAdding(decIpAddress() As Integer, amountToAdd As Integer, isStartOfRange As Boolean) As Integer()

        'determines weather to trickle left-over numbers
        Dim trickle As Boolean

        'stores the amount to carry over to the next octet in case of trickle
        Dim carryOver As Integer

        'add the amount to each octet, starting from last, and then trickles the left-overs to the left
        decIpAddress(3) += amountToAdd
        If isStartOfRange = False Then
            If decIpAddress(3) - 1 >= OCTET_UPDATER Then
                decIpAddress(3) = OCTET_UPDATER - 1
                If amountToAdd > OCTET_UPDATER Then
                    trickle = True
                    carryOver = (amountToAdd \ OCTET_UPDATER) - 1
                End If
            Else
                decIpAddress(3) -= 1
                trickle = False
            End If
        Else
            If decIpAddress(3) >= OCTET_UPDATER Then
                decIpAddress(3) = 0
                trickle = True
                carryOver = 1
            End If
        End If

        If trickle = True Then
            decIpAddress(2) += carryOver
            If decIpAddress(2) >= OCTET_UPDATER Then
                decIpAddress(2) = OCTET_UPDATER - 1
                If carryOver > OCTET_UPDATER Then
                    trickle = True
                    carryOver = (carryOver \ OCTET_UPDATER)
                Else
                    trickle = True
                    carryOver = 1
                    decIpAddress(2) = 0
                End If
            Else
                trickle = False
            End If
        End If

        If trickle = True Then
            decIpAddress(1) += carryOver
        End If

        Return decIpAddress

        'this function hurt

    End Function

End Class
