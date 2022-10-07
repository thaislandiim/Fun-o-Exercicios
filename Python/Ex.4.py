def facaMedia(n1, n2, n3, n4):
  media = (n1 + n2 + n3 + n4) / 4
  return media

def exibaOperacao(media):
  if media >= 7:
    print("Você foi aprovado")
  else:
    print("Você foi reprovado")

n1 = int(input("Insira sua 1° nota: "))
n2 = int(input("Insira sua 2° nota: "))
n3 = int(input("Insira sua 3° nota: "))
n4 = int(input("Insira sua 4° nota: "))

media = facaMedia(n1, n2, n3, n4)
exibaOperacao(media)