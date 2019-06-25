.SUFFIXES : .cs

.cs.exe:
	csc $<


clean:
	del *.exe

