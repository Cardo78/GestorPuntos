using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorPuntos
{
    public partial class GestorPuntos : MetroFramework.Forms.MetroForm
    {
        Farmanager.Farmanager far;


        public GestorPuntos()
        {
            InitializeComponent();
        }

        private void GestorPuntos_Load(object sender, EventArgs e)
        {
            tbIPServidor.Text = Properties.Settings.Default.IPServidor;

        }

        /// <summary>
        /// Botón de revisión de conexión con la BD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButton4_Click(object sender, EventArgs e)
        {
            far = new Farmanager.Farmanager(Properties.Settings.Default.IPServidor, 3306);
            try
            {
                if (far.IsOpenConnection())
                    MessageBox.Show("Conexión correcta");
                else
                    MessageBox.Show("No hay conexión con el IP configurado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        /// <summary>
        /// Carga de datos al modificar el textbox de la IP de la BD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbIPServidor_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.IPServidor = tbIPServidor.Text;
            Properties.Settings.Default.Save();
        }


        #region Clientes Tab

        /// <summary>
        /// Parámetros generales del Tab Clientes
        /// </summary>
        const string QUERYCLIENT = "select icodigo, ges051.idsubcliente, csubnombre, ipuntosfidelizacion from gesql.ges051 join gesql.ges059 on ges051.idcliente = ges059.idcliente where ges059.icodigo = @codigo or csubnombre LIKE @nombre";
        const string QUERYUPDATE = "update gesql.ges051 set ipuntosfidelizacion = @puntos where idsubcliente = @idcliente";
        List<CLIENTE> grupocli;
        CLIENTE cli;

        /// <summary>
        /// Función de obtención clientes a partir de los datos del textbox
        /// Del resultado se genera listado de clientes en general para la obtención de los datos en el grid.
        /// </summary>
        /// <returns></returns>
        private List<CLIENTE> ObtenerClientes()
        {
            try
            {
                string nombrecliente = tbNombreCliente.Text;
                if (nombrecliente.Equals(""))
                {
                    nombrecliente = "zzzzzzzzzzzzzzzzzzzzzzz";
                }
                List<CLIENTE> clientes = new List<CLIENTE>();
                far = new Farmanager.Farmanager(tbIPServidor.Text, 3306);
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@codigo", tbCodigoCliente.Text);
                parametros.Add("@nombre", "%" + nombrecliente + "%");

                List<object[]> resultado = far.Select(QUERYCLIENT, parametros);

                foreach (var aux in resultado)
                {
                    CLIENTE cliente = new CLIENTE();
                    cliente.idcliente = Convert.ToInt32(aux[1]);
                    cliente.codigo = Convert.ToInt32(aux[0]);
                    cliente.nombre = aux[2].ToString();
                    cliente.puntos = Convert.ToInt32(aux[3]);
                    clientes.Add(cliente);

                }
                return clientes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Función de modificación de los puntos obtenidos por parámetro del cliente seleccionado.
        /// </summary>
        /// <param name="puntos"></param>
        private void ActualizaPuntos(string puntos)
        {
            try
            {
                if (far != null)
                {
                    if (cli != null)
                    {
                        Dictionary<string, object> parametros = new Dictionary<string, object>();
                        parametros.Add("@puntos", puntos);
                        parametros.Add("@idcliente", cli.idcliente);

                        far.Update(QUERYUPDATE, parametros);
                        metroButton2.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        /// <summary>
        /// Botón de aceptación de datos para ejecutar la consulta de datos de clientes.
        /// Se realiza perform a partir de los intros de cada textbox del filtro y actualizando los puntos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                grupocli = ObtenerClientes();
                if (grupocli != null)
                {
                    bindingSource1.DataSource = grupocli;
                    metroGrid1.DataSource = bindingSource1;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Revisión de teclas para el textbox de codigo cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                metroButton2.PerformClick();
            }
            else if(Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }else
            {
                e.Handled = true;
            }
        }


        /// <summary>
        /// Revisión de teclas para el textbox de nombre cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                metroButton2.PerformClick();
            }
        }

        /// <summary>
        /// Revisión de teclas para el textbox de total puntos cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbTotalPuntos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ActualizaPuntos(tbTotalPuntos.Text);
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Obtención del row marcado en el datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cli = grupocli[e.RowIndex];
                tbTotalPuntos.Text = cli.puntos.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #endregion

        #region Articulos Tab

        const string QUERYARTICULO = "select ges101.idarticulo, ccodigo, cnombre, ipuntosgenera, lfidelizacion, bpvp1, bpvp2, bpvp3, bpvp4 from gesql.ges101 join gesql.ges103 on ges101.idarticulo = ges103.idarticulo join gesql.ges105 on ges101.idarticulo = ges105.idarticulo where (ges101.cnombre LIKE @nombre or ges103.ccodigo LIKE @codigo) and ges105.ianyo > 2018 and ges103.lprincipal = 1 group by idarticulo";
        const string QUERYUPDATEART = "update gesql.ges101 set ipuntosgenera = @puntos where idarticulo = @idarticulo";
        const string QUERYUPDATEFID = "update gesql.ges101 set lfidelizacion = @estado where idarticulo = @idarticulo";
        List<ARTICULO> grupoart;
        ARTICULO art;

        private List<ARTICULO> ObtenerArticulos()
        {
            try
            {                              
                List<ARTICULO> articulos = new List<ARTICULO>();
                far = new Farmanager.Farmanager(tbIPServidor.Text, 3306);
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@codigo", mtbCodigoNacional.Text);
                parametros.Add("@nombre", "%" + (mtbArticulo.Text.Equals("") ? " ":mtbArticulo.Text) + "%");

                List<object[]> resultado = far.Select(QUERYARTICULO, parametros);

                foreach (var aux in resultado)
                {
                    ARTICULO articulo = new ARTICULO();
                    articulo.idarticulo = Convert.ToInt32(aux[0]);
                    articulo.codigo = aux[1].ToString();
                    articulo.nombre = aux[2].ToString();
                    articulo.puntos = Convert.ToInt32(aux[3]);
                    articulo.activo = Convert.ToBoolean(aux[4]);
                    articulo.pvp = 0;
                    for (int i = 5; i < 9; i++)
                    {
                        if(Convert.ToDouble(aux[i])> 0)
                        {
                            articulo.pvp = Convert.ToDouble(aux[i]);
                            break;
                        }
                    }
                    articulos.Add(articulo);

                }
                return articulos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ActualizaPuntosArticulo(string puntos)
        {
            try
            {
                if (far != null)
                {
                    if (art != null)
                    {
                        Dictionary<string, object> parametros = new Dictionary<string, object>();
                        parametros.Add("@puntos", puntos);
                        parametros.Add("@idarticulo", art.idarticulo);

                        far.Update(QUERYUPDATEART, parametros);
                        metroButton1.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        private void actualizaFidelizacion(bool valor)
        {
            try
            {
                if (far != null)
                {
                    if (art != null)
                    {
                        Dictionary<string, object> parametros = new Dictionary<string, object>();
                        parametros.Add("@estado", valor);
                        parametros.Add("@idarticulo", art.idarticulo);

                        far.Update(QUERYUPDATEFID, parametros);
                        metroButton1.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex; 
            }
        }

        private void mtbCodigoNacional_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                metroButton1.PerformClick();
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void mtbArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                metroButton1.PerformClick();
            }
        }

        private void metroGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                art = grupoart[e.RowIndex];
                mtbTotalPArticulo.Text = art.puntos.ToString();
                mtbPuntosEuro.Text = art.pvp.ToString();

                if (e.ColumnIndex == metroGrid2.Columns["activo"].Index)
                {
                    bool estado = Convert.ToBoolean(metroGrid2[e.ColumnIndex, e.RowIndex].Value);
                    actualizaFidelizacion(!estado);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                grupoart = ObtenerArticulos();
                if (grupoart != null)
                {
                    bindingSource2.DataSource = grupoart;
                    metroGrid2.DataSource = bindingSource2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void mtbTotalPArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                ActualizaPuntosArticulo(mtbTotalPArticulo.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void mtbTotalPArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    ActualizaPuntosArticulo(mtbTotalPArticulo.Text);
                    //mtbTotalPArticulo_Click(null, null);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }        

        }

        private void metroGrid2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion



    }

    public class CLIENTE
    {
        public int idcliente { get; set; }
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int puntos { get; set; }
    }

    public class ARTICULO
    {
        public int idarticulo { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public int puntos { get; set; }
        public double pvp { get; set; }
        public bool activo { get; set; }
    }
}
