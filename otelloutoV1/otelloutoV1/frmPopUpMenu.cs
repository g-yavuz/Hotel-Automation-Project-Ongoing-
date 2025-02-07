using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otelloutoV1
{
    public partial class frmPopUpMenu : Form
    {
        public frmPopUpMenu()
        {
            InitializeComponent();
            //timer başlatma ve label'ın görünürlüğü
            timer1.Start();
            label1.Visible = false;
        }
        // anlık zaman burada tanımlanacaktır
        public int currentTime = 3;



        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {   // kapanması için kalan süre saniye saniye ekrana yazılacaktır
            if (currentTime >= 0)
            {

                label3.Text = $"Bu uyarı {currentTime} saniye sonra gidecektir";
                label1.Visible = true;
                currentTime -= 1;
            }
            //süre dolunca açık olan formu kapatma ve timer'ı durdurma
            else
            {
                timer1.Stop();
                this.Close();
            }
        }
        //Ekstra çıkış butonu
        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Cikis_MouseEnter(object sender, EventArgs e)
        {
            Btn_Cikis.BackColor = Color.Yellow;
        }

        private void Btn_Cikis_MouseLeave(object sender, EventArgs e)
        {
            Btn_Cikis.BackColor = Color.FromArgb(17, 55, 64);

        }
    }
}
