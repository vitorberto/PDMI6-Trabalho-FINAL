using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PDMTPFINAL.View.Cell
{
    public class CellCLiente : ViewCell
    {
        public CellCLiente()
        {
            var NomeMercadoria = new Label
            {
                FontSize = 15,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            NomeMercadoria.SetBinding(Label.TextProperty, new Binding("NomeMercadoria"));

            var PesoMercadoria = new Label
            {
                FontSize = 15,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            PesoMercadoria.SetBinding(Label.TextProperty, new Binding("PesoMercadoria"));

            var NomeProdutor = new Label
            {
                FontSize = 15,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            NomeProdutor.SetBinding(Label.TextProperty, new Binding("NomeProdutor"));

            var EmailProdutor = new Label
            {
                FontSize = 15,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            EmailProdutor.SetBinding(Label.TextProperty, new Binding("EmailProdutor"));

            var NCM = new Label
            {
                FontSize = 15,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            NCM.SetBinding(Label.TextProperty, new Binding("NCM"));



            var linha1 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { NomeMercadoria, PesoMercadoria, NomeProdutor, EmailProdutor, NCM }
            };

            View = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { linha1 }
            };

        }
    }
}
