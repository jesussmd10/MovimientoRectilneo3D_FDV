
---

## Índice de Demostraciones
1. [Movimiento Básico con Translate](#1-movimiento-básico-con-translate)
2. [Consistencia Vectorial y Temporal (Time.deltaTime)](#2-consistencia-vectorial-y-temporal-timedeltatime)
3. [Persecución de Posición y Espacio Global (Space.World)](#3-persecución-de-posición-y-espacio-global-spaceworld)
4. [Depuración Visual con Raycasts (Debug.DrawRay)](#4-depuración-visual-con-raycasts-debugdrawray)
5. [Seguimiento de Cubo por Teclado y Sprint](#5-seguimiento-de-cubo-por-teclado-y-sprint)
6. [Movimiento Rectilíneo Local (Vector3.forward)](#6-movimiento-rectilíneo-local-vector3forward)
7. [Control de Jittering y MoveTowards](#7-control-de-jittering-y-movetowards)
8. [Rotación Suave con Quaternion.Slerp](#8-rotación-suave-con-quaternionslerp)
9. [Sistema de Waypoints Básicos (Bucle por Módulo)](#9-sistema-de-waypoints-básicos-bucle-por-módulo)
10. [Sistema Avanzado con WaypointCircuit y ProgressTracker](#10-sistema-avanzado-con-waypointcircuit-y-progresstracker)

---

### 1. Movimiento Básico con Translate
* **Descripción:** Desplazamiento inicial del objeto hacia un punto fijo especificado en el espacio utilizando el método básico `Translate` ejecutado en el `Start`.

> ![Ejecución Ejercicio 1](./Assets/Media/p1.gif)

---

### 2. Consistencia Vectorial y Temporal (Time.deltaTime)
* **Descripción:** Demostración del movimiento suavizado e independiente del rendimiento (*framerate*) aplicando vectores normalizados y el factor temporal `Time.deltaTime`.

> ![Ejecución Ejercicio 2](./Assets/Media/p2.gif)

---

### 3-4. Persecución de Posición y Espacio Global (Space.World) con depuración Visual con Raycasts (Debug.DrawRay)
* **Descripción:** El personaje persigue dinámicamente la posición de un objeto de referencia calculando la distancia real y aplicando la traslación en el espacio global del mundo.

> ![Ejecución Ejercicio 3](./Assets/Media/p4.gif)

---


### 5. Seguimiento de Cubo por Teclado y Sprint
* **Descripción:** Interacción en tiempo de ejecución donde el usuario mueve libremente un cubo con las flechas de dirección y el personaje lo persigue aplicando un incremento de velocidad al pulsar la barra espaciadora.

> ![Ejecución Ejercicio 5](./Assets/Media/p5.gif)

---

### 6. Movimiento Rectilíneo Local (Vector3.forward)
* **Descripción:** Avance en línea recta optimizado utilizando el sistema de referencia local del personaje (`Vector3.forward`) tras haberlo orientado con `LookAt`.

> ![Ejecución Ejercicio 6](./Assets/Media/p6.gif)

---

### 7. Control de Jittering y MoveTowards
* **Descripción:** Solución al problema de oscilación y vibración (*jittering*) al llegar al destino mediante rangos de tolerancia (`accuracy`) y la función de parada exacta `Vector3.MoveTowards`.

> ![Ejecución Ejercicio 7](./Assets/Media/p7.gif)

---

### 8. Rotación Suave con Quaternion.Slerp
* **Descripción:** Transición fluida y orgánica de la orientación del personaje eliminando los giros bruscos de 180 grados mediante interpolación esférica lineal.

> ![Ejecución Ejercicio 8](./Assets/Media/p9.gif)

---

### 9. Sistema de Waypoints Básicos (Bucle por Módulo)
* **Descripción:** Recorrido automatizado de un circuito cerrado compuesto por múltiples puntos etiquetados como `"waypoint"`, gestionando el índice secuencial mediante el operador módulo.

> ![Ejecución Ejercicio 9](./Assets/Media/p10.gif)

---

