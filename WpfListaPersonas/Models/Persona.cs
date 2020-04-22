using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfListaPersonas.Models
{

    public class PersonaCollection : ObservableCollection<Persona>
    {

    }

    public class Persona
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private DateTime _fechaNac;
        public DateTime FechaNac
        {
            get { return _fechaNac; }
            set { _fechaNac = value; }
        }

    }
}
