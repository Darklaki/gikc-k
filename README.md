# Laboratorium VII 02-05-2021
Skalowanie histogramu oraz filtry rozmywające.

## Jak uruchomić
1. Uruchomić ```lab6_intensywnosc_histogram/bin/debug/lab6_intensywnosc_histogram.exe```
2. Lub załadować projekt w Visual Studio

## Informacje
Aby wybrać zdjęcie do edycji, należy kliknąć w pierwszy kwadrat. Pierwszy histogram wygeneruje się po wybraniu zdjęcia. Drugi po dokonaniu edycji.
Proszę unikać zdjęć o dużych rozdzielczościach gdyż algorytmy obliczające zdjęcie wyjściowe nie zostały oddelegowane do innego wątku - aplikacja po jakimś czasie może się zawiesić.

## Innowacje
1. Oprócz filtru uśredniającego i Gaussa dodano też filtr piramidalny.
2. Możliwość wyboru ile razy przefiltrować zdjęcie.

## Zdjęcie
![1](assets/1.png)
![2](assets/2.png)
![3](assets/3.png)