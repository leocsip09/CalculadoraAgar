using Microsoft.Maui.Controls;
using System;

namespace ejemplo2
{
    public partial class InformacionAgarPage : ContentPage
    {
        public InformacionAgarPage()
        {
            InitializeComponent();
        }

        private void MostrarInformacion(object sender, EventArgs e)
        {
            string tipoAgar = InfoTipoAgarPicker.SelectedItem.ToString();
            string descripcion = "";

            switch (tipoAgar)
            {
                case "agarNutritivo":
                    descripcion = "El agar nutritivo es un medio de cultivo que proporciona nutrientes para el crecimiento de una amplia variedad de microorganismos. Está compuesto por peptona, extracto de carne y otros nutrientes esenciales. Se utiliza para el crecimiento de microorganismos que requieren nutrientes básicos para su desarrollo. El agar nutritivo es un medio de cultivo que se utiliza comúnmente en laboratorios de microbiología para el crecimiento de microorganismos.";
                    break;
                case "agarSangre":
                    descripcion = "El agar sangre es un medio de cultivo que contiene sangre como fuente de nutrientes. Se utiliza para el crecimiento de microorganismos que requieren sangre para su desarrollo. El agar sangre es un medio de cultivo que se utiliza comúnmente en laboratorios de microbiología para el crecimiento de microorganismos que requieren sangre para su desarrollo.";
                    break;
                case "agarMacConkey":
                    descripcion = "El agar MacConkey es un medio de cultivo selectivo y diferencial que contiene lactosa, peptona y sales biliares. Se utiliza para el aislamiento de bacterias Gram negativas, especialmente Enterobacteriaceae. El agar MacConkey es un medio de cultivo que se utiliza comúnmente en laboratorios de microbiología para el aislamiento de bacterias Gram negativas.";
                    break;
                case "agarEMB":
                    descripcion = "El agar EMB es un medio de cultivo selectivo que combina las fórmulas de Holt-Harris y Teague con la de Levine. Contiene peptona, lactosa y otros nutrientes esenciales, y se utiliza para el aislamiento selectivo de bacilos Gram negativos de rápido desarrollo y escasas exigencias nutricionales. El agar EMB es un medio de cultivo que se utiliza comúnmente en laboratorios de microbiología para el aislamiento de bacilos Gram negativos.";
                    break;
                case "agarSS":
                    descripcion = "El agar SS es un medio de cultivo selectivo y diferencial que contiene peptona, lactosa, sales biliares y verde brillante. Se utiliza para el aislamiento de Salmonella spp. y algunas especies de Shigella spp. a partir de heces, alimentos y otros materiales en los que se sospeche su presencia. El agar SS es un medio de cultivo que se utiliza comúnmente en laboratorios de microbiología para el aislamiento de Salmonella spp. y Shigella spp.";
                    break;
                case "agarCetrimida":
                    descripcion = "El agar cetrimida es un medio de cultivo selectivo que contiene cetrimida, un compuesto que inhibe el crecimiento de bacterias Gram positivas y Gram negativas, excepto Pseudomonas aeruginosa. Se utiliza para el aislamiento de bacterias Gram negativas, especialmente Enterobacteriaceae. El agar cetrimida es un medio de cultivo que se utiliza comúnmente en laboratorios de microbiología para el aislamiento de bacterias Gram negativas.";
                    break;
                case "agarSabouraud":
                    descripcion = "El agar Sabouraud dextrosa es un medio de cultivo que contiene dextrosa como fuente de carbono y se utiliza para el crecimiento de hongos y levaduras. El agar Sabouraud dextrosa es un medio de cultivo que se utiliza comúnmente en laboratorios de microbiología para el crecimiento de hongos y levaduras.";
                    break;
                case "agarChocolate":
                    descripcion = "El agar chocolate es un medio de cultivo que contiene sangre y se utiliza para el crecimiento de microorganismos que requieren sangre para su desarrollo. El agar chocolate es un medio de cultivo que se utiliza comúnmente en laboratorios de microbiología para el crecimiento de microorganismos que requieren sangre para su desarrollo.";
                    break;
                case "agarEndo":
                    descripcion = "El agar Endo es un medio de cultivo selectivo que contiene lactosa, peptona y sales biliares. Se utiliza para el aislamiento de bacterias Gram negativas, especialmente Enterobacteriaceae. El agar Endo es un medio de cultivo que se utiliza comúnmente en laboratorios de microbiología para el aislamiento de bacterias Gram negativas.";
                    break;
                case "agarHektoen":
                    descripcion = "El agar Hektoen entérico es un medio de cultivo selectivo que contiene lactosa, peptona y sales biliares. Se utiliza para el aislamiento de bacterias Gram negativas, especialmente Enterobacteriaceae. El agar Hektoen entérico es un medio de cultivo que se utiliza comúnmente en laboratorios de microbiología para el aislamiento de bacterias Gram negativas.";
                    break;
                case "agarXLD":
                    descripcion = "El agar XLD es un medio de cultivo selectivo que contiene xilosa, lisina y desoxicolato. Se utiliza para el aislamiento de Salmonella spp. y algunas especies de Shigella spp. a partir de heces, alimentos y otros materiales en los que se sospeche su presencia. El agar XLD es un medio de cultivo que se utiliza comúnmente en laboratorios de microbiología para el aislamiento de Salmonella spp. y Shigella spp.";
                    break;
                case "agarBairdParker":
                    descripcion = "El agar Baird-Parker es un medio de cultivo selectivo que contiene peptona, lactosa y sales biliares. Se utiliza para el aislamiento de Staphylococcus aureus y otras bacterias Gram positivas. El agar Baird-Parker es un medio de cultivo que se utiliza comúnmente en laboratorios de microbiología para el aislamiento de Staphylococcus aureus y otras bacterias Gram positivas.";
                    break;
                case "agarManitol":
                    descripcion = "El agar manitol salado es un medio de cultivo selectivo que contiene manitol y sales biliares. Se utiliza para el aislamiento de Staphylococcus aureus y otras bacterias Gram positivas. El agar manitol salado es un medio de cultivo que se utiliza comúnmente en laboratorios de microbiología para el aislamiento de Staphylococcus aureus y otras bacterias Gram positivas.";
                    break;
                case "agarKligler":
                    descripcion = "El agar Kligler es un medio de cultivo selectivo que contiene lactosa, peptona y sales biliares. Se utiliza para el aislamiento de bacterias Gram negativas, especialmente Enterobacteriaceae. El agar Kligler es un medio de cultivo que se utiliza comúnmente en laboratorios de microbiología para el aislamiento de bacterias Gram negativas.";
                    break;
                case "agarCitrato":
                    descripcion = "El agar citrato de Simmons es un medio de cultivo selectivo que contiene citrato y sales biliares. Se utiliza para el aislamiento de bacterias Gram negativas, especialmente Enterobacteriaceae. El agar citrato de Simmons es un medio de cultivo que se utiliza comúnmente en laboratorios de microbiología para el aislamiento de bacterias Gram negativas.";
                    break;
                case "agarUrea":
                    descripcion = "El agar urea es un medio de cultivo selectivo que contiene urea y sales biliares. Se utiliza para el aislamiento de bacterias Gram negativas, especialmente Enterobacteriaceae. El agar urea es un medio de cultivo que se utiliza comúnmente en laboratorios de microbiología para el aislamiento de bacterias Gram negativas.";
                    break;
                case "agarLisina":
                    descripcion = "El agar lisina hierro es un medio de cultivo selectivo que contiene lisina y hierro. Se utiliza para el aislamiento de bacterias Gram negativas, especialmente Enterobacteriaceae. El agar lisina hierro es un medio de cultivo que se utiliza comúnmente en laboratorios de microbiología para el aislamiento de bacterias Gram negativas.";
                    break;
                case "agarTioglicolato":
                    descripcion = "El agar tioglicolato es un medio de cultivo selectivo que contiene tioglicolato y sales biliares. Se utiliza para el aislamiento de bacterias Gram negativas, especialmente Enterobacteriaceae. El agar tioglicolato es un medio de cultivo que se utiliza comúnmente en laboratorios de microbiología para el aislamiento de bacterias Gram negativas.";
                    break;
                case "agarMullerHinton":
                    descripcion = "El agar Müller-Hinton es un medio de cultivo selectivo que contiene peptona, lactosa y sales biliares. Se utiliza para el aislamiento de bacterias Gram negativas, especialmente Enterobacteriaceae. El agar Müller-Hinton es un medio de cultivo que se utiliza comúnmente en laboratorios de microbiología para el aislamiento de bacterias Gram negativas.";
                    break;
                    }

            DescripcionLabel.Text = descripcion;
        }

        private async void OnVolverInicioClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}