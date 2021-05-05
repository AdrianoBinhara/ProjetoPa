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
                new Sneaker{ Name="React Scape", Model="Woman running shoes", Price="135", Picture="Nike1.png", Color="#ecf2f4", PriceColor="#76abbc"},
                new Sneaker{ Name="Zoom Elx", Model="Woman running shoes", Price="143", Picture="Nike2.png", Color="#ecf2f4", PriceColor="#76abbc"},
                new Sneaker{ Name="Jumpo all", Model="Woman running shoes", Price="195", Picture="Nike3.png", Color="#ffeedf", PriceColor="#ec7430" },
                new Sneaker{ Name="Trace Run", Model="Woman running shoes", Price="175", Picture="Nike4.png", Color="#ffeedf", PriceColor="#ec7430"},
                new Sneaker{ Name="Supazi Scale", Model="Woman running shoes", Price="105", Picture="Nike1.png",Color="#ecf2f4", PriceColor="#76abbc"}
            };
        }
    }
}
