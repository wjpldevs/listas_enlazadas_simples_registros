using System;
using System.Windows.Forms;

namespace Listas_con_registros
{
    public partial class frmAgenda : Form
    {
        Nodo primero, auxiliar, auxiliar2;
        private int cantidad;

        public frmAgenda()
        {
            InitializeComponent();
            Timer.Enabled = true;
            primero = auxiliar = auxiliar2 = null;
            cantidad = 0;
        }

        public int Cantidad()
        {
            return cantidad;
        }

        public bool ListaVacia()
        {
            if (primero == null)
                return true;
            else
                return false;
        }

        public void Recorrido_Iterativo()
        {
            dtgContactos.Rows.Clear();

            Nodo nuevo = primero;

            while (nuevo != null)
            {
                dtgContactos.Rows.Add(nuevo.Nombre, nuevo.Direccion, nuevo.Telefono);
                nuevo = nuevo.Enlance;
            }
        }

        public void Limpiar()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTel.Clear();
            txtNombre.Focus();
        }

        // PARA INSERTAR

        public void Insertar_Inicio(string nombre, string direccion, int telefono)
        {
            if (ListaVacia() == true)
            {
                primero = new Nodo(nombre, direccion, telefono);
                primero.Enlance = null;
            }
            else
            {
                Nodo nuevo = new Nodo(nombre, direccion, telefono);
                nuevo.Enlance = primero;
                primero = nuevo;
            }
            cantidad++;
        }

        public void Insertar_Final(string nombre, string direccion, int telefono)
        {
            if (ListaVacia() == true)
            {
                primero = new Nodo(nombre, direccion, telefono);
                primero.Enlance = null;
            }
            else
            {
                auxiliar = primero;
                while (auxiliar.Enlance != null)
                    auxiliar = auxiliar.Enlance;

                Nodo nuevo = new Nodo(nombre, direccion, telefono);
                nuevo.Enlance = null;
                auxiliar.Enlance = nuevo;
                auxiliar = nuevo;
                
            }
            cantidad++;
        }

