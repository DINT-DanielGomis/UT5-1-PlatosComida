﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT5_1_PlatosComida
{
    class MainWindowVM : INotifyPropertyChanged

    {
        private ObservableCollection<string> tiposComida;
        public ObservableCollection<string> TiposComida
        {
            get { return tiposComida; }
            set { tiposComida = value;
                    NotifyPropertyChanged("TiposComida");
            }    
        }

        private ObservableCollection<Plato> listaPlatos;
        public ObservableCollection<Plato> ListaPlatos
        {
            get { return listaPlatos; }
            set
            {
                listaPlatos = value;
                NotifyPropertyChanged("ListaPlatos");
            }
        }
        private Plato platoSeleccionado;
        public Plato PlatoSelecionado
        {
            get { return platoSeleccionado; }
            set
            {
                platoSeleccionado = value;
                NotifyPropertyChanged("PlatoSeleccionado");
            }
        }
        public MainWindowVM()
        {
            ListaPlatos = Plato.GetSamples(@"Properties\recursos\FotosPlatos");

        }


        public event PropertyChangedEventHandler PropertyChanged;

        
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
