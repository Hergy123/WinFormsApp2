
namespace WinFormsApp2
{
    partial class GererUnCompte
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.DataGridView();
            this.txtNameId = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCl = new System.Windows.Forms.TextBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.txtL = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.DateTimePicker();
            this.txtCo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Update)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(468, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(327, 347);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 35);
            this.button4.TabIndex = 9;
            this.button4.Text = "Modifier";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(185, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 35);
            this.button3.TabIndex = 10;
            this.button3.Text = "Ajouter";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Update
            // 
            this.Update.AllowUserToAddRows = false;
            this.Update.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Update.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Update.Location = new System.Drawing.Point(12, 201);
            this.Update.Name = "Update";
            this.Update.RowTemplate.Height = 25;
            this.Update.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Update.Size = new System.Drawing.Size(732, 131);
            this.Update.TabIndex = 11;
            this.Update.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Update_CellContentClick_1);
            // 
            // txtNameId
            // 
            this.txtNameId.Enabled = false;
            this.txtNameId.Location = new System.Drawing.Point(594, 10);
            this.txtNameId.Name = "txtNameId";
            this.txtNameId.Size = new System.Drawing.Size(150, 23);
            this.txtNameId.TabIndex = 12;
            this.txtNameId.TextChanged += new System.EventHandler(this.txtNameId_TextChanged);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(134, 65);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(174, 23);
            this.txtNumero.TabIndex = 24;
            // 
            // txtCl
            // 
            this.txtCl.Location = new System.Drawing.Point(134, 111);
            this.txtCl.Name = "txtCl";
            this.txtCl.Size = new System.Drawing.Size(174, 23);
            this.txtCl.TabIndex = 25;
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(457, 111);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(184, 23);
            this.txtS.TabIndex = 26;
            // 
            // txtL
            // 
            this.txtL.Location = new System.Drawing.Point(134, 150);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(174, 23);
            this.txtL.TabIndex = 27;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(457, 65);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(184, 23);
            this.txtD.TabIndex = 28;
            // 
            // txtCo
            // 
            this.txtCo.FormattingEnabled = true;
            this.txtCo.Items.AddRange(new object[] {
            "Epagne",
            "Courant"});
            this.txtCo.Location = new System.Drawing.Point(457, 155);
            this.txtCo.Name = "txtCo";
            this.txtCo.Size = new System.Drawing.Size(184, 23);
            this.txtCo.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Solde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Libelle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Date D\'ouverture";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "Type de Compte";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(616, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 36;
            this.label7.Text = "Supprimer Par ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Image = global::WinFormsApp2.Properties.Resources.broom_32px;
            this.label8.Location = new System.Drawing.Point(657, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 37;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = global::WinFormsApp2.Properties.Resources.broom_32px1;
            this.button2.Location = new System.Drawing.Point(673, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 28);
            this.button2.TabIndex = 38;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // GererUnCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(756, 394);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCo);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtL);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.txtCl);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtNameId);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GererUnCompte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GererUnCompte";
            this.Load += new System.EventHandler(this.GererUnCompte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Update)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView Update;
        private System.Windows.Forms.TextBox txtNameId;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCl;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.DateTimePicker txtD;
        private System.Windows.Forms.ComboBox txtCo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
    }
}