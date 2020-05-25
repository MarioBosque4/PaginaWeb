using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace PaginaWeb
{
    public partial class _Default : Page
    {
        List<Departamentos> departamentos = new List<Departamentos>();
        List<Medidas> medidas = new List<Medidas>();

        protected void Page_Load(object sender, EventArgs e)
        {
            var archivo = Server.MapPath("~/Medidas.txt");

            FileStream stream = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while(reader.Peek() > -1)
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

            while(reader.Peek() > -1)
            {
                Departamentos deptmp = new Departamentos();

                deptmp.Id = reader.ReadLine();
                deptmp.Nombre = reader.ReadLine();

                departamentos.Add(deptmp);
            }
            reader.Close();

            if (!IsPostBack)
            {
                combo.SelectedValue = "Id";
                combo.DataTextField = "Nombre";
                combo.DataSource = departamentos;
                combo.DataBind();
            }
        }

        protected void Guardar_Click(object sender, EventArgs e)
        {
            var archivo = Server.MapPath("~/Medidas.txt");

            FileStream stream = new FileStream(archivo, FileMode.Append, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(combo.SelectedValue);
            writer.WriteLine(textml.Text);
            writer.WriteLine(DateTime.Now.Date);


            writer.Close();
        }
    }
}