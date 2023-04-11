class Node:
    def __init__(self, data):
        self.data = data
        self.next = None

class LinkedList:
    def __init__(self):
        self.head = None

    def add_node(self, data):
        new_node = Node(data)
        if not self.head:
            self.head = new_node
        else:
            current = self.head
            while current.next:
                current = current.next
            current.next = new_node

    def print_list(self):
        current = self.head
        while current:
            print(current.data)
            current = current.next

# Creamos una instancia de la lista
my_list = LinkedList()

# Añadimos los 5 datos
my_list.add_node("dato 1")
my_list.add_node("dato 2")
my_list.add_node("dato 3")
my_list.add_node("dato 4")
my_list.add_node("dato 5")

# Imprimimos la lista
my_list.print_list()

