Considero que es mejor crear el script 'Contador' y después varios scripts (oro, conocimiento, madera y comida) que hereden
de este script 'Contador'. 

Si te fijas, los métodos start() y update() de cada script actual hacen, en esencia, lo mismo (sumar 1 cada x ms). Aplicando la herencia
te ahorras mucho código a escribir y, además, es más fácil de mantener. También, a la hora de actualizar los valores de estos contadores,
podrías crear un método con clausura protected (o public, según desde donde se vaya a llamar este método) en el script padre que te serviría para todos sus hijos. Revisa la herencia de las tropas para ver un ejemplo más gráfico.

La idea de que haya un script para cada contador es realmente buena y útil, pues es totalmente necesario para que cada contador tenga valores propios!!

Si tienes alguna duda puedes pedirme y vemos cómo lo planteamos.

PD: Multiplicar por Time.deltaTime es algo que no hice en su día pero está la mar de bien. Buen trabajo!! :D