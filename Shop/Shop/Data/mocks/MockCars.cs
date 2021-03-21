using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "",
                        fullDesc = "",
                        img = "https://3dnews.ru/assets/external/illustrations/2020/09/23/1021277/tesla1.jpg",
                        price = 120000,
                        isFavorite = true,
                        available = true, 
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Tesla Model 3",
                        shortDesc = "",
                        fullDesc = "",
                        img = "https://www.ixbt.com/img/n1/news/2020/0/1/1a4981b29e6f140d1e8f407f99e499d1_large.jpg",
                        price = 50000,
                        isFavorite = true,
                        available = false,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Tesla Model X",
                        shortDesc = "",
                        fullDesc = "",
                        img = "https://www.ixbt.com/img/n1/news/2020/11/0/8084f2as-960_large.jpg",
                        price = 96000,
                        isFavorite = false,
                        available = false,
                        Category = _categoryCars.AllCategories.Last()
                    },                    
                    new Car
                    {
                        name = "Mercedes-Benz E Class",
                        shortDesc = "",
                        fullDesc = "",
                        img = "https://avatars.mds.yandex.net/get-verba/997355/2a00000176b7d3f6a4f92df665019bd8cd6f/cattouchret",
                        price = 57000,
                        isFavorite = false,
                        available = false,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Mercedes-Benz С Class",
                        shortDesc = "",
                        fullDesc = "",
                        img = "https://www.mercedes-benz.ru/passengercars/mercedes-benz-cars/models/c-class/saloon-w205/explore/highlights/_jcr_content/contentgallerycontainer/par/contentgallery_6cb4/par/contentgallerytile_8/image.MQ6.8.20200213101808.jpeg",
                        price = 35000,
                        isFavorite = true,
                        available = false,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Mercedes-Benz S Class",
                        shortDesc = "",
                        fullDesc = "",
                        img = "https://lh3.googleusercontent.com/proxy/nf8biA_9mbjQ8bMvFTNAwJqW8Kz656gnF4HGDlhxoY7gbznA49B32nf60uuJw9jZJ025y91Sl0Dcb83C15gRnuXGUIM",
                        price = 125000,
                        isFavorite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
