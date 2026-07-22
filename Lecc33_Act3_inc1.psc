Algoritmo ClasificarTriangulo
    Definir a,b,c Como Real
	
    Escribir "Ingrese el lado a: "
    Leer a
	
    Escribir "Ingrese el lado b: "
    Leer b
	
    Escribir "Ingrese el lado c: "
    Leer c
	
    Si a= b Y b = c Entonces
        Escribir "El triángulo es Equilátero."
    SiNo
        Si a = b O a = c O b = c Entonces
            Escribir "El triángulo es Isósceles."
        SiNo
            Escribir "El triángulo es Escaleno."
        FinSi
    FinSi
FinAlgoritmo
