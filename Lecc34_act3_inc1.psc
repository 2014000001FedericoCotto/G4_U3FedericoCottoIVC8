Algoritmo ConversionTemperatura
    Definir c, resultado Como Real
    Definir op Como Caracter

    Escribir "Ingrese grados Centígrados (°C): "
    Leer c

    Escribir "a. Fahrenheit"
    Escribir "b. Celsius"
    Escribir "c. Kelvin"
    Escribir "Opción: "
    Leer op

    Si op = "a" O op = "A" Entonces
        resultado <- (c * 9 / 5) + 32
        Escribir c, " °C = ", resultado, " °F"

    SiNo
        Si op = "b" O op = "B" Entonces
            Escribir c, " °C = ", c, " °C"

        SiNo
            Si op = "c" O op = "C" Entonces
                resultado <- c + 273.15
                Escribir c, " °C = ", resultado, " K"

            SiNo
                Escribir "Opción no válida."
            FinSi
        FinSi
    FinSi
FinAlgoritmo
