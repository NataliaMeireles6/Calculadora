using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        Calculadora.Form1 f1 = new Calculadora.Form1();
        [TestMethod()]

        public void ValidaValorTest()
        {

            //Calculadora.Form1 f1 = Calculadora.Form1
            // 5 --> verdadeiro
            // a --> falso
            // Null --> falso
            // espaço vazio --> falso
            String entrada = "25";
            Boolean respostaEsperada = true;
            Boolean resposta = f1.ValidaValor(entrada);
            Assert.AreEqual(resposta, respostaEsperada); 
        }
    }
}