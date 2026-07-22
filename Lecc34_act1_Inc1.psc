Algoritmo ConversorBinarioDecimal
    Definir op, dec, decimal, resto, potencia, i Como Entero
    Definir bin Como Caracter

    Escribir "1- Decimal a Binario"
    Escribir "2- Binario a Decimal"
    Escribir "Elija una opción: "
    Leer op

    Si op = 1 Entonces
        Escribir "Ingrese número decimal: "
        Leer dec

        Si dec = 0 Entonces
            bin <- "0"
        SiNo
            bin <- ""
            Mientras dec > 0 Hacer
                resto <- dec MOD 2

                Si resto = 0 Entonces
                    bin <- Concatenar("0", bin)
                SiNo
                    bin <- Concatenar("1", bin)
                FinSi

                dec <- Trunc(dec / 2)
            FinMientras
        FinSi

        Escribir "Binario: ", bin

    SiNo
        Si op = 2 Entonces
            Escribir "Ingrese número binario: "
            Leer bin

            decimal <- 0
            potencia <- 0

            Para i <- Longitud(bin) Hasta 1 Con Paso -1 Hacer
                Si Subcadena(bin, i, i) = "1" Entonces
                    decimal <- decimal + 2 ^ potencia
                FinSi

                potencia <- potencia + 1
            FinPara

            Escribir "Decimal: ", decimal
        FinSi
    FinSi
FinAlgoritmo
