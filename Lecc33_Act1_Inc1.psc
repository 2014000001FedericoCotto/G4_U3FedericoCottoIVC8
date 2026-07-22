Algoritmo AgendaTelefonica
    Definir nombres, telefonos Como Caracter
    Definir i, pos Como Entero
	
    Dimension nombres[10]
    Dimension telefonos[10]
	
    Para i <- 1 Hasta 10 Hacer
        Escribir "Ingrese el nombre ", i, ":"
        Leer nombres[i]
		
        Escribir "Ingrese el teléfono ", i, ":"
        Leer telefonos[i]
    FinPara
	
    Escribir ""
    Escribir "Ingrese la posición que desea consultar (1-10):"
    Leer pos
	
    Si pos >= 1 Y pos <= 10 Entonces
        Escribir "Nombre: ", nombres[pos]
        Escribir "Teléfono: ", telefonos[pos]
    SiNo
        Escribir "Posición no válida."
    FinSi
FinAlgoritmo
