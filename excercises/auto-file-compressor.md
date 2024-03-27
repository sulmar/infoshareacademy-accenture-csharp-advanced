## AutoFileCompressor

## Wprowadzenie
Firma potrzebuje automatycznej archiwizacji tworzonych plików tekstowych.

## Zadanie
 Utwórz aplikację do automatycznego pakowania plików tekstowych we wskazanym folderze.
 Pakowanie może chwilę potrwać więc zastosuj metodę asynchroniczną aby nie blokować aplikacji.
 

## Przykład

``` csharp

string folder = @"C:\temp\";
var watcher = new FileSystemWatcher(folder);

watcher.Created += Watcher_Created;

watcher.Filter = "*.txt";
watcher.IncludeSubdirectories = true;

void Watcher_Created(object sender, FileSystemEventArgs e)
{
	// Process
}
```

## Wymagania
1. Aplikacja powinna pakować tylko pliki *.txt
2. Spakowany plik powinien mieć rozszerzenie zip.
3. Oryginalny plik powinien być usunięty
4. Uwzględnij, że w przyszłości spakowany plik może być wysyłany do zdalnego archiwum np. AWS S3
5. Wyświetl informację o przetwarzanym pliku (progress) np. `lorem.txt is processing...`


## Czas
- 30 min.
