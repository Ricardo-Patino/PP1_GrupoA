Aplicación web en asp.net, utilizando el MVC framework. Está formada por tres controllers y cada controller cuenta con una vista que permite visualizar una lista de models (relacionada a cada controller).
Esta aplica los diferentes RazorViewEngine tags (if, for, foreach, switch). 
Cuenta con una pantalla para "crear" que realiza un POST al controller y salva items a cada lista. 
Ya que no persiste en memoria, únicamente durante la operación en cuestión, el POST request devuelve la lista existente más el ítem agregado.
