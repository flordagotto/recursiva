using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursiva.Forms
{
    public partial class frmListados : Form
    {
        public IOrderedEnumerable<Persona> listaPunto3;
        public List<string> nombresPunto4;
        public Dictionary<string, Equipo> equiposPunto5;
        public frmListados(IOrderedEnumerable<Persona> lista3, List<string> nombres4, Dictionary<string, Equipo> equipos5)
        {
            InitializeComponent();
            listaPunto3 = lista3;
            nombresPunto4 = nombres4;
            equiposPunto5 = equipos5;
            dgv3.Rows.Clear();
            dgv4.Rows.Clear();
            dgv5.Rows.Clear();
            CargarLista3();
            CargarLista4();
            CargarLista5();
        }

        public void CargarLista3()
        {
            foreach (var item in listaPunto3)
            {
                dgv3.Rows.Add(item.Name, item.Age, item.Team);
            }
        }

        public void CargarLista4()
        {
            for (int i = 0; i < nombresPunto4.Count; i++)
            {
                dgv4.Rows.Add(nombresPunto4[i]);
            }
        }

        public void CargarLista5()
        {
            foreach (var item in equiposPunto5)
            {
                dgv5.Rows.Add(item.Value.Nombre, item.Value.CantSocios, item.Value.Promedio, item.Value.MenorEdad, item.Value.MayorEdad);
            }
        }
    }
}
