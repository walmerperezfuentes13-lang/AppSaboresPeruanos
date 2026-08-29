using Dominio;
using System.ComponentModel;
namespace Presentacion
{
    public partial class FrmGestionarCategorias : Form
    {
        //Definir una lista de categorias enlazada al dataGridView
        private BindingList<Categoria> _listaCategorias = new BindingList<Categoria>();

        public FrmGestionarCategorias()
        {
            InitializeComponent();
        }

        private void btnProbarCategoria_Click(object sender, EventArgs e)
        {
            //Crear una instancia de la clase Categoria
            Categoria ocategoria1 = new Categoria();

            //Asignar valores a los atributos de la clase Categoria
            ocategoria1.Id = 1;
            ocategoria1.Nombre = "Bebidas";
            ocategoria1.Descripcion = "Bebidas alcohólicas y no alcohólicas";
            ocategoria1.Activa = true;

            //Mostrar los valores de los atributos de la clase Categoria en un MessageBox
            MessageBox.Show("Id: " + ocategoria1.Id + "\nNombre: " + ocategoria1.Nombre + "\nDescripcion: " + ocategoria1.Descripcion + "\nActiva: " + ocategoria1.Activa);

            //Craar otra instancia de la clase Categoria
            Categoria ocategoria2 = new Categoria();

            //Asignar valores a los atributos de la clase Categoria
            ocategoria2.Id = 2;
            ocategoria2.Nombre = "Lacteos";
            ocategoria2.Descripcion = "Productos lacteos";
            ocategoria2.Activa = true;

            //Mostrar los valores de los atributos de la clase Categoria en un MessageBox
            MessageBox.Show("Id: " + ocategoria2.Id + "\nNombre: " + ocategoria2.Nombre + "\nDescripcion: " + ocategoria2.Descripcion + "\nActiva: " + ocategoria2.Activa);

            //Agregar las instancias de la clase Categoria a la lista de categorias
            _listaCategorias.Add(ocategoria1);
            _listaCategorias.Add(ocategoria2);
        }

        private void FrmGestionarCategorias_Load(object sender, EventArgs e)
        {
            //Enlazar la lista de categorias al dataGridView
            dgvListaCategorias.DataSource = _listaCategorias;

        }

        private void btnCrearCategoria_Click(object sender, EventArgs e)
        {
            //1-Capturar los valores ingresados por el usuario en los TextBox
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;

            //2_Crear una instancia de la clase Categoria
            Categoria nuevaCategoria = new Categoria
            {
                Id = _listaCategorias.Count + 1, // Asignar un Id secuencial
                Nombre = nombre,
                Descripcion = descripcion,
                Activa = true
            };

            //3_Agregar la nueva categoria a la lista 
            _listaCategorias.Add(nuevaCategoria);

            //4_Limpiar los TextBox
            LimpiarControles();

        }

        private void LimpiarControles()
        {
            //Limpiar los TextBox
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
    }
}
