using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrestamosBlazor.BLL;
using PrestamosBlazor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamosBlazor.BLL.Tests
{
    [TestClass()]
    public class PersonasBLLTests
    {
        [TestMethod()]
        public void BuscarTest()
        {
            Personas Per;

            Per = PersonasBLL.Buscar(2);

            Assert.AreEqual(Per, Per);
        }

        [TestMethod()]
        public void GuardarTest()
        {
            Personas per = new Personas();

            bool paso = false;

            per.PersonaId = 0;

            per.Nombres = "Ery";

            per.FechaNacimiento = DateTime.Now;

            per.Cedula = "567890098765";

            per.Direccion = "Calle Principal #32";

            per.Telefono = "8097876785";

            per.Balance = 0;

            paso = PersonasBLL.Guardar(per);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;

            paso = PersonasBLL.Eliminar(2);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = new List<Personas>();

            lista = PersonasBLL.GetList(per => true);

            Assert.AreEqual(lista, lista);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = PersonasBLL.Existe(3);

            Assert.AreEqual(paso, true);
        }
    }
}