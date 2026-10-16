# Portafolio de Diego Calero

Proyecto básico en ASP.NET Core (.NET 8) que sirve una página estática.

## Estructura

```
PortafolioDiego/
├── PortafolioDiego.csproj
├── Program.cs
├── Properties/launchSettings.json
└── wwwroot/
    ├── index.html
    └── css/style.css
```

## Cómo ejecutarlo en Visual Studio 2022

Necesitas la carga de trabajo "ASP.NET y desarrollo web" y el SDK de .NET 8.

1. Abre `PortafolioDiego.csproj` (Archivo > Abrir > Proyecto o solución).
2. Elige el perfil **http** o **https** en la barra superior.
3. Presiona **F5**. Se abre el navegador con tu portafolio.

También puedes usar `dotnet run` en la carpeta del proyecto.

## Qué cambiar

- Descripción y proyectos: `wwwroot/index.html`
- Correo, teléfono y GitHub: sección Contacto de `index.html` (son datos de ejemplo)
- Colores: variables al inicio de `wwwroot/css/style.css`
