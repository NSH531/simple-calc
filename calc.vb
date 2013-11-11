sub main()
dim a1 as double
dim a2 as double
a1=cdbl(inputbox())
a2=cdbl(inputbox())
dim o as char
o=inputbox()
cells(1,1).formula=a1 & o & a2
