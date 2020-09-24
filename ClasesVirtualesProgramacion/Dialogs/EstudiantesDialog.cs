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
    public partial class EstudiantesDialog : baseDialog
    {
        public EstudiantesDialog()
        {
            InitializeComponent();
        }

        protected override bool ValidarEntrada()
        {
            erp.Clear();
            if (identidadTextBox.Text.Trim() == string.Empty)
                return NotificacionDeValidacion("Por favor escriba el número de identidad del estudiante", identidadTextBox);
            if (sexoComboBox.SelectedIndex < 0)
                return NotificacionDeValidacion("Por favor seleccione Femenino o Masculino para el sexo del estudiante", sexoComboBox);

            if (nombresTextBox.Text.Trim() == string.Empty)
                return NotificacionDeValidacion("Por favor escriba los nombres completos del estudiante", nombresTextBox);

            if(apellidosTextBox.Text.Trim()== string.Empty)
                return NotificacionDeValidacion("Por favor escriba los apellidos completos del estudiante", apellidosTextBox);

            if (direccionTextBox.Text.Trim() == string.Empty)
                return NotificacionDeValidacion("Por favor escriba los apellidos completos del estudiante", direccionTextBox);
            return true;
        }
    }
}
