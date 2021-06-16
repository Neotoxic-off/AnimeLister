
namespace AnimeLister
{
    partial class AnimeLister
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimeLister));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.box_grade = new System.Windows.Forms.ComboBox();
            this.box_name = new System.Windows.Forms.TextBox();
            this.box_items = new System.Windows.Forms.ListView();
            this.name_data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grade_data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.box = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.box.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.box_grade);
            this.groupBox1.Controls.Add(this.box_name);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Anime ";
            // 
            // Add
            // 
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Location = new System.Drawing.Point(243, 62);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // box_grade
            // 
            this.box_grade.FormattingEnabled = true;
            this.box_grade.Items.AddRange(new object[] {
            "N/A",
            "S",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.box_grade.Location = new System.Drawing.Point(270, 35);
            this.box_grade.Name = "box_grade";
            this.box_grade.Size = new System.Drawing.Size(48, 21);
            this.box_grade.TabIndex = 1;
            // 
            // box_name
            // 
            this.box_name.BackColor = System.Drawing.Color.Black;
            this.box_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_name.ForeColor = System.Drawing.Color.White;
            this.box_name.Location = new System.Drawing.Point(66, 35);
            this.box_name.Name = "box_name";
            this.box_name.Size = new System.Drawing.Size(198, 20);
            this.box_name.TabIndex = 0;
            // 
            // box_items
            // 
            this.box_items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name_data,
            this.grade_data});
            this.box_items.HideSelection = false;
            this.box_items.Location = new System.Drawing.Point(6, 19);
            this.box_items.Name = "box_items";
            this.box_items.Size = new System.Drawing.Size(325, 216);
            this.box_items.TabIndex = 1;
            this.box_items.UseCompatibleStateImageBehavior = false;
            this.box_items.View = System.Windows.Forms.View.Details;
            // 
            // name_data
            // 
            this.name_data.Text = "Name";
            this.name_data.Width = 250;
            // 
            // grade_data
            // 
            this.grade_data.Text = "Grade";
            this.grade_data.Width = 50;
            // 
            // box
            // 
            this.box.Controls.Add(this.box_items);
            this.box.Location = new System.Drawing.Point(12, 118);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(337, 241);
            this.box.TabIndex = 2;
            this.box.TabStop = false;
            this.box.Text = " Anime View ";
            // 
            // AnimeLister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(361, 370);
            this.Controls.Add(this.box);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnimeLister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anime Lister";
            this.Load += new System.EventHandler(this.AnimeLister_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.box.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox box_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox box_grade;
        private System.Windows.Forms.ListView box_items;
        private System.Windows.Forms.GroupBox box;
        private System.Windows.Forms.ColumnHeader name_data;
        private System.Windows.Forms.ColumnHeader grade_data;
        private System.Windows.Forms.Button Add;
    }
}

