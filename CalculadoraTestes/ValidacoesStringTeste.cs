using System.Security.Cryptography.X509Certificates;
using Calculadora.Services;

namespace CalculadoraTestes;

public class ValidacoesStringTeste
{
    private ValidacoesStrings _validacoes;
    public ValidacoesStringTeste()
    {

        _validacoes = new ValidacoesStrings();

    }

public void DeveContar3CaracteristicasEmOlaERetorna3()
{
    //Arrange
string texto = "ola";

        //act

        Assert.Equal(3, _validacoes.ContarCaracters(texto));
}




}