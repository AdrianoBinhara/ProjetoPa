using ProjetoSneakersPA.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjetoSneakersPA.ViewModel
{
    public class SneakersViewModel
    {

        public ObservableCollection<Sneaker> SneakersList { get; set; }
        public SneakersViewModel()
        {
            SneakersList = new ObservableCollection<Sneaker>
            {
                new Sneaker{ Name="React Scape", Model="Woman running shoes", Price="135"},
                new Sneaker{ Name="Zoom Elx", Model="Woman running shoes", Price="143"},
                new Sneaker{ Name="Jumpo all", Model="Woman running shoes", Price="195"},
                new Sneaker{ Name="Trace Run", Model="Woman running shoes", Price="175"},
                new Sneaker{ Name="Supazi Scale", Model="Woman running shoes", Price="105"}
            };
        }
    }
}
