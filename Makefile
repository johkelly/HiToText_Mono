all: HiToText.exe
HiToText.exe:
	gmcs -recurse:"*.cs" -out:"HiToText.exe" -nowarn:219,114
clean: 
	rm HiToText.exe