class Nodo:
    def __init__(self, dato=None, siguiente=None):
        self.dato = dato
        self.siguiente = siguiente


class ListaSimplementeLigada:
    def __init__(self):
        self.cabeza = None
        self.cola = None

    def esta_vacia(self):
        return self.cabeza is None

    def agregar(self, dato):
        nuevo_nodo = Nodo(dato)
        if self.esta_vacia():
            self.cabeza = nuevo_nodo
            self.cola = nuevo_nodo
        else:
            self.cola.siguiente = nuevo_nodo
            self.cola = nuevo_nodo

    def recorrer(self):
        if self.esta_vacia():
            print("La lista está vacía.")
        else:
            actual = self.cabeza
            while actual is not None:
                print(actual.dato)
                actual = actual.siguiente

    def eliminar(self, dato):
        if self.esta_vacia():
            print("La lista está vacía.")
        elif self.cabeza.dato == dato:
            self.cabeza = self.cabeza.siguiente
        else:
            actual = self.cabeza
            while actual.siguiente is not None and actual.siguiente.dato != dato:
                actual = actual.siguiente
            if actual.siguiente is None:
                print("El dato no se encontró en la lista.")
            else:
                actual.siguiente = actual.siguiente.siguiente
                if actual.siguiente is None:
                    self.cola = actual


# Crear una nueva lista
lista = ListaSimplementeLigada()

# Solicitar al usuario ingresar los números a la lista
for i in range(4):
    dato = int(input(f"Ingrese el número {i+1}: "))
    lista.agregar(dato)

# Mostrar el menú después de llenar la lista por primera vez
while True:
    print("-------- Menú --------")
    print("1. Imprimir lista")
    print("2. Eliminar elemento")
    print("3. Salir")
    opcion = int(input("Seleccione una opción: "))

    if opcion == 1:
        print("Lista:")
        lista.recorrer()
    elif opcion == 2:
        dato_eliminar = int(input("Ingrese el número a eliminar: "))
        lista.eliminar(dato_eliminar)
    elif opcion == 3:
        print("¡Hasta luego!")
        break
    else:
        print("Opción inválida. Por favor, seleccione una opción válida.")

