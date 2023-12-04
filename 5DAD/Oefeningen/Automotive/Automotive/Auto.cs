using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotive
{
    public class Auto
    {

		private DateTime _constructiedatum;

		public string Merk { get; set; }
		public string Kleur { get; set; }
		public string Type { get; set; }



		public DateTime ConstructieDatum
		{
			get { return _constructiedatum; }
			set {
				if (value.Date < DateTime.Now.Date)
				{
					_constructiedatum = value;
				}
				else {
					throw new Exception("De Constructiedatum kan niet in de toekomst liggen");
				}
			
			}
		}




	}
}
