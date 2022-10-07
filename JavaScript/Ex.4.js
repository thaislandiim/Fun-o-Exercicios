function facaMedia(n1, n2, n3, n4){
    media = (n1 + n2 + n3 + n4) / 4
    return media
  }
  
  function aprovacao(media){
    if(media >= 7){
      console.log("Você foi aprovado")
    } else {
      console.log("Você foi reprovado")
    }
  }
  
  let n1, n2, n3, n4, media
  
  n1 = Number(prompt("Insira sua nota: "))
  n2 = Number(prompt("Insira sua nota: "))
  n3 = Number(prompt("Insira sua nota: "))
  n4 = Number(prompt("Insira sua nota: "))
  
  media = facaMedia(n1, n2, n3, n4)
  aprovacao(media)