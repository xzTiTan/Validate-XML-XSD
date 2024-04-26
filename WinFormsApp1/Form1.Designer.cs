namespace Validate_XML_XSD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnOpenFileXML = new Button();
            btnOpenFileXSD = new Button();
            btnValidate = new Button();
            tbMasege = new TextBox();
            btnClear = new Button();
            SuspendLayout();
            // 
            // btnOpenFileXML
            // 
            btnOpenFileXML.ImeMode = ImeMode.NoControl;
            btnOpenFileXML.Location = new Point(12, 12);
            btnOpenFileXML.Name = "btnOpenFileXML";
            btnOpenFileXML.Size = new Size(187, 37);
            btnOpenFileXML.TabIndex = 0;
            btnOpenFileXML.Text = "Open File XML";
            btnOpenFileXML.UseVisualStyleBackColor = true;
            btnOpenFileXML.Click += btnOpenFileXML_Click;
            // 
            // btnOpenFileXSD
            // 
            btnOpenFileXSD.ImeMode = ImeMode.NoControl;
            btnOpenFileXSD.Location = new Point(281, 12);
            btnOpenFileXSD.Name = "btnOpenFileXSD";
            btnOpenFileXSD.Size = new Size(187, 37);
            btnOpenFileXSD.TabIndex = 1;
            btnOpenFileXSD.Text = "Open File XSD";
            btnOpenFileXSD.UseVisualStyleBackColor = true;
            btnOpenFileXSD.Click += btnOpenFileXSD_Click;
            // 
            // btnValidate
            // 
            btnValidate.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnValidate.ImeMode = ImeMode.NoControl;
            btnValidate.Location = new Point(12, 220);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(456, 37);
            btnValidate.TabIndex = 2;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // tbMasege
            // 
            tbMasege.BackColor = SystemColors.InactiveCaption;
            tbMasege.ForeColor = Color.Black;
            tbMasege.Location = new Point(12, 55);
            tbMasege.Margin = new Padding(4);
            tbMasege.Multiline = true;
            tbMasege.Name = "tbMasege";
            tbMasege.Size = new Size(456, 150);
            tbMasege.TabIndex = 3;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Control;
            btnClear.BackgroundImage = (Image)resources.GetObject("btnClear.BackgroundImage");
            btnClear.BackgroundImageLayout = ImageLayout.Zoom;
            btnClear.Location = new Point(228, 12);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(30, 30);
            btnClear.TabIndex = 4;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 269);
            Controls.Add(btnClear);
            Controls.Add(tbMasege);
            Controls.Add(btnValidate);
            Controls.Add(btnOpenFileXSD);
            Controls.Add(btnOpenFileXML);
            Name = "Form1";
            Text = "Соответствие XML - XSD (xzTiTan)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnOpenFileXML;
        private Button btnOpenFileXSD;
        private Button btnValidate;
        private TextBox tbMasege;
        private Button btnClear;
    }
}
