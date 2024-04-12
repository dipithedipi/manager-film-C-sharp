using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manager_film
{
    public class Film
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string trama { get; set; }
        public TimeSpan durata { get; set; }
        public DateTime uscita { get; set; }
        public int genere { get; set; }

        public Film (int id_, string nome_, string trama_, TimeSpan durata_, DateTime uscita_, int genere_)
        {

            this.id = id_;
            this.nome = nome_;
            this.trama = trama_;
            this.durata = durata_;
            this.uscita = uscita_;
            this.genere = genere_;
        }

        public override string ToString()
        {
            return $"Id: {id}, Nome: {nome}, Trama: {trama}, Durata: {durata}, Uscita: {uscita}, Genere: {genere}";
        }
    }
}
