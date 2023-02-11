#include <stdio.h>
#include <stdlib.h> //usado malloc
#include <string.h> //usado strcpy 
#include <ctype.h> //usado toupper

int main(){

 struct tipo{
	  char Palavra[20];
	  void *Prox; 
  };
  typedef struct tipo TIPO;
  
  TIPO *Inicio, *Fim, *Auxiliar, *Atual, *Anterior, *Inicio2, *Fim2, *Aux2;
  char P[20],R='S';

  Inicio=NULL;
  Inicio2=NULL;
  while (R=='S'){
    system("cls");
    printf("\n > > > ORDENA PALAVRAS < < < \n");
    printf("\n Entrada atual:");
    Auxiliar=Inicio; 
    while (Auxiliar!=NULL){
      printf(" %s ",Auxiliar->Palavra);
      Auxiliar= Auxiliar->Prox;} 
    printf("\n\n Entrada desordenada:");
    Aux2=Inicio2; 
    while (Aux2!=NULL){
      printf(" %s ",Aux2->Palavra);
      Aux2= Aux2->Prox;}

    printf("\n\n Qual palavra deseja inserir? ");
    scanf(" %s",P);    
    Auxiliar=(TIPO *) malloc(sizeof(TIPO));
    strcpy(Auxiliar->Palavra,P);
    Auxiliar->Prox = NULL;
    Aux2=(TIPO *) malloc(sizeof(TIPO));
    strcpy(Aux2->Palavra,P);
    Aux2->Prox = NULL;
    printf("%s",Aux2->Palavra);

    if (Inicio == NULL){ //primeiro elemento da estrutura
      Auxiliar->Prox=NULL;
      Inicio = Auxiliar;
      Fim = Auxiliar;
      Inicio2 = Aux2;
      Fim2 = Aux2;}
    else
      if (strcmp(P,Inicio->Palavra)<=0){ //insere no inicio
		Auxiliar->Prox = Inicio;
		Inicio = Auxiliar;
    Fim2->Prox = Aux2;
    Fim2 = Aux2;}
	  else
	    if (strcmp(P,Fim->Palavra)>=0){ //insere no fim
		  Fim->Prox = Auxiliar;
		  Fim = Auxiliar;
      Fim2->Prox = Aux2;
      Fim2 = Aux2;}
		else{ //insere no meio - antes do primeiro maior
		  Atual = Inicio->Prox;
		  Anterior = Inicio;
		  while (strcmp(Atual->Palavra,Auxiliar->Palavra)<0){
		    Anterior = Atual;
		    Atual = Atual->Prox;}
		  Anterior->Prox = Auxiliar;
		  Auxiliar->Prox = Atual;
      Fim2->Prox = Aux2;
      Fim2 = Aux2;}
    system("cls");
    printf("\n > > > ORDENA PALAVRAS < < < \n");
    printf("\n Palavras ordenadas: "); 
    Auxiliar=Inicio; 
    while (Auxiliar!=NULL){
      printf(" %s ",Auxiliar->Palavra);
      Auxiliar= Auxiliar->Prox; }
    printf("\n\n Palavras desordenadas: "); 
    Aux2=Inicio2; 
    while (Aux2!=NULL){
      printf(" %s ",Aux2->Palavra);
      Aux2= Aux2->Prox; }
    printf("\n\n Digite S se deseja continuar: ");
    scanf(" %c",&R);
    R = toupper(R); }
   return 0;
}
