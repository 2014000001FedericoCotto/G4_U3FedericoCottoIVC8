Algoritmo CalcularCambio
    Definir precio, pago, cambio Como Entero
    Definir b200, b100, b50, b20, monedas Como Entero

    Escribir "Ingrese el precio del producto: "
    Leer precio

    Escribir "Ingrese la denominación dada por el cliente: "
    Leer pago

    cambio <- pago - precio

    Si cambio < 0 Entonces
        Escribir "Monto insuficiente."
    SiNo
        Escribir ""
        Escribir "Cambio total: ", cambio

        b200 <- Trunc(cambio / 200)
        cambio <- cambio MOD 200

        b100 <- Trunc(cambio / 100)
        cambio <- cambio MOD 100

        b50 <- Trunc(cambio / 50)
        cambio <- cambio MOD 50

        b20 <- Trunc(cambio / 20)
        cambio <- cambio MOD 20

        monedas <- cambio

        Escribir "Billetes de 200: ", b200
        Escribir "Billetes de 100: ", b100
        Escribir "Billetes de 50: ", b50
        Escribir "Billetes de 20: ", b20
        Escribir "Monedas: ", monedas
    FinSi
FinAlgoritmo
