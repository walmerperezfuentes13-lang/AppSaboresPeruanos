using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    /*
     Clase categoria:
    Atributos: Id, Nombre, Descripcion, Activa
     */
    //Comentario
    public class Categoria
    { 
       //Definir atributos
       private int _id;
       private string _nombre;
       private string _descripcion;
       private bool _activa;

        // Propiedades publicas
        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public bool Activa { get => _activa; set => _activa = value; }

       
    }
}
