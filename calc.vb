Sub main()
Dim a1 As Double
Dim a2 As Double
a1 = CDbl(InputBox("get num"))
a2 = CDbl(InputBox("get num"))
Dim o As Integer
o = Asc(InputBox("get char"))

Cells(1, 1).FormulaR1C1 = "=" & a1 & Chr(o) & a2
End Sub
