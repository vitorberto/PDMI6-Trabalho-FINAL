using PDMTPFINAL.Model;
using PDMTPFINAL.View.Cell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDMTPFINAL.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Crud : ContentPage
    {
        public Crud()
        {
            InitializeComponent();
            Recarregar();
        }

        private void Recarregar()
        {
            Contexto contexto = new Contexto();
            Listagem.ItemTemplate = new DataTemplate(typeof(CellCLiente));
            Listagem.ItemsSource = contexto.conexao.Query<Mercadorias>("select * from Mercadorias").ToList();
            Listagem.RowHeight = 20;
        }

        private void Limpar()
        {
            txtID.Text = "0";
            txtNomeMercadoria.Text = null;
            txtPesoMercadoria.Text = null;
            txtNomeProdutor.Text = null;
            txtEmailProdutor.Text = null;
            txtNCM.Text = null;
        }

        private void btnAtualizar_Clicked(object sender, EventArgs e)
        {
            try
            {
                Contexto contexto = new Contexto();
                Mercadorias mercadoria = new Mercadorias();
                if (txtID.Text == "0")
                {
                    DisplayAlert("Erro", "Mercadoria não existente", "OK");
                    return;
                }


                mercadoria.ID = int.Parse(txtID.Text);
                mercadoria.NomeMercadoria = txtNomeMercadoria.Text;
                mercadoria.PesoMercadoria = txtPesoMercadoria.Text;
                mercadoria.NomeProdutor = txtNomeProdutor.Text;
                mercadoria.EmailProdutor = txtEmailProdutor.Text;
                mercadoria.NCM = txtNCM.Text;

                contexto.Update(mercadoria);
                DisplayAlert("Sucesso", "Mercadoria Atualizada com sucesso", "OK");
                Recarregar();
                Limpar();
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro", ex.Message, "OK");
                return;
            }
        }

        private void Listagem_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {

                var Mercadorias = (Mercadorias)e.SelectedItem;
                txtID.Text = Mercadorias.ID.ToString();
                txtNomeMercadoria.Text = Mercadorias.NomeMercadoria;
                txtPesoMercadoria.Text = Mercadorias.PesoMercadoria;
                txtNomeProdutor.Text = Mercadorias.NomeProdutor;
                txtEmailProdutor.Text = Mercadorias.EmailProdutor;
                txtNCM.Text = Mercadorias.NCM;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDeletar_Clicked(object sender, EventArgs e)
        {
            try
            {
                Contexto contexto = new Contexto();
                if (txtID.Text != "0")
                    contexto.conexao.Execute($"Delete from Mercadorias where ID ={txtID.Text}");
                else
                    DisplayAlert("Erro", "Selecione um mercadoria", "OK");
                Recarregar();
                Limpar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSalvar_Clicked(object sender, EventArgs e)
        {
            try
            {
                Contexto contexto = new Contexto();
                if (string.IsNullOrEmpty(txtNomeMercadoria.Text))
                {
                    DisplayAlert("Erro", "Informe o mercadoria", "OK");
                    return;
                }
                if (string.IsNullOrEmpty(txtPesoMercadoria.Text))
                {
                    DisplayAlert("Erro", "Informe o mercadoria", "OK");
                    return;
                }
                if (string.IsNullOrEmpty(txtNomeProdutor.Text))
                {
                    DisplayAlert("Erro", "Informe o mercadoria", "OK");
                    return;
                }
                if (string.IsNullOrEmpty(txtEmailProdutor.Text))
                {
                    DisplayAlert("Erro", "Informe o mercadoria", "OK");
                    return;
                }
                if (string.IsNullOrEmpty(txtNCM.Text))
                {
                    DisplayAlert("Erro", "Informe a mercadoria", "OK");
                    return;
                }
                Mercadorias mercadoria = new Mercadorias();

                mercadoria.NomeMercadoria = txtNomeMercadoria.Text;
                mercadoria.PesoMercadoria = txtPesoMercadoria.Text;
                mercadoria.NomeProdutor = txtNomeProdutor.Text;
                mercadoria.EmailProdutor = txtEmailProdutor.Text;
                mercadoria.NCM = txtNCM.Text;



                contexto.Insert(mercadoria);
                DisplayAlert("Sucesso", "Mercadoria inserido com sucesso", "OK");
                Recarregar();
                Limpar();
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro", ex.Message, "OK");
                return;
            }
        }

        private void btnLimpar_Clicked(object sender, EventArgs e)
        {
            try
            {
                Limpar();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}