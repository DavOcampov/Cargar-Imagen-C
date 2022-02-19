using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//libreria para conexion a SQL Server
using System.Data.SqlClient;
using System.Data;

namespace Proyecto_img
{
    public partial class Form1 : Form
    {
        // Caden, Mensaje de error
        public static string cadena = "Data Source=.;Initial Catalog=BD_IMAGEN;User ID=ADSI;Password=12345";
        public static string MsgError = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (JPG,PNG,GIF)|*.JPG;*.PNG;*.GIF";
            openFileDialog1.Title = "Buscar imagen";
            openFileDialog1.ShowDialog(this);
            string ruta = openFileDialog1.FileName;
            pbx_img.Image = Image.FromFile(ruta);
        }

        // Comvierte una imagen a bytes
        // Parametros: Imagen
        // Retorna: Byte
        public static byte[] Convertir_Imagen_Bytes(Image img)
        {
            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Position = 0;

            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];
            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;
        }

        // Comvierte una Byte en Imagen
        // Parametros: Byte
        // Retorna: Imagen
        public static Image Convertir_Bytes_Imagen(byte[] bytes)
        {
            if (bytes == null) return null;

            MemoryStream ms = new MemoryStream(bytes);
            Bitmap bm = null;
            try
            {
                bm = new Bitmap(ms);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            return bm;
        }

        // Funcion insertar datos
        // Retorna: Verdadero o falso (True o False)
        //Parametros: id, nombre imagen(byte)

        public static bool Func_Insertar(long id, string nombre, byte[] bytes)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlConnection conexion = new SqlConnection(cadena);
                string sql = "INSERT INTO dato_img (id, nombre, img) VALUES ('" + id + "', '" + nombre + "', '" + bytes + "');";
                SqlDataAdapter adap = new SqlDataAdapter(sql, conexion) ;
                adap.Fill(dt);
                return true;
            }
            catch (Exception ex)
            {
                MsgError = ex.ToString();
                return false;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            byte[] bytes = Convertir_Imagen_Bytes(pbx_img.Image);
            string nombre = txt_nombre.Text;
            long id = Convert.ToInt64(txt_id.Text);
            if(Func_Insertar(id, nombre, bytes))
            {
                MessageBox.Show("Dato guardado");
            }
            else
            {
                MessageBox.Show("Error: " + MsgError);
            }

        }
    }
}
