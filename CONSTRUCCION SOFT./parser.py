from xml.dom import minidom

# Ruta del archivo XML en la misma carpeta
ruta_xml = "/ejemplo.xml"

# Parsear el archivo XML
doc = minidom.parse(ruta_xml)

# Obtener la raíz del documento
raiz = doc.documentElement

# Obtener todas las películas
peliculas = doc.getElementsByTagName("pelicula")

print("Pequeña presentación de las películas de terror mas famosas del cine mundial")

# Iterar sobre las películas y mostrar su contenido
for pelicula in peliculas:
    titulo = pelicula.getElementsByTagName("titulo")[0].childNodes[0].nodeValue
    director = pelicula.getElementsByTagName("director")[0].childNodes[0].nodeValue
    año = pelicula.getElementsByTagName("año")[0].childNodes[0].nodeValue

    print("--------")

    print(f"Titulo: {titulo}")
    print(f"Director: {director}")
    print(f"Año: {año}")
    print("--------")
