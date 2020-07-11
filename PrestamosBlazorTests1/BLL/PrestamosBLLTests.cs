using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrestamosBlazor.BLL;
using PrestamosBlazor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamosBlazor.BLL.Tests
{
    [TestClass()]
    public class PrestamosBLLTests
    {
        [TestMethod()]
        public void BuscarTest()
        {
            Prestamos pre;

            pre = PrestamosBLL.Buscar(1);

            Assert.AreEqual(pre, pre);
        }

        [TestMethod()]
        public void GuardarTest()

        {
           
            Prestamos pre = new Prestamos();

            pre.PrestamoId = 0;

            pre.Fecha = DateTime.Now;

            pre.PersonaId = 1;

            pre.Concepto = "Alquiler";

            pre.Monto = 100;

            pre.Balance = 100;

          //  bool paso = PrestamosBLL.GU(pre);

       //     Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;

            paso = PrestamosBLL.Eliminar(1);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = new List<Prestamos>();

            lista = PrestamosBLL.GetList(p => true);

            Assert.AreEqual(lista, lista);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = PrestamosBLL.Existe(1);

            Assert.AreEqual(paso, true);
        }

    }
}