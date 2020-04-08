Module Module1

	Public r As Short
	Public h As Short
	Const PI As Double = 3.14

	Public Function mySA(ByRef h As Short, ByRef r As Short) As Single
		Dim mySArea As Single
		mySArea = 2 * PI * r * h
		Return mySArea
	End Function
	Public Function myVol(ByRef h As Short, ByRef r As Short) As Double
		Dim myvolume As Double
		myvolume = mySA(h, r) * r / 2
		Return myvolume
	End Function

End Module
