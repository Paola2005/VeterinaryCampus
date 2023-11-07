@echo off
setlocal enabledelayedexpansion

REM Pregunta al usuario por el número de entidades
set /p "num_entidades=Introduce el número de entidades: "

REM Ciclo para crear las entidades
for /l %%i in (1, 1, %num_entidades%) do (
    set /p "nombre_entidad=Introduce el nombre de la entidad %%i: "

    REM Crear la carpeta para la entidad
    mkdir "Domain\Entities"

    REM Generar el código base para la entidad
    (
        echo using System;
        echo using System.Collections.Generic;
        echo using System.Linq;
        echo using System.Threading.Tasks;
        echo.
        echo namespace Domain.Entities
        echo {
        echo     public class !nombre_entidad! : BaseEntity
        echo     {
        echo         public string Name { get; set; }
        echo     }
        echo }
    )> "Domain\Entities\!nombre_entidad!.cs"


    REM Crea el controlador en API\Controllers
    echo.>"Domain\Interfaces\I!nombre_entidad!.cs"


    REM Crea el controlador en API\Controllers
    echo.>"API\Controllers\!nombre_entidad!Controller.cs"

    REM Crea el Dto en API\Dtos
    echo.>"API\Dtos\!nombre_entidad!Dto.cs"

    REM Crea el Repository en API\Repository
    echo.>"Application\Repository\!nombre_entidad!Repository.cs"

    REM Crea la Configuracion en Persistencia\Data\Configuration
    echo.>"Persistence\Data\Configuration\!nombre_entidad!Configuration.cs"




    
)

echo Proceso completado. Pulsa una tecla para salir.
pause > nul
