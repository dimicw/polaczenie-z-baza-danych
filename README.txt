By uruchomi� program nale�y:
1. utowrzy� baz� danych na podstawie pliku zadanie4.sql lub uruchomi� istniej�c� o odpowiadaj�cej strukturze
2. ustawi� poprawny connection string w pliku Zadanie4_DCW/bin/Release/zadanie4_DCW.exe.config
3. otworzy� plik Zadanie4_DCW/bin/Release/zadanie4_DCW.exe


Struktura:
- Start.cs - zawiera okno g��wne, w kt�rym uruchamiane s� inne okna
- Sklep.cs - zawiera okno obs�ugi tabeli sklep, w kt�rym mo�na edytowa�, usuwa� i dodawa� rekordy do bazy.
- Produkt.cs - zawiera okno obs�ugi tabeli produkt (ka�dy produkt przypisany jest do konkretnego sklepu), w kt�rym mo�na edytowa�, usuwa� i dodawa� rekordy do bazy.
- App.config - plik umo�liwiaj�cy po��czenie z baz� (zawiera connection string)
