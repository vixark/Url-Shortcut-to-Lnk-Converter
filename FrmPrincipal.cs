using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Url_Shortcut_to_Lnk_Converter {



    public partial class FrmPrincipal : Form {


        public FrmPrincipal() {
            InitializeComponent();
        } // FrmPrincipal>


        private void BtnConvertir_Click(object sender, EventArgs e) {

            var cuenta = 0;
            var accesosDirectosUrlConvertidos = new List<string>();
            var mostrarMensaje = true;

            foreach (var rutaArchivo in Directory.GetFiles(TxtDirectorioAccesosDirectos.Text)) {

                var extensión = Path.GetExtension(rutaArchivo);
                if (extensión == ".url") {

                    var rutaObjetivo = "";
                    var rutaÍconoOriginal = "";
                    var nombreSinExtensión = Path.GetFileNameWithoutExtension(rutaArchivo);
                    foreach (var línea in System.IO.File.ReadAllLines(rutaArchivo)) {

                        if (línea.StartsWith("URL=")) {
                            rutaObjetivo = línea.Replace("URL=", "");
                        } else if (línea.StartsWith("IconFile=")) {
                            rutaÍconoOriginal = línea.Replace("IconFile=", "");
                        }

                    }

                    if (!string.IsNullOrEmpty(rutaObjetivo)) {

                        var rutaÍcono = ChkUseCustomIcons.Checked ? Path.Combine(TxtDirectorioÍconos.Text, $"{nombreSinExtensión}.ico") : rutaÍconoOriginal;
                        var rutaLnk = Path.Combine(TxtDirectorioAccesosDirectos.Text, $"{nombreSinExtensión}.lnk");

                        if (System.IO.File.Exists(rutaÍcono)) {

                            if (System.IO.File.Exists(rutaLnk)) {

                                if (mostrarMensaje) {

                                    if (MessageBox.Show($"{rutaLnk} already exists. {rutaArchivo} wasn't converted.{Environment.NewLine}{Environment.NewLine}" +
                                        $"Do you want to be notified every time a Lnk file exists?", "Error", MessageBoxButtons.YesNo) == DialogResult.No) {
                                        mostrarMensaje = false;
                                    }

                                }

                            } else {

                                CrearLnk(rutaLnk, rutaÍcono, rutaObjetivo);
                                cuenta++;
                                accesosDirectosUrlConvertidos.Add(rutaArchivo);

                            }


                        } else {
                            MessageBox.Show($"{rutaÍcono} icon file doesn't exist.", "Error");
                        }

                    } else {
                        MessageBox.Show($"{rutaArchivo} file doesn't contain a valid target url.", "Error");
                    }

                }

            }

            if (MessageBox.Show($"{cuenta} Url Shorcut{(cuenta == 1 ? "" : "s")} converted to Lnk.{Environment.NewLine}{Environment.NewLine}" +
                $"Do you want to delete the converted Url Shortcut files?", "Success", MessageBoxButtons.YesNo) == DialogResult.Yes) {

                foreach (var rutaArchivo in accesosDirectosUrlConvertidos) {

                    try {
                        System.IO.File.Delete(rutaArchivo);
                    } catch (Exception) {
                        throw;
                    }

                }

            }

        } // BtnConvertir_Click>


        private void CrearLnk(string rutaLnk, string rutaÍcono, string rutaObjetivo) {

            var oShell = new IWshShell_Class();
            var cl = (WshShortcut)oShell.CreateShortcut(rutaLnk);
            cl.IconLocation = rutaÍcono;
            cl.TargetPath = rutaObjetivo;
            cl.Save();

        } // CrearLnk>


    } // FrmPrincipal>


} // Url_Shortcut_to_Lnk_Converter>