using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalLife.Controle;

namespace PersonalLife.Teste
{
    [TestClass]
    public class Teste
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Instanciando classe
            BD cont = new BD();
            Entidade objTabela = new Entidade();
            //Testando método de PegaEmail (acerto)
            objTabela.Email = "pedro@pl.com";
            Assert.AreEqual(1, cont.PegaEmail(objTabela));
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Instanciando classe
            BD cont = new BD();
            Entidade objTabela = new Entidade();
            //Testando método de PegaEmail (erro)
            objTabela.Email = "pedro@pl.com";
            Assert.AreEqual(0, cont.PegaEmail(objTabela));
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Instanciando classe
            BD cont = new BD();
            Entidade objTabela = new Entidade();
            //Testando método ExistUsu (acerto)
            objTabela.Usuario = "pero";
            Assert.AreEqual(0, cont.ExistUsu(objTabela));
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Instanciando classe
            BD cont = new BD();
            Entidade objTabela = new Entidade();
            //Testando método ExistUsu (erro)
            objTabela.Usuario = "pedro";
            Assert.AreEqual(1, cont.ExistUsu(objTabela));
        }

        [TestMethod]
        public void TestMethod5()
        {
            //Instanciando classe
            BD cont = new BD();
            Entidade objTabela = new Entidade();
            //Testando método ExistUsu (erro)
            objTabela.Usuario = "pedro";
            Assert.AreEqual(1, cont.InserirUsuario(objTabela));
        }
    }
}
