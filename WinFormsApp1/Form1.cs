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
                tbMasege.Text += "����� �� �������!" + Environment.NewLine;
                return;
            }
            try
            {
                // �������� XML ���������
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(pathXML);

                // �������� XSD �����
                XmlSchemaSet schemaSet = new XmlSchemaSet();
                schemaSet.Add(null, pathXSD);

                // ��������� ����������� ������� ��� ������ ������ ���������
                ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationCallback);

                // �������� ������������ XML ��������� XSD �����
                xmlDoc.Schemas.Add(schemaSet);
                xmlDoc.Validate(eventHandler);

                ResultMasage("XML �������� ������������� XSD �����.");
            }
            catch (Exception ex)
            {
                ResultMasage(ex.Message);
            }
        }

        private void MasageResultOK(OpenFileDialog ofd)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
                tbMasege.Text += $"���� {ofd.SafeFileName} ������." + Environment.NewLine;
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
                throw new Exception($"������ ���������: {e.Message}");

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
