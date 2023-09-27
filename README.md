# Interfaces Inteligentes
## Práctica 2
### Diego Herrera Mendoza
Introducción a C#

En esta práctica se ha pedido realizar varios ejercicios de scripting en Unity con C#. Cada ejercicio será escrito con su mostrado con su enunciado y un gif de su correcto funcionamiento.

1. Crea un script asociado al cubo que inicialice un array a un conjunto de valores numéricos aleatorios entre 0 y 25. En cada frame se debe cambiar una posición aleatoria y mostrar en pantalla en la consola los que sean mayores que 15. Parametrizar el rango para poderlo cambiar desde el inspector. 

![Ejercicio1](gifs/Ejercicio1.gif)

Script: [RandomArray.cs](scripts/RandomArray.cs)

---

2. Crea una escena simple en la que ubiques un plano y sobre él un cubo, una esfera y un cilindro. Cada uno de los objetos debe estar en un color diferente. En la consola cada objeto debe mostrar su nombre

![Ejercicio2](gifs/Ejercicio2.gif)

Script: [ShowName.cs](scripts/ShowName.cs)

---

3. Crea un script asociado a la esfera con dos variables Vector3 públicas. Dale valor a cada componente de los vectores desde el inspector. Muestra en la consola:

- La magnitud de cada uno de ellos. 
- El ángulo que forman
- La distancia entre ambos.
- Un mensaje indicando qué vector está a una altura mayor.

He añadido el ejercicio 4 a este script ya que solo era mostrar la posición de la esfera.

![Ejercicio3](gifs/Ejercicio3.gif)

Script: [SphereVector.cs](scripts/SphereVector.cs)

---

4. Muestra en pantalla el vector con la posición de la esfera.

*Se muestra en el anterior ejercicio*

---

5. Crea un script para la esfera que muestre en consola la distancia a la que están el cubo y el cilindro.

![Ejercicio5](gifs/Ejercicio5.gif)

Script: [DistanceFrom.cs](scripts/DistanceFrom.cs)

---

6. Crea un script que alinee el cilindro y el cubo con la esfera, 5  unidades a derecha e izquierda respectivamente en el eje X. Prueba a cambiar a cambiar la coordenada x de la posición de la esfera en el Inspector de Objetos.

![Ejercicio6](gifs/Ejercicio6.gif)

Script: [Align.cs](scripts/Align.cs)

---

7. Cambia el color del cilindro cuando el usuario pulse la tecla A, cambia el color del cubo cuando el usuario pulse la flecha arriba.

![Ejercicio7](gifs/Ejercicio7.gif)

Script: [ChangeColor.cs](scripts/ChangeColor.cs)

---

8. Agrega 5 esferas más en la escena. Crea un grupo de 2 , asígnales la misma etiqueta y a las restantes otra etiqueta diferente a ésta. Crea un vector con las distancias de cada una de las del segundo grupo al cubo. Sube en altura (aumenta la y) de la esfera más cercana. Cambiar color de la más lejana cuando el jugador pulsa la tecla espacio.

![Ejercicio8](gifs/Ejercicio8.gif) 

---

Script: [SpheresManagment.cs](scripts/SpheresManagment.cs)

