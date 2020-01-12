'Vincent Vassallo
'Ohms Law
'Jan 10th 2020



'Voltage (V) = Current (I) * Resistance (R)
'Power(P) = Voltage(V) * Current(I)
Public Class OhmsLaw_Complete
    Private Sub btn_Calculate_Click(sender As Object, e As EventArgs) Handles btn_Calculate.Click
        Dim process = 0
        Dim voltage As Double
        Dim goodCount As Integer = 0
        Const _voltage As Integer = 1
        Dim bGoodVoltage = Double.TryParse(txt_Voltage.Text, voltage)

        Dim current As Double
        Const _current As Integer = 2
        Dim bGoodCurrent = Double.TryParse(txt_Current.Text, current)

        Dim resistance As Double
        Const _resistance As Integer = 4
        Dim bGoodResistance = Double.TryParse(txt_Resistance.Text, resistance)

        Dim power As Double
        Const _power As Integer = 8
        Dim bGoodPower = Double.TryParse(txt_Power.Text, power)

        If bGoodVoltage AndAlso voltage <> 0 Then
            process += _voltage
            goodCount += 1
        End If
        If bGoodCurrent AndAlso current <> 0 Then
            process += _current
            goodCount += 1
        End If
        If bGoodResistance AndAlso resistance <> 0 Then
            process += _resistance
            goodCount += 1
        End If
        If bGoodPower AndAlso power <> 0 Then
            process += _power
            goodCount += 1
        End If


        If goodCount >= 2 Then
            Select Case (process)
                Case _power + _voltage
                    current = CalculateCurrent(power, voltage)
                    resistance = CalculateResistance(voltage, current)
                Case _power + _current
                    voltage = CalculateVoltageFromIoP(current, power)
                    resistance = CalculateResistance(current, power)
                Case _power + _resistance
                    current = CalculateCurrentFromPR(power, resistance)
                    voltage = CalculateVoltageFromIR(current, resistance)
                Case _voltage + _current
                    resistance = CalculateResistance(voltage, current)
                    power = CalculatePower(voltage, current)
                Case _voltage + _resistance
                    current = CalculateCurrentFromVR(voltage, resistance)
                    power = CalculatePower(voltage, current)
                Case _current + _resistance
                    power = CalculatePowerIR(current, resistance)
                    voltage = CalculateVoltageFromIR(current, resistance)
            End Select

            txt_Current.Text = current.ToString()
            txt_Power.Text = power.ToString()
            txt_Resistance.Text = resistance.ToString()
            txt_Voltage.Text = voltage.ToString()
        Else
            lbl_ErrorMessage.Text = "You have to enter atleast 2 values"
        End If
    End Sub

    ''' <summary>
    ''' P=VI
    ''' </summary>
    ''' <param name="v">voltage in volts</param>
    ''' <param name="i">current in amps</param>
    ''' <returns>power in watts</returns>
    Public Function CalculatePower(v As Double, i As Double)
        Return v * i
    End Function
    Public Function CalculatePowerIR(i As Double, r As Double) As Double
        Return i ^ 2 * r
    End Function

    ''' <summary>
    ''' R=voltage/current
    ''' </summary>
    ''' <param name="v">voltage in volts</param>
    ''' <param name="i">current in amps</param>
    ''' <returns>resistance in ohms</returns>
    Public Function CalculateResistance(v As Double, i As Double)
        Return v / i
    End Function

    ''' <summary>
    ''' I=P/V
    ''' </summary>
    ''' <returns></returns>
    Public Function CalculateCurrent(p As Double, v As Double)
        Return p / v
    End Function

    Public Function CalculateCurrentFromPR(p As Double, r As Double)
        Return Math.Sqrt(p / r)
    End Function
    Public Function CalculateCurrentFromVR(v As Double, r As Double)
        Return v / r
    End Function

    ''' <summary>
    ''' V=IR
    ''' </summary>
    ''' <returns></returns>
    Public Function CalculateVoltageFromIR(i As Double, r As Double)
        Return i * r
    End Function

    ''' <summary>
    ''' V=I/P
    ''' </summary>
    ''' <returns></returns>
    Public Function CalculateVoltageFromIoP(i As Double, p As Double)
        Return i / p
    End Function

End Class