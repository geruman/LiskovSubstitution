# Liskov Substitution

- Si S es un subtipo de T, entonces los objetos de tipo T en un programa de computadora pueden ser sustituidos por objetos de tipo S (es decir, los objetos de tipo S pueden sustituir objetos de tipo T), sin alterar ninguna de las propiedades deseables de ese programa (la corrección, la tarea que realiza, etc.)

## Se hace uso de interfaces para lograr un sistema más modular y no tener que recurrir a métodos vacios o que tiren NotImplementedException cuando necesitamos agregar "animales" que no
sepan correr, cazar o caminad. Simplemente implementamos las interfaces correspondientes a cada tipo de animal y podemos asegurarnos que cualquier implementador de la interfaz
pueda ser ejecutado.
