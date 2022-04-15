# Serializacji i deserializacja


# Właściwości Kontrolek

## 1.	Kontrolki przycisku (5 x Button):

 
### a.	Button „new_bt”  właściwości:
		Text z wartością „New”

### b.	Button „save_bt”  właściwości:
		Text z wartością „Save”

### c.	Button „load_bt”  właściwości:
		Text z wartością „Load”



### d.	Button „mat_bt”  właściwości:
		Text z wartością „Magic”

### e.	Button „at_bt”  właściwości:
		Text z wartością „Attack”





 

## 2.	Kontrolki miejsca na obraz (4 x PictureBox):

 
### a.	PictureBox „player_pb” właściwości:
 		SizeMode z wartością „AutoSize”
		Image z ustawieniem na dany obraz

### b.	PictureBox „wolf_pic” właściwości:
		SizeMode z wartością „AutoSize”
		Image z ustawieniem na dany obraz


### c.	PictureBox „atackp_pc” właściwości:
		SizeMode z wartością „StrechImage”
		Image z ustawieniem na dany obraz

### d.	PictureBox „atackw_pc” właściwości:
		SizeMode z wartością „StrechImage”
		Image z ustawieniem na dany obraz


 

## 3.	Kontrolki etykiety (5 x Label):

 
### a.	Label „playerinfo_lb” wartości:
		Font – Size na wartość 9

### b.	Label „wolfinfo_lb” wartości:
		Font – Size na wartość  9

### c.	Label „hit_lb” wartości:
		Font – Size na wartość 12

### d.	Label „tura_lb” wartości:
		Font – Size na wartość 20

### e.	Label „turaliczba_lb” wartości:
		Font – Size na wartość 20


 

## 4.	Kontrolka okna (1 x Form):
### a.	Form „Form1” właściwości:
		FormBorderStyle na wartość „FixedSingle”
		Text na wartość „Serializator2000”
		MaximizeBox, MinimizeBox na wartość „False”




# Przydatne metody

## Metoda „createNewWolf” 
##### 	Tworzy nowy obiekt przeciwnika


## Metoda „showPlayerAttackElements” 
##### 	Wyświetla informacje o trafieniach gracza


## Metoda „showWolfAttackElements” 
##### 	Wyświetla informacje o trafieniach przeciwnika


## Metoda „resetValue” 
##### 	Resetuje wszystkie wartości


## Metoda „reloadStats” 
##### 	Uaktualnia i wyświetla statystyki gracza



## Metoda „configurateStream” wraz z nadpisem
##### 	Konfiguruje strumień danych do zapisu i odczytu


## Metoda „saveObject” i „loadObject”
##### 	Serializuje i deserializuje obiekt gracza


## Metoda „SetTimeout”  
##### 	Wywołuje inną metode po określonym czasie w milisekundach


## Metoda „gameOver”  
##### 	Zakończenie gry 


## Metoda „gameStart”  
##### 	Rozpoczęcie gry 
