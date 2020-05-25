using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;


namespace PaginaWeb
{
    public partial class Datos : System.Web.UI.Page
    {
        List<Departamentos> departamentos = new List<Departamentos>();
        List<Medidas> medidas = new List<Medidas>();
        List<Asistente> datos = new List<Asistente>();

        protected void Page_Load(object sender, EventArgs e)
        {

            var archivo = Server.MapPath("~/Medidas.txt");

            FileStream stream = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Medidas medida = new Medidas();

                medida.Id = reader.ReadLine();
                medida.Milimetro = Convert.ToInt32(reader.ReadLine());
                medida.Fecha = Convert.ToDateTime(reader.ReadLine());

                medidas.Add(medida);

            }

            reader.Close();

            archivo = Server.MapPath("~/Departamentos.txt");

            stream = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Departamentos deptmp = new Departamentos();

                deptmp.Id = reader.ReadLine();
                deptmp.Nombre = reader.ReadLine();

                departamentos.Add(deptmp);
            }
            reader.Close();
        }

        protected void Mostrar_Click(object sender, EventArgs e)
        {
            foreach (var m in medidas)
            {
                Departamentos depa = departamentos.Find(d => d.Id == m.Id);

                Asistente dat = new Asistente();

                dat.Milimetro = m.Milimetro;
                dat.Nombre = depa.Nombre;

                datos.Add(dat);
            }
            data.DataSource = datos;
            data.DataBind();
        }

        protected void Prom_Click(object sender, EventArgs e)
        {
            double promedio = medidas.Average(m => m.Milimetro);

            LabelProm.Text = promedio.ToString();
        }
    }
}