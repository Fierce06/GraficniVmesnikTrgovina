# GraficniVmesnikTrgovina

## Opis projekta
Projekt predstavlja preprosto namizno aplikacijo v programskem jeziku C#, izdelano v okolju Windows Forms. Aplikacija simulira delovanje trgovine z elektronskimi izdelki. Uporabnik lahko dodaja izdelke tipa telefon ali laptop, pregleduje seznam dodanih izdelkov in izračuna skupno ceno vseh izdelkov.

Projekt je razdeljen na dva dela:
- GraficniVmesnikTrgovina – grafični uporabniški vmesnik
- TrgovinaLib – knjižnica z razredi in poslovno logiko

## Glavne funkcionalnosti
- dodajanje telefona
- dodajanje laptopa
- prikaz različnih vnosnih polj glede na izbran tip izdelka
- prikaz vseh dodanih izdelkov v seznamu
- izračun skupne cene vseh izdelkov
- uporaba abstraktnega razreda
- uporaba vmesnika
- uporaba polimorfizma
- uporaba indekserja
- uporaba delegatov in dogodkov

## Uporabljene tehnologije
- C#
- Windows Forms
- .NET Framework
- Visual Studio
- GitHub

## Namestitev in zagon programa

### Zahteve
Za zagon programa uporabnik potrebuje:
- nameščen Visual Studio
- podporo za .NET Framework projekt
- dostop do GitHub repozitorija

### Postopek namestitve
1. Odprite GitHub repozitorij projekta.
2. Prenesite projekt na računalnik z možnostjo Code > Download ZIP ali s kloniranjem repozitorija.
3. Razširite preneseno ZIP datoteko, če ste projekt prenesli kot arhiv.
4. Odprite mapo projekta.
5. V Visual Studiu odprite rešitev oziroma `.sln` datoteko.
6. Počakajte, da Visual Studio naloži oba projekta.
7. Preverite, da je kot zagonski projekt nastavljen GraficniVmesnikTrgovina.
8. Program zaženite s klikom na Start.

## Navodila za uporabo
1. Ob zagonu programa se odpre glavno okno aplikacije.
2. V polje naziv vnesite ime izdelka.
3. V polje cena vnesite ceno izdelka.
4. V polju tip izdelka izberite možnost Telefon ali Laptop.
5. Če izberete Telefon, se prikažejo polja za kamero, 5G in baterijo.
6. Če izberete Laptop, se prikažejo polja za RAM, procesor in težo.
7. Po vnosu podatkov kliknite gumb Dodaj izdelek.
8. Dodani izdelek se izpiše v seznamu izdelkov.
9. Ob dodajanju izdelka se prikaže obvestilo, da je bil izdelek dodan.
10. S klikom na gumb Izračunaj ceno se izračuna skupna cena vseh dodanih izdelkov.

## Struktura projekta

### TrgovinaLib
Knjižnica vsebuje razrede:
- `Izdelek` – abstraktni osnovni razred
- `Telefon` – podrazred za telefone
- `Laptop` – podrazred za laptope
- `Stranka` – razred za podatke o stranki
- `Trgovina` – razred za upravljanje izdelkov, indekser, delegate in dogodke
- `IGarancija` – vmesnik za garancijo

### GraficniVmesnikTrgovina
Projekt vsebuje:
- `Form1` – glavno okno aplikacije
- vnosna polja za dodajanje izdelkov
- seznam izdelkov
- gumbe za dodajanje izdelka in izračun cene

## Objektno usmerjeno programiranje v projektu
V projektu so uporabljeni naslednji koncepti objektno usmerjenega programiranja:
- enkapsulacija
- lastnosti
- konstruktorji
- statične metode in podatki
- dedovanje
- abstraktni razred
- abstraktna metoda
- vmesnik
- polimorfizem
- preobremenjevanje operatorjev
- indekser
- delegati
- dogodki

Avtor: Nal Paradižnik
