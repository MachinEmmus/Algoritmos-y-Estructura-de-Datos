# Importar las clases Cola y Nodo

class ColaArreglo:
    def __init__(self):
        self.items = []

    def verificar_cola(self):
        return self.items == []

    def encolar(self, item):
        self.items.append(item)

    def desencolar(self):
        return self.items.pop(0)

    def primero(self):
        if not self.verificar_cola():
            return self.items[0]
        else:
            return None

class Nodo:
    def __init__(self, valor):
        self.valor = valor
        self.siguiente = None

class Cola:
    def __init__(self):
        self.cabeza = None
        self.cola = None

    def verificar_cola(self):
        return self.cabeza == None

    def encolar(self, valor):
        nuevo_nodo = Nodo(valor)
        if self.cola:
            self.cola.siguiente = nuevo_nodo
        else:
            self.cabeza = nuevo_nodo
        self.cola = nuevo_nodo

    def desencolar(self):
        if self.cabeza == None:
            return None
        valor = self.cabeza.valor
        self.cabeza = self.cabeza.siguiente
        if not self.cabeza:
            self.cola = None
        return valor

    def primero(self):
        if not self.verificar_cola():
            return self.cabeza.valor
        else:
            return None

# Función para el menú interactivo
def menu_interactivo():
    cola = None
    while True:
        print("1. Utilizar Cola con Arreglos")
        print("2. Utilizar Cola con Listas Ligadas")
        print("3. Salir")
        opcion = input("Ingrese su opción: ")
        if opcion == "1":
            cola = ColaArreglo()
            break
        elif opcion == "2":
            cola = Cola()
            break
        elif opcion == "3":
            return
        else:
            print("Opción no válida. Intente de nuevo.")

    while True:
        print("\n1. Verificar si la cola está vacía")
        print("2. Encolar un elemento")
        print("3. Desencolar un elemento")
        print("4. Ver el primer elemento de la cola")
        print("5. Salir")
        opcion = input("Ingrese su opción: ")
        if opcion == "1":
            if cola.verificar_cola():
                print("La cola está vacía.")
            else:
                print("La cola no está vacía.")
        elif opcion == "2":
            valor = input("Ingrese el valor a encolar: ")
            cola.encolar(valor)
            print(f"Se encoló el valor {valor}.")
        elif opcion == "3":
            valor = cola.desencolar()
            if valor is None:
                print("La cola está vacía.")
            else:
                print(f"Se desencoló el valor {valor}.")
        elif opcion == "4":
            valor = cola.primero()
            if valor is None:
                print("La cola está vacía.")
            else:
                print(f"El primer valor en la cola es {valor}.")
        elif opcion == "5":
            return
        else:
            print("Opción no válida. Intente de nuevo.")

menu_interactivo()

