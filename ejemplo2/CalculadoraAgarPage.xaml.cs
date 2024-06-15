using Microsoft.Maui.Controls;
using System;

namespace ejemplo2
{
    public partial class CalculadoraAgarPage : ContentPage
    {
        public CalculadoraAgarPage()
        {
            InitializeComponent();
        }

        private void ShowAdditionalFields(object sender, EventArgs e)
        {
            string tipoAgar = TipoAgarPicker.SelectedItem?.ToString(); // Utilizamos ?. para evitar NRE
            SangreContainer.IsVisible = tipoAgar == "Agar Sangre" || tipoAgar == "Agar Chocolate";
            UreaContainer.IsVisible = tipoAgar == "Agar Urea";
        }

        private void CalcularDisolucion(object sender, EventArgs e)
        {
            try
            {
                string tipoAgar = TipoAgarPicker.SelectedItem?.ToString(); // Utilizamos ?. para evitar NRE
                if (string.IsNullOrEmpty(tipoAgar))
                {
                    MostrarMensajeError("Seleccione un tipo de agar.");
                    return;
                }

                double volumenAgua;
                if (!double.TryParse(VolumenAguaEntry.Text, out volumenAgua))
                {
                    MostrarMensajeError("Ingrese un volumen de agua válido.");
                    return;
                }

                double masaAgar = 0;

                switch (tipoAgar)
                {
                    case "Agar Nutritivo":
                    case "Agar MacConkey":
                    case "Agar Hektoen":
                    case "Agar Lisina Hierro":
                    case "Agar Kligler":
                        masaAgar = volumenAgua * 0.052;
                        break;
                    case "Agar Sangre":
                    case "Agar Chocolate":
                        double sangre;
                        if (!double.TryParse(SangreEntry.Text, out sangre))
                        {
                            MostrarMensajeError("Ingrese una cantidad de sangre válida.");
                            return;
                        }
                        masaAgar = volumenAgua * 0.052 + sangre;
                        break;
                    case "Agar Eosina Azul de Metileno (EMB)":
                    case "Agar Endo":
                        masaAgar = volumenAgua * 0.037;
                        break;
                    case "Agar Salmonella-Shigella (SS)":
                        masaAgar = volumenAgua * 0.059;
                        break;
                    case "Agar Cetrimida":
                        masaAgar = volumenAgua * 0.045;
                        break;
                    case "Agar Sabouraud Dextrosa":
                        masaAgar = volumenAgua * 0.065;
                        break;
                    case "Agar Xilosa Lisina Desoxicolato (XLD)":
                        masaAgar = volumenAgua * 0.055;
                        break;
                    case "Agar Baird-Parker":
                        masaAgar = volumenAgua * 0.063;
                        break;
                    case "Agar Manitol Salado":
                        masaAgar = volumenAgua * 0.111;
                        break;
                    case "Agar Citrato de Simmons":
                        masaAgar = volumenAgua * 0.024;
                        break;
                    case "Agar Urea":
                        double urea;
                        if (!double.TryParse(UreaEntry.Text, out urea))
                        {
                            MostrarMensajeError("Ingrese una cantidad de urea válida.");
                            return;
                        }
                        masaAgar = volumenAgua * 0.021 + urea;
                        break;
                    case "Agar Tioglicolato":
                        masaAgar = volumenAgua * 0.029;
                        break;
                    case "Agar Müller-Hinton":
                        masaAgar = volumenAgua * 0.038;
                        break;
                    default:
                        MostrarMensajeError("Tipo de agar no reconocido.");
                        return;
                }

                ResultadoLabel.Text = $"Tipo de agar: {tipoAgar}\nVolumen de agua: {volumenAgua} ml\nMasa de agar: {masaAgar} g";
                ResultadoContainer.IsVisible = true;
            }
            catch (Exception ex)
            {
                MostrarMensajeError($"Error inesperado: {ex.Message}");
            }
        }

        private async void OnVolverInicioClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void MostrarMensajeError(string mensaje)
        {
            Console.WriteLine($"Error: {mensaje}");
        }
    }
}
