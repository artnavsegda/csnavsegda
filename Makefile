.SUFFIXES : .cs

.cs.exe:
	csc $<


all:	hello.exe

clean:
	del *.exe

