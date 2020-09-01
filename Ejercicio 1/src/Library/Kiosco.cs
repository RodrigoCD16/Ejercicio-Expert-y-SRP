using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda, Double unidadenpesos, Conversor c) 
        {
            Double pesos = c.ConvertirAPesos(dinero, moneda, unidadenpesos);
            return pesos >= a.PrecioAlfajor(5, 10);
        }
    }
}