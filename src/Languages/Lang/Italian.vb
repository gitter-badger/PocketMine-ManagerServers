Module Italian
    ' _____           _        _   __  __ _                   __  __                                   _____                              
    '|  __ \         | |      | | |  \/  (_)                 |  \/  |                                 / ____|                             
    '| |__) |__   ___| | _____| |_| \  / |_ _ __   ___ ______| \  / | __ _ _ __   __ _  __ _  ___ _ _| (___   ___ _ ____   _____ _ __ ___ 
    '|  ___/ _ \ / __| |/ / _ \ __| |\/| | | '_ \ / _ \______| |\/| |/ _` | '_ \ / _` |/ _` |/ _ \ '__\___ \ / _ \ '__\ \ / / _ \ '__/ __|
    '| |  | (_) | (__|   <  __/ |_| |  | | | | | |  __/      | |  | | (_| | | | | (_| | (_| |  __/ |  ____) |  __/ |   \ V /  __/ |  \__ \
    '|_|   \___/ \___|_|\_\___|\__|_|  |_|_|_| |_|\___|      |_|  |_|\__,_|_| |_|\__,_|\__, |\___|_| |_____/ \___|_|    \_/ \___|_|  |___/
    '                                                                                   __/ |                                             
    '                                                                                  |___/                                              
    'Copyright (C) 2015  matcracker

    'This program is free software: you can redistribute it and/or modify 
    'it under the terms of the GNU Lesser General Public License as published by 
    'the Free Software Foundation, either version 3 of the License, or 
    '(at your option) any later version. 

    Sub Italian() 'TRANSLATED BY matcracker
        Dim back, changemade, status1, version1, versionstable1, versionbeta1, versiondev1, versionsoft1, currentversion, writepath1, writepath2, writepath3 As String

        back = "Indietro"
        changemade = "Cambiamenti fatti! Premi INVIO per tornare al menù"
        status1 = "Stato"
        version1 = "Versione"
        versionstable1 = "Versione Stabile"
        versionbeta1 = "Versione Beta"
        versiondev1 = "Versione Dev"
        versionsoft1 = "Versione Soft"
        currentversion = "Versione attuale:"
        writepath1 = "Scrivi il collegamento della cartella del server "
        writepath2 = " , ad esempio 'C:\PocketMine-MP': "
        writepath3 = "ERRORE! Inserisci un collegamento valido!"

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\UniqueWords1.lang", back, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\UniqueWords2.lang", changemade, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\UniqueWords3.lang", status1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\UniqueWords4.lang", version1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\UniqueWords5.lang", versionstable1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\UniqueWords6.lang", versionbeta1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\UniqueWords7.lang", versiondev1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\UniqueWords8.lang", versionsoft1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\UniqueWords9.lang", currentversion, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\UniqueWords10.lang", writepath1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\UniqueWords11.lang", writepath2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\UniqueWords12.lang", writepath3, True)

        '#Main Menu
        Dim menudev, menutitle, menu1, menu2, menu3, menu4, menu5, menu6 As String

        menutitle = "----------------------------<Menù Principale>-----------------------------------"
        menudev = "                                                           Version: 1.2 #BUILD 2"
        menu1 = "Installa PocketMine-MP"
        menu2 = "Gestisci Servers"
        menu3 = "Opzioni del programma"
        menu4 = "Informazioni"
        menu5 = "Esci"
        menu6 = "Che cosa desideri fare?: "

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Menu1.lang", menutitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Menu2.lang", menudev, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Menu3.lang", menu1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Menu4.lang", menu2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Menu5.lang", menu3, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Menu6.lang", menu4, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Menu7.lang", menu5, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Menu8.lang", menu6, True)

        '#Install PocketMine-MP
        Dim installertitle, installer1, installer2, installer3 As String

        installertitle = "-------------------------<Inizializza PocketMine-MP>----------------------------"
        installer1 = "Scarica"
        installer2 = "Installa"
        installer3 = "Scegli cosa vuoi fare: "

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Install1.lang", installertitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Install2.lang", installer1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Install3.lang", installer2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Install4.lang", installer3, True)

        '--------#ManagerInstaller
        '-----------------#Installator
        Dim installatortitle, installator1, installator2, installator3, installator4, installator5, installator6, installator7 As String

        installatortitle = "--------------------------<Installa PocketMine-MP>------------------------------"
        installator1 = "Che genere di versione vuoi scaricare?"
        installator2 = "Quale versione vuoi installare?:"
        installator3 = "Iniziando l'installazione..."
        installator4 = "Installazione completata"
        installator5 = "Installer non trovato! Perfavore scarica l'installer!"
        installator6 = "Installato"
        installator7 = "Non Installato"

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Installator0.lang", installatortitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Installator1.lang", installator1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Installator2.lang", installator2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Installator3.lang", installator3, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Installator4.lang", installator4, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Installator5.lang", installator5, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Installator6.lang", installator6, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Installator7.lang", installator7, True)

        '------------------------#Versions(Beta, Dev, Soft)

        Dim versions1, versions2, versions3 As String

        versions1 = "Are you sure you want to replace the file phar with the current one? (This will create a copy)"
        versions2 = "Phar file not found!"
        versions3 = "Please download the file."

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Versions1.lang", versions1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Versions2.lang", versions2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Versions3.lang", versions3, True)

        '-----------------#Downloader
        Dim downloadertitle, downloader1, downloader2, downloader3, downloader4, downloader5, downloader6, downloader7, downloader8, downloader9, downloader10, downloader11 As String

        downloadertitle = "----------------------------<Scarica PocketMine-MP>-----------------------------"
        downloader1 = "Che genere di versione vuoi scaricare?"
        downloader2 = "Quale versione vuoi scaricare?: "
        downloader3 = "Hai già scaricato questo installer!"
        downloader4 = "Scaricamento Installer...!"
        downloader5 = "Installer scaricato! Premi INVIO per continuare."
        downloader6 = "Hai già scaricato questo file!"
        downloader7 = "Scaricamento del Phar File!"
        downloader8 = "Phar file scaricato! Premi INVIO per continuare-"
        downloader9 = "Perfavore indica il collegamento della cartella nella quale hai scaricato l'installer, ad esempio 'C:\PocketMine-MP': "
        downloader10 = "Scaricato"
        downloader11 = "Non scaricato"

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Downloader0.lang", downloadertitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Downloader1.lang", downloader1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Downloader2.lang", downloader2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Downloader3.lang", downloader3, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Downloader4.lang", downloader4, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Downloader5.lang", downloader5, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Downloader6.lang", downloader6, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Downloader7.lang", downloader7, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Downloader8.lang", downloader8, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Downloader9.lang", downloader9, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Downloader10.lang", downloader10, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Downloader11.lang", downloader11, True)

        '#ManageServers
        Dim managertitle, manager1, manager2, manager3, manager4 As String

        managertitle = "------------------------------<Gestisci Servers>--------------------------------"
        manager1 = "Apri [Server/Cartella]"
        manager2 = "Modifica prestazioni dei servers"
        manager3 = "Esegui Backup/Ripristini per i servers."
        manager4 = "Seleziona un'opzione: "

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Manager0.lang", managertitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Manager1.lang", manager1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Manager2.lang", manager2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Manager3.lang", manager3, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Manager4.lang", manager4, True)

        '-----------#Opener
        Dim openertitle, opener1, opener2, opener3, opener4, opener5, opener6, opener7, opener8 As String

        openertitle = "----------------------------------<Apritore>------------------------------------"
        opener1 = "Apri"
        opener2 = "Che cosa vuoi fare? "
        opener3 = "Leggento i tuoi file(s)..."
        opener4 = "File(s) letti con successo!"
        opener5 = "Aprendo i tuoi server(s)..."
        opener6 = "Caricamento"
        opener7 = "Aspetta 3 secondi per ogni carimanto dei server!"
        opener8 = "Cartelle"

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Opener0.lang", openertitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Opener1.lang", opener1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Opener2.lang", opener2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Opener3.lang", opener3, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Opener4.lang", opener4, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Opener5.lang", opener5, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Opener6.lang", opener6, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Opener7.lang", opener7, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Opener8.lang", opener8, True)

        '-----------#Editor
        Dim editortitle, editor1, editor2, editor3 As String

        editortitle = "---------------------------------<Modificatore>---------------------------------"
        editor1 = "Modifica proprietà del server"
        editor2 = "Modifica prestazioni del server"
        editor3 = "Che cosa vuoi modificare? "

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Editor0.lang", editortitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Editor1.lang", editor1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Editor2.lang", editor2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Editor3.lang", editor3, True)

        '-----------------#EditProperties
        Dim propertiestitle, properties1, properties2, properties3, properties4, properties5, properties6 As String

        propertiestitle = "----------------------<Modifica proprietà dei servers>--------------------------"
        properties1 = "Controllando i collegamenti..."
        properties2 = "Collegamenti trovati!"
        properties3 = "Sto creando il tuo server.properties, aspetta"
        properties4 = "Server.properties creato!"
        properties5 = "Vuoi sostituire il vecchio con il nuovo file? (Verrà creata una copia di backup) <Y/N>: "
        properties6 = "Collegamenti non trovati!"

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Properties0.lang", propertiestitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Properties1.lang", properties1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Properties2.lang", properties2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Properties3.lang", properties3, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Properties4.lang", properties4, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Properties5.lang", properties5, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Properties6.lang", properties6, True)

        '----------------#EditPerformance
        Dim performancetitle, performance1, performance2, performance3, performance4, performance5, performance6, performance7, performance8, performance9, performance10, performance11, performance12 As String

        performancetitle = "--------------------------------<Prestazioni>-----------------------------------"
        performance1 = "Le tue prestazioni attuali sono: "
        performance2 = "Che caratteristica vuoi attribuire ai tuoi servers?"
        performance3 = "Alte"
        performance4 = "Medie"
        performance5 = "Basse"
        performance6 = "Scegli caratteristica: "
        performance7 = "Se scegli questa opzione, avrai bisogno di un PC che lo supporti, quindi se non possiede è fortemente consigliato di non usarlo."
        performance8 = "Vuoi continuare? <Y/N>: "
        performance9 = "Se si sceglie questa opzione, avrete bisogno di un PC non troppo perfomante, è adatto per la gestione di piccoli server."
        performance10 = "Se si sceglie questa opzione , avrete bisogno di un PC non troppo perfomante, è adatto per gestire i server con gli amici ."
        performance11 = "Su quale server vuoi applicare queste impostazioni? "
        performance12 = "Sto facendo i cambiamenti..."

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance0.lang", performancetitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance1.lang", performance1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance2.lang", performance2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance3.lang", performance3, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance4.lang", performance4, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance5.lang", performance5, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance6.lang", performance6, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance7.lang", performance7, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance8.lang", performance8, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance9.lang", performance9, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance10.lang", performance10, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance11.lang", performance11, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance12.lang", performance12, True)

        '-----------#Rescuer
        Dim rescuertitle, rescuer1, rescuer2 As String

        rescuertitle = "-------------------------<Backup/Ripristina Servers>----------------------------"
        rescuer1 = "Crea un backup per i servers"
        rescuer2 = "Ripristana servers"

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Rescuer0.lang", rescuertitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Rescuer1.lang", rescuer1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Rescuer2.lang", rescuer2, True)

        '----------------#Backup
        Dim backuptitle, backup1, backup2, backup3, backup4, backup5 As String

        backuptitle = "--------------------------------<Backup Server>---------------------------------"
        backup1 = "Scegli a quale server vuoi fare un backup: "
        backup2 = "Sto facendo il backup, perfavore aspetta!"
        backup3 = "FATTO! Premi INVIO per continuare"
        backup4 = "Esiste già un'altro backup di questo server, vuoi sovrascriverlo? "
        backup5 = "Puoi trovare il tuo backup in 'C:\Program Files\PocketMine-ManagerServers\Backups\', vuoi aprire questa cartella?"

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Backup0.lang", backuptitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Backup1.lang", backup1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Backup2.lang", backup2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Backup3.lang", backup3, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Backup4.lang", backup4, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Backup5.lang", backup5, True)

        '----------------#Restore
        Dim restoretitle, restore1, restore2, restore3, restore4, restore5 As String

        restoretitle = "------------------------------<Riprista Server>---------------------------------"
        restore1 = "Scegli quale server vuoi ripristinare: "
        restore2 = "Sto estraendo il tuo server, perfavore aspetta!"
        restore3 = "FATTO! Premi INVIO per continuare"
        restore4 = "Errore, prima fai un backup."
        restore5 = "Puoi trovare il tuo backup in 'C:\Program Files\PocketMine-ManagerServers\Backups\', vuoi aprire questa cartella?"

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Restore0.lang", restoretitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Restore1.lang", restore1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Restore2.lang", restore2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Restore3.lang", restore3, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Restore4.lang", restore4, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Restore5.lang", restore5, True)

        '#Options
        Dim optiontitle, option1, option2, option3 As String

        optiontitle = "---------------------------<Opzioni del Programma>------------------------------"
        option1 = "Linguaggio"
        option2 = "Resetta il programma"
        option3 = "Scegli un'opzione: "

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Option0.lang", optiontitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Option1.lang", option1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Option2.lang", option2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Option3.lang", option3, True)

        '------------#ChangeLanguages
        Dim lang1 As String

        lang1 = "Per favore selezione una lingua disponibile!"

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Lang1.lang", lang1, True)

        '------------#ResetProgram
        Dim resettitle, resetp1, resetp2, resetp3, resetp4, resetp5, resetp6, resetp7, resetp8, resetp9, resetp10, resetp11 As String

        resettitle = "-----------------------------<Resetta Programma>--------------------------------"
        resetp1 = "Resetta dati dei servers (Solo programma)"
        resetp2 = "Resetta dati dei servers (Solo i servers specificari)"
        resetp3 = "Resetta tutti i dati/cartelle del programma"
        resetp4 = "Scegli cosa vuoi resettare: "
        resetp5 = "Sei sicuro i voler resettare i dati dei servers (Solo programma)? <Y/N>: "
        resetp6 = "Chiudendo il programma.."
        resetp7 = "Non ci sono file da cancellare!"
        resetp8 = "ATTENZIONE! Sei sicuro di voler resettare i dati dei servers (Solo servers specificati)? <Y/N>: "
        resetp9 = "Perfavore, prima configura i servers."
        resetp10 = "Non ci sono collegamenti da cancellare!"
        resetp11 = "Sei sicuro di voler resettare tutti i dati/cartelle del programma (Cancella le cartelle del programma)? <Y/N>: "

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Resetp0.lang", resettitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Resetp1.lang", resetp1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Resetp2.lang", resetp2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Resetp3.lang", resetp3, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Resetp4.lang", resetp4, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Resetp5.lang", resetp5, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Resetp6.lang", resetp6, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Resetp7.lang", resetp7, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Resetp8.lang", resetp8, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Resetp9.lang", resetp9, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Resetp10.lang", resetp10, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Resetp11.lang", resetp11, True)

        '#Informations
        Dim infotitle, infocredits, infoinformations, infodisclaimer, info1, info2, info3, info4, info5, info6 As String

        infotitle = "--------------------------------<Informazioni>----------------------------------"
        infocredits = "-----------------------------------<Crediti>------------------------------------"
        infoinformations = "------------------------------<Più Informazioni>--------------------------------"
        infodisclaimer = "------------------------------<Disconoscimento>---------------------------------"
        info1 = "Licenza"
        info2 = "Crediti"
        info3 = "Più Informazioni"
        info4 = "Disconoscimento"
        info5 = "Scegli informazione: "
        info6 = "ERRORE! Brutta installazione! Licenza non trovata!"

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Info0.lang", infotitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Info1.lang", info1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Info2.lang", info2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Info3.lang", info3, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Info4.lang", info4, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Info5.lang", info5, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Info6.lang", info6, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Info7.lang", infocredits, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Info8.lang", infoinformations, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Info9.lang", infodisclaimer, True)

        '#Exit
        Dim exittitle, exit1, exit2 As String

        exittitle = "---------------------------------<Uscita>---------------------------------------"
        exit1 = "Sei sicuro di voler uscire? <Y/N>: "
        exit2 = "A presto!"

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Exit0.lang", exittitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Exit1.lang", exit1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Exit2.lang", exit2, True)

    End Sub
End Module
