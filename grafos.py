from collections import deque

def bfs(graph, start):
    visited = set()
    queue = deque([start])

    while queue:
        node = queue.popleft()
        visited.add(node)

        for neighbor in graph[node]:
            if neighbor not in visited:
                queue.append(neighbor)

    return visited

# Definir el grafo Skynet con 15 vértices y enlaces a otros vértices
skynet_graph = {
    'A': ['B', 'C', 'D', 'E', 'F', 'G', 'H'],
    'B': ['A', 'C', 'D', 'E', 'F', 'G', 'H'],
    'C': ['A', 'B', 'D', 'E', 'F', 'G', 'H'],
    'D': ['A', 'B', 'C', 'E', 'F', 'G', 'H'],
    'E': ['A', 'B', 'C', 'D', 'F', 'G', 'H'],
    'F': ['A', 'B', 'C', 'D', 'E', 'G', 'H'],
    'G': ['A', 'B', 'C', 'D', 'E', 'F', 'H'],
    'H': ['A', 'B', 'C', 'D', 'E', 'F', 'G'],
    'I': ['J', 'K', 'L', 'M', 'N', 'O', 'P'],
    'J': ['I', 'K', 'L', 'M', 'N', 'O', 'P'],
    'K': ['I', 'J', 'L', 'M', 'N', 'O', 'P'],
    'L': ['I', 'J', 'K', 'M', 'N', 'O', 'P'],
    'M': ['I', 'J', 'K', 'L', 'N', 'O', 'P'],
    'N': ['I', 'J', 'K', 'L', 'M', 'O', 'P'],
    'O': ['I', 'J', 'K', 'L', 'M', 'N', 'P'],
    'P': ['I', 'J', 'K', 'L', 'M', 'N', 'O']
}

reachable_to_all = None

# Recorrer todos los vértices y encontrar uno desde el cual se puedan alcanzar todos los demás
for vertex in skynet_graph:
    reachable_vertices = bfs(skynet_graph, vertex)
    if len(reachable_vertices) == len(skynet_graph):
        reachable_to_all = vertex
        break

if reachable_to_all:
    print(f"Se puede llegar desde el vértice {reachable_to_all} a todos los demás vértices en Skynet")
else:
    print("No hay ningún vértice desde el cual se pueda llegar a todos los demás en Skynet")

