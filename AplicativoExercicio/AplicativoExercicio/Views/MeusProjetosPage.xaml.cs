using AplicativoExercicio.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace AplicativoExercicio.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MeusProjetosPage : ContentPage
    {
        private ObservableCollection<MeusProjetos> projetos = new ObservableCollection<MeusProjetos>();
        public MeusProjetosPage()
        {
            InitializeComponent();

            ListaInformacao.ItemsSource = projetos;

            projetos.Add(new MeusProjetos
            {
                Nome = "Desenvolvimento de Sistema e Aplicativo",
                Curso = "Informatica ",
                Docente = "Carlos e Wellington",
                Descricao = "Aprender a Desenvolver sistemas e aplicativos",
                Integrantes = "23"
            });
        }
    }
}