
namespace SmartPantry
{
    partial class Form1
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
            this.cookedButton = new System.Windows.Forms.Button();
            this.ateButton = new System.Windows.Forms.Button();
            this.shoppingButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.allFoodTab = new System.Windows.Forms.TabPage();
            this.allFoodLB = new System.Windows.Forms.ListBox();
            this.pantryTab = new System.Windows.Forms.TabPage();
            this.pantryLB = new System.Windows.Forms.ListBox();
            this.refrigeratorTab = new System.Windows.Forms.TabPage();
            this.refrigeratorLB = new System.Windows.Forms.ListBox();
            this.freezerTab = new System.Windows.Forms.TabPage();
            this.freezerLB = new System.Windows.Forms.ListBox();
            this.recipesTab = new System.Windows.Forms.TabPage();
            this.addRecipe = new System.Windows.Forms.Button();
            this.recipesLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addFoodItemButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.allFoodTab.SuspendLayout();
            this.pantryTab.SuspendLayout();
            this.refrigeratorTab.SuspendLayout();
            this.freezerTab.SuspendLayout();
            this.recipesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // cookedButton
            // 
            this.cookedButton.BackColor = System.Drawing.Color.Silver;
            this.cookedButton.Location = new System.Drawing.Point(16, 35);
            this.cookedButton.Margin = new System.Windows.Forms.Padding(2);
            this.cookedButton.Name = "cookedButton";
            this.cookedButton.Size = new System.Drawing.Size(81, 49);
            this.cookedButton.TabIndex = 0;
            this.cookedButton.Text = "I Cooked Something!";
            this.cookedButton.UseVisualStyleBackColor = false;
            this.cookedButton.Click += new System.EventHandler(this.cookedButton_Click);
            // 
            // ateButton
            // 
            this.ateButton.BackColor = System.Drawing.Color.Silver;
            this.ateButton.Location = new System.Drawing.Point(102, 35);
            this.ateButton.Margin = new System.Windows.Forms.Padding(2);
            this.ateButton.Name = "ateButton";
            this.ateButton.Size = new System.Drawing.Size(81, 49);
            this.ateButton.TabIndex = 5;
            this.ateButton.Text = "I Ate Something!";
            this.ateButton.UseVisualStyleBackColor = false;
            this.ateButton.Click += new System.EventHandler(this.ateButton_Click);
            // 
            // shoppingButton
            // 
            this.shoppingButton.BackColor = System.Drawing.Color.Silver;
            this.shoppingButton.Location = new System.Drawing.Point(188, 35);
            this.shoppingButton.Margin = new System.Windows.Forms.Padding(2);
            this.shoppingButton.Name = "shoppingButton";
            this.shoppingButton.Size = new System.Drawing.Size(81, 49);
            this.shoppingButton.TabIndex = 7;
            this.shoppingButton.Text = "Shopping List";
            this.shoppingButton.UseVisualStyleBackColor = false;
            this.shoppingButton.Click += new System.EventHandler(this.shoppingButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.allFoodTab);
            this.tabControl.Controls.Add(this.pantryTab);
            this.tabControl.Controls.Add(this.refrigeratorTab);
            this.tabControl.Controls.Add(this.freezerTab);
            this.tabControl.Controls.Add(this.recipesTab);
            this.tabControl.Location = new System.Drawing.Point(12, 88);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(262, 371);
            this.tabControl.TabIndex = 8;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // allFoodTab
            // 
            this.allFoodTab.BackColor = System.Drawing.SystemColors.Window;
            this.allFoodTab.Controls.Add(this.addFoodItemButton);
            this.allFoodTab.Controls.Add(this.allFoodLB);
            this.allFoodTab.Location = new System.Drawing.Point(4, 22);
            this.allFoodTab.Name = "allFoodTab";
            this.allFoodTab.Padding = new System.Windows.Forms.Padding(2);
            this.allFoodTab.Size = new System.Drawing.Size(254, 345);
            this.allFoodTab.TabIndex = 0;
            this.allFoodTab.Text = "All Food";
            // 
            // allFoodLB
            // 
            this.allFoodLB.BackColor = System.Drawing.SystemColors.Window;
            this.allFoodLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allFoodLB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.allFoodLB.FormattingEnabled = true;
            this.allFoodLB.Location = new System.Drawing.Point(3, 2);
            this.allFoodLB.Name = "allFoodLB";
            this.allFoodLB.Size = new System.Drawing.Size(246, 377);
            this.allFoodLB.TabIndex = 0;
            this.allFoodLB.SelectedIndexChanged += new System.EventHandler(this.allFoodLB_SelectedIndexChanged);
            // 
            // pantryTab
            // 
            this.pantryTab.BackColor = System.Drawing.SystemColors.Window;
            this.pantryTab.Controls.Add(this.pantryLB);
            this.pantryTab.Location = new System.Drawing.Point(4, 22);
            this.pantryTab.Name = "pantryTab";
            this.pantryTab.Padding = new System.Windows.Forms.Padding(2);
            this.pantryTab.Size = new System.Drawing.Size(254, 345);
            this.pantryTab.TabIndex = 1;
            this.pantryTab.Text = "Pantry";
            // 
            // pantryLB
            // 
            this.pantryLB.BackColor = System.Drawing.SystemColors.Window;
            this.pantryLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pantryLB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pantryLB.FormattingEnabled = true;
            this.pantryLB.Location = new System.Drawing.Point(5, 5);
            this.pantryLB.Name = "pantryLB";
            this.pantryLB.Size = new System.Drawing.Size(244, 377);
            this.pantryLB.TabIndex = 1;
            this.pantryLB.SelectedIndexChanged += new System.EventHandler(this.pantryLB_SelectedIndexChanged);
            // 
            // refrigeratorTab
            // 
            this.refrigeratorTab.BackColor = System.Drawing.SystemColors.Window;
            this.refrigeratorTab.Controls.Add(this.refrigeratorLB);
            this.refrigeratorTab.Location = new System.Drawing.Point(4, 22);
            this.refrigeratorTab.Name = "refrigeratorTab";
            this.refrigeratorTab.Padding = new System.Windows.Forms.Padding(2);
            this.refrigeratorTab.Size = new System.Drawing.Size(254, 345);
            this.refrigeratorTab.TabIndex = 2;
            this.refrigeratorTab.Text = "Refrigerator";
            // 
            // refrigeratorLB
            // 
            this.refrigeratorLB.BackColor = System.Drawing.SystemColors.Window;
            this.refrigeratorLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.refrigeratorLB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.refrigeratorLB.FormattingEnabled = true;
            this.refrigeratorLB.Location = new System.Drawing.Point(5, 5);
            this.refrigeratorLB.Name = "refrigeratorLB";
            this.refrigeratorLB.Size = new System.Drawing.Size(244, 377);
            this.refrigeratorLB.TabIndex = 1;
            this.refrigeratorLB.SelectedIndexChanged += new System.EventHandler(this.refrigeratorLB_SelectedIndexChanged);
            // 
            // freezerTab
            // 
            this.freezerTab.BackColor = System.Drawing.SystemColors.Window;
            this.freezerTab.Controls.Add(this.freezerLB);
            this.freezerTab.Location = new System.Drawing.Point(4, 22);
            this.freezerTab.Name = "freezerTab";
            this.freezerTab.Padding = new System.Windows.Forms.Padding(2);
            this.freezerTab.Size = new System.Drawing.Size(254, 345);
            this.freezerTab.TabIndex = 3;
            this.freezerTab.Text = "Freezer";
            // 
            // freezerLB
            // 
            this.freezerLB.BackColor = System.Drawing.SystemColors.Window;
            this.freezerLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.freezerLB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.freezerLB.FormattingEnabled = true;
            this.freezerLB.Location = new System.Drawing.Point(5, 5);
            this.freezerLB.Name = "freezerLB";
            this.freezerLB.Size = new System.Drawing.Size(244, 377);
            this.freezerLB.TabIndex = 1;
            this.freezerLB.SelectedIndexChanged += new System.EventHandler(this.freezerLB_SelectedIndexChanged);
            // 
            // recipesTab
            // 
            this.recipesTab.BackColor = System.Drawing.SystemColors.Window;
            this.recipesTab.Controls.Add(this.addRecipe);
            this.recipesTab.Controls.Add(this.recipesLB);
            this.recipesTab.Location = new System.Drawing.Point(4, 22);
            this.recipesTab.Name = "recipesTab";
            this.recipesTab.Padding = new System.Windows.Forms.Padding(2);
            this.recipesTab.Size = new System.Drawing.Size(254, 345);
            this.recipesTab.TabIndex = 4;
            this.recipesTab.Text = "Recipes";
            // 
            // addRecipe
            // 
            this.addRecipe.Location = new System.Drawing.Point(172, 14);
            this.addRecipe.Margin = new System.Windows.Forms.Padding(2);
            this.addRecipe.Name = "addRecipe";
            this.addRecipe.Size = new System.Drawing.Size(77, 25);
            this.addRecipe.TabIndex = 2;
            this.addRecipe.Text = "Add Recipe";
            this.addRecipe.UseVisualStyleBackColor = true;
            this.addRecipe.Click += new System.EventHandler(this.addRecipe_Click);
            // 
            // recipesLB
            // 
            this.recipesLB.BackColor = System.Drawing.SystemColors.Window;
            this.recipesLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recipesLB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.recipesLB.FormattingEnabled = true;
            this.recipesLB.Location = new System.Drawing.Point(5, 5);
            this.recipesLB.Name = "recipesLB";
            this.recipesLB.Size = new System.Drawing.Size(244, 377);
            this.recipesLB.TabIndex = 1;
            this.recipesLB.SelectedIndexChanged += new System.EventHandler(this.recipesLB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rage Italic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(4, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Smart Pantry";
            // 
            // addFoodItemButton
            // 
            this.addFoodItemButton.Location = new System.Drawing.Point(174, 14);
            this.addFoodItemButton.Name = "addFoodItemButton";
            this.addFoodItemButton.Size = new System.Drawing.Size(75, 25);
            this.addFoodItemButton.TabIndex = 1;
            this.addFoodItemButton.Text = "Add Item";
            this.addFoodItemButton.UseVisualStyleBackColor = true;
            this.addFoodItemButton.Click += new System.EventHandler(this.addFoodItemButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(285, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.shoppingButton);
            this.Controls.Add(this.ateButton);
            this.Controls.Add(this.cookedButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Activated += new System.EventHandler(this.isActive);
            this.tabControl.ResumeLayout(false);
            this.allFoodTab.ResumeLayout(false);
            this.pantryTab.ResumeLayout(false);
            this.refrigeratorTab.ResumeLayout(false);
            this.freezerTab.ResumeLayout(false);
            this.recipesTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cookedButton;
        private System.Windows.Forms.Button ateButton;
        private System.Windows.Forms.Button shoppingButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage allFoodTab;
        private System.Windows.Forms.TabPage pantryTab;
        private System.Windows.Forms.TabPage refrigeratorTab;
        private System.Windows.Forms.TabPage freezerTab;
        private System.Windows.Forms.TabPage recipesTab;
        private System.Windows.Forms.ListBox allFoodLB;
        private System.Windows.Forms.ListBox pantryLB;
        private System.Windows.Forms.ListBox refrigeratorLB;
        private System.Windows.Forms.ListBox freezerLB;
        private System.Windows.Forms.ListBox recipesLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addRecipe;
        private System.Windows.Forms.Button addFoodItemButton;
    }
}

