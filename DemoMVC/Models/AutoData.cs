using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.Models
{
	public static class AutoData
	{
        public static List<AutoModel> autolijst { get; set; } = new List<AutoModel>();
        public static void Create()
		{
            autolijst.Add(new AutoModel() {
                KilometerStand = 150000,
            Merk = "Toyota",
            Type = "Auris"
        });

            autolijst.Add(new AutoModel()
            {
                KilometerStand = 20,
                Merk = "BMW",
                Type = "109D"
            });
		}
		
    }
}
