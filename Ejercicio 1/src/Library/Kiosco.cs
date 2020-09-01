using System;

namespace Expert_SRP
{
    public class Kiosco //No se aplica correctamente el SRP ya que hay dos razones de cambios, ya que si apareciera un nuevo tipo de moneda o se quisiera vender otro producto en el kiosko se tendría que modificar el código ya existente
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa; //No se aplica correctamente el expert, esta operación tendría que estar dentro de la clase Alfajor ya que esta es la experta que posee todos los datos
        }
        private Double ConvertirAPesos(Double dinero, String moneda) //se tendría que separar convertir a pesos en una clase a parte que permita hacer la conversión entre cualquier tipo de moneda
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}