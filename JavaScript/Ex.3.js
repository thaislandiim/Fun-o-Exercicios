function soma2(valor){
    valor = valor + 2
    return valor
  }
  
  function multi2(valor1){
    valor1 = valor1 * 2
    return valor1
  }
  vetor = [0,0,0,0,0,0,0,0,0,0]
  vetor1 = [0,0,0,0,0,0,0,0,0,0]
  
  for(v = 0; v < 10; v++){
    vetor[v] = Number(prompt("Insira um número: "))
      
    if(vetor[v] % 2 == 0){
      vetor[v] = soma2(vetor[v])
      vetor1[v] = 0
    } else {
      vetor[v] = multi2(vetor[v])
      vetor1[v] = 1
    }
  }
  
  console.log("Números pares: ")
  for(v = 0; v < 10; v++){
    if(vetor1[v] == 0){
      console.log(vetor[v])
    }
  }
  
  console.log("Números impares: ")
  for(v = 0; v < 10; v++){
    if(vetor1[v] == 1){
      console.log(vetor[v])
    }
  }
  