all: HiToText.exe
HiToText.exe:
	gmcs -recurse:"*.cs" -out:"HiToText.exe" -nowarn:219,114
install:
	cp HiToText.xml /etc/sdlmame
	cp HiToText.exe /usr/local/bin
clean: 
	rm HiToText.exe