from design import linhas
def lerINT(escolha):
  while True: 
    
    try: 
      num = int(escolha)
      linhas.linha('=')
  
    except: 
      num = -1 
    
    if num <= 0:
      linhas.linha('=')
      print('ERRO! Por favor, tente novamente!')
      linhas.linha('=')
    
      return num
    
    return num