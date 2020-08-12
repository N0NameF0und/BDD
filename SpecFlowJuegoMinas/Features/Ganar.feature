# language: es
Característica: Ganar
    como usuario jugador
	quiero ganar el juego  
	Para obener el mayor puntaje posible

@mytag
Escenario: Estoy en la tabla minas y números
	Dado que escogo los cuadros alazar
	Cuando no selecciono ninguna mina
	Entonces gano el juego con mayor puntaje 