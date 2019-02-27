using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Maravilhoso
{
    public partial class MainPage : ContentPage
    {
        int cont = 1;
        public MainPage()
        {
            InitializeComponent();
        }

        void ClicadaDoBotao(Object sender, EventArgs e){

            label_status.Text = "Voce clicou " + cont + " Vezes";

            button_clique.Text = "Novo Botao";

            cont++;
        }
    }
}
