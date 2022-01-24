using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using Recursiva.Forms;
using System.Text;

namespace Recursiva
{
    public partial class frmPrincipal : Form
    {
        Dictionary<string, List<Persona>> personas = new Dictionary<string, List<Persona>>();
        public IOrderedEnumerable<Persona> listaPunto3;
        public List<string> nombresPunto4;
        public Dictionary<string, Equipo> equiposPunto5;
        public frmPrincipal()
        {
            InitializeComponent();
            btnListados.Enabled = false;
        }

        private void btnSelec_Click_1(object sender, EventArgs e)
        {
            List<Persona> personasPto3 = new List<Persona>();
            List<string> nombresRiver = new List<string>();
            int total = 0;
            string path = "";

            if (ofdCsv.ShowDialog() == DialogResult.OK)
            {
                path = ofdCsv.FileName;
                btnSelec.Text = path;

                var reader = new StreamReader(File.OpenRead(path), Encoding.Default, true);

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    //para el punto 3, genero el listado filtrando por estado civil, estudios y selecciono hasta 100
                    //fuera del while ordeno el resultado por edad
                    if (values[3] == "Casado" && values[4] == "Universitario" && personasPto3.Count < 100)
                    {
                        personasPto3.Add(new Persona
                        {
                            Name = values[0],
                            Age = Convert.ToInt32(values[1]),
                            Team = values[2]
                        });
                    }

                    //acá guardo en un diccionario las personas según su equipo
                    if(personas.ContainsKey(values[2]))
                        personas[values[2]].Add(GenerarPersona(values));
                    else
                        personas.Add(values[2], new List<Persona> { GenerarPersona(values) });

                    total++;
                }
                var totalRegis = total; //1
                var promedioEdadRacing2 = CalcularPromedioEdadRacing(); //2
                listaPunto3 = personasPto3.OrderBy(x => x.Age); //3
                nombresPunto4 = CalcularTopNombres(); //4
                equiposPunto5 = GenerarEquipos(); //5

                lblUno.Text = "Cantidad total de personas registradas: " + totalRegis;
                lblDos.Text = "Promedio de edad de socios de Racing: " + promedioEdadRacing2;
                btnListados.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error", "No se seleccionó un archivo .csv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private Dictionary<string, Equipo> GenerarEquipos()
        {
            Dictionary<string, Equipo> equipos = new Dictionary<string, Equipo>();
            foreach (var equipo in personas)
            {
                var prom = equipo.Value.Average(x => x.Age);
                var menor = equipo.Value.Min(x => x.Age);
                var mayor = equipo.Value.Max(x => x.Age);
                equipos.Add(equipo.Key, new Equipo
                {
                    Promedio = Convert.ToDouble(string.Format("{0:n2}", (Math.Truncate(prom * 100) / 100))),
                    Nombre = equipo.Key,
                    MenorEdad = menor,
                    MayorEdad = mayor,
                    CantSocios = equipo.Value.Count
                });
            }
            equipos.Values.OrderByDescending(x => x.CantSocios);
            return equipos;
        }

        private Persona GenerarPersona(string[] values)
        {
            return new Persona
            {
                Name = values[0],
                Age = Convert.ToInt32(values[1]),
                Team = values[2]
            };
        }

        private double CalcularPromedioEdadRacing()
        {
            var prom = personas["Racing"].Average(x=> x.Age);
            return Convert.ToDouble(string.Format("{0:n2}", (Math.Truncate(prom * 100) / 100)));
        }

        private List<string> CalcularTopNombres()
        {
            List<string> nuevaLista = new List<string>();
            foreach (var item in personas)
            {
                if (item.Key == "River")
                    nuevaLista = (item.Value.Select(x=> x.Name).ToList());
            }
            return nuevaLista.OrderBy(x => x).Distinct().ToList().GetRange(0,5);
        }

        private void btnListados_Click_1(object sender, EventArgs e)
        {
            var frm = new frmListados(listaPunto3, nombresPunto4, equiposPunto5);
            frm.ShowDialog();
        }
    }
}

