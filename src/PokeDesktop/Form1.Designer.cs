namespace PokeDesktop
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
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnLoadAll = new Button();
            lbPokemon = new ListBox();
            pbPokemon = new PictureBox();
            lblName = new Label();
            lblDex = new Label();
            lblTypes = new Label();
            lblStats = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPokemon).BeginInit();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(20, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(150, 25);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Поиск по имени:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(176, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 31);
            txtSearch.TabIndex = 1;
            // 
            // btnLoadAll
            // 
            btnLoadAll.Location = new Point(420, 17);
            btnLoadAll.Name = "btnLoadAll";
            btnLoadAll.Size = new Size(220, 35);
            btnLoadAll.TabIndex = 2;
            btnLoadAll.Text = "Загрузить всех покемонов";
            btnLoadAll.UseVisualStyleBackColor = true;
            // 
            // lbPokemon
            // 
            lbPokemon.FormattingEnabled = true;
            lbPokemon.Location = new Point(20, 70);
            lbPokemon.Name = "lbPokemon";
            lbPokemon.Size = new Size(300, 529);
            lbPokemon.TabIndex = 3;
            // 
            // pbPokemon
            // 
            pbPokemon.BorderStyle = BorderStyle.FixedSingle;
            pbPokemon.Location = new Point(326, 70);
            pbPokemon.Name = "pbPokemon";
            pbPokemon.Size = new Size(240, 240);
            pbPokemon.SizeMode = PictureBoxSizeMode.Zoom;
            pbPokemon.TabIndex = 4;
            pbPokemon.TabStop = false;
            // 
            // lblName
            // 
            lblName.Location = new Point(340, 330);
            lblName.Name = "lblName";
            lblName.Size = new Size(500, 25);
            lblName.TabIndex = 5;
            lblName.Text = "label1";
            // 
            // lblDex
            // 
            lblDex.Location = new Point(340, 360);
            lblDex.Name = "lblDex";
            lblDex.Size = new Size(500, 25);
            lblDex.TabIndex = 6;
            lblDex.Text = "label1";
            // 
            // lblTypes
            // 
            lblTypes.Location = new Point(340, 390);
            lblTypes.Name = "lblTypes";
            lblTypes.Size = new Size(500, 25);
            lblTypes.TabIndex = 7;
            lblTypes.Text = "label1";
            // 
            // lblStats
            // 
            lblStats.Location = new Point(340, 420);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(500, 25);
            lblStats.TabIndex = 8;
            lblStats.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 624);
            Controls.Add(lblStats);
            Controls.Add(lblTypes);
            Controls.Add(lblDex);
            Controls.Add(lblName);
            Controls.Add(pbPokemon);
            Controls.Add(lbPokemon);
            Controls.Add(btnLoadAll);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Name = "Form1";
            Text = "PokeDesk";
            ((System.ComponentModel.ISupportInitialize)pbPokemon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnLoadAll;
        private ListBox lbPokemon;
        private PictureBox pbPokemon;
        private Label lblName;
        private Label lblDex;
        private Label lblTypes;
        private Label lblStats;
    }
}
