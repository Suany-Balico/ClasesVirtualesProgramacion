using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesVirtualesProgramacion.Dialogs;

namespace ClasesVirtualesProgramacion.Dialogs
{
    public partial class GastosDialog : baseDialog
    {
        public GastosDialog()
        {
            InitializeComponent();
        }
        protected override bool ValidarEntrada()
        {
            erp.Clear();
            if (categoriaComboBox.SelectedIndex < 0 )
                return NotificacionDeValidacion("Por favor seleccione una de las opciones para la categoría", categoriaComboBox);

            if (subcategoriaComboBox.SelectedIndex < 0)
                return NotificacionDeValidacion("Por favor seleccione una de las opciones para la subcategoría", subcategoriaComboBox);

            if (descripcionTextBox.Text.Trim()==string.Empty)
                return NotificacionDeValidacion("Por favor llene la descripción del gasto", descripcionTextBox);

            if (formapagoComboBox.SelectedIndex < 0)
                return NotificacionDeValidacion("Por favor seleccionne una de las formas de pago, ya sea en efectivo, crédito o con tarjeta de crédito", formapagoComboBox);
            return true;
        }
    }
}
