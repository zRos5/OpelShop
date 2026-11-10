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
   git clone https://github.com/zRos5/OpelShop.git
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
| Logo de Opel | [PNGWing](https://www.pngwing.com/es/free-png-bkooi) | Marca registrada, uso académico |
| Foto Opel Corsa | [Qué coche me compro](https://www.quecochemecompro.com/fotos/opel-corsa/) | Derechos de su propietario; uso solo académico, sin fines comerciales |
| Foto Opel Frontera | [Drivek](https://www.drivek.es/opel/frontera/) | Derechos de su propietario; uso solo académico, sin fines comerciales |
| Foto Opel Mokka | [Opel España](https://www.opel.es/hub/datasheet/mokka-my26-es.html) | Derechos de su propietario; uso solo académico, sin fines comerciales |
| Foto Opel Combo | [Opel Chiclana](https://www.opelchiclana.com/vehiculos-comerciales/opel/combo/furgon-3-puertas/2024/) | Derechos de su propietario; uso solo académico, sin fines comerciales |
| Foto Opel Grandland | [Carwow](https://www.carwow.es/opel/grandland) | Derechos de su propietario; uso solo académico, sin fines comerciales |
| Foto Opel Astra | [Fiat Eira Motor](https://www.fiateiramotor.com/coches/nuevos/opel/astra-plug-in-hybrid/familiar-5-puertas/2026/) | Derechos de su propietario; uso solo académico, sin fines comerciales |
| Segoe UI (tipografía) | Viene con Windows | Licencia de Microsoft |

No se han usado librerías ni plantillas de terceros, solo WPF y .NET.

## Uso de IA

He usado Claude (Anthropic) en claude.ai, versión Claude Sonnet 5.5, el 9 de noviembre de 2026, para aprender a usar Blend y GitHub, generar código XAML y C#, arreglar errores de compilación y sacar un borrador de la documentación. Yo elegí la marca y la idea, integré y probé cada archivo, hice las pruebas con usuarios y decidí qué mejorar. La conversación completa está publicada en la ruta de la tabla de enlaces, y la documentación técnica explica qué acepté, cambié y descarté.

## Licencia

El código tiene licencia MIT (ver el archivo `LICENSE`). El logo y las fotos son de terceros y no están incluidos en esa licencia.

## Autor

Sergio Ros León
