from design import linhas
#VALIDACAO DE STRING:
def lerSTR(escolha):
  
  escolha = escolha.upper()
  escolha = escolha.strip()
  try:
    verificar = int(escolha)
    linhas.linha('=')
    print('ERRO!' '\n' 'Observação: Você pode estar tentando digitar um inteiro, tente novamente.')
    linhas.linha('=')
    escolha = 'ERRO'
    return escolha

  except:
    return escolha