import os
os.environ['MPLCONFIGDIR'] = os.getcwd() + "/configs/"
from menu import listaMenu
from opcoes import opc_graficos

# ___________________PROGRAMA PRINCIPAL_____________________#

#ENTRADA:
listaOpc = ['De Linhas', 'De Barras', 'Boxplot', 'Textual', 'Questionário','Fechar programa']
arquivoNoc = 'noc_regions.csv'
arquivoAtleta = 'athlete_events.csv'
arquivoContinente = 'countries-continents.csv'
#MENU:
listaMenu.menu(listaOpc)

#DESENVOLVIMENTO
opc_graficos.posEscolha()
