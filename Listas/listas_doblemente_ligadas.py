class Nodo:
    def __init__(self, valor=None):
        self.valor = valor
        self.siguiente = None
        self.anterior = None

class ListaDoble:
    def __init__(self):
        self.cabeza = None
        self.cola = None
        self.longitud = 0
        
    def agregar_nodo(self, valor):
        nuevo_nodo = Nodo(valor)
        if self.cabeza is None:
            self.cabeza = nuevo_nodo
            self.cola = nuevo_nodo
        else:
            nuevo_nodo.anterior = self.cola
            self.cola.siguiente = nuevo_nodo
            self.cola = nuevo_nodo
        self.longitud += 1
        
    def recorrer(self):
        nodo_actual = self.cabeza
        while nodo_actual is not None:
            print(nodo_actual.valor, end=" ")
            nodo_actual = nodo_actual.siguiente
        print()
        
    def eliminar_nodo(self, valor):
        nodo_actual = self.cabeza
        while nodo_actual is not None:
            if nodo_actual.valor == valor:
                if nodo_actual.anterior is None:
                    self.cabeza = nodo_actual.siguiente
                    if self.cabeza is not None:
                        self.cabeza.anterior = None
                else:
                    nodo_actual.anterior.siguiente = nodo_actual.siguiente
                if nodo_actual.siguiente is None:
                    self.cola = nodo_actual.anterior
                    if self.cola is not None:
                        self.cola.siguiente = None
                else:
                    nodo_actual.siguiente.anterior = nodo_actual.anterior
                self.longitud -= 1
                return
            else:
                nodo_actual = nodo_actual.siguiente
        print("El valor no se encuentra en la lista.")

def imprimir_menu():
    print("_______________MÉNU_______________")
    print("1. Agregar un valor a la lista")
    print("2. Recorrer la lista")
    print("3. Eliminar un valor de la lista")
    print("4. Salir")

# Crear una lista vacía
lista = ListaDoble()

# Ciclo principal del programa
while True:
    imprimir_menu()
    opcion = int(input("Ingrese una opción: "))
    
    if opcion == 1:
        valor = int(input("Ingrese el valor que desea agregar: "))
        lista.agregar_nodo(valor)
        print("El nodo ha sido agregado")
    elif opcion == 2:
        lista.recorrer()
    elif opcion == 3:
        valor = int(input("Ingrese el valor que desea eliminar: "))
        lista.eliminar_nodo(valor)
        print("El nodo ha sido eliminado")
    elif opcion == 4:
        break
    else:
        print("Opción inválida, intente de nuevo.")
    
    print()

