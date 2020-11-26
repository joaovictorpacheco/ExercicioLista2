using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 2");

            Console.WriteLine("Selecione um tipo de combustivel");
            Console.WriteLine("A - Alcool");
            Console.WriteLine("G - Gasolina");
            string combustivel = Console.ReadLine();
            
            Console.WriteLine("Digite a quantidade de combustivel");
            float quantidadeCombustivel = float.Parse(Console.ReadLine());


            float percDesconto, desconto, valorTotal;
            float precoAlcool = 5f;
            float precoGasolina = 5f;
            float percAlcool1 = 0.05f;
            float percAlcool2 = 0.03f;
            float percGasolina1 = 0.06f;
            float percGasolina2 = 0.04f;

            switch (combustivel.ToLower())
            {
                case "a":
                    float retornoDesconto = AplicarDesconto(quantidadeCombustivel, precoAlcool, percAlcool1, percAlcool2);
                    ExibirValorPago(retornoDesconto);
                    //Console.WriteLine(AplicarDesconto(quantidadeCombustivel, precoAlcool, 0.05f, 0.03f));
                break;
            case "g":
                retornoDesconto = AplicarDesconto(quantidadeCombustivel,precoGasolina,percGasolina1,percGasolina2);
                ExibirValorPago(retornoDesconto);
                break;
            default:
                Console.WriteLine("Opção Inválida");
                break;
            }
            float AplicarDesconto(float litros, float preco, float prec1, float perc2){
                if(litros>20){
                    float valorTotal = litros * preco;
                    float desconto = (litros* preco)* prec1;
                    return valorTotal - desconto;
                }else{
                    float valorTotal = litros * preco;
                    float desconto = (litros* preco)* perc2;
                    return valorTotal - desconto;
                }
            }// fim do aplicar desconto
            void ExibirValorPago(float valor){

                Console.WriteLine($"O valor total a ser pago é de: {valor}");
            }
        }
    }
}
