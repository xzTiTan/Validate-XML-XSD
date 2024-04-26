using System.Configuration;
using System.Diagnostics.Tracing;
using System.Xml.Schema;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Validate_XML_XSD
{
    public partial class Form1 : Form
    {
        String pathXML = "";
        String pathXSD = "";

        public Form1()
        {
            InitializeComponent();
            tbMasege.ScrollBars = ScrollBars.Both;
            tbMasege.SelectionStart = tbMasege.Text.Length;
        }

        private void btnOpenFileXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML Files (*.XML)|*.XML";
            MasageResultOK(ofd);
            pathXML = ofd.FileName;
        }
        private void btnOpenFileXSD_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XSD Files (*.XSD)|*.XSD";
            MasageResultOK(ofd);
            pathXSD = ofd.FileName;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (IsValidFiles() == false)
            {
                tbMasege.Text += "Файлы не выбраны!" + Environment.NewLine;
                return;
            }
            try
            {
                // Загрузка XML документа
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(pathXML);

                // Загрузка XSD схемы
                XmlSchemaSet schemaSet = new XmlSchemaSet();
                schemaSet.Add(null, pathXSD);

                // Установка обработчика событий для вывода ошибок валидации
                ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationCallback);

                // Проверка соответствия XML документа XSD схеме
                xmlDoc.Schemas.Add(schemaSet);
                xmlDoc.Validate(eventHandler);

                ResultMasage("XML документ соответствует XSD схеме.");
            }
            catch (Exception ex)
            {
                ResultMasage(ex.Message);
            }
        }

        private void MasageResultOK(OpenFileDialog ofd)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
                tbMasege.Text += $"Файл {ofd.SafeFileName} выбран." + Environment.NewLine;
        }
        private Boolean IsValidFiles()
        {
            if (pathXML == String.Empty || pathXSD == String.Empty)
                return false;
            return true;
        }
        private void ValidationCallback(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Error)
                throw new Exception($"Ошибка валидации: {e.Message}");

        }
        private void ResultMasage(String masage)
        {
            tbMasege.Text += masage + Environment.NewLine;
            MessageBox.Show(masage);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbMasege.Text = String.Empty;
            pathXSD = String.Empty;
            pathXML = String.Empty;
        }
    }
}
