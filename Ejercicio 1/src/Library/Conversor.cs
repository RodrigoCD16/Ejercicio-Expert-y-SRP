using System;

namespace Expert_SRP
{
    public class Conversor
    {
        public Double ConvertirAPesos(Double dinero, String moneda, Double unidadenpesos) 
        {
            if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else
            {
                return dinero / unidadenpesos;
            }
        }         
    }
}