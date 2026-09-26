#include<stdio.h>
int main ()
{
float custoaluguel, totalpago
int jogosalugados, pagamento
float desconto
printf("Digite o custo de aluguel de um jogo")
scanf("%f",custoaluguel)
printf("Digite a forma de pagamento (1- para pagamento em dinheiro e 2-para pagamento com cartão de crédito): ")
scanf("%d"pagamento)
printf("Digite a quantidade de jogos alugados")
scanf("%d", jogosalugados)
totalpago = jogosalugados * custoaluguel
if(jogosalugados>=1 && jogosalugados <=3)
{
    desconto = (pagamento== 1) ? 0.12 : 0.10;
}
else if(jogosalugados>=4 && jogosalugados<=5)
{
    desconto =(pagamento ==1) ? 0.28 : 0.25;
}
else if (jogosalugados>=6 )
{
    desconto= (jogosalugados==1) ? 0.38 : 0.30;
}
totalpago = totalpago * desconto;
printf("Total a ser pago: R$ %.2f\n", totalpago);
return 0; 
}

