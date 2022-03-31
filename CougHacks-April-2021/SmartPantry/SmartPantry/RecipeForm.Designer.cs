
namespace SmartPantry
{
    partial class RecipeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.directionsText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ingredientsLB = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.addIngredientsToShopping = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rage Italic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Recipe Details";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(17, 70);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(291, 20);
            this.nameTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Recipe Name:";
            // 
            // directionsText
            // 
            this.directionsText.Location = new System.Drawing.Point(17, 122);
            this.directionsText.Multiline = true;
            this.directionsText.Name = "directionsText";
            this.directionsText.Size = new System.Drawing.Size(291, 67);
            this.directionsText.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(14, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Directions:";
            // 
            // ingredientsLB
            // 
            this.ingredientsLB.BackColor = System.Drawing.SystemColors.Window;
            this.ingredientsLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ingredientsLB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ingredientsLB.FormattingEnabled = true;
            this.ingredientsLB.Location = new System.Drawing.Point(17, 221);
            this.ingredientsLB.Name = "ingredientsLB";
            this.ingredientsLB.Size = new System.Drawing.Size(291, 91);
            this.ingredientsLB.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(14, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ingredients:";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(33, 332);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(98, 59);
            this.update.TabIndex = 23;
            this.update.Text = "Update Recipe";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // addIngredientsToShopping
            // 
            this.addIngredientsToShopping.Location = new System.Drawing.Point(173, 332);
            this.addIngredientsToShopping.Name = "addIngredientsToShopping";
            this.addIngredientsToShopping.Size = new System.Drawing.Size(98, 59);
            this.addIngredientsToShopping.TabIndex = 24;
            this.addIngredientsToShopping.Text = "Add Missing Ingredients To Shopping List";
            this.addIngredientsToShopping.UseVisualStyleBackColor = true;
            this.addIngredientsToShopping.Click += new System.EventHandler(this.addIngredientsToShopping_Click);
            // 
            // RecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(320, 416);
            this.Controls.Add(this.addIngredientsToShopping);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ingredientsLB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.directionsText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RecipeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox directionsText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ingredientsLB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button addIngredientsToShopping;
    }
}