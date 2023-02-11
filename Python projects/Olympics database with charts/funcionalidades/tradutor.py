#TRADUÇÃO:
def listarDados(posicao, arquivo):
  arq = arquivo.abrirArquivo(arquivo)
  lista = []
  linhas = 0
  for dados in arq:
    linhas += 1
    if linhas == 1:
      continue
      
    elif dados[posicao] not in lista:
      lista.append(dados[posicao])

    else:
      continue
      
  return lista

#TRADUÇÃO DOS ESPORTES:
#listaInglesEsportes = listarDados(12, arquivoAtleta)

#TRADUÇÃO
esportesPT = ['Basquete', 'Judô', 'Futebol', 'Cabo de guerra', 'Patinação de velocidade', 'Esqui cross-country', 'Atletismo', 'Hóquei no gelo', 'Natação', 'Badminton', ' Vela ',' Biatlo ',' Ginástica ',' Competições artísticas ',' Esqui alpino ',' Handebol ',' Halterofilismo ',' Luta Livre ',' Luge ',' Pólo Aquático ',' Hóquei ',' Remo ', 'Bobsleigh', 'Esgrima', 'Hipismo', 'Tiro', 'Boxe', 'Taekwondo', 'Ciclismo', 'Mergulho', 'Canoagem', 'Tênis', 'Pentatlo moderno', 'Patinação artística', 'Golfe', 'Softball', 'Tiro com arco', 'Voleibol', 'Natação sincronizada', 'Tênis de mesa', 'Combinado nórdico', 'Beisebol', 'Ginástica rítmica', 'Esqui livre', 'Rugby de sete', 'Trampolim', 'Voleibol de praia', 'Triatlo', 'Salto de esqui', 'Curling', 'Snowboarding', 'Rugby', 'Patinagem de velocidade em pista curta', 'Skeleton', 'Lacrosse', 'Polo', ' Críquete ',' Raquetes ',' Barco a motor ',' Patrulha militar de esqui ',' Croquet ',' Jogo de palma ',' Roque ',' Alpinismo ',' Pelota basca ',' Aeronáutica '] 

esportesIng = ['Basketball', 'Judo', 'Football', 'Tug-Of-War', 'Speed Skating', 'Cross Country Skiing', 'Athletics', 'Ice Hockey', 'Swimming', 'Badminton', 'Sailing', 'Biathlon', 'Gymnastics', 'Art Competitions', 'Alpine Skiing', 'Handball', 'Weightlifting', 'Wrestling', 'Luge', 'Water Polo', 'Hockey', 'Rowing', 'Bobsleigh', 'Fencing', 'Equestrianism', 'Shooting', 'Boxing', 'Taekwondo', 'Cycling', 'Diving', 'Canoeing', 'Tennis', 'Modern Pentathlon', 'Figure Skating', 'Golf', 'Softball', 'Archery', 'Volleyball', 'Synchronized Swimming', 'Table Tennis', 'Nordic Combined', 'Baseball', 'Rhythmic Gymnastics', 'Freestyle Skiing', 'Rugby Sevens', 'Trampolining', 'Beach Volleyball', 'Triathlon', 'Ski Jumping', 'Curling', 'Snowboarding', 'Rugby', 'Short Track Speed Skating', 'Skeleton', 'Lacrosse', 'Polo', 'Cricket', 'Racquets', 'Motorboating', 'Military Ski Patrol', 'Croquet', 'Jeu De Paume', 'Roque', 'Alpinism', 'Basque Pelota', 'Aeronautics']

def ptParaIngles(listaTraduzida,listaIngles,escolha):
  if escolha in listaIngles:
    dadoIngles = escolha 

  elif escolha in listaTraduzida:
    pos = 0
    for i in listaTraduzida:

      if i == escolha:
        dadoIngles = listaIngles[pos]
        break
  
      else:
        pos += 1
        continue
  
  else:
    print('ERRO! A Olimpiadas não')
  return dadoIngles

#TRADUÇÃO DOS PAISES:
#listaInglesPaises = listarDados(1, arquivoContinente)
#print(listaInglesPaises)

