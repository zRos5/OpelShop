# OpelShop – Prototipo de tienda Opel con Microsoft Blend

Prototipo de aplicación de escritorio (WPF) para que los concesionarios ofrezcan a sus clientes los modelos de Opel. Es la **Práctica 1 de Interfaces de Usuario** (Grado en Ingeniería Informática en Tecnologías de la Información, UMH).

**Alumno:** Sergio Ros León

## Qué hace la aplicación

- **Inicio:** banner con la oferta de invierno y las secciones *Novedades* y *Mejores precios*.
- **Productos:** los 6 modelos en tarjetas, con filtro por tipo (eléctrico, híbrido o gasolina). Al pulsar una tarjeta se abre una ventana con el detalle del coche.
- **Acceso:** inicio de sesión con contraseña oculta y mensajes de error claros.
- **Registro:** creación de cuenta con validación.
- **Cabecera común** en todas las pantallas: logotipo, menú y, si hay sesión iniciada, saludo y botón *Cerrar sesión*.
- **Animaciones cortas:** fundido al cambiar de pantalla, zoom en las tarjetas y sacudida del formulario de acceso cuando hay un error.

## Requisitos

- Windows
- Visual Studio con la carga de trabajo de **desarrollo de escritorio de .NET** y Blend
- SDK de **.NET 10**

## Cómo ejecutarlo

1. Clona el repositorio o descárgalo con **Code → Download ZIP**.
2. Abre el archivo `OpelShop.slnx` con Visual Studio o Blend.
3. Pulsa **F5**.
4. Entra con el usuario de prueba **`cliente`** y la contraseña **`Opel2026`**, o crea una cuenta nueva desde *Regístrate*.

> Las cuentas se guardan en memoria: las que crees se borran al cerrar la aplicación.

## Estructura del proyecto

| Archivo | Para qué sirve |
| --- | --- |
| `App.xaml` | Colores y estilos comunes: menú, botones y tarjeta de coche |
| `MainWindow` | La cabecera, el cambio de pantalla y el estado de la sesión |
| `Inicio`, `Galeria`, `Login`, `Registro` | Las pantallas |
| `DetalleCoche` | Ventana con la información de un coche |
| `Coche.cs` | Los datos de los 6 coches |
| `Usuarios.cs` | Las cuentas y quién ha iniciado sesión |
| `Assets` | El logo y las fotos |

## Documentación

La documentación técnica completa (requisitos, decisiones de diseño, pruebas con usuarios, recursos y uso de IA) se entrega junto con la práctica.

## Uso de IA y ayuda externa

- **Claude (claude.ai):** organización del trabajo, revisión del código, guía de GitHub y revisión de la documentación. [Conversación pública](https://claude.ai/share/08c842ac-74b0-4350-8bcc-16768fdc58fc).
- **Gemini:** apoyo con las animaciones.
- El código C# lo hice con la ayuda de mi profesor de programación de la Academia Alba (Murcia), en clases particulares.

## Recursos y licencia

- El **código** del proyecto está bajo licencia MIT (ver `LICENSE`).
- El **logotipo de Opel** es una marca registrada, y las **fotos de los coches** son de webs de terceros y del fabricante. Se usan solo con fines académicos, sin fines comerciales, y **no están cubiertos por la licencia MIT**. Su procedencia está en la documentación técnica.
- Los datos de los coches (descripciones y precios) son inventados.
