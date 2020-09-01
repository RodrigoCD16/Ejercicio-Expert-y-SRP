using System;

namespace Expert_SRP
{
    public class Conversor
    {
        private Double ConvertirAPesos(Double dinero, String moneda, Double unidadenpesos) 
        {
            return dinero / unidadenpesos;
        }
            
    }
}