#TRADUZIDO: 
paisesTraduzidos = ['Argélia', 'Angola', 'Benin', 'Botswana', 'Burkina', 'Burundi', 'Camarões', 'Cabo Verde', 'República Centro-Africana', 'Chade', 'Comores', 'Congo' , 'Congo, República Democrática de', 'Djibouti', 'Egito', 'Guiné Equatorial', 'Eritreia', 'Etiópia', 'Gabão', 'Gâmbia', 'Gana', 'Guiné', 'Guiné-Bissau ',' Costa do Marfim ',' Quênia ',' Lesoto ',' Libéria ',' Líbia ',' Madagascar ',' Malaui ',' Mali ',' Mauritânia ',' Maurício ',' Marrocos ',' Moçambique ' , 'Namíbia', 'Níger', 'Nigéria', 'Ruanda', 'São Tomé e Príncipe', 'Senegal', 'Seychelles', 'Serra Leoa', 'Somália', 'África do Sul', 'Sudão do Sul' , 'Sudão', 'Suazilândia', 'Tanzânia', 'Togo', 'Tunísia', 'Uganda', 'Zâmbia', 'Zimbábue', 'Afeganistão', 'Bahrein', 'Bangladesh', 'Butão', ' Brunei ',' Burma (Mianmar) ',' Camboja ',' China ',' Timor Leste ',' Índia ',' Indonésia ',' Irã ',' Iraque ',' Israel ',' Japão ',' Jordânia ' , 'Cazaquistão', 'Coreia do Norte', 'Coreia do Sul', 'Kuwait', 'Quirguistão', 'Laos', 'Líbano', 'Malásia', 'Maldivas', 'Mongólia', 'Nepal', ' Omã ',' Paki stan ',' Filipinas ',' Qatar ',' Federação Russa ',' Arábia Saudita ',' Cingapura ',' Sri Lanka ',' Síria ',' Tadjiquistão ',' Tailândia ',' Turquia ',' Turcomenistão ', 'Emirados Árabes Unidos', 'Uzbequistão', 'Vietnã', 'Iêmen', 'Albânia', 'Andorra', 'Armênia', 'Áustria', 'Azerbaijão', 'Bielorrússia', 'Bélgica', 'Bósnia e Herzegovina ',' Bulgária ',' Croácia ',' Chipre ',' República Tcheca ',' Dinamarca ',' Estônia ',' Finlândia ',' França ',' Geórgia ',' Alemanha ',' Grécia ',' Hungria ', 'Islândia', 'Irlanda', 'Itália', 'Letônia', 'Liechtenstein', 'Lituânia', 'Luxemburgo', 'Macedônia', 'Malta', 'Moldávia', 'Mônaco', 'Montenegro', 'Holanda ',' Noruega ',' Polônia ',' Portugal ',' Romênia ',' San Marino ',' Sérvia ',' Eslováquia ',' Eslovênia ',' Espanha ',' Suécia ',' Suíça ',' Ucrânia ' , 'Reino Unido', 'Cidade do Vaticano', 'Antígua e Barbuda', 'Bahamas', 'Barbados', 'Belize', 'Canadá', 'Costa Rica', 'Cuba', 'Dominica', 'República Dominicana' , 'El Salvador', 'Grenada', 'Guatemala', 'Haiti', 'Honduras', 'Jamaica', 'México', 'Nicarágua', 'Panamá', 'São Cristóvão e Névis ',' Santa Lúcia ',' São Vicente e Granadinas ', 'Trindade e Tobago' ,' Estados Unidos ',' Austrália ',' Fiji ',' Kiribati ',' Ilhas Marshall ',' Micronésia ', 'Nauru', 'Nova Zelândia', 'Palau', 'Papua Nova Guiné', 'Samoa', 'Ilhas Salomão', 'Tonga', 'Tuvalu', 'Vanuatu', 'Argentina', 'Bolívia', 'Brasil ',' Chile ',' Colômbia ',' Equador ',' Guiana ',' Paraguai ',' Peru ',' Suriname ',' Uruguai ',' Venezuela ']

