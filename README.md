# Hit 'Em all

*¡En la aldea virtual, tu destreza es esencial, en el juego de arquería, demuestra tu maestría!*

**Autores:**
- Muhammad Campos Preira.
- Alicia Guadalupe Cruz Pérez.
- Gabriel Jonay Vera Estévez.

## Cuestiones importantes para el uso

Hemos desarrolado un juego de arquería en el que el jugador debe disparar a los distintos objetivos (dianas y dummy) que aparecen en la pantalla. 

Como no contamos con mandos propios de RV, hemos optado por usar un controlador de PS4 para poder jugar. Podemos apuntar moviendo la cabeza y disparar con el botón 'x' del mando (La fuerza de disparo depende del tiempo de pulsación de dicho botón).

Existen tres modos de juego: *Modo normal*, *Modo Desafío* y *Modo difícil*.

### - Modo normal
En el modo normal. el jugador puede disparar a cuelquier objetivo que aparezca en la pantalla. El objetivo es conseguir la mayor puntuación posible.

### - Modo desafío
En el modo desafío, el jugador debe disparar a los objetivos que aparecen en la pantalla en un tiempo determinado. Cuando se le dispara a un objetivo, y acierta, este desaparece y aparece otro en otro lugar de la pantalla. El objetivo es conseguir la mayor puntuación posible en el tiempo establecido.

### - Modo difícil
En caso de que el jugador quiera un reto mayor, se puede activar el modo difícil (Movimiento). En este modo, los objetivos se mueven por la pantalla, por lo que es más difícil acertarles. Este aumento de dificultad puede ser activado en ambos modos de juego.

> [!IMPORTANT]
> Para activar los distintos modos de juego, el jugador cuenta con varios botones en la escena principal. 
>
> Si apuntamos hacia un botón durante 1.5 segundos, éste se activará.
> Si ya está activo, si lo volvemos a apuntar durante 1.5s, se desactivará.

## Hitos de programación

### **Controles**:
 
- Se ha implementado un sistema de disparo con el mando de PS4.
- Se ha implementando un sistema de apuntado con la cabeza.

### **Físicas y Movimiento**:

- Se ha conseguido que los objetivos se muevan por la pantalla de un lado a otro.
- Se ha conseguido que los objetivos se destruyan al ser golpeados por una flecha.
- El arco se mueve con la camara del jugador.
- El arco dispara flechas. (Lo hemos importado de la tienda de assets de Unity)

### **Eventos**:

- La puntuación y la aparición/desaparición de los objetivos (dianas y dummys). Cuando una flecha entra en contacto con un objetivo, éste lanzará el evento *IncrementarPuntuacion*, aumentando la puntuación total (dependiendo del valor del objetivo).
- Un objetivo desaparece si entra en contacto con una flecha y se activa en un lugar diferente del mapa.

### **Interfaces Multimodales**:

- Cuando se dispara una flecha y ésta entra en contacto con un objetivo, suena un sonido de acierto.
- Cuando se carga una flecha, se activa la vibración del mando de PS4.

## Aspectos destacados de la aplicación

- **Simulación de arquería en una aldea:** El usuario se encuentra en una aldea
virtual en la que puede practicar tiro con arco. El escenario está ambientado
con casas, árboles y demás detalles de la naturaleza, junto con dianas y dummies.

- **Disparo de flechas:** Como jugador, tienes control sobre el arco y las flechas.
Puedes manejar el arco y disparar como en la vida real.

- **Inmersión en el escenario:** El usuario tiene la libertad de observar el
escenario desde cualquier ángulo, pudiendo apuntar a los distintos objetivos sin
necesidad de moverse.

- **Interacción física:** Como jugador, tienes la capacidad de interactuar con
el escenario, pudiendo presionar los botones para activar los distintos modos de
juego.

## Sensores Multimodales

- **Cámara.** La cámara utiliza el sensor de rotación (giroscopio) para que el jugador pueda
observar el escenario desde cualquier ángulo.

## Gif animado de ejecución

![gif](./gif/gif.gif)

## Acta de los acuerdos del trabajo en equipo

En general, se desarrolló la aplicación trabajando conjuntamente en diferentes
sesiones.

- **Alicia**:
  - Buscar y descargar assets.
  - Crear el escenario.
  - Crear los scripts de los objetivos.
  - Crear los scripts de la puntuación.
- **Gabriel Jonay**:
  - Crear los scripts de los objetivos.
  - Crear los scripts de los modos de juego.
  - Crear los scripts de la puntuación.
- **Muhammad**:
  - Modificar los scripts de los arcos y las flechas.
  - Crear los scripts de los objetivos.
  - Crear los scripts de la puntuación.

