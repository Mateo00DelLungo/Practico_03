
# Proyecto[Practica_02]

#### Ejercicio Práctico sobre WebApi utilizando ASP.NET CORE.

Tomando como base la actividad Actividad Práctica 02, se pide:

- Refactorizar la Web API desarrollada agregando los siguientes componentes:

  	  ++ Un controlador llamado FacturaController (carpeta Controllers).

      ++ Refactorizar la implementación de una interfaz IAplicacion que exponga los servicios para: registrar, consultar (con filtros) y editar facturas.

      ++ Refactorizar la capa de acceso a datos para incluir la gestión de facturas. Se deberá prever la consulta de facturas por fecha y forma de pago.

- Utilizar la misma base de datos de la actividad 01

- Desarrollar el/los procedimientos almacenados que considere necesarios.

- Adicionalmente deberá probar la WebApi mediante la herramienta POSTMAN.


## API Reference

#### Get all Facturas

```http
  GET /api/Facturas
```
#### Insertar una Factura

```http
  POST /api/Facturas
```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `value` | `json` | Objeto de tipo Factura |

#### Get Factura by id

```http
  GET /api/Factura/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **Required**. Id de la factura |

#### Update Factura 

```http
  PUT /api/Factura/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **Required**. Id de la factura a actualizar |
|FROM BODY|
| `value`      | `json` | **Required**. Objeto factura con los datos a cambiar |

#### Delete Factura 
```http
  DELETE /api/Factura/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **Required**. Id de la factura a borrar |




## Estadísticas

![GitHub commit activity](https://img.shields.io/github/commit-activity/t/Mateo00DelLungo/Practico_03)
[![wakatime](https://wakatime.com/badge/user/ecb456c5-1b67-4281-9da9-456ba4d60a8e/project/68a53381-8842-4aff-8906-ccbe720b1298.svg)](https://wakatime.com/badge/user/ecb456c5-1b67-4281-9da9-456ba4d60a8e/project/68a53381-8842-4aff-8906-ccbe720b1298)
![GitHub top language](https://img.shields.io/github/languages/top/Mateo00DelLungo/Practico_03)


## Autor

- [@Mateo del lungo](https://github.com/Mudo0)🤓

