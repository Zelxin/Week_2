'Vincent Vassallo
'Ohms Law
'Jan 10th 2020



'Voltage (V) = Current (I) * Resistance (R)
'Power(P) = Voltage(V) * Current(I)
Public Class OhmsLaw_Complete
    Private Sub btn_Calculate_Click(sender As Object, e As EventArgs) Handles btn_Calculate.Click

        Dim voltage As Double
        Dim bGoodVoltage = Double.TryParse(txt_Voltage.Text, voltage)

        Dim current As Double
        Dim bGoodCurrent = Double.TryParse(txt_Current.Text, current)

        Dim resistance As Double
        Dim bGoodResistance = Double.TryParse(txt_Resistance.Text, resistance)

        Dim power As Double
        Dim bGoodPower = Double.TryParse(txt_Power.Text, power)

        lbl_ErrorMessage.Text = ""
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