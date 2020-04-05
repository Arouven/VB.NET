Module Module1

	Sub Main()
		Console.WriteLine("Cobalt 60, a radioactive element used in cancer therapy, decays over a period of time. Each year 12% of the amount present at the beginning of the year will be decayed. If a container of Cobalt 60 initially contains 15 gms, write a VB.NET program to determine the amount of this element remaining after 8 years.")
		Dim remain As Double = 15.0
		Dim year As Integer = 8
		For yrs As Integer = 1 To year Step 1
			remain = remain - ((remain * 12) / 100)
		Next
		Console.WriteLine(vbCrLf & vbCrLf & "The amount of cobalt-60 remaining after {0} years is {1:F2}", year, remain)
		Console.Read()
	End Sub

End Module
