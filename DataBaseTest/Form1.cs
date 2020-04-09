using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseTest
{
    public partial class Form1 : Form
    {
        public int offset  = 0;
        
        List<Data> data = null;
        List<Dupla> Filter = new List<Dupla>();
        List<TextBox> Boxes = new List<TextBox>();

        TextBox txtFecha = new TextBox();
        TextBox txtTecnologia = new TextBox();
        TextBox txtAutoridad = new TextBox();
        TextBox txtEstacion = new TextBox();
        TextBox txtLatitud = new TextBox();
        TextBox txtLongitud = new TextBox();
        TextBox txtCDepartamento = new TextBox();
        TextBox txtDepartamento = new TextBox();
        TextBox txtCMunicipio = new TextBox();
        TextBox txtMunicipio = new TextBox();
        TextBox txtTEstacion = new TextBox();
        TextBox txtExposicion = new TextBox();
        TextBox txtVariable = new TextBox();
        TextBox txtUnidad = new TextBox();
        TextBox txtConcentracion = new TextBox();
        public Form1()
        {
            InitializeComponent();

          
            Filter.Add(new Dupla("Fecha", "fecha=") { });
            Filter.Add(new Dupla( "Autoridad", "autoridad_ambiental=") {  });
            Filter.Add(new Dupla("Estacion", "nombre_de_la_estaci_n="));
            Filter.Add(new Dupla("Tecnologia", "tecnolog_a="));
            Filter.Add(new Dupla("Latiitud", "latitud="));
            Filter.Add(new Dupla("Longitud", "longitud="));
            Filter.Add(new Dupla("C Departamento", "c_digo_del_departamento="));
            Filter.Add(new Dupla("Departamento", "departamento="));
            Filter.Add (new Dupla("C Municipio", "c_digo_del_municipio="));
            Filter.Add(new Dupla("Municipio", "nombre_del_municipio="));
            Filter.Add(new Dupla("T Estacion", "tipo_de_estaci_n="));
            Filter.Add (new Dupla("Exposicion", "tiempo_de_exposici_n="));
            Filter.Add(new Dupla("Variable", "variable="));
            Filter.Add(new Dupla("Unidad", "unidades="));
            Filter.Add(new Dupla("Concentracion", "concentraci_n="));

            Boxes.Add(txtFecha);
            Boxes.Add(txtAutoridad);
            Boxes.Add(txtEstacion);
            Boxes.Add(txtTecnologia);
            Boxes.Add(txtLatitud);
            Boxes.Add(txtLongitud);
            Boxes.Add(txtCDepartamento);
            Boxes.Add(txtDepartamento);
            Boxes.Add(txtCMunicipio);
            Boxes.Add(txtMunicipio);
            Boxes.Add(txtTEstacion);
            Boxes.Add(txtExposicion);
            Boxes.Add(txtVariable);
            Boxes.Add(txtUnidad);
            Boxes.Add(txtConcentracion);
            createTable();

          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String url = tbUrl.Text;
            String id = tbId.Text;
           
            callData(0,url,id);
            
            

        }

        private void dgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            String url = tbUrl.Text;
            String id = tbId.Text;
            offset = offset + 20;
            callData(offset,url,id);
        }

        public void callData(int page,String url, String id)
        {
            String extensions = CreateUrl();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://" + url + "/resource/" + id +".json?$limit="+20+"&$offset="+offset+extensions);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                data = JsonConvert.DeserializeObject<List<Data>>(json);
                dgData.DataSource = data;
            }

            

          
           
        }



        private void btPrev_Click(object sender, EventArgs e)
        {
            offset = offset - 20;
            if(offset < 0)
            {
                MessageBox.Show("No hay mas datos previos");
            }else{

                String url = tbUrl.Text;
                String id = tbId.Text;
                callData(offset,url,id);
            }



        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void createTable()
        {
            tableLayoutPanel1.RowCount = 15;
            tableLayoutPanel1.ColumnCount = 2;
            for(int c = 1; c < 16; c++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
                tableLayoutPanel1.Controls.Add(new Label() { Text = Filter[c-1].Filter }, 0, c);
                tableLayoutPanel1.Controls.Add(Boxes[c-1],1,c);

            }
           

            tableLayoutPanel1.AutoScroll = true;
            
          
        }

        public void CreateExcel()
        {
            String file = "C:/Users/juanp/desktop/BaseDatos.csv";
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine("Autoridad Ambiental,Nombre Estacion,Tecnologia,Latitud,Longitud,Codigo Departamento,Departamento,Codigo Municipio,Municipio,Tipo Estacion,Tiempo Exposicion,Variable,Unidad,Concentracion,Nueva Columna Georeferenciada");

            for (int c = 0; c < data.Count; c++)
            {
                sw.WriteLine(data[c].autoridad+","+data[c].estacion+","+data[c].tecnologia+","+data[c].latitud+","+data[c].longitud+","+data[c].codigo_departamento+","+data[c].departamento+","+data[c].codigo_municipio+","+data[c].municipio+","+data[c].tipo_estacion+","+data[c].tiempo_exposicion+","+data[c].variable+","+data[c].unidades+","+data[c].concentracion+","+data[c].georeferencia+",");
            }



            sw.Close();
        }
        
        public String CreateUrl()
        {
            String extension = "";
          for(int c = 0; c < Filter.Count; c++)
            {
                if(Boxes[c].Text != "")
                {
                    extension += "&"+Filter[c].Output + Boxes[c].Text;
                }

            }
            Console.WriteLine(extension);

            return extension;
        }
        
    }
}
