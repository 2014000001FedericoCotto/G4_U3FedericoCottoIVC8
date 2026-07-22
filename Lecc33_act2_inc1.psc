Algoritmo InvertirFrase
    Definir frase, invertida Como Caracter
    Definir i Como Entero

    Escribir "Ingrese una frase: "
    Leer frase

    invertida <- ""

    Para i <- Longitud(frase) Hasta 1 Con Paso -1 Hacer
        invertida <- Concatenar(invertida, Subcadena(frase, i, i))
    FinPara

    Escribir invertida
FinAlgoritmo
