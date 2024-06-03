namespace LaboratorioFinalDB
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.comboBoxPosicion = new System.Windows.Forms.ComboBox();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.dataGridViewConsolas = new System.Windows.Forms.DataGridView();
            this.buttonCargarRegistros = new System.Windows.Forms.Button();
            this.buttonBuscarPorID = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPor = new System.Windows.Forms.Button();
            this.buttonMedio = new System.Windows.Forms.Button();
            this.buttonDefensa = new System.Windows.Forms.Button();
            this.ButtonPortero = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textDorsal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textSigue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsolas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(2, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1033, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "                                                                                 " +
    "        Leonel Andres Guerra Godoy                                              " +
    "                       ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(217, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jugadores de Fútbol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(53, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(53, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(53, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Edad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(53, 252);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dorsal:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(217, 111);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(174, 20);
            this.textBoxID.TabIndex = 7;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(217, 142);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(174, 20);
            this.textBoxNombre.TabIndex = 8;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(217, 177);
            this.textApellido.Margin = new System.Windows.Forms.Padding(2);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(174, 20);
            this.textApellido.TabIndex = 10;
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(217, 211);
            this.textBoxEdad.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(174, 20);
            this.textBoxEdad.TabIndex = 11;
            // 
            // comboBoxPosicion
            // 
            this.comboBoxPosicion.FormattingEnabled = true;
            this.comboBoxPosicion.Location = new System.Drawing.Point(217, 285);
            this.comboBoxPosicion.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPosicion.Name = "comboBoxPosicion";
            this.comboBoxPosicion.Size = new System.Drawing.Size(174, 21);
            this.comboBoxPosicion.TabIndex = 12;
            this.comboBoxPosicion.SelectedIndexChanged += new System.EventHandler(this.comboBoxPosicion_SelectedIndexChanged);
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(56, 367);
            this.buttonCrear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(101, 32);
            this.buttonCrear.TabIndex = 13;
            this.buttonCrear.Text = "Crear Registro";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // dataGridViewConsolas
            // 
            this.dataGridViewConsolas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsolas.Location = new System.Drawing.Point(527, 114);
            this.dataGridViewConsolas.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewConsolas.Name = "dataGridViewConsolas";
            this.dataGridViewConsolas.RowHeadersWidth = 62;
            this.dataGridViewConsolas.RowTemplate.Height = 28;
            this.dataGridViewConsolas.Size = new System.Drawing.Size(504, 192);
            this.dataGridViewConsolas.TabIndex = 14;
            // 
            // buttonCargarRegistros
            // 
            this.buttonCargarRegistros.Location = new System.Drawing.Point(906, 70);
            this.buttonCargarRegistros.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCargarRegistros.Name = "buttonCargarRegistros";
            this.buttonCargarRegistros.Size = new System.Drawing.Size(125, 40);
            this.buttonCargarRegistros.TabIndex = 15;
            this.buttonCargarRegistros.Text = "Cargar todos los registros";
            this.buttonCargarRegistros.UseVisualStyleBackColor = true;
            this.buttonCargarRegistros.Click += new System.EventHandler(this.buttonCargarRegistros_Click);
            // 
            // buttonBuscarPorID
            // 
            this.buttonBuscarPorID.Location = new System.Drawing.Point(398, 112);
            this.buttonBuscarPorID.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscarPorID.Name = "buttonBuscarPorID";
            this.buttonBuscarPorID.Size = new System.Drawing.Size(85, 21);
            this.buttonBuscarPorID.TabIndex = 16;
            this.buttonBuscarPorID.Text = "Buscar por Id";
            this.buttonBuscarPorID.UseVisualStyleBackColor = true;
            this.buttonBuscarPorID.Click += new System.EventHandler(this.buttonBuscarPorID_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(172, 367);
            this.buttonActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(101, 32);
            this.buttonActualizar.TabIndex = 17;
            this.buttonActualizar.Text = "Actualizar registro";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(290, 367);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(101, 32);
            this.buttonEliminar.TabIndex = 18;
            this.buttonEliminar.Text = "Eliminar registro";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.Location = new System.Drawing.Point(173, 22);
            this.buttonSiguiente.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(73, 21);
            this.buttonSiguiente.TabIndex = 20;
            this.buttonSiguiente.Text = "Siguiente";
            this.buttonSiguiente.UseVisualStyleBackColor = true;
            this.buttonSiguiente.Click += new System.EventHandler(this.buttonSiguiente_Click);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Location = new System.Drawing.Point(77, 22);
            this.buttonAnterior.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(73, 21);
            this.buttonAnterior.TabIndex = 21;
            this.buttonAnterior.Text = "Anterior";
            this.buttonAnterior.UseVisualStyleBackColor = true;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPor);
            this.groupBox1.Controls.Add(this.buttonMedio);
            this.groupBox1.Controls.Add(this.buttonDefensa);
            this.groupBox1.Controls.Add(this.ButtonPortero);
            this.groupBox1.Location = new System.Drawing.Point(527, 310);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(504, 72);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultas por filtro";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonPor
            // 
            this.buttonPor.Location = new System.Drawing.Point(386, 17);
            this.buttonPor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPor.Name = "buttonPor";
            this.buttonPor.Size = new System.Drawing.Size(114, 36);
            this.buttonPor.TabIndex = 3;
            this.buttonPor.Text = "Filtrar por Portero";
            this.buttonPor.UseVisualStyleBackColor = true;
            this.buttonPor.Click += new System.EventHandler(this.buttonPor_Click);
            // 
            // buttonMedio
            // 
            this.buttonMedio.Location = new System.Drawing.Point(132, 17);
            this.buttonMedio.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMedio.Name = "buttonMedio";
            this.buttonMedio.Size = new System.Drawing.Size(114, 40);
            this.buttonMedio.TabIndex = 2;
            this.buttonMedio.Text = "Filtrar por Centrocampista";
            this.buttonMedio.UseVisualStyleBackColor = true;
            this.buttonMedio.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonDefensa
            // 
            this.buttonDefensa.Location = new System.Drawing.Point(259, 19);
            this.buttonDefensa.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDefensa.Name = "buttonDefensa";
            this.buttonDefensa.Size = new System.Drawing.Size(114, 36);
            this.buttonDefensa.TabIndex = 1;
            this.buttonDefensa.Text = "Filtrar por Defensa";
            this.buttonDefensa.UseVisualStyleBackColor = true;
            this.buttonDefensa.Click += new System.EventHandler(this.buttonFiltrar_porSega_Click);
            // 
            // ButtonPortero
            // 
            this.ButtonPortero.Location = new System.Drawing.Point(4, 21);
            this.ButtonPortero.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonPortero.Name = "ButtonPortero";
            this.ButtonPortero.Size = new System.Drawing.Size(114, 36);
            this.ButtonPortero.TabIndex = 0;
            this.ButtonPortero.Text = "Filtrar por Delantero";
            this.ButtonPortero.UseVisualStyleBackColor = true;
            this.ButtonPortero.Click += new System.EventHandler(this.buttonFiltrar_porNintendo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAnterior);
            this.groupBox2.Controls.Add(this.buttonSiguiente);
            this.groupBox2.Location = new System.Drawing.Point(702, 386);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(333, 55);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ver registros";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(53, 289);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Posición:";
            // 
            // textDorsal
            // 
            this.textDorsal.Location = new System.Drawing.Point(217, 249);
            this.textDorsal.Margin = new System.Windows.Forms.Padding(2);
            this.textDorsal.Name = "textDorsal";
            this.textDorsal.Size = new System.Drawing.Size(174, 20);
            this.textDorsal.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(53, 324);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Sigue:";
            // 
            // textSigue
            // 
            this.textSigue.Location = new System.Drawing.Point(217, 323);
            this.textSigue.Margin = new System.Windows.Forms.Padding(2);
            this.textSigue.Name = "textSigue";
            this.textSigue.Size = new System.Drawing.Size(174, 20);
            this.textSigue.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1039, 483);
            this.Controls.Add(this.textSigue);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textDorsal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonBuscarPorID);
            this.Controls.Add(this.buttonCargarRegistros);
            this.Controls.Add(this.dataGridViewConsolas);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.comboBoxPosicion);
            this.Controls.Add(this.textBoxEdad);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de datos sobre Consolas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsolas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.ComboBox comboBoxPosicion;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.DataGridView dataGridViewConsolas;
        private System.Windows.Forms.Button buttonCargarRegistros;
        private System.Windows.Forms.Button buttonBuscarPorID;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonMedio;
        private System.Windows.Forms.Button buttonDefensa;
        private System.Windows.Forms.Button ButtonPortero;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textDorsal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textSigue;
        private System.Windows.Forms.Button buttonPor;
    }
}

