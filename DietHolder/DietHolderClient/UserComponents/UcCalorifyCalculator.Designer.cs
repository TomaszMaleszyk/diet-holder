namespace DietHolderClient.UserComponents
{
    partial class UcCalorifyCalculator
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
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_resultsOfCalculations = new System.Windows.Forms.Panel();
            this.lb_fat = new System.Windows.Forms.Label();
            this.lb_protein = new System.Windows.Forms.Label();
            this.lb_carbohydrates = new System.Windows.Forms.Label();
            this.lb_txtCalorifyToEat = new System.Windows.Forms.Label();
            this.lb_txtProtein = new System.Windows.Forms.Label();
            this.lb_txtFat = new System.Windows.Forms.Label();
            this.lb_txtCarbos = new System.Windows.Forms.Label();
            this.lb_calorifyToEat = new System.Windows.Forms.Label();
            this.cb_posture = new System.Windows.Forms.ComboBox();
            this.label_posture = new System.Windows.Forms.Label();
            this.btn_calculateCalorify = new System.Windows.Forms.Button();
            this.cb_goal = new System.Windows.Forms.ComboBox();
            this.label_goal = new System.Windows.Forms.Label();
            this.label_sex = new System.Windows.Forms.Label();
            this.label_activity = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.label_height = new System.Windows.Forms.Label();
            this.label_weight = new System.Windows.Forms.Label();
            this.panel_sexChoice = new System.Windows.Forms.Panel();
            this.rb_women = new System.Windows.Forms.RadioButton();
            this.rb_man = new System.Windows.Forms.RadioButton();
            this.txtbox_weight = new System.Windows.Forms.TextBox();
            this.cb_activity = new System.Windows.Forms.ComboBox();
            this.txtbox_height = new System.Windows.Forms.TextBox();
            this.txtbox_age = new System.Windows.Forms.TextBox();
            this.gb_questionnaire = new System.Windows.Forms.GroupBox();
            this.panel_resultsOfCalculations.SuspendLayout();
            this.panel_sexChoice.SuspendLayout();
            this.gb_questionnaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_resultsOfCalculations
            // 
            this.panel_resultsOfCalculations.Controls.Add(this.lb_fat);
            this.panel_resultsOfCalculations.Controls.Add(this.lb_protein);
            this.panel_resultsOfCalculations.Controls.Add(this.lb_carbohydrates);
            this.panel_resultsOfCalculations.Controls.Add(this.lb_txtCalorifyToEat);
            this.panel_resultsOfCalculations.Controls.Add(this.lb_txtProtein);
            this.panel_resultsOfCalculations.Controls.Add(this.lb_txtFat);
            this.panel_resultsOfCalculations.Controls.Add(this.lb_txtCarbos);
            this.panel_resultsOfCalculations.Controls.Add(this.lb_calorifyToEat);
            this.panel_resultsOfCalculations.Location = new System.Drawing.Point(13, 334);
            this.panel_resultsOfCalculations.Name = "panel_resultsOfCalculations";
            this.panel_resultsOfCalculations.Size = new System.Drawing.Size(448, 100);
            this.panel_resultsOfCalculations.TabIndex = 38;
            // 
            // lb_fat
            // 
            this.lb_fat.AutoSize = true;
            this.lb_fat.Location = new System.Drawing.Point(362, 68);
            this.lb_fat.Name = "lb_fat";
            this.lb_fat.Size = new System.Drawing.Size(56, 17);
            this.lb_fat.TabIndex = 23;
            this.lb_fat.Text = "000000";
            // 
            // lb_protein
            // 
            this.lb_protein.AutoSize = true;
            this.lb_protein.Location = new System.Drawing.Point(362, 51);
            this.lb_protein.Name = "lb_protein";
            this.lb_protein.Size = new System.Drawing.Size(56, 17);
            this.lb_protein.TabIndex = 22;
            this.lb_protein.Text = "000000";
            // 
            // lb_carbohydrates
            // 
            this.lb_carbohydrates.AutoSize = true;
            this.lb_carbohydrates.Location = new System.Drawing.Point(362, 34);
            this.lb_carbohydrates.Name = "lb_carbohydrates";
            this.lb_carbohydrates.Size = new System.Drawing.Size(56, 17);
            this.lb_carbohydrates.TabIndex = 21;
            this.lb_carbohydrates.Text = "000000";
            // 
            // lb_txtCalorifyToEat
            // 
            this.lb_txtCalorifyToEat.AutoSize = true;
            this.lb_txtCalorifyToEat.Location = new System.Drawing.Point(11, 17);
            this.lb_txtCalorifyToEat.Name = "lb_txtCalorifyToEat";
            this.lb_txtCalorifyToEat.Size = new System.Drawing.Size(327, 17);
            this.lb_txtCalorifyToEat.TabIndex = 17;
            this.lb_txtCalorifyToEat.Text = "Twoje zapotrzebowanie kaloryczne wynosi (KCAL):";
            // 
            // lb_txtProtein
            // 
            this.lb_txtProtein.AutoSize = true;
            this.lb_txtProtein.Location = new System.Drawing.Point(11, 51);
            this.lb_txtProtein.Name = "lb_txtProtein";
            this.lb_txtProtein.Size = new System.Drawing.Size(96, 17);
            this.lb_txtProtein.TabIndex = 19;
            this.lb_txtProtein.Text = "Białko (gram):";
            // 
            // lb_txtFat
            // 
            this.lb_txtFat.AutoSize = true;
            this.lb_txtFat.Location = new System.Drawing.Point(11, 68);
            this.lb_txtFat.Name = "lb_txtFat";
            this.lb_txtFat.Size = new System.Drawing.Size(114, 17);
            this.lb_txtFat.TabIndex = 20;
            this.lb_txtFat.Text = "Tłuszcze (gram):";
            // 
            // lb_txtCarbos
            // 
            this.lb_txtCarbos.AutoSize = true;
            this.lb_txtCarbos.Location = new System.Drawing.Point(11, 34);
            this.lb_txtCarbos.Name = "lb_txtCarbos";
            this.lb_txtCarbos.Size = new System.Drawing.Size(146, 17);
            this.lb_txtCarbos.TabIndex = 18;
            this.lb_txtCarbos.Text = "Węglowodany (gram):";
            // 
            // lb_calorifyToEat
            // 
            this.lb_calorifyToEat.AutoSize = true;
            this.lb_calorifyToEat.Location = new System.Drawing.Point(362, 17);
            this.lb_calorifyToEat.Name = "lb_calorifyToEat";
            this.lb_calorifyToEat.Size = new System.Drawing.Size(56, 17);
            this.lb_calorifyToEat.TabIndex = 13;
            this.lb_calorifyToEat.Text = "000000";
            // 
            // cb_posture
            // 
            this.cb_posture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_posture.FormattingEnabled = true;
            this.cb_posture.Items.AddRange(new object[] {
            "Ektomorfik",
            "Mezomorfik",
            "Endomorfik"});
            this.cb_posture.Location = new System.Drawing.Point(206, 141);
            this.cb_posture.Name = "cb_posture";
            this.cb_posture.Size = new System.Drawing.Size(212, 24);
            this.cb_posture.TabIndex = 37;
            // 
            // label_posture
            // 
            this.label_posture.AutoSize = true;
            this.label_posture.Location = new System.Drawing.Point(17, 141);
            this.label_posture.Name = "label_posture";
            this.label_posture.Size = new System.Drawing.Size(104, 17);
            this.label_posture.TabIndex = 36;
            this.label_posture.Text = "Rodzaj budowy";
            // 
            // btn_calculateCalorify
            // 
            this.btn_calculateCalorify.Location = new System.Drawing.Point(20, 243);
            this.btn_calculateCalorify.Name = "btn_calculateCalorify";
            this.btn_calculateCalorify.Size = new System.Drawing.Size(398, 52);
            this.btn_calculateCalorify.TabIndex = 35;
            this.btn_calculateCalorify.Text = "Oblicz";
            this.btn_calculateCalorify.UseVisualStyleBackColor = true;
            this.btn_calculateCalorify.Click += new System.EventHandler(this.btn_calculateCalorify_Click);
            // 
            // cb_goal
            // 
            this.cb_goal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_goal.FormattingEnabled = true;
            this.cb_goal.Items.AddRange(new object[] {
            "Redukcja wagi",
            "Utrzymanie wagi",
            "Zyskanie wagi"});
            this.cb_goal.Location = new System.Drawing.Point(206, 201);
            this.cb_goal.Name = "cb_goal";
            this.cb_goal.Size = new System.Drawing.Size(212, 24);
            this.cb_goal.TabIndex = 34;
            // 
            // label_goal
            // 
            this.label_goal.AutoSize = true;
            this.label_goal.Location = new System.Drawing.Point(17, 201);
            this.label_goal.Name = "label_goal";
            this.label_goal.Size = new System.Drawing.Size(55, 17);
            this.label_goal.TabIndex = 33;
            this.label_goal.Text = "Planuje";
            // 
            // label_sex
            // 
            this.label_sex.AutoSize = true;
            this.label_sex.Location = new System.Drawing.Point(17, 28);
            this.label_sex.Name = "label_sex";
            this.label_sex.Size = new System.Drawing.Size(35, 17);
            this.label_sex.TabIndex = 32;
            this.label_sex.Text = "Płeć";
            // 
            // label_activity
            // 
            this.label_activity.AutoSize = true;
            this.label_activity.Location = new System.Drawing.Point(17, 172);
            this.label_activity.Name = "label_activity";
            this.label_activity.Size = new System.Drawing.Size(129, 17);
            this.label_activity.TabIndex = 31;
            this.label_activity.Text = "Aktywność fizyczna";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Location = new System.Drawing.Point(17, 112);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(76, 17);
            this.label_age.TabIndex = 30;
            this.label_age.Text = "Wiek (lata)";
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(17, 84);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(84, 17);
            this.label_height.TabIndex = 29;
            this.label_height.Text = "Wzrost (cm)";
            // 
            // label_weight
            // 
            this.label_weight.AutoSize = true;
            this.label_weight.Location = new System.Drawing.Point(17, 56);
            this.label_weight.Name = "label_weight";
            this.label_weight.Size = new System.Drawing.Size(104, 17);
            this.label_weight.TabIndex = 28;
            this.label_weight.Text = "Masa ciała (kg)";
            // 
            // panel_sexChoice
            // 
            this.panel_sexChoice.Controls.Add(this.rb_women);
            this.panel_sexChoice.Controls.Add(this.rb_man);
            this.panel_sexChoice.Location = new System.Drawing.Point(206, 28);
            this.panel_sexChoice.Name = "panel_sexChoice";
            this.panel_sexChoice.Size = new System.Drawing.Size(212, 28);
            this.panel_sexChoice.TabIndex = 26;
            // 
            // rb_women
            // 
            this.rb_women.AutoSize = true;
            this.rb_women.Location = new System.Drawing.Point(3, 3);
            this.rb_women.Name = "rb_women";
            this.rb_women.Size = new System.Drawing.Size(77, 21);
            this.rb_women.TabIndex = 5;
            this.rb_women.TabStop = true;
            this.rb_women.Text = "Kobieta";
            this.rb_women.UseVisualStyleBackColor = true;
            // 
            // rb_man
            // 
            this.rb_man.AutoSize = true;
            this.rb_man.Location = new System.Drawing.Point(110, 4);
            this.rb_man.Name = "rb_man";
            this.rb_man.Size = new System.Drawing.Size(99, 21);
            this.rb_man.TabIndex = 6;
            this.rb_man.TabStop = true;
            this.rb_man.Text = "Mężczyzna";
            this.rb_man.UseVisualStyleBackColor = true;
            // 
            // txtbox_weight
            // 
            this.txtbox_weight.Location = new System.Drawing.Point(206, 56);
            this.txtbox_weight.Name = "txtbox_weight";
            this.txtbox_weight.Size = new System.Drawing.Size(212, 22);
            this.txtbox_weight.TabIndex = 22;
            // 
            // cb_activity
            // 
            this.cb_activity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_activity.FormattingEnabled = true;
            this.cb_activity.Items.AddRange(new object[] {
            "Mała",
            "Średnia",
            "Duża",
            "Bardzo duża"});
            this.cb_activity.Location = new System.Drawing.Point(206, 172);
            this.cb_activity.Name = "cb_activity";
            this.cb_activity.Size = new System.Drawing.Size(212, 24);
            this.cb_activity.TabIndex = 25;
            // 
            // txtbox_height
            // 
            this.txtbox_height.Location = new System.Drawing.Point(206, 84);
            this.txtbox_height.Name = "txtbox_height";
            this.txtbox_height.Size = new System.Drawing.Size(212, 22);
            this.txtbox_height.TabIndex = 23;
            // 
            // txtbox_age
            // 
            this.txtbox_age.Location = new System.Drawing.Point(206, 112);
            this.txtbox_age.Name = "txtbox_age";
            this.txtbox_age.Size = new System.Drawing.Size(212, 22);
            this.txtbox_age.TabIndex = 24;
            // 
            // gb_questionnaire
            // 
            this.gb_questionnaire.Controls.Add(this.label_activity);
            this.gb_questionnaire.Controls.Add(this.label_weight);
            this.gb_questionnaire.Controls.Add(this.btn_calculateCalorify);
            this.gb_questionnaire.Controls.Add(this.cb_posture);
            this.gb_questionnaire.Controls.Add(this.label_posture);
            this.gb_questionnaire.Controls.Add(this.label_height);
            this.gb_questionnaire.Controls.Add(this.cb_goal);
            this.gb_questionnaire.Controls.Add(this.label_age);
            this.gb_questionnaire.Controls.Add(this.panel_sexChoice);
            this.gb_questionnaire.Controls.Add(this.label_sex);
            this.gb_questionnaire.Controls.Add(this.txtbox_weight);
            this.gb_questionnaire.Controls.Add(this.label_goal);
            this.gb_questionnaire.Controls.Add(this.cb_activity);
            this.gb_questionnaire.Controls.Add(this.txtbox_age);
            this.gb_questionnaire.Controls.Add(this.txtbox_height);
            this.gb_questionnaire.Location = new System.Drawing.Point(13, 16);
            this.gb_questionnaire.Name = "gb_questionnaire";
            this.gb_questionnaire.Size = new System.Drawing.Size(448, 312);
            this.gb_questionnaire.TabIndex = 39;
            this.gb_questionnaire.TabStop = false;
            this.gb_questionnaire.Text = "Proszę wypełnić formularz";
            // 
            // UcCalorifyCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_questionnaire);
            this.Controls.Add(this.panel_resultsOfCalculations);
            this.Name = "UcCalorifyCalculator";
            this.Size = new System.Drawing.Size(478, 464);
            this.panel_resultsOfCalculations.ResumeLayout(false);
            this.panel_resultsOfCalculations.PerformLayout();
            this.panel_sexChoice.ResumeLayout(false);
            this.panel_sexChoice.PerformLayout();
            this.gb_questionnaire.ResumeLayout(false);
            this.gb_questionnaire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_resultsOfCalculations;
        private System.Windows.Forms.Label lb_fat;
        private System.Windows.Forms.Label lb_protein;
        private System.Windows.Forms.Label lb_carbohydrates;
        private System.Windows.Forms.Label lb_txtCalorifyToEat;
        private System.Windows.Forms.Label lb_txtProtein;
        private System.Windows.Forms.Label lb_txtFat;
        private System.Windows.Forms.Label lb_txtCarbos;
        private System.Windows.Forms.Label lb_calorifyToEat;
        private System.Windows.Forms.ComboBox cb_posture;
        private System.Windows.Forms.Label label_posture;
        private System.Windows.Forms.Button btn_calculateCalorify;
        private System.Windows.Forms.ComboBox cb_goal;
        private System.Windows.Forms.Label label_goal;
        private System.Windows.Forms.Label label_sex;
        private System.Windows.Forms.Label label_activity;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.Label label_weight;
        private System.Windows.Forms.Panel panel_sexChoice;
        private System.Windows.Forms.RadioButton rb_women;
        private System.Windows.Forms.RadioButton rb_man;
        private System.Windows.Forms.TextBox txtbox_weight;
        private System.Windows.Forms.ComboBox cb_activity;
        private System.Windows.Forms.TextBox txtbox_height;
        private System.Windows.Forms.TextBox txtbox_age;
        private System.Windows.Forms.GroupBox gb_questionnaire;
    }
}
