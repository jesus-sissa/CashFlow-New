
namespace CashFlow.Vista
{
    partial class frm_Server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Server));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.txt_conexion = new Bunifu.UI.WinForms.BunifuTextBox();
            this.SuspendLayout();
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.Btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Location = new System.Drawing.Point(28, 92);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(164, 47);
            this.Btn_Salir.TabIndex = 36;
            this.Btn_Salir.Tag = "";
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(160)))), ((int)(((byte)(98)))));
            this.btn_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(224, 92);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(164, 47);
            this.btn_Guardar.TabIndex = 35;
            this.btn_Guardar.Tag = "";
            this.btn_Guardar.Text = "&Guardar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // txt_conexion
            // 
            this.txt_conexion.AcceptsReturn = false;
            this.txt_conexion.AcceptsTab = false;
            this.txt_conexion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_conexion.AnimationSpeed = 200;
            this.txt_conexion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_conexion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_conexion.BackColor = System.Drawing.Color.Transparent;
            this.txt_conexion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_conexion.BackgroundImage")));
            this.txt_conexion.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_conexion.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_conexion.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_conexion.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_conexion.BorderRadius = 1;
            this.txt_conexion.BorderThickness = 1;
            this.txt_conexion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_conexion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_conexion.DefaultFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_conexion.DefaultText = "";
            this.txt_conexion.FillColor = System.Drawing.Color.White;
            this.txt_conexion.HideSelection = true;
            this.txt_conexion.IconLeft = null;
            this.txt_conexion.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_conexion.IconPadding = 10;
            this.txt_conexion.IconRight = null;
            this.txt_conexion.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_conexion.Lines = new string[0];
            this.txt_conexion.Location = new System.Drawing.Point(28, 24);
            this.txt_conexion.MaxLength = 32767;
            this.txt_conexion.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_conexion.Modified = false;
            this.txt_conexion.Multiline = false;
            this.txt_conexion.Name = "txt_conexion";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_conexion.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_conexion.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_conexion.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_conexion.OnIdleState = stateProperties4;
            this.txt_conexion.Padding = new System.Windows.Forms.Padding(3);
            this.txt_conexion.PasswordChar = '\0';
            this.txt_conexion.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_conexion.PlaceholderText = "Cadena de conexion";
            this.txt_conexion.ReadOnly = false;
            this.txt_conexion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_conexion.SelectedText = "";
            this.txt_conexion.SelectionLength = 0;
            this.txt_conexion.SelectionStart = 0;
            this.txt_conexion.ShortcutsEnabled = true;
            this.txt_conexion.Size = new System.Drawing.Size(741, 39);
            this.txt_conexion.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_conexion.TabIndex = 37;
            this.txt_conexion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_conexion.TextMarginBottom = 0;
            this.txt_conexion.TextMarginLeft = 3;
            this.txt_conexion.TextMarginTop = 0;
            this.txt_conexion.TextPlaceholder = "Cadena de conexion";
            this.txt_conexion.UseSystemPasswordChar = false;
            this.txt_conexion.WordWrap = true;
            // 
            // frm_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 169);
            this.ControlBox = false;
            this.Controls.Add(this.txt_conexion);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.btn_Guardar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sql Server";
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button Btn_Salir;
        internal System.Windows.Forms.Button btn_Guardar;
        private Bunifu.UI.WinForms.BunifuTextBox txt_conexion;
    }
}