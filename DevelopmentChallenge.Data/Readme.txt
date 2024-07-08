Pasos para agregar una figura nueva:

* Modificar el enum "TipoForma", agregando la nueva forma al listado
* Declarar la clase con la funcionalidad
* Configurar en los archivos de idioma el nombre de la nueva figura, usando el nombre de la nueva figura como llave:
    {
        "Id": "FiguraNueva",
        "Texto": "Figura Nueva Singular"
    },
    {
        "Id": "FiguraNueva_plural",
        "Texto": "Figura Nueva Plural"
    }

Para agregar un nuevo idioma:

    Existen dos formas de generar un nuevo idioma

        1) Configurar manualmente un nuevo tipo diccionario con las claves correspondientes, y usarlo como parametro para el constructor
        2) Configurar un nuevo archivo con las claves correspondientes, y configurar un nuevo idioma en el enum "Idioma"