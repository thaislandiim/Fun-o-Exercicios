def soma2(valor):
  valor = valor + 2;
  return valor

def multi2(valor1):
  valor1 = valor1 * 2;
  return valor1

vetor = [0,0,0,0,0,0,0,0,0,0]
vetor1 = [0,0,0,0,0,0,0,0,0,0]

for v in range(0,10):
  vetor[v] = int(input("Insira um número: "))
  if vetor[v] % 2 == 0:
    vetor[v] = soma2(vetor[v])
    vetor1[v] = 0
  else:
    vetor[v] = multi2(vetor[v])
    vetor1[v] = 1

print("Números pares: ")
for v in range(0,10):
  if vetor1[v] == 0:
    print(vetor[v])

print("Números impares: ")
for v in range(0,10):
  if vetor1[v] == 1:
    print(vetor[v])

    
