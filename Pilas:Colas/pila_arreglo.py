class Pila:
    def __init__(self):
        self.items = []

    def verificar_pila(self):
        return self.items == []

    def apilar(self, item):
        self.items.append(item)

    def desapilar(self):
        return self.items.pop()
        
# Importar las clases de Pila y Nodo, si se está utilizando la implementación de Listas Ligadas
# desde pila_lista_ligada import Pila, Nodo

# Función para mostrar el menú
def mostrar_menu():
    print("1. Verificar si la pila está vacía")
    print("2. Apilar un elemento")
    print("3. Desapilar un elemento")
    print("4. Salir")

# Crear una instancia de la Pila
pila = Pila()

# Mostrar el menú por primera vez
mostrar_menu()

# Variable para controlar el bucle del menú
opcion = 0

while opcion != 4:
    opcion = int(input("Ingrese una opción: "))

    if opcion == 1:
        if pila.verificar_pila():
            print("La pila está vacía")
        else:
            print("La pila no está vacía")

    elif opcion == 2:
        elemento = input("Ingrese el elemento que desea apilar: ")
        pila.apilar(elemento)
        print("El elemento", elemento, "ha sido apilado")

    elif opcion == 3:
        elemento_desapilado = pila.desapilar()
        if elemento_desapilado == None:
            print("La pila está vacía, no se puede desapilar")
        else:
            print("El elemento", elemento_desapilado, "ha sido desapilado")

    elif opcion == 4:
        print("Saliendo del programa...")
    
    else:
        print("Opción inválida. Por favor ingrese una opción válida.")

    # Mostrar el menú después de cada opción
    mostrar_menu()
