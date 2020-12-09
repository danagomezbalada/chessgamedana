# Joc Escacs
---------
# Instal·lació
Per instal·lar el joc, tan sols hem de descarregar l'[executable](https://gitlab.com/dam2-dana/jocescacsdana/-/blob/master/JocEscacsDana.exe).
# Utilització
### Funcionalitats del programa
Un cop executem el joc, entrem directament a la pantalla del tauler i opcions del joc. A la dreta, tenim disponibles una sèrie de botons que compleixen diferents funcions:
- **Nova partida**. Fent clic a aquesta botó esborrem tots els resultats anteriors i carreguem el joc de nou, començant des de zero.
- **Següent Joc**. Aquest botó manté els resultats obtinguts i reinicia el tauler i els comptadors de cada jugador. 
- **Resultats**. Quan fem clic a aquest botó s'obre una nova finestra on es mostren els resultats de cada jugador obtinguts fins ara (quantes victòries té cada jugador).
- **Sortir**. Tanca el joc un cop fem clic a aquest botó.

Adicionalment, a sota d'aquests botons tenim els marcadors de **captures de cada jugador**, així com l'**indicador del jugador actual** (fons vermell darrera del jugador actual). Cada captura suma un punt al jugador que ha capturat.
*La finestra del joc es pot moure fent clic a qualsevol part del fons i arrastrant el ratolí a la posició desitjada.*

### Funcionalitats del joc
Es juga amb dues persones, i sempre comença el joc el `jugador 1` (peçes blanques). Aquest joc permet fer les següents accions: 
- **Moure peces a les caselles permitides**. Per moure una peça, fem clic sobre aquesta i el programa marca a quines caselles ens podem moure.
    - Encara que el programa marqui caselles ocupades només ens podem moure a les `caselles lliures` (sempre que siguin del mateix color).
- **Atrapar peces de l'altre color**. Un cop cliquem sobre una peça, podem atrapar les peces de l'altre color que estiguin dins del marge. 
    - El programa permet saltar a totes les peçes excepte els peons i reis.
- **Matar al rei i guanyar la partida**. Un cop atrapem al rei del color contrari guanyem la partida i el programa no permet fer més moviments.
    - Un cop hem guanyat, es suma un punt al resultat del jugador que ha guanyat (que podem veure des del botó de `Resultats`).