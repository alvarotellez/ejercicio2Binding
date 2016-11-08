using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingEj2Elementos.Models
{
    public class clsListado
    {
        public List<clsPersona> getListado()
        {
            List<clsPersona> miLista = new List<clsPersona>();

            miLista.Add(new clsPersona(1, "Jose Antonio", "Fernandez", null, "IES nervion", "656392054"));
            miLista.Add(new clsPersona(2, "David", "Fernandez", null, "IES nervion", "65644654"));
            miLista.Add(new clsPersona(3, "Maria", "Fernandez", null, "IES nervion", "65644654"));
            miLista.Add(new clsPersona(4, "Jesus", "Fernandez", null, "IES nervion", "65644654"));
            miLista.Add(new clsPersona(5, "German", "Fernandez", null, "IES nervion", "75644654"));
            miLista.Add(new clsPersona(6, "Luis", "Fernandez", null, "IES nervion", "75644654"));

            return miLista;
        }
    }
}
