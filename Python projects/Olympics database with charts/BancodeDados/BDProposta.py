from funcionalidades import tradutor
from funcionalidades import arquivo

def apresentarProposta(continenteEscolhido,medalhaEscolhida):
  dadosIng = tradutor.continentesIng
  dadosPT = tradutor.continentesPT
  medalIng = tradutor.medalhasIng
  medalPT = tradutor.medalhasPT
  arquivoNoc = 'noc_regions.csv'
  arquivoAtleta = 'athlete_events.csv'
  arquivoContinente = 'countries-continents.csv'
  corrigidos = ['Boliva','Czech Republic','Myanmar','North Korea','South Korea','Russia','Burkina Faso','Republic of Congo','Democratic Republic of the Congo','Antigua','Saint Kitts','Saint Vincent','Trinidad','USA' ]

  errados = ['Bolivia', 'CZ', 'Burma (Myanmar)', '"Korea, North"', '"Korea, South"', 'Russian Federation', 'Burkina','Congo', '"Congo, Democratic Republic of"', 'Antigua aand Barbuda', 'Saint Kitta and Nevis', 'Saint Vicent and the Grenadines', 'Trinidad and Tobago', 'US']
  
  arq = arquivo.abrirArquivo(arquivoAtleta)

  cont_siglas = arquivo.noc_cont(arquivoContinente, arquivoNoc, continenteEscolhido,corrigidos,errados)

  listaMedalhistas = {}
  conta = 0
  for dados in arq:
    atleta = dados[1]
      
    if medalhaEscolhida in dados and dados[7] in cont_siglas[continenteEscolhido] or dados[7] == continenteEscolhido:
      
      if atleta not in listaMedalhistas:
        conta = 1
        listaMedalhistas[atleta] = conta

      elif atleta in listaMedalhistas :
        conta += 1
        listaMedalhistas[atleta] = conta 

  maior = 0
  #maior dos
  for i in listaMedalhistas:
    if listaMedalhistas[i] > maior:
      maisvencedor = i
      maior = listaMedalhistas[i]

  #continenteEscolhido = tradutor.validarcontinente(continenteEscolhido)
  if medalhaEscolhida == 'Gold':
        medalhaEscolhida = 'Ouro'
       
  elif medalhaEscolhida == 'Silver':
    medalhaEscolhida = 'Prata'
      
  elif medalhaEscolhida == 'Bronze':
    medalhaEscolhida = 'Bronze'
  print('O atleta da {} que conquistou mais medalhas de {}, foi {}, com {} medalhas de {} conquistadas.'.format(continenteEscolhido, medalhaEscolhida, maisvencedor,maior,medalhaEscolhida))

#------------------FINAL---------------------------#
def bancoDadosProposta(continenteEscolhido,medalhaEscolhida):
  dadosProposta = apresentarProposta(continenteEscolhido,medalhaEscolhida)
  return dadosProposta