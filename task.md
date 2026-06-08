# Part 1 -- UML Class Diagram aus Issues

- Erstellen Sie ein GitHub-Issue, in dem Kevin (AI-Agent) aufgefordert wird, aus der User Story in `README.md` ein PlantUML-Klassendiagramm zu erstellen.
- Kevin dokumentiert das UML-Klassendiagramm im PlantUML-Antwortfeld der `README.md` und aktualisiert den LiaScript-Course-Link auf Ihr studentisches Repository.
- Kevin arbeitet auf einem eigenen Branch und erstellt eine Pull Request nach `main`.
- Reviewen Sie Kevins Pull Request und leiten Sie Kevin an, bis das UML-Klassendiagramm die benoetigte Struktur widerspiegelt.
- Lisa (AI-Agent) reviewed Kevins Pull Request ebenfalls. Der PR wird erst gemerged, wenn Ihr Review und Lisas Review genehmigt sind.

# Part 2 -- CSharp Grundlage: Turniertabelle

- Setzen Sie die Grundlage des freigegebenen UML-Klassendiagramms in C# Code um.
- Modellieren Sie Mannschaften, Spiele und die Gruppenphase der Fussball-Weltmeisterschaft.
- Implementieren Sie Speichern und Laden der Turnierdaten.
- Implementieren Sie die Command-Line-Befehle `new` und `print`.
- Erweitern Sie Ihre `Program.cs` so, dass bei einem Start ohne Argumente (`dotnet run`) automatisch die neuen Befehle `new` und `print` nacheinander aufgerufen werden, damit deren Ausgabe im automatischen GitHub Actions Check (CI) für Lisa sichtbar wird.
- Arbeiten Sie auf einem eigenen Branch, erstellen Sie eine Pull Request nach `main` und verknuepfen Sie diese PR mit diesem Issue ueber `Closes #<Issue-Number>`.
- Lisa (AI-Agent) reviewed die Pull Request. Arbeiten Sie Feedback auf demselben Branch ein.

# Part 3 -- CSharp Wettquoten

- Erweitern Sie die C# Implementierung aus Part 2 um Wettquoten fuer Spiele.
- Speichern Sie pro Spiel Wettquoten fuer verschiedene Wett-Typen, zum Beispiel Siegwette und Ergebniswette.
- Implementieren Sie die Command-Line-Befehle `set <spielid> <Wetttyp> <Wettquote>` und `get <spielid> <Wetttyp>`.
- Stellen Sie sicher, dass Wettquoten persistent gespeichert und geladen werden.
- Erweitern Sie den parameterlosen Programmstart (`dotnet run`) so, dass nach der Tabellenerstellung (`new`) nun auch exemplarisch Quoten via `set` gesetzt und via `get` abgerufen werden, um deren Funktion in der CI zu demonstrieren.
- Arbeiten Sie auf einem eigenen Branch, erstellen Sie eine Pull Request nach `main` und verknuepfen Sie diese PR mit diesem Issue ueber `Closes #<Issue-Number>`.
- Lisa (AI-Agent) reviewed die Pull Request. Arbeiten Sie Feedback auf demselben Branch ein.

# Part 4 -- CSharp Wetten und Auswertung

- Erweitern Sie die C# Implementierung aus Part 3 um Benutzer, Wetten und Ergebnis-Auswertung.
- Implementieren Sie Benutzer-Guthaben, Wetteinsaetze und persistente Speicherung von Wetten.
- Implementieren Sie den Command-Line-Befehl `bid <player> <spielid> <Wetttyp> <amount>`.
- Implementieren Sie den Command-Line-Befehl `result <spielid> <Tore-1.Mannschaft>:<Tore-2.Mannschaft>` und werten Sie passende Wetten anhand der gesetzten Quoten aus.
- Erweitern Sie den parameterlosen Programmstart (`dotnet run`) abschließend so, dass auch exemplarische Wetten (`bid`) platziert und ein Spielergebnis (`result`) eingetragen wird. Geben Sie danach die abgerechneten Wetten und aktuellen Guthaben aus.
- Arbeiten Sie auf einem eigenen Branch, erstellen Sie eine Pull Request nach `main` und verknuepfen Sie diese PR mit diesem Issue ueber `Closes #<Issue-Number>`.
- Lisa (AI-Agent) reviewed die Pull Request. Arbeiten Sie Feedback auf demselben Branch ein.
