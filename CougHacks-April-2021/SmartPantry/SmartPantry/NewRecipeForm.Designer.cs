
namespace SmartPantry
{
    partial class NewRecipeForm
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
            this.newRecipeDescriptionTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.recipeNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ingredient1 = new System.Windows.Forms.TextBox();
            this.quantity1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveRecipeButton = new System.Windows.Forms.Button();
            this.addRecipeItemButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.newRecipeItemLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // newRecipeDescriptionTB
            // 
            this.newRecipeDescriptionTB.Location = new System.Drawing.Point(30, 120);
            this.newRecipeDescriptionTB.Multiline = true;
            this.newRecipeDescriptionTB.Name = "newRecipeDescriptionTB";
            this.newRecipeDescriptionTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.newRecipeDescriptionTB.Size = new System.Drawing.Size(265, 79);
            this.newRecipeDescriptionTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(27, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Description and Procedure if Desired:";
            // 
            // recipeNameTB
            // 
            this.recipeNameTB.Location = new System.Drawing.Point(30, 59);
            this.recipeNameTB.Name = "recipeNameTB";
            this.recipeNameTB.Size = new System.Drawing.Size(249, 20);
            this.recipeNameTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(27, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Name of the Dish:";
            // 
            // ingredient1
            // 
            this.ingredient1.Location = new System.Drawing.Point(30, 256);
            this.ingredient1.Name = "ingredient1";
            this.ingredient1.Size = new System.Drawing.Size(130, 20);
            this.ingredient1.TabIndex = 4;
            // 
            // quantity1
            // 
            this.quantity1.Location = new System.Drawing.Point(166, 256);
            this.quantity1.Name = "quantity1";
            this.quantity1.Size = new System.Drawing.Size(53, 20);
            this.quantity1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(27, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingredient Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(163, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity:";
            // 
            // saveRecipeButton
            // 
            this.saveRecipeButton.BackColor = System.Drawing.Color.Silver;
            this.saveRecipeButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.saveRecipeButton.Location = new System.Drawing.Point(30, 420);
            this.saveRecipeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveRecipeButton.Name = "saveRecipeButton";
            this.saveRecipeButton.Size = new System.Drawing.Size(265, 45);
            this.saveRecipeButton.TabIndex = 18;
            this.saveRecipeButton.Text = "Save Recipe!";
            this.saveRecipeButton.UseVisualStyleBackColor = false;
            this.saveRecipeButton.Click += new System.EventHandler(this.saveRecipeButton_Click);
            // 
            // addRecipeItemButton
            // 
            this.addRecipeItemButton.BackColor = System.Drawing.Color.Silver;
            this.addRecipeItemButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.addRecipeItemButton.Location = new System.Drawing.Point(224, 253);
            this.addRecipeItemButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addRecipeItemButton.Name = "addRecipeItemButton";
            this.addRecipeItemButton.Size = new System.Drawing.Size(75, 23);
            this.addRecipeItemButton.TabIndex = 19;
            this.addRecipeItemButton.Text = "Add Item";
            this.addRecipeItemButton.UseVisualStyleBackColor = false;
            this.addRecipeItemButton.Click += new System.EventHandler(this.addRecipeItemButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rage Italic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(12, -1);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 34);
            this.label5.TabIndex = 20;
            this.label5.Text = "Create New Recipe";
            // 
            // newRecipeItemLB
            // 
            this.newRecipeItemLB.FormattingEnabled = true;
            this.newRecipeItemLB.Location = new System.Drawing.Point(32, 295);
            this.newRecipeItemLB.Name = "newRecipeItemLB";
            this.newRecipeItemLB.Size = new System.Drawing.Size(187, 108);
            this.newRecipeItemLB.TabIndex = 21;
            // 
            // NewRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(322, 506);
            this.Controls.Add(this.newRecipeItemLB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addRecipeItemButton);
            this.Controls.Add(this.saveRecipeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantity1);
            this.Controls.Add(this.ingredient1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recipeNameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newRecipeDescriptionTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewRecipeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newRecipeDescriptionTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox recipeNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ingredient1;
        private System.Windows.Forms.TextBox quantity1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveRecipeButton;
        private System.Windows.Forms.Button addRecipeItemButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox newRecipeItemLB;
    }
}