paisesEmING = ['Algeria', 'Angola', 'Benin', 'Botswana', 'Burkina', 'Burundi', 'Cameroon', 'Cape Verde', 'Central African Republic', 'Chad', 'Comoros', 'Congo', 'Congo, Democratic Republic of', 'Djibouti', 'Egypt', 'Equatorial Guinea', 'Eritrea', 'Ethiopia', 'Gabon', 'Gambia', 'Ghana', 'Guinea', 'Guinea-Bissau', 'Ivory Coast', 'Kenya', 'Lesotho', 'Liberia', 'Libya', 'Madagascar', 'Malawi', 'Mali', 'Mauritania', 'Mauritius', 'Morocco', 'Mozambique', 'Namibia', 'Niger', 'Nigeria', 'Rwanda', 'Sao Tome and Principe', 'Senegal', 'Seychelles', 'Sierra Leone', 'Somalia', 'South Africa', 'South Sudan', 'Sudan', 'Swaziland', 'Tanzania', 'Togo', 'Tunisia', 'Uganda', 'Zambia', 'Zimbabwe', 'Afghanistan', 'Bahrain', 'Bangladesh', 'Bhutan', 'Brunei', 'Burma (Myanmar)', 'Cambodia', 'China', 'East Timor', 'India', 'Indonesia', 'Iran', 'Iraq', 'Israel', 'Japan', 'Jordan', 'Kazakhstan', 'Korea, North', 'Korea, South', 'Kuwait', 'Kyrgyzstan', 'Laos', 'Lebanon', 'Malaysia', 'Maldives', 'Mongolia', 'Nepal', 'Oman', 'Pakistan', 'Philippines', 'Qatar', 'Russian Federation', 'Saudi Arabia', 'Singapore', 'Sri Lanka', 'Syria', 'Tajikistan', 'Thailand', 'Turkey', 'Turkmenistan', 'United Arab Emirates', 'Uzbekistan', 'Vietnam', 'Yemen', 'Albania', 'Andorra', 'Armenia', 'Austria', 'Azerbaijan', 'Belarus', 'Belgium', 'Bosnia and Herzegovina', 'Bulgaria', 'Croatia', 'Cyprus', 'CZ', 'Denmark', 'Estonia', 'Finland', 'France', 'Georgia', 'Germany', 'Greece', 'Hungary', 'Iceland', 'Ireland', 'Italy', 'Latvia', 'Liechtenstein', 'Lithuania', 'Luxembourg', 'Macedonia', 'Malta', 'Moldova', 'Monaco', 'Montenegro', 'Netherlands', 'Norway', 'Poland', 'Portugal', 'Romania', 'San Marino', 'Serbia', 'Slovakia', 'Slovenia', 'Spain', 'Sweden', 'Switzerland', 'Ukraine', 'United Kingdom', 'Vatican City', 'Antigua and Barbuda', 'Bahamas', 'Barbados', 'Belize', 'Canada', 'Costa Rica', 'Cuba', 'Dominica', 'Dominican Republic', 'El Salvador', 'Grenada', 'Guatemala', 'Haiti', 'Honduras', 'Jamaica', 'Mexico', 'Nicaragua', 'Panama', 'Saint Kitts and Nevis', 'Saint Lucia', 'Saint Vincent and the Grenadines', 'Trinidad and Tobago', 'USA', 'Australia', 'Fiji', 'Kiribati', 'Marshall Islands', 'Micronesia', 'Nauru', 'New Zealand', 'Palau', 'Papua New Guinea', 'Samoa', 'Solomon Islands', 'Tonga', 'Tuvalu', 'Vanuatu', 'Argentina', 'Bolivia', 'Brazil', 'Chile', 'Colombia', 'Ecuador', 'Guyana', 'Paraguay', 'Peru', 'Suriname', 'Uruguay', 'Venezuela']

#TRADUCAO CONTINENTES:
continentesPT = ['Africa', 'Asia', 'America do Sul', 'America do Norte', 'Europa', 'Oceania']

continentesIng = ['Africa', 'Asia', 'South America', 'North America', 'Europe', 'Oceania']
#TRADUÇÃO DAS MEDALHAS:
#TRADUZIDO: 
medalhasPT = ['Ouro', 'Prata', 'Bronze']
medalhasIng = ['Gold', 'Prata', 'Bronze']

#listaInglesMedalhas = listarDados(14, arquivoAtleta)

def validarcontinente(escolha):
  continentesPT = ['Africa', 'Asia', 'America do Sul', 'America do Norte', 'Europa', 'Oceania']

  continentesIng = ['Africa', 'Asia', 'South America', 'North America', 'Europe', 'Oceania']
  escolha = escolha.strip()
  escolha = escolha.capitalize()
  if escolha == 'America do sul':
    escolha = 'America do Sul'

  elif escolha == 'America do norte':
    escolha = 'America do Norte'

  if escolha in continentesPT:
  
    indice = continentesPT.index(escolha)
    return continentesIng[indice]
    #escolhaTrad = dadosING[indice-1] 

def validarPalavra(escolha,dadosPT,dadosING):
  
  escolha = escolha.strip()
  escolha = escolha.capitalize()

  if escolha in dadosPT:
  
    indice = dadosPT.index(escolha)

    return dadosING[indice]
  #return escolhaTrad