        public void Inserta_Antes(object referencia, string nombre, string direccion, int telefono)
        {
            // solo permite tomar como referencia al nombre y el telefono

            Nodo nuevo = primero;
            int bandera = 1;

            while ((!nuevo.Nombre.Equals(referencia)
                && !nuevo.Telefono.Equals(referencia)
                && !nuevo.Direccion.Equals(referencia))
                && bandera == 1)
            {
                if (nuevo.Enlance != null)
                {
                    auxiliar = nuevo;
                    nuevo = nuevo.Enlance;
                }
                else
                    bandera = 0;
            }

            if (bandera == 1)
            {
                Nodo antes = new Nodo(nombre, direccion, telefono);

                if (primero == nuevo)
                {
                    antes.Enlance = primero;
                    primero = antes;
                }
                else
                {
                    auxiliar.Enlance = antes;
                    antes.Enlance = nuevo;
                    
                }
                cantidad++;
            }
            else
                MessageBox.Show("La referencia no se encuentra en la lista", "Referencia no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Inserta_Despues(object referencia, string nombre, string direccion, int telefono)
        {

            auxiliar = primero;
            int bandera = 1;

            while ((!auxiliar.Nombre.Equals(referencia)
                && !auxiliar.Telefono.Equals(referencia)
                && !auxiliar.Direccion.Equals(referencia))
                && bandera == 1)
            {
                if (auxiliar.Enlance != null)
                    auxiliar = auxiliar.Enlance;
                else
                    bandera = 0;
            }

            if (bandera == 1)
            {
                Nodo nuevo = new Nodo(nombre, direccion, telefono);
                nuevo.Enlance = auxiliar.Enlance;
                auxiliar.Enlance = nuevo;
                
            }
            cantidad++;
        }

        // PARA ELIMINAR

        public void Eliminar_Inicio()
        {
            if (ListaVacia() == true)
            {
                MessageBox.Show("No pueden eliminar más elementos.\nLa lista está vacía.", "Lista vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblCantidad.Text = "Cantidad de elementos de lista: " + "0";
            }
            else
            {
                auxiliar = primero;

                if (primero.Enlance == null)
                    primero = null;
                else
                {
                    primero = auxiliar.Enlance;
                    auxiliar = null;
                    cantidad--;
                }
            }
        }

        public void Eliminar_Final()
        {
            if (ListaVacia() == true)
            {
                MessageBox.Show("No pueden eliminar más elementos.\nLa lista está vacía.", "Lista vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblCantidad.Text = "Cantidad de elementos de lista: " + "0";
            }
            else
            {
                auxiliar = primero;

                if (primero.Enlance == null)
                    primero = null;
                else
                {
                    while (auxiliar.Enlance != null)
                    {
                        auxiliar2 = auxiliar;
                        auxiliar = auxiliar.Enlance;
                    }
                    auxiliar2.Enlance = null;
                }
                auxiliar = null;
                cantidad--;
            }
        }

        public void Eliminar_X(object referencia)
        {
            if (ListaVacia() == true)
            {
                MessageBox.Show("No pueden eliminar más elementos.\nLa lista está vacía.", "Lista vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblCantidad.Text = "Cantidad de elementos de lista: " + "0";
            }
            else
            {
                auxiliar = primero;
                int bandera = 1;

                while ((!auxiliar.Nombre.Equals(referencia)
                    && !auxiliar.Direccion.Equals(referencia)
                    && !auxiliar.Telefono.Equals(referencia)) && bandera == 1)
                {
                    if (auxiliar.Enlance != null)
                    {
                        auxiliar2 = auxiliar;
                        auxiliar = auxiliar.Enlance;
                    }
                    else
                        bandera = 0;
                }

                if (bandera == 0)
                    MessageBox.Show(string.Format("El la referencia \"{0}\" no se encontró en la lista.", referencia.ToString()), "Referencia Errónea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (primero == auxiliar)
                        primero = auxiliar.Enlance;
                    else
                        auxiliar2.Enlance = auxiliar.Enlance;

                    auxiliar = null;
                    cantidad--;
                }

            }
        }

        public void Eliminar_Antes(object referencia)
        {
            if (ListaVacia() == true)
            {
                MessageBox.Show("No pueden eliminar más elementos.\nLa lista está vacía.", "Lista vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblCantidad.Text = "Cantidad de elementos de lista: " + "0";
            }
            else
            {
                if (primero.Nombre.Equals(referencia)
                    || primero.Direccion.Equals(referencia)
                    || primero.Telefono.Equals(referencia))
                    MessageBox.Show(string.Format("No existe un nodo que preceda a \"{0}\" .", referencia.ToString()), "Referencia no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    Nodo nuevo = primero; auxiliar = primero;
                    int bandera = 1;

                    while ((!nuevo.Nombre.Equals(referencia)
                        && !nuevo.Direccion.Equals(referencia)
                        && !nuevo.Telefono.Equals(referencia)) && bandera == 1)
                    {
                        if (nuevo.Enlance != null)
                        {
                            auxiliar2 = auxiliar;
                            auxiliar = nuevo;
                            nuevo = nuevo.Enlance;
                        }
                        else
                            bandera = 0;
                    }

                    if (bandera == 0)
                        MessageBox.Show(string.Format("No se encontró la referencia \"{0}\" .", referencia.ToString()), "Referencia no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        if (primero.Enlance == nuevo)
                            primero = nuevo;
                        else
                            auxiliar2.Enlance = nuevo;

                        auxiliar = null;
                        cantidad--;
                    }
                }

            }
        }

        public void Eliminar_Despues(object referencia)
        {
            if (ListaVacia() == true)
            {
                MessageBox.Show("No pueden eliminar más elementos.\nLa lista está vacía.", "Lista vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblCantidad.Text = "Cantidad de elementos de lista: " + "0";
            }
            else
            {
                /*if ((primero.Nombre.Equals(referencia)
                    || primero.Direccion.Equals(referencia)
                    || primero.Telefono.Equals(referencia)) && (primero.Enlance == null)) // cuando solo hay un elemento
                    MessageBox.Show("Solo hay un nodo, no hay ninguno posterior a él.", "Nodo único", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    Nodo nuevo = primero;

                    while (!nuevo.Nombre.Equals(referencia)
                            && !nuevo.Direccion.Equals(referencia)
                            && !nuevo.Telefono.Equals(referencia))
                    {
                        if (nuevo.Enlance != null)
                        {
                            nuevo = nuevo.Enlance;
                            auxiliar = nuevo;
                            auxiliar2 = auxiliar.Enlance;
                        }
                    }

                    if (primero.Nombre.Equals(referencia)
                        || primero.Direccion.Equals(referencia)
                        || primero.Telefono.Equals(referencia))
                    {
                        auxiliar2 = nuevo.Enlance;
                        primero.Enlance = auxiliar2.Enlance;
                    }
                    else
                    {
                        if (auxiliar2 == null)
                            MessageBox.Show("No se puede utilizar el último como referencia.", "Nodo único", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            auxiliar.Enlance = auxiliar2.Enlance;
                        }
                    }

                    auxiliar2 = null;
                    cantidad--;

                }*/

                if ((primero.Nombre.Equals(referencia)
                    || primero.Direccion.Equals(referencia)
                    || primero.Telefono.Equals(referencia)) && primero.Enlance == null)
                    MessageBox.Show("Solo hay un elemento");
                else
                {
                    auxiliar2 = primero;
                    int bandera = 1;
                    while (!auxiliar2.Nombre.Equals(referencia) && !auxiliar2.Direccion.Equals(referencia)
                        && !auxiliar2.Telefono.Equals(referencia) && bandera == 1)
                    {
                        if (auxiliar2.Enlance != null)
                        {
                            auxiliar2 = auxiliar2.Enlance;
                            auxiliar = auxiliar2.Enlance;
                        }
                        else
                            bandera = 0;
                    }

                    if (bandera == 0)
                        MessageBox.Show("No se encontró la referencia");
                    else
                    {
                        if (auxiliar == null)
                            MessageBox.Show("No se puede eliminar el último");
                        else
                        {
                            auxiliar2.Enlance = auxiliar.Enlance;
                        }

                        auxiliar = null;
                        cantidad--;
                    }

                }


            }
        }

        // PARA BUSCAR

        public void Busqueda_Desordenada(object elemento)
        {
            Nodo nuevo = primero;

            switch (cboBuscar.Text)
            {
                case "Nombre y apellido":

                    while (nuevo.Enlance != null && !nuevo.Nombre.Equals(elemento))
                        nuevo = nuevo.Enlance;

                    break;

                case "Dirección":

                    while (nuevo.Enlance != null && !nuevo.Direccion.Equals(elemento))
                        nuevo = nuevo.Enlance;

                    break;

                case "Teléfono":

                    while (nuevo.Enlance != null && !nuevo.Telefono.Equals(elemento))
                        nuevo = nuevo.Enlance;

                    break;

                default:
                    MessageBox.Show("Seleccione una opción correcta.", "Elemento encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }

            if (nuevo == null)
                MessageBox.Show(string.Format("No se encontró la referencia \"{0}\".", elemento.ToString()), "Elemento encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show(string.Format("Si se encontró la referencia \"{0}\".", elemento.ToString()), "Elemento no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // CONTROLES

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = "Fecha y hora: " + DateTime.Now.ToString();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // void
        }

        private void btnAgInicio_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtNombre.Text) || "".Equals(txtDireccion.Text) || "".Equals(txtTel.Text))
            {
                MessageBox.Show("No pueden existir campos vacíos.\nInténtelo de nuevo.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
            else
            {
                Insertar_Inicio(txtNombre.Text, txtDireccion.Text, int.Parse(txtTel.Text));
                Recorrido_Iterativo();
                lblCantidad.Text = "Cantidad de elementos de lista: " + Convert.ToString(Cantidad());
                Limpiar();
                
            }
        }

        private void btnAgFinal_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtNombre.Text) || "".Equals(txtDireccion.Text) || "".Equals(txtTel.Text))
            {
                MessageBox.Show("No pueden existir campos vacíos.\nInténtelo de nuevo.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
            else
            {
                Insertar_Final(txtNombre.Text, txtDireccion.Text, int.Parse(txtTel.Text));
                Recorrido_Iterativo();
                lblCantidad.Text = "Cantidad de elementos de lista: "+Convert.ToString(Cantidad());
                Limpiar();
            }
        }

        private void btnAgAntes_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtNombre.Text) ||
                "".Equals(txtDireccion.Text) ||
                "".Equals(txtTel.Text) || "".Equals(txtRefAgregar.Text))
            {
                MessageBox.Show("No pueden existir campos vacíos.\nInténtelo de nuevo.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                txtRefAgregar.Clear();
            }
            else
            {
                Inserta_Antes(txtRefAgregar.Text, txtNombre.Text, txtDireccion.Text, int.Parse(txtTel.Text));
                Recorrido_Iterativo();
                lblCantidad.Text = "Cantidad de elementos de lista: " + Convert.ToString(Cantidad());
                Limpiar();
                txtRefAgregar.Clear();
            }
        }

        private void btnAgDespues_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtNombre.Text) ||
                "".Equals(txtDireccion.Text) ||
                "".Equals(txtTel.Text) || "".Equals(txtRefAgregar.Text))
            {
                MessageBox.Show("No pueden existir campos vacíos.\nInténtelo de nuevo.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                txtRefAgregar.Clear();
            }
            else
            {
                Inserta_Despues(txtRefAgregar.Text, txtNombre.Text, txtDireccion.Text, int.Parse(txtTel.Text));
                Recorrido_Iterativo();
                lblCantidad.Text = "Cantidad de elementos de lista: " + Convert.ToString(Cantidad());
                Limpiar();
                txtRefAgregar.Clear();
            }
        }

        private void btnDeInicio_Click(object sender, EventArgs e)
        {
            Eliminar_Inicio();
            Recorrido_Iterativo();
            lblCantidad.Text = "Cantidad de elementos de lista: " + Convert.ToString(Cantidad());
        }

        private void btnDeFinal_Click(object sender, EventArgs e)
        {
            Eliminar_Final();
            Recorrido_Iterativo();
            lblCantidad.Text = "Cantidad de elementos de lista: " + Convert.ToString(Cantidad());
        }

        private void btnDeX_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtRefEliminar.Text))
            {
                MessageBox.Show("El campo de la referencia no puede estar vacío.", "Referencia a eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRefEliminar.Clear();
                txtRefEliminar.Focus();
            }
            else
            {
                Eliminar_X(txtRefEliminar.Text);
                Recorrido_Iterativo();
                lblCantidad.Text = "Cantidad de elementos de lista: " + Convert.ToString(Cantidad());
                txtRefEliminar.Clear();
                txtRefEliminar.Focus();
            }
        }

        private void btnDeAntesX_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtRefEliminar.Text))
            {
                MessageBox.Show("El campo de la referencia no puede estar vacío.", "Referencia a eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRefEliminar.Clear();
                txtRefEliminar.Focus();
            }
            else
            {
                Eliminar_Antes(txtRefEliminar.Text);
                Recorrido_Iterativo();
                lblCantidad.Text = "Cantidad de elementos de lista: " + Convert.ToString(Cantidad());
                txtRefEliminar.Clear();
                txtRefEliminar.Focus();
            }
        }

        private void btnDeDespuesX_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtRefEliminar.Text))
            {
                MessageBox.Show("El campo de la referencia no puede estar vacío.", "Referencia a eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRefEliminar.Clear();
                txtRefEliminar.Focus();
            }
            else
            {
                Eliminar_Despues(txtRefEliminar.Text);
                Recorrido_Iterativo();
                lblCantidad.Text = "Cantidad de elementos de lista: " + Convert.ToString(Cantidad());
                txtRefEliminar.Clear();
                txtRefEliminar.Focus();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtBuscar.Text))
            {
                MessageBox.Show("Por favor ingrese un elemento a buscar", "Buscar...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscar.Clear();
                txtBuscar.Focus();
            }
            else
            {
                Busqueda_Desordenada(txtBuscar.Text);
                txtBuscar.Clear();
                txtBuscar.Focus();
            }

        }

        // Validaciones con eventos KeyPress

        private void Solo_Numeros(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void Solo_Texto(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }


    }
}
