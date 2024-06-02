using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            var listaSemNegativos = lista.Where(x => x > 0);
            return listaSemNegativos.ToList();
        }

        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            var contem = lista.Contains(numero);
            return contem;
        }

        public List<int> MultiplicarNumerosLista(List<int> lista, int numero)
        {
            var listaMultiplicada = lista.Select(x => x * numero).ToList();
            return listaMultiplicada;
        }

        public int RetornaMaiorNumeroLista(List<int> lista)
        {
            return lista.Max();
        }

        public int RetornaMenorNumeroLista(List<int> lista)
        {
            return lista.Min();
        }
    }
}