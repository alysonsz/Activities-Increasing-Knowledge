from validacoes import validacao_str
from design import linhas
from time import sleep
from BancodeDados import BDLinhas
import matplotlib.pyplot as plt

def grafLinhas():  #grafico de linhas
  print('Apresentaremos a seguir a evolução da média do IMC (Índice de Massa Corporal) dos atletas do gênero masculino (M) ou feminino (F), que ganharam medalhas em alguma das Olimpiadas.')
  print()
  sleep(1)

  while True:
    while True:
      genero = str(input('Por favor, escolha um dos gêneros. Digite M para masculino ou F para feminino: '))
      generoEsc = validacao_str.lerSTR(genero) #validação de string
      if generoEsc == 'ERRO':
        continue
      
      else:
        break
        
    print()
          
    if generoEsc == 'M':
      generoDesejado = 'Masculino'
      print('Você escolheu o gênero Masculino')
      break
    elif generoEsc == 'F':
      generoDesejado = 'Feminino'
      print('Você escolheu o gênero Feminino')
      break 
    else:
      linhas.linha('=')
      print('ERRO! Tente novamente.')
      linhas.linha('=')

  dados = BDLinhas.bancoDadosLinhas(generoEsc)
  anoS = []
  dadosimc = []
  for c, v in dados.items():
    anoS.append(c)
    dadosimc.append(v)

#def eixos():
#Evolução da média do IMC (Índice de Massa Corporal - IMC = Peso ÷ (Altura × Altura)) dos atletas do <Gênero> que ganharam medalhas em alguma das Olimpíadas.
  
      #fazer depois a filtragem dados dos pesos dos atletas
      
  anos = anoS

  imc = dadosimc
  #return(genero, imc)

#def gerarGrafico():
  plt.plot(anoS, imc) #X , Y
  '''if generoEsc == 'F':
    mulheres = plt.bar(x - 0.35/2, qtdMulheres, label = 'Mulheres', color = 'deeppink')
  elif generoEsc == 'M':
    homens = plt.bar(x + 0.35/2, qtdHomens, label = 'Homens', color = 'mediumblue')'''
  plt.title('IMC dos atletas do gênero {} que ganharam medalhas em alguma das Olimpiadas'.format((generoDesejado)))
  plt.xlabel('Anos')
  plt.ylabel('Média do IMC')
  plt.savefig('Linhas.png')
  plt.show()
