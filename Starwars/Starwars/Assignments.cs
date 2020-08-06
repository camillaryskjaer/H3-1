using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Starwars
{
    public class Assignments
    {
        private readonly List<Planet> _planets;

        public Assignments(List<Planet> planets)
        {
            _planets = planets;
        }

        //Her kunne man godt argumentere for at bruge ToLower, så man fik "stavefejls" planeter med :)
        public List<string> Opgave1()
            => _planets
                .Select(p => p.Name)
            
                .Where(n => n.StartsWith("M"))
                .ToList();
        
        public List<string> Opgave2()
            //Kan gøres nemmere 
            => _planets.Where(p => p.Name.ToLower().Contains("y"))
            
            
            
            => _planets.Where(p => p.Name.Contains("y") || p.Name.Contains("Y"))
                .Select(p => p.Name)
                .ToList();

        public List<string> Opgave3() 
            => _planets
                .Select(p => p.Name)
                .Where(n => n.Length > 9 && n.Length < 15)
                .ToList();
        public List<string> Opgave4()
            => _planets
                .Select(p => p.Name)
                .Where(n => n.Substring(1, 1) == "a" && n.EndsWith("e"))
                .ToList();

        public List<string> Opgave5()
            => _planets
                .Where(p => p.RotationPeriod > 40)
                .OrderBy(r => r.RotationPeriod)
                .Select(p => p.Name)
                .ToList();
        
        public List<string> Opgave6()
            => _planets
                .Where(p => p.RotationPeriod > 10 && p.RotationPeriod < 20)
                .OrderBy(p => p.Name)
                .Select(p => p.Name)
                .ToList();

        public List<string> Opgave7()
            => _planets
                .Where(p => p.RotationPeriod > 30)
                .OrderBy(p => p.Name)
                .ThenBy(p => p.RotationPeriod)
                .Select(p => p.Name)
                .ToList();

        public List<string> Opgave8()
            => _planets
            //For læsevenlighedens skyld, er det en god ide at indkapsle udtryk i paranteser
          
                .Where(p => p.RotationPeriod < 30 && p.Name.Contains("ba")|| p.SurfaceWater > 50 && p.Name.Contains("ba"))
                .OrderBy(p => p.Name)
                .ThenBy(p => p.SurfaceWater)
                .ThenBy(p => p.RotationPeriod)
                .Select(p => p.Name)
                .ToList();

        public List<string> Opgave9()
            => _planets
                .Where(p => p.SurfaceWater > 0)
                .OrderByDescending(p => p.SurfaceWater)
                .Select(p => p.Name)
                .ToList();

        public List<string> Opgave10()
        {
            var planets = _planets.Where(p => p.Diameter != null && p.Residents != null).ToList();
            var areas = CalculatePlanetArea(planets);
            var result = new List<string>();
            result.Add("Jeg giver op! xD");
            //Det gør jeg også nogle gange :)
            
            //Hvad med 
            var planets = _planets.Where(p => p.Diameter > 0 && p.Population > 0).OrderBy(p => (4 * Math.PI * Math.Pow(p.Diameter / 2, 2)) / p.Population);
         
            
            
            
            return result;
        }

        public List<string> Opgave11()
        {
            var noRotationPlanets = _planets.Where(p => p.RotationPeriod == null || p.RotationPeriod > 0);
            return _planets.Except(noRotationPlanets, new NameComparer()).Select(p => p.Name).ToList();
        }

        public List<string> Opgave12()
        {
            var planetsLetterSort = _planets.Where(p => p.Name.StartsWith("a") || p.Name.EndsWith("s"));
            var rainforestPlanets = _planets.Where(p => p.Terrain != null && p.Terrain.Contains("rainforests"));
            return planetsLetterSort.Union(rainforestPlanets, new NameComparer()).Select(p => p.Name).ToList();
        }

        public List<string> Opgave13()
            => _planets
                .Where(p => p.Terrain != null && p.Terrain.Any("deserts".Contains))
                .Select(p => p.Name)
                .ToList();
        
        public List<string> Opgave14()
            => _planets
                .Where(p => p.Terrain != null && p.Terrain.Any("swamps".Contains))
                .OrderBy(p => p.RotationPeriod)
                .ThenBy(p => p.Name)
                .Select(p => p.Name)
                .ToList();

        public List<string> Opgave15()
        {
            string pattern = @"\w[aeiou]{2}\w"; // Kan ikke finde det rigtige regex til det her snask..
            var regex = new Regex(pattern);
            return _planets.Where(p => regex.IsMatch(p.Name)).Select(p => p.Name).ToList();
        }
        
        public List<string> Opgave16()
        {
            string pattern = @"\w[klrnKLRN]{2}\w";
            var regex = new Regex(pattern);
            return _planets.Where(p => regex.IsMatch(p.Name)).OrderByDescending(p => p.Name).Select(p => p.Name).ToList();
        }
        
        private Dictionary<string, double> CalculatePlanetArea(List<Planet> planets)
        {
            var areas = new Dictionary<string, double>();
            foreach (var planet in planets)
            {
                var radial = planet.Diameter / 2;
                var area = 4 * Math.PI * radial;
                areas.Add(planet.Name, area);
            }
            return areas;
        }
    }
}
