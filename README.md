oe-selectie-gewichtsadvies
# Gezondheidsadvies: validatie en feedback via selectie
De beginsituatie is een combinatie van de oefening Persoonlijke info en geziene methoden in andere oefeningen
## txtFamilienaam en txtVoornaam
Bij elke verandering van de input in deze tekstboxen wordt gechecked of de input minimum 2 karakters telt. 
Het resultaat van de check wordt opgeslagen in de globale variabelen familieNaamOK/ voornaamOK.
Gebruik hiervoor de methode HeeftTekstMinimumLengte.
Gebruik MarkeerTextbox om de lay-out van de textbox aan te passen.
## RijksRegisterCorrect
Gebruik de methode BerekenControleGetal om het controlegetal te berekenen en vergelijk het met de laatste twee cijfers uit het rijksregisternummer.
Geef aan of het controlegetal al dan niet juist is.
## txtRijksregister
Bij elke verandering van de input in deze tekstbox wordt gechecked of de input een geldig rijksregisternummer is.
Als de lengte van de input geen 11 karakters bedraagt, is de input sowieso fout. In het andere geval gebruik je de methode IsRijksRegisterCorrect.
Het resultaat van de check wordt opgeslagen in de globale variabele rijksregisterOK.
## GeefGewichtsToestand
Afhankelijk van het doorgegeven bmi wordt de gewichtstoestand gegeven. Hiervoor wordt gebruik gemaakt van de teksten, opgeslagen in de constanten.
- bmi onder de 18,5: ondergewicht
- bmi van 18,5 - 25: gezond gewicht
- bmi van 25 - 30: overgewicht
- bmi vanaf 30: obesitas
## GeefGewichtsAdvies
Afhankelijk van de doorgegeven gewichtstoestand (zoals opgeslagen in de constanten) wordt een advies geformuleerd.
Dit begint altijd met 'Advies voor gewichtstoestand' gevolgd door door de doorgegeven gewichtstoestand en twee nieuwe lijnen.
Daarna volgt het eigenlijke advies, zoals opgeslagen in de constanten met een naam eindigend op \_ADVIES.
Bij een onbekende gewichtstoestand luidt het advies: 'Geef een geldige gewichtstoestand in.'.
## GeefGewichtsAdviesKleur
Afhankelijk van de doorgegeven gewichtstoestand (zoals opgeslagen in de constanten) wordt een kleur gegeven.
- ondergewicht: rood
- gezond gewicht: groen
- overgewicht: oranje
- obesitas: rood
Bij een onbekende gewichtstoestand is de kleur wit.
## IsFormulierGoedIngevuld
Deze methode gaat na of alles op het formulier goed ingevuld is.
Dit is het geval als er in de 2 comboboxen wel degelijk een waarde is aangeduid.
Via de variabelen rijksregisterOK, familieNaamOK, voornaamOK wordt nagegaan of de input in de textboxen correct is.
## btnVatSamen
De code in de click-event handler van deze knop wordt enkel uitgevoerd als het formulier correct is ingevuld (zie IsFormulierGoedIngevuld).
Is dit het geval niet, dan verschijnt in lblSamenvatting de tekst 'Kijk je input na en probeer het opnieuw'.



