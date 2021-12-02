//Applicazione per gestire il noleggio di Veicoli.

// I veicoli sono caratterizzati da:
// - Targa
// - Modello 
// - Tariffa giornaliera

// I veicoli a noleggio sono furgoni e automobili.

//Le automobili hanno:
//- numero di posti

//I furgoni hanno:
//- capacità di carico espressa in kg.

//Il noleggio ha:
//- Id (identificativo)
//- Data di inizio,
//- Numero di giorni
//- Costo totale,
//- Codice fiscale del Cliente,
//- Targa del Veicolo

//Il cliente ha:
//- Nome,
//- Cognome, 
//- Codice fiscale

//Inizializzare una lista di clienti, di veicoli disponibili e di noleggi già esistenti
//(alcuni attivi e alcuni terminati)

//Noleggi
//ID; Targa;  CodiceFiscale;    DataInizio;     NumeroGiorni; Costo
//1; AX743HJ; RSSMRA76A01L219J; 29 / 11 / 2021; 5;            275
//2; GJ924LR; RSSMRA76A01L219J; 3 / 12 / 2021;  2;            120
//3; UY248QW; RSSMRA76A01L219J; 7 / 6 / 2020;   1;            65
//4; AX743HJ; RSSMRA80A01L219M; 10 / 10 / 2021; 1;            70
//5; TY467WE; RSSMRA80A01L219M; 29 / 11 / 2021; 5;            625
//6; GH567KU; RSSMRA80A01L219M; 19 / 4 / 2020;  3;            600

//Clienti
//CodiceFiscale;    Nome;  Cognome
//RSSMRA76A01L219J; Mario; Rossi
//RSSMRC80A01L219M; Marco; Rossi

//Veicoli
//Targa; Modello; Tariffa; Posti / Capacità
//AX743HJ; Fiat Panda; 55; 4 (automobile)
//GJ924LR; Fiat Punto; 60; 5 (automobile)
//UY248QW; Fiat Tipo; 65; 5 (automobile)
//GK823NB; Smart fortwo coupè; 70; 2 (automobile)
//TY467WE; Fiat Ducato; 125; 750 (furgone)
//GH567KU; Fiat Fiorino; 100; 450 (furgone)

//All'accesso, l'utente può:
//1 Visualizzare tutti i noleggi, con i dati del veicolo e del cliente
//2 Visualizzare i noleggi di un certo veicolo (input: targa)
//3 Visualizzare i dettagli di un certo noleggio (input: id)
//4 Visualizzare i noleggi attivi
//5 Inserire un nuovo noleggio verificando che il veicolo non sia impegnato.
//Il costo del noleggio si calcola moltiplicando la tariffa per il numero
//di giorni.
//6 Data una targa, calcolare il totale in euro dei noleggi
//7 Ricavare il totale in euro dei noleggi di automobili

using Academy.Week1.VR.Client;

Menu.Start();