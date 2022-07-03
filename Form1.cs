namespace InterfacesYClasesAbstractas
{
    public partial class Form1 : Form
    {
        private string nombre = "", apellido1 = "", apellido2 = "", dni = "", destino = "", carrera = "",
                        curso = "", departamento = "", titulacion = "";
        private double sueldo = 0.0, precio = 0.0, plus = 0.0, media;
        private int horas = 0, trabajos = 0, proyectos = 0, nota1, nota2, nota3;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            listView.Items.Clear();
        }

        private void checkBoxObreros_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxObreros.Checked)
            {
                activaObrero();
            }
        }

        private void checkBoxBecarios_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBecarios.Checked)
            {
                activaBecario();
            }
        }

        private void checkBoxCualificados_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCualificados.Checked)
            {
                activaCualificado();
            }
        }

        private void checkBoxJefeDepartamento_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxJefeDepartamento.Checked)
            {
                activaJefeDepartamento();
            }
        }

        private void activaObrero()
        {
            desactivaJefeDepartamento();
            checkBoxCualificados.Checked = false;
            checkBoxBecarios.Checked = false;
            label1.Text = "Destino de trabajo: ";
            label2.Text = "Horas extra: ";
            label3.Text = "Precio Hora Extra: ";
            label1.Visible = true; label2.Visible = true; label3.Visible = true;
            textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true;
        }

        private void activaBecario()
        {
            desactivaJefeDepartamento();
            checkBoxCualificados.Checked = false;
            checkBoxObreros.Checked = false;
            label1.Text = "Carrera: ";
            label2.Text = "Curso: ";
            label3.Text = "Departamento: ";
            label1.Visible = true; label2.Visible = true; label3.Visible = true;
            textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true;
        }

        private void activaCualificado()
        {
            desactivaJefeDepartamento();
            checkBoxObreros.Checked = false;
            checkBoxBecarios.Checked = false;
            checkBoxJefeDepartamento.Visible = true;
            label1.Text = "Titulación: ";
            label2.Text = "Plus: ";
            label3.Text = "Departamento: ";
            label1.Visible = true; label2.Visible = true; label3.Visible = true;
            textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true;
        }

        private void activaJefeDepartamento()
        {
            checkBoxObreros.Checked = false;
            checkBoxBecarios.Checked = false;
            checkBoxCualificados.Checked = false;
            label1.Text = "Titulación:";
            label2.Text = "Plus:";
            label3.Text = "Departamento:";
            label4.Text = "Total trabajo a cargo:";
            label5.Text = "Proyectos:";
            label6.Text = "Plus:";

            label1.Location = new System.Drawing.Point(150, 145);
            label2.Location = new System.Drawing.Point(150, 185);
            label3.Location = new System.Drawing.Point(150, 225);
            label4.Location = new System.Drawing.Point(700, 145);
            label5.Location = new System.Drawing.Point(700, 185);
            label6.Location = new System.Drawing.Point(700, 225);

            textBox1.Location = new System.Drawing.Point(400, 145);
            textBox2.Location = new System.Drawing.Point(400, 185);
            textBox3.Location = new System.Drawing.Point(400, 225);
            textBox4.Location = new System.Drawing.Point(900, 145);
            textBox5.Location = new System.Drawing.Point(900, 185);
            textBox6.Location = new System.Drawing.Point(900, 225);

            label2.Text = ""; textBox2.Enabled = false;

            label1.Visible = true; label2.Visible = true; label3.Visible = true;
            label4.Visible = true; label5.Visible = true; label6.Visible = true;
            textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true;
            textBox4.Visible = true; textBox5.Visible = true; textBox6.Visible = true;
        }

        private void desactivaJefeDepartamento()
        {
            if (label4.Visible)
            {
                checkBoxJefeDepartamento.Checked = false;
                checkBoxJefeDepartamento.Visible = false;

                label1.Location = new System.Drawing.Point(400, 145);
                label2.Location = new System.Drawing.Point(400, 185);
                label3.Location = new System.Drawing.Point(400, 225);

                textBox1.Location = new System.Drawing.Point(700, 145);
                textBox2.Location = new System.Drawing.Point(700, 185);
                textBox3.Location = new System.Drawing.Point(700, 225);

                textBox2.Enabled = true;

                label1.Visible = true; label2.Visible = true; label3.Visible = true;
                label4.Visible = false; label5.Visible = false; label6.Visible = false;
                textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true;
                textBox4.Visible = false; textBox5.Visible = false; textBox6.Visible = false;
            }
            else { }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            actualizarEmpleado();
        }

        private void actualizarEmpleado()
        {
            int index;
            //listView.SelectedItems[index].SubItems[index].Text;
            ListView.SelectedListViewItemCollection selectedList = listView.SelectedItems;
            foreach (ListViewItem item in selectedList)
            {
                index = listView.SelectedItems.IndexOf(item);
                listView.Items[index].SubItems[0].Text = textBoxNombre.Text;
                listView.Items[index].SubItems[1].Text = textBoxPrApellido.Text;
                listView.Items[index].SubItems[2].Text = textBoxSgApellido.Text;
                listView.Items[index].SubItems[3].Text = textBoxSueldoBase.Text;
                listView.Items[index].SubItems[4].Text = maskedTextBoxDNI.Text;
                if (checkBoxObreros.Checked)
                {
                    Obreros obrero = new Obreros(nombre, apellido1, apellido2, sueldo, dni, destino, horas, precio);
                    ListViewItem itemObrero = new ListViewItem(obrero.Nombre);
                    itemObrero.SubItems.Add(obrero.PrApellido);
                    itemObrero.SubItems.Add(obrero.SgApellido);
                    itemObrero.SubItems.Add(obrero.SueldoBase.ToString());
                    itemObrero.SubItems.Add(obrero.Dni.ToString());
                    itemObrero.SubItems.Add("Obrero");
                    itemObrero.SubItems.Add(obrero.DestinoTrabajo);
                    itemObrero.SubItems.Add(obrero.HorasExtra.ToString());
                    itemObrero.SubItems.Add(obrero.PrecioHE.ToString());
                    itemObrero.SubItems.Add("");
                    itemObrero.SubItems.Add("");
                    itemObrero.SubItems.Add("");
                    itemObrero.SubItems.Add("");
                    itemObrero.SubItems.Add("");
                    itemObrero.SubItems.Add("");
                    itemObrero.SubItems.Add("");
                    listView.Items.Remove(item);
                    listView.Items.Insert(index, itemObrero);
                }
                else if (checkBoxBecarios.Checked)
                {
                    Becarios becario = new Becarios(nombre, apellido1, apellido2, sueldo, dni, carrera, curso, departamento);
                    ListViewItem itemBecario = new ListViewItem(becario.Nombre);
                    itemBecario.SubItems.Add(becario.PrApellido);
                    itemBecario.SubItems.Add(becario.SgApellido);
                    itemBecario.SubItems.Add(becario.SueldoBase.ToString());
                    itemBecario.SubItems.Add(becario.Dni.ToString());
                    itemBecario.SubItems.Add("Becario");
                    itemBecario.SubItems.Add("");
                    itemBecario.SubItems.Add("");
                    itemBecario.SubItems.Add("");
                    itemBecario.SubItems.Add(becario.Carrera);
                    itemBecario.SubItems.Add(becario.Curso);
                    itemBecario.SubItems.Add("");
                    itemBecario.SubItems.Add(becario.Departamento);
                    itemBecario.SubItems.Add("");
                    itemBecario.SubItems.Add("");
                    itemBecario.SubItems.Add("");
                    item.Remove();
                    listView.Items.Insert(index, itemBecario);
                }
                else if (checkBoxCualificados.Checked)
                {
                    Cualificados cualificado = new Cualificados(nombre, apellido1, apellido2, sueldo,
                                                                dni, titulacion, departamento, plus);
                    ListViewItem itemCualificado = new ListViewItem(cualificado.Nombre);
                    itemCualificado.SubItems.Add(cualificado.PrApellido);
                    itemCualificado.SubItems.Add(cualificado.SgApellido);
                    itemCualificado.SubItems.Add(cualificado.SueldoBase.ToString());
                    itemCualificado.SubItems.Add(cualificado.Dni.ToString());
                    itemCualificado.SubItems.Add("Cualificado");
                    itemCualificado.SubItems.Add("");
                    itemCualificado.SubItems.Add("");
                    itemCualificado.SubItems.Add("");
                    itemCualificado.SubItems.Add("");
                    itemCualificado.SubItems.Add("");
                    itemCualificado.SubItems.Add(cualificado.Titulacion);
                    itemCualificado.SubItems.Add(cualificado.Departamento);
                    itemCualificado.SubItems.Add("");
                    itemCualificado.SubItems.Add("");
                    itemCualificado.SubItems.Add(cualificado.Plus.ToString());
                    item.Remove();
                    listView.Items.Insert(index, itemCualificado);
                }
                else if (checkBoxJefeDepartamento.Checked)
                {
                    JefeDepartamento jefe = new JefeDepartamento(nombre, apellido1, apellido2, sueldo,
                                                    dni, titulacion, departamento, plus, trabajos, proyectos);
                    ListViewItem itemJefeDepartamento = new ListViewItem(jefe.Nombre);
                    itemJefeDepartamento.SubItems.Add(jefe.PrApellido);
                    itemJefeDepartamento.SubItems.Add(jefe.SgApellido);
                    itemJefeDepartamento.SubItems.Add(jefe.SueldoBase.ToString());
                    itemJefeDepartamento.SubItems.Add(jefe.Dni.ToString());
                    itemJefeDepartamento.SubItems.Add("Jefe de Departamento");
                    itemJefeDepartamento.SubItems.Add("");
                    itemJefeDepartamento.SubItems.Add("");
                    itemJefeDepartamento.SubItems.Add("");
                    itemJefeDepartamento.SubItems.Add("");
                    itemJefeDepartamento.SubItems.Add("");
                    itemJefeDepartamento.SubItems.Add(jefe.Titulacion);
                    itemJefeDepartamento.SubItems.Add(jefe.Departamento);
                    itemJefeDepartamento.SubItems.Add(jefe.TotalTrabajoCargo.ToString());
                    itemJefeDepartamento.SubItems.Add(jefe.Proyectos.ToString());
                    itemJefeDepartamento.SubItems.Add(jefe.Plus.ToString());
                    item.Remove();
                    listView.Items.Insert(index, itemJefeDepartamento);
                }
                else
                {
                    Obreros obrero = new Obreros(nombre, apellido1, apellido2, sueldo, dni, "", 0, 0.0);
                    ListViewItem itemBase = new ListViewItem(obrero.Nombre);
                    itemBase.SubItems.Add(obrero.PrApellido);
                    itemBase.SubItems.Add(obrero.SgApellido);
                    itemBase.SubItems.Add(obrero.SueldoBase.ToString());
                    itemBase.SubItems.Add(obrero.Dni.ToString());
                    itemBase.SubItems.Add("Empleado");
                    item.Remove();
                    listView.Items.Insert(index, itemBase);
                }
            }
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            eliminarEmpleado();
        }

        private void eliminarEmpleado()
        {
            ListView.SelectedListViewItemCollection selectedList = listView.SelectedItems;
            foreach (ListViewItem item in selectedList)
            {
                listView.Items.Remove(item);
            }
        }

        private void btAñadir_Click(object sender, EventArgs e)
        {
            crearNuevoEmpleado();
        }

        private void crearNuevoEmpleado()
        {
            if (checkBoxObreros.Checked == true) { crearObrero(); }
            if (checkBoxCualificados.Checked == true) { crearCualificado(); }
            if (checkBoxBecarios.Checked == true) { crearBecario(); }
            if (checkBoxJefeDepartamento.Checked == true) { crearJefeDepartamento(); }
            if (checkBoxBecarios.Checked == false &&
                checkBoxObreros.Checked == false &&
                checkBoxCualificados.Checked == false &&
                checkBoxJefeDepartamento.Checked == false)
            { crearEmpleadoBase(); }
        }

        private void obtenerDatosBase()
        {
            if (textBoxNombre.Text != "") { this.nombre = textBoxNombre.Text; }
            else { this.nombre = ""; }
            if (textBoxPrApellido.Text != "") { this.apellido1 = textBoxPrApellido.Text; }
            else { this.apellido1 = ""; }
            if (textBoxSgApellido.Text != "") { this.apellido2 = textBoxSgApellido.Text; }
            else { this.apellido2 = ""; }
            if (textBoxSueldoBase.Text != "") { this.sueldo = double.Parse(textBoxSueldoBase.Text); }
            else { this.sueldo = 0.0; }
            if (maskedTextBoxDNI.Text != "") { this.dni = maskedTextBoxDNI.Text; }
            else { this.dni = ""; }
        }

        private void crearEmpleadoBase()
        {
            obtenerDatosBase();
            Obreros obrero = new Obreros(nombre, apellido1, apellido2, 1234.56, dni, "", 0, 0.0);
            ListViewItem itemBase = new ListViewItem(obrero.Nombre);
            itemBase.SubItems.Add(obrero.PrApellido);
            itemBase.SubItems.Add(obrero.SgApellido);
            itemBase.SubItems.Add(obrero.SueldoBase.ToString());
            itemBase.SubItems.Add(obrero.Dni.ToString());
            itemBase.SubItems.Add("Empleado");
            listView.Items.Add(itemBase);
        }

        private void crearObrero()
        {
            obtenerDatosBase();
            obtenerDatosObrero();
            Obreros obrero = new Obreros(nombre, apellido1, apellido2, sueldo, dni, destino, horas, precio);
            añadirObreroLista(obrero);
        }

        private void obtenerDatosObrero()
        {
            if (textBox1.Text != "") { this.destino = textBox1.Text; }
            else { this.destino = ""; }
            if (textBox2.Text != "") { this.horas = int.Parse(textBox2.Text); }
            else { this.horas = 0; }
            if (textBox3.Text != "") { this.precio = double.Parse(textBox3.Text); }
            else { this.precio = 0; }
        }

        private void añadirObreroLista(Obreros obrero)
        {
            ListViewItem itemObrero = new ListViewItem(obrero.Nombre);
            itemObrero.SubItems.Add(obrero.PrApellido);
            itemObrero.SubItems.Add(obrero.SgApellido);
            itemObrero.SubItems.Add(obrero.SueldoBase.ToString());
            itemObrero.SubItems.Add(obrero.Dni.ToString());
            itemObrero.SubItems.Add("Obrero");
            itemObrero.SubItems.Add(obrero.DestinoTrabajo);
            itemObrero.SubItems.Add(obrero.HorasExtra.ToString());
            itemObrero.SubItems.Add(obrero.PrecioHE.ToString());
            itemObrero.SubItems.Add("");
            itemObrero.SubItems.Add("");
            itemObrero.SubItems.Add("");
            itemObrero.SubItems.Add("");
            itemObrero.SubItems.Add("");
            itemObrero.SubItems.Add("");
            itemObrero.SubItems.Add("");
            listView.Items.Add(itemObrero);
        }

        private void crearBecario()
        {
            obtenerDatosBase();
            obtenerDatosBecario();
            Becarios becario = new Becarios(nombre, apellido1, apellido2, sueldo, dni, carrera, curso, departamento);
            añadirBecarioLista(becario);
        }

        private void obtenerDatosBecario()
        {
            if (textBox1.Text != "") { this.carrera = textBox1.Text; }
            else { this.carrera = ""; }
            if (textBox2.Text != "") { this.curso = textBox2.Text; }
            else { this.curso = ""; }
            if (textBox3.Text != "") { this.departamento = textBox3.Text; }
            else { this.departamento = ""; }
        }

        private void añadirBecarioLista(Becarios becario)
        {
            ListViewItem itemBecario = new ListViewItem(becario.Nombre);
            itemBecario.SubItems.Add(becario.PrApellido);
            itemBecario.SubItems.Add(becario.SgApellido);
            itemBecario.SubItems.Add(becario.SueldoBase.ToString());
            itemBecario.SubItems.Add(becario.Dni.ToString());
            itemBecario.SubItems.Add("Becario");
            itemBecario.SubItems.Add("");
            itemBecario.SubItems.Add("");
            itemBecario.SubItems.Add("");
            itemBecario.SubItems.Add(becario.Carrera);
            itemBecario.SubItems.Add(becario.Curso);
            itemBecario.SubItems.Add("");
            itemBecario.SubItems.Add(becario.Departamento);
            itemBecario.SubItems.Add("");
            itemBecario.SubItems.Add("");
            itemBecario.SubItems.Add("");
            listView.Items.Add(itemBecario);
        }

        private void crearCualificado()
        {
            obtenerDatosBase();
            obtenerDatosCualificado();
            Cualificados cualificado = new Cualificados(nombre, apellido1, apellido2, sueldo, 
                dni, titulacion, departamento, plus);
            añadirCualificadoLista(cualificado);
        }

        private void obtenerDatosCualificado()
        {
            if (textBox1.Text != "") { this.titulacion = textBox1.Text; }
            else { this.titulacion = ""; }
            if (textBox2.Text != "") { this.plus = double.Parse(textBox2.Text); }
            else { this.plus = 0.0; }
            if (textBox3.Text != "") { this.departamento = textBox3.Text; }
            else { this.departamento = ""; }
        }

        private void añadirCualificadoLista(Cualificados cualificado)
        {
            ListViewItem itemCualificado = new ListViewItem(cualificado.Nombre);
            itemCualificado.SubItems.Add(cualificado.PrApellido);
            itemCualificado.SubItems.Add(cualificado.SgApellido);
            itemCualificado.SubItems.Add(cualificado.SueldoBase.ToString());
            itemCualificado.SubItems.Add(cualificado.Dni.ToString());
            itemCualificado.SubItems.Add("Cualificado");
            itemCualificado.SubItems.Add("");
            itemCualificado.SubItems.Add("");
            itemCualificado.SubItems.Add("");
            itemCualificado.SubItems.Add("");
            itemCualificado.SubItems.Add("");
            itemCualificado.SubItems.Add(cualificado.Titulacion);
            itemCualificado.SubItems.Add(cualificado.Departamento);
            itemCualificado.SubItems.Add("");
            itemCualificado.SubItems.Add("");
            itemCualificado.SubItems.Add(cualificado.Plus.ToString());
            listView.Items.Add(itemCualificado);
        }

        private void crearJefeDepartamento()
        {
            obtenerDatosBase();
            obtenerDatosCualificado();
            obtenerDatosJefeDepartamento();
            JefeDepartamento jefe = new JefeDepartamento(nombre, apellido1, apellido2, sueldo, 
                dni, titulacion, departamento, plus, trabajos, proyectos);
            añadirJefeDepartamentoLista(jefe);
        }

        private void obtenerDatosJefeDepartamento()
        {
            if (textBox4.Text != "") { this.trabajos = int.Parse(textBox4.Text); }
            else { this.trabajos = 0; }
            if (textBox5.Text != "") { this.plus = double.Parse(textBox5.Text); }
            else { this.plus = 0.0; }
            if (textBox6.Text != "") { this.proyectos = int.Parse(textBox6.Text); }
            else { this.proyectos = 0; }
        }

        private void añadirJefeDepartamentoLista(JefeDepartamento jefe)
        {
            ListViewItem itemJefeDepartamento = new ListViewItem(jefe.Nombre);
            itemJefeDepartamento.SubItems.Add(jefe.PrApellido);
            itemJefeDepartamento.SubItems.Add(jefe.SgApellido);
            itemJefeDepartamento.SubItems.Add(jefe.SueldoBase.ToString());
            itemJefeDepartamento.SubItems.Add(jefe.Dni.ToString());
            itemJefeDepartamento.SubItems.Add("Jefe de Departamento");
            itemJefeDepartamento.SubItems.Add("");
            itemJefeDepartamento.SubItems.Add("");
            itemJefeDepartamento.SubItems.Add("");
            itemJefeDepartamento.SubItems.Add("");
            itemJefeDepartamento.SubItems.Add("");
            itemJefeDepartamento.SubItems.Add(jefe.Titulacion);
            itemJefeDepartamento.SubItems.Add(jefe.Departamento);
            itemJefeDepartamento.SubItems.Add(jefe.TotalTrabajoCargo.ToString());
            itemJefeDepartamento.SubItems.Add(jefe.Proyectos.ToString());
            itemJefeDepartamento.SubItems.Add(jefe.Plus.ToString());
            listView.Items.Add(itemJefeDepartamento);
        }

        private void buttonInformacion_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection items = listView.SelectedItems;
            foreach (ListViewItem item in items)
            {
                if (item.SubItems[5].Text == "Obrero") 
                {
                    Obreros obrero = new Obreros("n", "pA", "sA", 1.234, "d", item.SubItems[6].Text, 5, double.Parse(item.SubItems[7].Text));
                    MessageBox.Show(obrero.informacion()); 
                } 
                else if (item.SubItems[5].Text == "Becario")
                {
                    Becarios becario = new Becarios("n", "pA", "sA", 1.234, "d", item.SubItems[9].Text, item.SubItems[10].Text, item.SubItems[12].Text);
                    MessageBox.Show(becario.informacion());
                }
                else if (item.SubItems[5].Text == "Cualificado")
                {
                    Cualificados cualificado = new Cualificados("n", "pA", "sA", 1.234, "d", item.SubItems[11].Text, item.SubItems[12].Text, 5.6789);
                    MessageBox.Show(cualificado.informacion());
                }
                else if (item.SubItems[5].Text == "Jefe de Departamento")
                {
                    JefeDepartamento jefe = new JefeDepartamento("n", "pA", "sA", 1.234, "d", "t", "d", 56.789, int.Parse(item.SubItems[13].Text), int.Parse(item.SubItems[14].Text));
                    MessageBox.Show(jefe.informacion());
                }
                else
                {
                    Obreros obrero = new("n", "pA", "sA", 1234.56, "d", "e", 5, 6.789);
                    Empleados empleado = obrero;
                    MessageBox.Show(empleado.informacion());
                }
            }
        }

        private void btExamenes_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection items = listView.SelectedItems;
            foreach (ListViewItem item in items)
            {
                if (item.SubItems[5].Text != "Becario") { MessageBox.Show("Este empleado no es un estudiante."); }
                else
                {
                    if (item.SubItems.Count == 16)
                    {
                        calculaNota(item);
                        calculaUniversidad(item);
                        MessageBox.Show("Nota 1: " + item.SubItems[16].Text +
                                        ".\nNota 2: " + item.SubItems[17].Text +
                                        ".\nNota 3: " + item.SubItems[18].Text +
                                        ".");
                    }
                    else
                    {
                        MessageBox.Show("Nota 1: " + item.SubItems[17].Text + 
                                        ".\nNota 2: " + item.SubItems[18].Text + 
                                        ".\nNota 3: " + item.SubItems[19].Text + 
                                        ".");
                    }
                }
            }
        }

        private void btUniversidad_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection items = listView.SelectedItems;
            foreach (ListViewItem item in items)
            {
                if (item.SubItems[5].Text != "Becario") { MessageBox.Show("Este empleado no es un estudiante."); }
                else
                {
                    if (item.SubItems.Count == 16)
                    {
                        calculaNota(item);
                        calculaUniversidad(item);
                        MessageBox.Show("El estudiante pertenece a la " + item.SubItems[20].Text + ".");
                    }
                    else
                    {
                        MessageBox.Show("El estudiante pertenece a la " + item.SubItems[20].Text + ".");
                    }
                }
            }
        }

        private void btNotaMedia_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection items = listView.SelectedItems;
            foreach (ListViewItem item in items)
            {
                if (item.SubItems[5].Text != "Becario") { MessageBox.Show("Este empleado no es un estudiante."); }
                else
                {
                    if (item.SubItems.Count == 16)
                    {
                        calculaNota(item);
                        calculaUniversidad(item);
                        MessageBox.Show("La media del alumno es: " + item.SubItems[19].Text + ".");
                    }
                    else
                    {
                        MessageBox.Show("La media del alumno es: " + item.SubItems[19].Text + ".");
                    }
                }
            }
        }

        private void calculaNota(ListViewItem item)
        {
            nota1 = random.Next(11); nota2 = random.Next(11); nota3 = random.Next(11);
            media = ((nota1 + nota2 + nota3) / 3);
            item.SubItems.Add(nota1.ToString("0.0"));
            item.SubItems.Add(nota2.ToString("0.0"));
            item.SubItems.Add(nota3.ToString("0.0"));
            item.SubItems.Add(media.ToString("0.0"));
        }

        private void calculaUniversidad(ListViewItem item)
        {
            string[] universidades = { "Universidad Miguel Hernández", "Universidad de Alicante",
                "Universidad Nacional de Educación a Distancia", "Universidad Complutense de Madrid",
                "Universidad de Zaragoza", "Universidad de Granada", "Universidad Isabel I",
                "Universitat Oberta de Cataluña", "Universidad Autónoma de Madrid", "Universidad de Almería" };
            item.SubItems.Add(universidades[random.Next(10)].ToString());
        }
    }
}