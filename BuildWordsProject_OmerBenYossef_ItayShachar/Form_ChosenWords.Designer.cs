namespace BuildWordsProject_OmerBenYossef_ItayShachar
{
    partial class Form_ChosenWords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ChosenWords));
            this.ListBox_ChosenWordsBoxPlayer1 = new System.Windows.Forms.ListBox();
            this.ListBox_ChosenWordsBoxPlayer2 = new System.Windows.Forms.ListBox();
            this.Label_explanation = new System.Windows.Forms.Label();
            this.Button_player1_MakesSense = new System.Windows.Forms.Button();
            this.Button_player2_MakesSense = new System.Windows.Forms.Button();
            this.Button_player1_NotMakesSense = new System.Windows.Forms.Button();
            this.Button_player2_NotMakesSense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBox_ChosenWordsBoxPlayer1
            // 
            this.ListBox_ChosenWordsBoxPlayer1.FormattingEnabled = true;
            resources.ApplyResources(this.ListBox_ChosenWordsBoxPlayer1, "ListBox_ChosenWordsBoxPlayer1");
            this.ListBox_ChosenWordsBoxPlayer1.Name = "ListBox_ChosenWordsBoxPlayer1";
            // 
            // ListBox_ChosenWordsBoxPlayer2
            // 
            this.ListBox_ChosenWordsBoxPlayer2.FormattingEnabled = true;
            resources.ApplyResources(this.ListBox_ChosenWordsBoxPlayer2, "ListBox_ChosenWordsBoxPlayer2");
            this.ListBox_ChosenWordsBoxPlayer2.Name = "ListBox_ChosenWordsBoxPlayer2";
            // 
            // Label_explanation
            // 
            this.Label_explanation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.Label_explanation, "Label_explanation");
            this.Label_explanation.Name = "Label_explanation";
            // 
            // Button_player1_MakesSense
            // 
            this.Button_player1_MakesSense.BackColor = System.Drawing.Color.SeaGreen;
            this.Button_player1_MakesSense.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Button_player1_MakesSense, "Button_player1_MakesSense");
            this.Button_player1_MakesSense.ForeColor = System.Drawing.Color.White;
            this.Button_player1_MakesSense.Name = "Button_player1_MakesSense";
            this.Button_player1_MakesSense.UseVisualStyleBackColor = false;
            // 
            // Button_player2_MakesSense
            // 
            this.Button_player2_MakesSense.BackColor = System.Drawing.Color.SeaGreen;
            this.Button_player2_MakesSense.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Button_player2_MakesSense, "Button_player2_MakesSense");
            this.Button_player2_MakesSense.ForeColor = System.Drawing.Color.White;
            this.Button_player2_MakesSense.Name = "Button_player2_MakesSense";
            this.Button_player2_MakesSense.UseVisualStyleBackColor = false;
            // 
            // Button_player1_NotMakesSense
            // 
            this.Button_player1_NotMakesSense.BackColor = System.Drawing.Color.Red;
            this.Button_player1_NotMakesSense.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Button_player1_NotMakesSense, "Button_player1_NotMakesSense");
            this.Button_player1_NotMakesSense.ForeColor = System.Drawing.Color.White;
            this.Button_player1_NotMakesSense.Name = "Button_player1_NotMakesSense";
            this.Button_player1_NotMakesSense.UseVisualStyleBackColor = false;
            // 
            // Button_player2_NotMakesSense
            // 
            this.Button_player2_NotMakesSense.BackColor = System.Drawing.Color.Red;
            this.Button_player2_NotMakesSense.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Button_player2_NotMakesSense, "Button_player2_NotMakesSense");
            this.Button_player2_NotMakesSense.ForeColor = System.Drawing.Color.White;
            this.Button_player2_NotMakesSense.Name = "Button_player2_NotMakesSense";
            this.Button_player2_NotMakesSense.UseVisualStyleBackColor = false;
            // 
            // Form_ChosenWords
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.Button_player2_NotMakesSense);
            this.Controls.Add(this.Button_player1_NotMakesSense);
            this.Controls.Add(this.Button_player2_MakesSense);
            this.Controls.Add(this.Button_player1_MakesSense);
            this.Controls.Add(this.Label_explanation);
            this.Controls.Add(this.ListBox_ChosenWordsBoxPlayer2);
            this.Controls.Add(this.ListBox_ChosenWordsBoxPlayer1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form_ChosenWords";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox ListBox_ChosenWordsBoxPlayer1;
        public System.Windows.Forms.ListBox ListBox_ChosenWordsBoxPlayer2;
        private System.Windows.Forms.Label Label_explanation;
        private System.Windows.Forms.Button Button_player1_MakesSense;
        private System.Windows.Forms.Button Button_player2_MakesSense;
        private System.Windows.Forms.Button Button_player1_NotMakesSense;
        private System.Windows.Forms.Button Button_player2_NotMakesSense;
    }
}