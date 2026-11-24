# Specyfikacja minutnika

## Co robi

1. Program pozwala zmieniać długość pracy i przerwy.
2. Program domyślnie odmierz 25 minut pracy i 5 minut przerwy.
3. Program pozwala rozpocząć, wstrzymać i zresetować odliczanie jednym przyciskiem Start/Pauza oraz osobnym przyciskiem Reset.
4. Program pokazuje pozostały czas w formacie mm:ss.
5. Program pokazuje bieżącą fazę: pracę lub przerwę.
6. Program pokazuje liczbę ukończonych cykli.
7. Program automatycznie rozpoczyna przerwę po zakończeniu pracy.
8. Program dodaje ukończony cykl do historii wraz z godziną.
9. Interfejs programu jest po polsku, a nazwy wewnętrzne w kodzie są po angielsku.

## Czego nie robi

- Nie zapisuje czasu, ustawień ani historii po zamknięciu programu.
- Nie odtwarza dźwięku ani powiadomienia po zakończeniu fazy.
- Nie synchronizuje minutnika między urządzeniami.
- Nie tworzy raportu ani eksportu historii.
- Nie pobiera danych z internetu.

## Po czym poznam

1. Kiedy uruchomię program, to zobaczę 25:00 przy fazie „Praca”.
2. Kiedy uruchomię program, to licznik cykli pokazuje 0.
3. Kiedy zakończy się 25 minut pracy, to przerwa zaczyna się bez klikania.
4. Kiedy naciśnę Reset w dowolnym momencie, to widoczna jest faza „Praca”, czas z ustawionego czasu pracy i licznik cykli 0.
5. Kiedy naciśnę Start, a następnie Pauza, to czas przestaje się zmniejszać i można go wznowić.

## Do ustalenia

- Jak ma wyglądać historia po przejściu przez wiele cykli i czy lista ma ograniczać liczbę wpisów.
- Czy przerwa ma być automatycznie uruchamiana, czy tylko po zakończeniu pracy.
- Co dokładnie oznacza jeden ukończony cykl i czy praca liczy się po zakończeniu przerwy.
- Czy zmiana ustawionego czasu ma być możliwa podczas odmierzania.
- Jak zresetować limit ustawionego czasu poza 1–180 minutami.
