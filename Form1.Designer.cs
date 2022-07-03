namespace InterfacesYClasesAbstractas
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.listView = new System.Windows.Forms.ListView();
            this.chNombre = new System.Windows.Forms.ColumnHeader();
            this.chPrApellido = new System.Windows.Forms.ColumnHeader();
            this.chSgApellido = new System.Windows.Forms.ColumnHeader();
            this.chSueldoBase = new System.Windows.Forms.ColumnHeader();
            this.chDNI = new System.Windows.Forms.ColumnHeader();
            this.chTipoEmpleado = new System.Windows.Forms.ColumnHeader();
            this.chDestino = new System.Windows.Forms.ColumnHeader();
            this.chHorasExtra = new System.Windows.Forms.ColumnHeader();
            this.chPrecioHE = new System.Windows.Forms.ColumnHeader();
            this.chCarrera = new System.Windows.Forms.ColumnHeader();
            this.chCurso = new System.Windows.Forms.ColumnHeader();
            this.chTitulacion = new System.Windows.Forms.ColumnHeader();
            this.chDepartamento = new System.Windows.Forms.ColumnHeader();
            this.chCargo = new System.Windows.Forms.ColumnHeader();
            this.chProyectos = new System.Windows.Forms.ColumnHeader();
            this.chPlus = new System.Windows.Forms.ColumnHeader();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrApellido = new System.Windows.Forms.Label();
            this.lblSgApellido = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblSueldoBase = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxSueldoBase = new System.Windows.Forms.TextBox();
            this.textBoxSgApellido = new System.Windows.Forms.TextBox();
            this.textBoxPrApellido = new System.Windows.Forms.TextBox();
            this.maskedTextBoxDNI = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxObreros = new System.Windows.Forms.CheckBox();
            this.checkBoxBecarios = new System.Windows.Forms.CheckBox();
            this.checkBoxJefeDepartamento = new System.Windows.Forms.CheckBox();
            this.checkBoxCualificados = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btAñadir = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.buttonInformacion = new System.Windows.Forms.Button();
            this.btUniversidad = new System.Windows.Forms.Button();
            this.btNotaMedia = new System.Windows.Forms.Button();
            this.btExamenes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNombre,
            this.chPrApellido,
            this.chSgApellido,
            this.chSueldoBase,
            this.chDNI,
            this.chTipoEmpleado,
            this.chDestino,
            this.chHorasExtra,
            this.chPrecioHE,
            this.chCarrera,
            this.chCurso,
            this.chTitulacion,
            this.chDepartamento,
            this.chCargo,
            this.chProyectos,
            this.chPlus});
            this.listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView.Location = new System.Drawing.Point(12, 330);
            this.listView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1158, 281);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            this.chNombre.Width = 70;
            // 
            // chPrApellido
            // 
            this.chPrApellido.Text = "1r Apellido";
            this.chPrApellido.Width = 90;
            // 
            // chSgApellido
            // 
            this.chSgApellido.Text = "2o Apellido";
            this.chSgApellido.Width = 90;
            // 
            // chSueldoBase
            // 
            this.chSueldoBase.Text = "Sueldo";
            // 
            // chDNI
            // 
            this.chDNI.Text = "DNI";
            this.chDNI.Width = 45;
            // 
            // chTipoEmpleado
            // 
            this.chTipoEmpleado.Text = "Tipo";
            this.chTipoEmpleado.Width = 65;
            // 
            // chDestino
            // 
            this.chDestino.Text = "Destino";
            this.chDestino.Width = 70;
            // 
            // chHorasExtra
            // 
            this.chHorasExtra.Text = "Horas Extra";
            this.chHorasExtra.Width = 90;
            // 
            // chPrecioHE
            // 
            this.chPrecioHE.Text = "Precio";
            // 
            // chCarrera
            // 
            this.chCarrera.Text = "Carrera";
            this.chCarrera.Width = 70;
            // 
            // chCurso
            // 
            this.chCurso.Text = "Curso";
            this.chCurso.Width = 50;
            // 
            // chTitulacion
            // 
            this.chTitulacion.Text = "Titulación";
            this.chTitulacion.Width = 80;
            // 
            // chDepartamento
            // 
            this.chDepartamento.Text = "Departamento";
            this.chDepartamento.Width = 110;
            // 
            // chCargo
            // 
            this.chCargo.Text = "A cargo";
            this.chCargo.Width = 70;
            // 
            // chProyectos
            // 
            this.chProyectos.Text = "Proyectos";
            this.chProyectos.Width = 80;
            // 
            // chPlus
            // 
            this.chPlus.Text = "Plus";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(12, 284);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(193, 28);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Lista de Empleados";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(50, 10);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 28);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblPrApellido
            // 
            this.lblPrApellido.AutoSize = true;
            this.lblPrApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrApellido.Location = new System.Drawing.Point(400, 10);
            this.lblPrApellido.Name = "lblPrApellido";
            this.lblPrApellido.Size = new System.Drawing.Size(171, 28);
            this.lblPrApellido.TabIndex = 3;
            this.lblPrApellido.Text = "Primer Apellido: ";
            // 
            // lblSgApellido
            // 
            this.lblSgApellido.AutoSize = true;
            this.lblSgApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSgApellido.Location = new System.Drawing.Point(800, 10);
            this.lblSgApellido.Name = "lblSgApellido";
            this.lblSgApellido.Size = new System.Drawing.Size(190, 28);
            this.lblSgApellido.TabIndex = 4;
            this.lblSgApellido.Text = "Segundo Apellido: ";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDNI.Location = new System.Drawing.Point(240, 60);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(60, 28);
            this.lblDNI.TabIndex = 5;
            this.lblDNI.Text = "DNI: ";
            // 
            // lblSueldoBase
            // 
            this.lblSueldoBase.AutoSize = true;
            this.lblSueldoBase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSueldoBase.Location = new System.Drawing.Point(550, 60);
            this.lblSueldoBase.Name = "lblSueldoBase";
            this.lblSueldoBase.Size = new System.Drawing.Size(137, 28);
            this.lblSueldoBase.TabIndex = 6;
            this.lblSueldoBase.Text = "Sueldo Base: ";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(150, 10);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(150, 27);
            this.textBoxNombre.TabIndex = 7;
            // 
            // textBoxSueldoBase
            // 
            this.textBoxSueldoBase.Location = new System.Drawing.Point(700, 60);
            this.textBoxSueldoBase.Name = "textBoxSueldoBase";
            this.textBoxSueldoBase.Size = new System.Drawing.Size(150, 27);
            this.textBoxSueldoBase.TabIndex = 9;
            // 
            // textBoxSgApellido
            // 
            this.textBoxSgApellido.Location = new System.Drawing.Point(1000, 10);
            this.textBoxSgApellido.Name = "textBoxSgApellido";
            this.textBoxSgApellido.Size = new System.Drawing.Size(150, 27);
            this.textBoxSgApellido.TabIndex = 10;
            // 
            // textBoxPrApellido
            // 
            this.textBoxPrApellido.Location = new System.Drawing.Point(575, 10);
            this.textBoxPrApellido.Name = "textBoxPrApellido";
            this.textBoxPrApellido.Size = new System.Drawing.Size(150, 27);
            this.textBoxPrApellido.TabIndex = 11;
            // 
            // maskedTextBoxDNI
            // 
            this.maskedTextBoxDNI.Location = new System.Drawing.Point(300, 60);
            this.maskedTextBoxDNI.Mask = "00000000-&";
            this.maskedTextBoxDNI.Name = "maskedTextBoxDNI";
            this.maskedTextBoxDNI.Size = new System.Drawing.Size(150, 27);
            this.maskedTextBoxDNI.TabIndex = 12;
            // 
            // checkBoxObreros
            // 
            this.checkBoxObreros.AutoSize = true;
            this.checkBoxObreros.Location = new System.Drawing.Point(150, 110);
            this.checkBoxObreros.Name = "checkBoxObreros";
            this.checkBoxObreros.Size = new System.Drawing.Size(84, 24);
            this.checkBoxObreros.TabIndex = 13;
            this.checkBoxObreros.Text = "Obreros";
            this.checkBoxObreros.UseVisualStyleBackColor = true;
            this.checkBoxObreros.CheckedChanged += new System.EventHandler(this.checkBoxObreros_CheckedChanged);
            // 
            // checkBoxBecarios
            // 
            this.checkBoxBecarios.AutoSize = true;
            this.checkBoxBecarios.Location = new System.Drawing.Point(400, 110);
            this.checkBoxBecarios.Name = "checkBoxBecarios";
            this.checkBoxBecarios.Size = new System.Drawing.Size(87, 24);
            this.checkBoxBecarios.TabIndex = 14;
            this.checkBoxBecarios.Text = "Becarios";
            this.checkBoxBecarios.UseVisualStyleBackColor = true;
            this.checkBoxBecarios.CheckedChanged += new System.EventHandler(this.checkBoxBecarios_CheckedChanged);
            // 
            // checkBoxJefeDepartamento
            // 
            this.checkBoxJefeDepartamento.AutoSize = true;
            this.checkBoxJefeDepartamento.Location = new System.Drawing.Point(900, 110);
            this.checkBoxJefeDepartamento.Name = "checkBoxJefeDepartamento";
            this.checkBoxJefeDepartamento.Size = new System.Drawing.Size(179, 24);
            this.checkBoxJefeDepartamento.TabIndex = 16;
            this.checkBoxJefeDepartamento.Text = "Jefe de Departamento";
            this.checkBoxJefeDepartamento.UseVisualStyleBackColor = true;
            this.checkBoxJefeDepartamento.Visible = false;
            this.checkBoxJefeDepartamento.CheckedChanged += new System.EventHandler(this.checkBoxJefeDepartamento_CheckedChanged);
            // 
            // checkBoxCualificados
            // 
            this.checkBoxCualificados.AutoSize = true;
            this.checkBoxCualificados.Location = new System.Drawing.Point(700, 110);
            this.checkBoxCualificados.Name = "checkBoxCualificados";
            this.checkBoxCualificados.Size = new System.Drawing.Size(112, 24);
            this.checkBoxCualificados.TabIndex = 15;
            this.checkBoxCualificados.Text = "Cualificados";
            this.checkBoxCualificados.UseVisualStyleBackColor = true;
            this.checkBoxCualificados.CheckedChanged += new System.EventHandler(this.checkBoxCualificados_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(700, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 27);
            this.textBox2.TabIndex = 22;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(700, 225);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 27);
            this.textBox3.TabIndex = 21;
            this.textBox3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(700, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 27);
            this.textBox1.TabIndex = 20;
            this.textBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(400, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Segundo Apellido: ";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(400, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Primer Apellido: ";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(400, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre: ";
            this.label1.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1200, 145);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 27);
            this.textBox4.TabIndex = 28;
            this.textBox4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1200, 185);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(150, 27);
            this.textBox5.TabIndex = 27;
            this.textBox5.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1200, 225);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 27);
            this.textBox6.TabIndex = 26;
            this.textBox6.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(950, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "Segundo Apellido: ";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(950, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 28);
            this.label5.TabIndex = 24;
            this.label5.Text = "Primer Apellido: ";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(950, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "Nombre: ";
            this.label6.Visible = false;
            // 
            // btAñadir
            // 
            this.btAñadir.Location = new System.Drawing.Point(350, 280);
            this.btAñadir.Name = "btAñadir";
            this.btAñadir.Size = new System.Drawing.Size(94, 29);
            this.btAñadir.TabIndex = 29;
            this.btAñadir.Text = "Añadir";
            this.btAñadir.UseVisualStyleBackColor = true;
            this.btAñadir.Click += new System.EventHandler(this.btAñadir_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(750, 280);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(94, 29);
            this.btBorrar.TabIndex = 30;
            this.btBorrar.Text = "Eliminar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(550, 280);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(94, 29);
            this.btModificar.TabIndex = 31;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // buttonInformacion
            // 
            this.buttonInformacion.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonInformacion.Location = new System.Drawing.Point(950, 263);
            this.buttonInformacion.Name = "buttonInformacion";
            this.buttonInformacion.Size = new System.Drawing.Size(220, 60);
            this.buttonInformacion.TabIndex = 32;
            this.buttonInformacion.Text = "Información";
            this.buttonInformacion.UseVisualStyleBackColor = true;
            this.buttonInformacion.Click += new System.EventHandler(this.buttonInformacion_Click);
            // 
            // btUniversidad
            // 
            this.btUniversidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btUniversidad.Location = new System.Drawing.Point(550, 615);
            this.btUniversidad.Name = "btUniversidad";
            this.btUniversidad.Size = new System.Drawing.Size(100, 29);
            this.btUniversidad.TabIndex = 35;
            this.btUniversidad.Text = "Universidad";
            this.btUniversidad.UseVisualStyleBackColor = true;
            this.btUniversidad.Click += new System.EventHandler(this.btUniversidad_Click);
            // 
            // btNotaMedia
            // 
            this.btNotaMedia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btNotaMedia.Location = new System.Drawing.Point(700, 615);
            this.btNotaMedia.Name = "btNotaMedia";
            this.btNotaMedia.Size = new System.Drawing.Size(100, 29);
            this.btNotaMedia.TabIndex = 34;
            this.btNotaMedia.Text = "Nota Media";
            this.btNotaMedia.UseVisualStyleBackColor = true;
            this.btNotaMedia.Click += new System.EventHandler(this.btNotaMedia_Click);
            // 
            // btExamenes
            // 
            this.btExamenes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btExamenes.Location = new System.Drawing.Point(400, 615);
            this.btExamenes.Name = "btExamenes";
            this.btExamenes.Size = new System.Drawing.Size(94, 29);
            this.btExamenes.TabIndex = 33;
            this.btExamenes.Text = "Exámenes";
            this.btExamenes.UseVisualStyleBackColor = true;
            this.btExamenes.Click += new System.EventHandler(this.btExamenes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.btUniversidad);
            this.Controls.Add(this.btNotaMedia);
            this.Controls.Add(this.btExamenes);
            this.Controls.Add(this.buttonInformacion);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btAñadir);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxJefeDepartamento);
            this.Controls.Add(this.checkBoxCualificados);
            this.Controls.Add(this.checkBoxBecarios);
            this.Controls.Add(this.checkBoxObreros);
            this.Controls.Add(this.maskedTextBoxDNI);
            this.Controls.Add(this.textBoxPrApellido);
            this.Controls.Add(this.textBoxSgApellido);
            this.Controls.Add(this.textBoxSueldoBase);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.lblSueldoBase);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblSgApellido);
            this.Controls.Add(this.lblPrApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.listView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Gestión de Estudiantes - Empleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView;
        private ColumnHeader chNombre;
        private ColumnHeader chPrApellido;
        private ColumnHeader chSgApellido;
        private ColumnHeader chSueldoBase;
        private Label lblTitulo;
        private ColumnHeader chDNI;
        private ColumnHeader chTipoEmpleado;
        private ColumnHeader chCarrera;
        private ColumnHeader chCurso;
        private Label lblNombre;
        private Label lblPrApellido;
        private Label lblSgApellido;
        private Label lblDNI;
        private Label lblSueldoBase;
        private TextBox textBoxNombre;
        private TextBox textBoxSueldoBase;
        private TextBox textBoxSgApellido;
        private TextBox textBoxPrApellido;
        private MaskedTextBox maskedTextBoxDNI;
        private CheckBox checkBoxObreros;
        private CheckBox checkBoxBecarios;
        private CheckBox checkBoxJefeDepartamento;
        private CheckBox checkBoxCualificados;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label4;
        private Label label5;
        private Label label6;
        private ColumnHeader chTitulacion;
        private ColumnHeader chPlus;
        private ColumnHeader chDepartamento;
        private ColumnHeader chCargo;
        private ColumnHeader chProyectos;
        private Button btAñadir;
        private Button btBorrar;
        private Button btModificar;
        private Button buttonInformacion;
        private ColumnHeader chDestino;
        private ColumnHeader chHorasExtra;
        private ColumnHeader chPrecioHE;
        private Button btUniversidad;
        private Button btNotaMedia;
        private Button btExamenes;
    }
}