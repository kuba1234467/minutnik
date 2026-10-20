Minutnik — zadanie 3.1
1. Opis projektu

Minutnik to aplikacja desktopowa zbudowana w C# i Avalonia. Służy do odmierzania czasu pracy i przerw oraz zliczania ukończonych cykli.

Wymagania funkcjonalne

Aplikacja spełnia siedem zasad określonych w zadaniu:

Domyślnie 25 minut pracy i 5 minut przerwy; obie wartości można zmieniać w oknie.
Jeden przycisk start/pauza oraz osobny przycisk reset.
Widoczny licznik ukończonych cykli.
Po zakończeniu pracy przerwa rozpoczyna się automatycznie.
Czas jest wyświetlany w formacie mm:ss.
Interfejs jest po polsku, a nazwy w kodzie po angielsku.
Aplikacja nie korzysta z dodatkowych bibliotek.

Dodatkowa decyzja techniczna: cała logika aplikacji znajduje się w pliku MainWindow.axaml.cs, bez osobnych klas pośredniczących.

Historia ukończonych cykli

Do aplikacji dodano listę historii, która wyświetla godzinę i numer ukończonego cyklu.

Kontrolka w interfejsie: HistoryList.
Lista napisów w kodzie: _history.
Historia jest aktualizowana po dodaniu wpisu.

Zmiana została wykonana własnoręcznie w ramach zadania.

2. Narzędzie i model AI
Narzędzie: Cursor.
Model: Grok 4.6 Medium.
Wybór modelu: automatyczny w Cursorze.
Data dokumentacji i pomiarów: 20.10.2026.

Ponieważ model był wybierany automatycznie, konfiguracja mogła zależeć od ustawień i dostępności modeli w Cursorze.

3. Pomiar tokenów pierwszej wiadomości

Data pomiaru: 20.10.2026.

Narzędzie pomiarowe: OpenAI Tokenizer.

Wyniki pomiaru pierwszej wiadomości z instrukcją budowy minutnika:

Język wiadomości	Liczba tokenów
Polski	146
Angielski	121

Narzędzie: https://platform.openai.com/tokenizer

Uwaga: liczby te pochodzą z pomiaru w tokenizerze OpenAI. Model używany w Cursorze może korzystać z innego tokenizera, dlatego wyniki nie muszą być identyczne z wewnętrzną liczbą tokenów modelu Grok.

4. Okno kontekstu i limit odpowiedzi

Data sprawdzenia: 20.10.2026.

Narzędzie: Cursor.
Model: Grok 4.6.
Okno kontekstu: 256 000 tokenów (256k), zgodnie z dokumentacją Cursora.
Źródło: https://prod.cursor.com/docs/models/grok-4-6
Maksymalna długość odpowiedzi: brak liczby w sprawdzonej dokumentacji Cursora.
Źródło: https://prod.cursor.com/docs/models/grok-4-6

Okno kontekstu i limit odpowiedzi to dwa różne ograniczenia. Okno kontekstu określa rozmiar informacji, które model może uwzględnić w jednym zapytaniu, a limit odpowiedzi określa maksymalną długość generowanej odpowiedzi.

Wartości dotyczą konfiguracji modelu udostępnianej przez Cursor, a niekoniecznie każdej konfiguracji Grok 4.6 u innych dostawców.

5. Próba z separatorem dziesiętnym

Wykonano próbę wpisania dwóch wartości w polu zmiany czasu.

Wartość 25,5

Zaobserwowane zachowanie: według przeprowadzonego testu aplikacja zaokrągla wartość do liczby większej, gdy część dziesiętna wynosi 5 lub więcej, a do liczby mniejszej, gdy wynosi od 1 do 4.

Przykład: wartość z częścią dziesiętną równą 5 lub większą jest zaokrąglana w górę, a z częścią dziesiętną od 1 do 4 — w dół.

Wartość 25.5

Zaobserwowane zachowanie: po wpisaniu wartości z kropką cyfra z kropką znika z pola.

Wniosek

Zachowanie pola zależy od użytego separatora dziesiętnego. Przecinek i kropka nie są obsługiwane w ten sam sposób. Wyniki opisują zachowanie zaobserwowane podczas testowania aplikacji.

6. Testowanie aplikacji

Podczas testów potwierdzono działanie wszystkich wymagań funkcjonalnych:

Domyślny czas pracy wynosi 25 minut.
Domyślny czas przerwy wynosi 5 minut.
Oba czasy można zmieniać.
Jeden przycisk obsługuje start i pauzę.
Osobny przycisk resetuje minutnik.
Czas jest wyświetlany jako mm:ss.
Licznik ukończonych cykli jest widoczny.
Przerwa rozpoczyna się automatycznie po zakończeniu pracy.
Interfejs jest po polsku.
Nazwy w kodzie są po angielsku.
Nie dodano dodatkowych bibliotek.
Historia ukończonych cykli jest wyświetlana w aplikacji.
7. Historia zmian w Git

Zmiany wprowadzane przez agenta były sprawdzane przed zaakceptowaniem. Poszczególne prośby i poprawki powinny być zapisywane w osobnych commitach.

Własnoręczna zmiana historii cykli ma wymagany opis commita:

wlasna reka: historia cykli

Dokumentacja pomiarów i testów jest zapisywana w osobnym commicie.

8. Repozytorium i publikacja

Adres repozytorium GitHub: jeszcze nie utworzono.

Po utworzeniu repozytorium należy wypchnąć wszystkie commity i uzupełnić tę sekcję rzeczywistym adresem URL.

Po opublikowaniu projektu należy przesłać adres repozytorium w formularzu oddania zadania 3.1.

9. Podsumowanie

Projekt obejmuje minutnik pracy i przerw, licznik cykli oraz własnoręcznie dodaną historię ukończonych cykli. W README zapisano wyniki pomiaru tokenów pierwszej wiadomości w języku polskim i angielskim, limity modelu dostępnego w Cursorze oraz wyniki testów separatora dziesiętnego.

