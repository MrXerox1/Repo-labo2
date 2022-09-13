using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contador
{
    public partial class Contador : Form
    {
        private Dictionary<string, int> diccionario;
        private List<int> listaPalabras;

        public Contador()
        {
            InitializeComponent();
            diccionario = new Dictionary<string, int>();
            listaPalabras = new List<int>();
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
        }
    }
}

    


