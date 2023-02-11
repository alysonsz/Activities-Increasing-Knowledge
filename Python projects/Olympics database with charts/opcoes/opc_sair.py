from validacoes import validacao_str
from opcoes import opc_voltar
from design import linhas
from time import sleep
def fechar():
  
  while True:
    print()
    print('Deseja encerrar o programa? ')
    while True:
      escolha = str(input('Digite S para encerrar ou N para voltar: '))
      resposta = validacao_str.lerSTR(escolha)
      if resposta == 'ERRO':
        continue
      
      else:
        break 
        
    if resposta == 'S':
      print()
      print(' '* 15, 'PROCESSANDO...', ' '* 15)
      sleep(2)
      linhas.linha('=')
      print('O programa foi encerrado. Volte sempre! :)')
      return resposta
    
    elif resposta == 'N':
      opc_voltar.voltar()
      break

    else:
      linhas.linha('=')
      print('Por favor, tente novamente!')
      continue 