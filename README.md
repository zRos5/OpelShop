# OpelShop – Prototipo de tienda Opel

Prototipo de aplicación de escritorio (WPF, .NET 10) hecho con Microsoft Blend para la Práctica 1 de Interfaces de Usuario (Grado en Ingeniería Informática en Tecnologías de la Información, UMH). Simula la tienda de un concesionario Opel.

> Es un prototipo universitario. Los coches, las descripciones y los precios son inventados. Opel y su logotipo son marcas de sus propietarios y se usan solo con fines académicos, sin fines comerciales.

## Qué tiene

- **Inicio:** banner con la oferta de invierno, novedades y mejores precios.
- **Productos:** 6 coches con filtro por tipo de motor y una ventana de detalle al pulsar cada uno.
- **Acceso:** login con contraseña oculta y mensajes de error claros, y pantalla para crear una cuenta.
- **Sesión:** el nombre del usuario aparece en la cabecera, con botón para cerrar sesión.
- **Cabecera común** con el logo y el menú en todas las pantallas.
- **3 animaciones cortas:** fundido al cambiar de pantalla, zoom en las tarjetas y sacudida del login cuando hay un error.

## Cómo ejecutarlo

1. Instalar Visual Studio con la carga de trabajo de escritorio de .NET y Blend, y el SDK de .NET 10.
2. Clonar el repositorio:
   ```
   git clone [COMPLETAR: https://github.com/TU-USUARIO/OpelShop.git]
   ```
3. Abrir el archivo `OpelShop.slnx`.
4. Pulsar **F5**.

Usuario de prueba (ficticio): `cliente` / `Opel2026`. También se puede crear una cuenta nueva desde "Regístrate". Las cuentas se guardan solo en memoria y se pierden al cerrar la app.

## Estructura del proyecto

| Archivo | Para qué sirve |
| --- | --- |
| `App.xaml` | Colores y estilos comunes (menú, botones y tarjeta de coche) |
| `MainWindow` | Cabecera, cambio de pantalla y estado de la sesión |
| `Inicio`, `Galeria`, `Login`, `Registro` | Las pantallas |
| `DetalleCoche` | Ventana con la información de un coche |
| `Coche.cs` | Datos de los 6 coches |
| `Usuarios.cs` | Cuentas y usuario que ha iniciado sesión |
| `Assets/` | Logo y fotos |

## Enlaces

| Qué | Enlace |
| --- | --- |
| Documentación técnica | [COMPLETAR: enlace o ruta, por ejemplo `docs/documentacion.pdf`] |
| Prototipo | [COMPLETAR: versión publicada en el repositorio o vídeo de demostración] |
| Conversación con la IA | [COMPLETAR: ruta, por ejemplo `docs/conversacion-ia.md`] |

## Recursos y licencias

| Recurso | Origen | Licencia |
| --- | --- | --- |
| Logo de Opel | [COMPLETAR: enlace] | Marca registrada, uso académico |
| Foto Opel Corsa | [COMPLETAR: enlace y autor] | [COMPLETAR] |
| Foto Opel Frontera | [COMPLETAR: enlace y autor] | [COMPLETAR] |
| Foto Opel Mokka | [COMPLETAR: enlace y autor] | [COMPLETAR] |
| Foto Opel Combo | [COMPLETAR: enlace y autor] | [COMPLETAR] |
| Foto Opel Grandland | [COMPLETAR: enlace y autor] | [COMPLETAR] |
| Foto Opel Astra | [COMPLETAR: enlace y autor] | [COMPLETAR] |
| Segoe UI (tipografía) | Viene con Windows | Licencia de Microsoft |

No se han usado librerías ni plantillas de terceros, solo WPF y .NET.

## Uso de IA

He usado Claude (Anthropic) en claude.ai, versión Claude Sonnet 5.5, el 9 de noviembre de 2026, para aprender a usar Blend y GitHub, generar código XAML y C#, arreglar errores de compilación y sacar un borrador de la documentación. Yo elegí la marca y la idea, integré y probé cada archivo, hice las pruebas con usuarios y decidí qué mejorar. La conversación completa está publicada en la ruta de la tabla de enlaces, y la documentación técnica explica qué acepté, cambié y descarté.

## Licencia

El código tiene licencia MIT (ver el archivo `LICENSE`). El logo y las fotos son de terceros y no están incluidos en esa licencia.

## Autor

Sergio Ros León
