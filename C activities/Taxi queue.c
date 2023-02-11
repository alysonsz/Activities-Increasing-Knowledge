/* 
 * Universidade Federal de Sergipe
 * Centro de Ciência Exatas e Tecnologia
 * Departamento de Computação
 * 
 * Disciplina: Estruturas de Dados
 * Professora: Kenia Kodel
 * 
 * Objetivo Didático: Aplicação de fila.
 * 
 * Objetivos: Operador de uma agência de taxis, contendo 10 taxis.
 *            O sistema deve agendar qual taxi atende à próxima chamada.
 *            Sendo formada uma fila de taxistas e havendo uma chamada, o 
 *            primeiro da fila atende. E quando um taxiste chega para trabalhar ou
 *            finaliza uma corrida, deve ser inserido no final da fila.
 * Implementar no projeto “Charme Taxis” (TestaFila.c) uma fila de espera de cliente com até 4 clientes de maneira que quando houver uma chamada
 * e a lista de taxis disponíveis estiver vazia, o cliente possa ficar a espera de um taxi.
 * Havendo clientes na fila de clientes, caso um taxista chegue, este não entra na fila de taxistas,
 * é logo enviado para atender um cliente em espera, o qual (cliente) deve ser removido da fila de clientes. 
 * */
 
#include <stdio.h>
#include <stdlib.h>  //usado system
#include <ctype.h>   //usado toupper
#include <string.h>  //usado strcmp

typedef char Str20[20];
struct Reg{
  int escolha;
	Str20 Taxista;
  Str20 Cliente;
	void *Prox;
  };
  
typedef struct Reg TpReg;
Str20 T;
Str20 C;

TpReg *Inicio,*Fim=NULL;
TpReg *Aux;
TpReg *Inicio2,*Fim2=NULL;
TpReg *Aux2;

int Opcao;

void EmFila(Str20 S, int escolha){
  if (escolha == 0){
    Aux=(TpReg *) malloc(sizeof(TpReg));
    strcpy(Aux->Taxista,S);
    Aux->Prox=NULL;
    if ((Inicio==NULL) && (Fim==NULL)){
      Inicio=Aux;
	  Fim=Aux;}
    else{
      Fim->Prox=Aux;
	  Fim=Aux;}
  }
  if (escolha == 1){
    Aux2=(TpReg *) malloc(sizeof(TpReg));
    strcpy(Aux2->Cliente,S);
    Aux2->Prox=NULL;
    if ((Inicio2==NULL) && (Fim2==NULL)){
      Inicio2=Aux2;
	  Fim2=Aux2;}
    else{
      Fim2->Prox=Aux2;
	  Fim2=Aux2;}
  }
}


//Para incluir taxista.
void IncluirTaxista() {
  char R;
  do{
    system("cls");
    printf("*** Chegada de Taxista ***\n\n");
    printf("Taxista: ");
    scanf("%[^\n]s",T);
    fflush(stdin);
    
    //inclusao da taxista na fila
    if ((Inicio2 == NULL) && (Fim2 == NULL)){
      EmFila(T, 0);}
    else{
      RemoverCliente();
    }
	  
    printf("\nOutro taxista? S/N ");
    scanf("%c",&R);
    fflush(stdin);
    R=toupper(R);}
  while (R!='N');
  return;}

void IncluirCliente() {
  char R;
  do{
    system("cls");
    printf("*** Incluir Cliente ***\n\n");
    printf("Cliente: ");
    scanf("%[^\n]s",C);
    fflush(stdin);
    
    //inclusao de cliente na fila
    if ((Inicio == NULL) && (Fim == NULL)){
      EmFila(C, 1);}
    else{
      RemoverTaxista();
    }
	  
    printf("\nDeseja inserir outro cliente na lista de espera? S/N ");
    scanf("%c",&R);
    fflush(stdin);
    R=toupper(R);}
  while (R!='N');
  return;}

void RemoverTaxista(){
  if ((Inicio != NULL) && (Fim != NULL)){
    Aux = Inicio;
    Inicio=Inicio->Prox;
    free(Aux);
    if (Inicio==NULL)
      Fim=NULL;
  }
}

void RemoverCliente(){
  if ((Inicio2 != NULL) && (Fim2 != NULL)){
    Aux2 = Inicio2;
    Inicio2=Inicio2->Prox;
    free(Aux2);
    if (Inicio2==NULL)
      Fim2=NULL;
  }
}

void LTodos() {
  system("cls");
  printf("***Fila de Taxistas***\n\n ");
  if (Inicio!= NULL){
	Aux = Inicio;
	do{
	  printf("%s\n",Aux->Taxista);
	  Aux=Aux->Prox;}
	while (Aux!=NULL);}
  else
    printf("\nLista de afazeres vazia. Pressione <ENTER>\n");  
  system("pause");}

int main(){
  do{
	system("cls");
    printf("\n\n> > > Charme Taxis < < < \n\n");
    printf("Taxistas disponiveis: ");
    if (Inicio!= NULL){
	  Aux = Inicio;
	  do{
	    printf("%s ",Aux->Taxista);
	    Aux=Aux->Prox;}
	  while (Aux!=NULL);
    }
    printf("\n\nFila de espera: ");
    if (Inicio2!= NULL){
    Aux2 = Inicio2;
    do{
	    printf("%s ",Aux2->Cliente);
	    Aux2=Aux2->Prox;}
	  while (Aux2!=NULL);
    }

    printf("\n\nQue deseja fazer? \n\n");
    printf("1 - Chegada de Taxista \n"); 
    printf("2 - Chamada de Cliente \n"); //taxista é removido da fila
    printf("3 - Listar Todos \n");
    printf("4 - Sair \n\n");
    printf("Opcao: ");
    scanf("%d",&Opcao);
    fflush(stdin);
    switch (Opcao){
      case 1: IncluirTaxista(); break;
      case 2: IncluirCliente("*** Atender Chamada ***"); break;
      case 3: LTodos(); break;}}
  while (Opcao != 4);
  return 0;}
