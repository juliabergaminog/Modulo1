Console.WriteLine("Digite um valor do produto"); double valorProduto = Convert.ToDouble(Console.ReadLine()); Console.WriteLine("Digite o valor maximo do produto"); double valorMaximoProduto = Convert.ToDouble(Console.ReadLine());

if (VerificarPrecoPromocional(valorProduto, valorMaximoProduto) == true)

{

    Console.WriteLine($"Verificando produto 1 (R$ {valorProduto} com máximo R$ {valorMaximoProduto}):");

    Console.WriteLine("Está em promoção!");


}
else
{

    Console.WriteLine($"Verificando produto 2 (R$ {valorProduto} com máximo R$ {valorMaximoProduto}):");

    Console.WriteLine("Não está em promoção");

}

static bool VerificarPrecoPromocional(double valorProduto, double valorMaximoProduto)

{

    if (valorProduto <= valorMaximoProduto)

    {

        return true;

    }

    else
    {

        return false;

    }


}