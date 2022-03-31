
namespace SmartPantry
{
    partial class CookedForm
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
            this.cookedRecipeList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cookedNewRecipeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectRecipe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cookedRecipeList
            // 
            this.cookedRecipeList.BackColor = System.Drawing.SystemColors.Window;
            this.cookedRecipeList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cookedRecipeList.FormattingEnabled = true;
            this.cookedRecipeList.Location = new System.Drawing.Point(24, 76);
            this.cookedRecipeList.Name = "cookedRecipeList";
            this.cookedRecipeList.Size = new System.Drawing.Size(253, 329);
            this.cookedRecipeList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Which Recipe You Crafted:";
            // 
            // cookedNewRecipeButton
            // 
            this.cookedNewRecipeButton.BackColor = System.Drawing.Color.Silver;
            this.cookedNewRecipeButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cookedNewRecipeButton.Location = new System.Drawing.Point(162, 409);
            this.cookedNewRecipeButton.Name = "cookedNewRecipeButton";
            this.cookedNewRecipeButton.Size = new System.Drawing.Size(114, 40);
            this.cookedNewRecipeButton.TabIndex = 2;
            this.cookedNewRecipeButton.Text = "New Recipe";
            this.cookedNewRecipeButton.UseVisualStyleBackColor = false;
            this.cookedNewRecipeButton.Click += new System.EventHandler(this.cookedNewRecipeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rage Italic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(18, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 43);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cooked Recipe";
            // 
            // SelectRecipe
            // 
            this.SelectRecipe.BackColor = System.Drawing.Color.Silver;
            this.SelectRecipe.Location = new System.Drawing.Point(25, 409);
            this.SelectRecipe.Margin = new System.Windows.Forms.Padding(2);
            this.SelectRecipe.Name = "SelectRecipe";
            this.SelectRecipe.Size = new System.Drawing.Size(112, 40);
            this.SelectRecipe.TabIndex = 6;
            this.SelectRecipe.Text = "Select Recipe";
            this.SelectRecipe.UseVisualStyleBackColor = false;
            this.SelectRecipe.Click += new System.EventHandler(this.SelectRecipe_Click);
            // 
            // CookedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(302, 470);
            this.Controls.Add(this.SelectRecipe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cookedNewRecipeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cookedRecipeList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CookedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox cookedRecipeList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cookedNewRecipeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SelectRecipe;
    }
}