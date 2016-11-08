using BindingEj2Elementos.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingEj2Elementos.ViewModels
{
    class clsMainPageVM
    {
        private clsPersona _personaSeleccionada;
        private ObservableCollection<clsPersona> _listaPersonas;

        public clsPersona PersonaSeleccionada
        {
            get
            {
                return _personaSeleccionada;
            }

            set
            {
                _personaSeleccionada = value;
            }
        }

        public clsMainPageVM()
        {
            clsListado oListado = new clsListado();
            _listaPersonas = oListado.getListado();
        }


    }


}
