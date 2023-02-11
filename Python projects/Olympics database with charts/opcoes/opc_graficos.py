from graficos import Barras 
from graficos import Boxplot
from graficos import Linhas
from graficos import Textual 
from opcoes import opc_sair
from graficos import Proposta
from validacoes import validacao_num
from design import linhas 

def posEscolha ():
  while True:
    while True:
      mensagem = 'Digite a opção desejada. Tecle o número inteiro correspondente: '
      escolha = input(mensagem)
      opcaoEscolhida = validacao_num.lerINT(escolha)
      if opcaoEscolhida == -1:
        continue
      
      else:
        break

    if opcaoEscolhida == 1: #grafico de linhas
      Linhas.grafLinhas()
      opc_sair.fechar()
      break      
      
  #OPÇÃO 2: #
    elif opcaoEscolhida == 2: #grafico de barras
      Barras.grafBarras()
      opc_sair.fechar()
      break
  #OPÇÃO 3: 
    elif opcaoEscolhida == 3: #Boxplot
      Boxplot.grafBoxplot()
      opc_sair.fechar()
      break
  #OPÇÃO 4:
    elif opcaoEscolhida == 4: #Grafico Textual
      Textual.grafTextual()
      opc_sair.fechar()
      break
  #OPÇÃO 5:
    elif opcaoEscolhida == 5:
      Proposta.questionario()
      opc_sair.fechar()
      break
  #OPÇÃO 6:
    elif opcaoEscolhida == 6: #Encerre o  programa
      opc_sair.fechar()
      break
  #quaisquer caractere:
    else:
      print('ERRO! Por favor, tente novamente!')
      linhas.linha('=')
      continue