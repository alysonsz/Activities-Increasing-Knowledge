from design import linhas
def menu(opcoes):
  numero = 0
  linhas.linha('=')
  print(' '* 15, 'MENU PRINCIPAL:', ' '* 15)
  linhas.linha('=')
  print('Escolha uma das opções dos gráficos abaixo:')
  for i in opcoes:
    numero += 1
    print('[ {} ] {}'.format(numero, i))
  linhas.linha('=')