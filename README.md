# PIV_Aplikacja_BD_ESIT
ESIT = Elektroniczny System Informacji Turystycznej
![Opis alternatywny](/Schemat_Bazy_Danych_ESIT.png)
## OPIS PROGRAMU
Etap 1.(folder-Models)Zdefiniowane zostały poszczególne klasy opisujące kolumny w tabellach.:

-Oferta Turystyczna

-Użytkownicy

-Wiadomości

-Opinie

-Rezerwacja

Etap 1.2 Nadane zostały właściwości dla każdej z wartości(np:klucz lub czy wartość jest wymagana)

Etap 2.Zdefiniowanie relacji między tabelami

Każda Oferta turystyczna może mieć wiele rezerwacji oraz wiele opini.

Każda rezerwacja może odnosić się tylko do jedenj oferty turystycznej oraz do jednego użytkownika,

Każdy Użytkownik może złożyć wiele rezerwacji oraz wysłac wiele wiadomości,

Każda wiadomość odnosi się do jednej rezerwacji oraz jednego użytkownika,

Każda opinia tyczy się jednej oferty turystycznej.

Etap 3.(folder-Models->ESITContext)Zdefiniowany został kontekst dziędziczący po klasie DbContext

-określono właściwości DbSet dla każdej klasy(modelu danych)

-Skonfigurowane połączenie do bazy danych

-Za pomocą metody OnModelCreating() zdefiniowane zostały niestandardowe ustawienia dla poszczególnych klas i relacji

Etap 4.Przeprowadzono migracje w celu utworzenia schematu bazy danych
  
