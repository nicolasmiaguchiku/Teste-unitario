using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTeste
{
    public class ValidacoesStringTest
    {
        private ValidacoesString _validacao;

        public ValidacoesStringTest()
        {
            _validacao = new ValidacoesString();
        }

        [Fact]
        public void Validar()
        {
            //Arrange
            string text = "Ola";

            //ACT
            int count = _validacao.ContarCaracteres(text);

            //Assert
            Assert.Equal(3, count);
        }

    }
}