Algoritmo ConversorMoneda
    Definir monto Como Real
    Definir resp Como Caracter

    Repetir
        Escribir "Ingrese la cantidad en moneda local: "
        Leer monto

        Escribir ""
        Escribir "Conversiones para ", monto, ":"
        Escribir "Dolar: ", monto * 0.13
        Escribir "Euro: ", monto * 0.12
        Escribir "Peso: ", monto * 2.30
        Escribir "Jen Japon: ", monto * 20.0
        Escribir "Libra Esterlina: ", monto * 0.10

        Escribir ""
        Escribir "¿Desea convertir otra cantidad? (s/n): "
        Leer resp

    Hasta Que resp <> "s" Y resp <> "S"
FinAlgoritmo
