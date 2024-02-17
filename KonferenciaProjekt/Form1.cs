using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KonferenciaProjekt
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        List<Eloadas> konferencia = new List<Eloadas>();
        Konferencia db = new Konferencia();
        int konferenciaIndex = 0;
        int ertekelesKepmeret = 40;
        private object kep;



        private void Form1_Load(object sender, EventArgs e)
        {
            konferencia = db.adatokBetoltese();

            konferenciaAdatai();
        }

        private void konferenciaAdatai()
        {
            panelErtekeles.Controls.Clear();        // a panel ürítése, törlése

            // a költők képének betöltése a cím mező használatával, amiből le kell vágni csak az első szót 
            //pl: Babits Mihály gondolati lírája (Tóth Miklós)  --> ebből csak ez lesz: Babits   és ezt a jpg fájl felhaszálni a kép és a költő helyes megjelenítésére
            this.Text = $"{konferencia[konferenciaIndex].Cim}";
            foreach (string kepNeve in Directory.GetFiles("Kepek"))
                if (konferencia[konferenciaIndex].Cim.ToLower().Contains(kepNeve.ToLower().Split('.')[0].Split('\\')[1]))
                pictureBoxKolto.Image = Image.FromFile(kepNeve);
        }

        // KÖRKÖRÖS LAPOZHATÓSÁG KELL //

        //JOBB NYIL eltűnik ha végére értünk
        private void buttonJobbNyil_Click(object sender, EventArgs e)
        {
            if ( konferenciaIndex < konferencia.Count -1 )
            {
                konferenciaIndex++;
            }
            konferenciaAdatai();
        }

        //BAL NYIL eltűnik ha végére értünk
        private void buttonBalNyil_Click(object sender, EventArgs e)
        {
            if(konferenciaIndex != 0)
            {
                konferenciaIndex--;
            }
            konferenciaAdatai();
        }

    }
}
