
namespace SmartPantry
{
    partial class ShoppingForm
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
            this.shoppingList = new System.Windows.Forms.ListBox();
            this.newShoppingItemButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.boughtAndClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shoppingList
            // 
            this.shoppingList.FormattingEnabled = true;
            this.shoppingList.Location = new System.Drawing.Point(30, 54);
            this.shoppingList.Name = "shoppingList";
            this.shoppingList.Size = new System.Drawing.Size(268, 368);
            this.shoppingList.TabIndex = 0;
            // 
            // newShoppingItemButton
            // 
            this.newShoppingItemButton.BackColor = System.Drawing.Color.Silver;
            this.newShoppingItemButton.Location = new System.Drawing.Point(167, 428);
            this.newShoppingItemButton.Name = "newShoppingItemButton";
            this.newShoppingItemButton.Size = new System.Drawing.Size(131, 42);
            this.newShoppingItemButton.TabIndex = 2;
            this.newShoppingItemButton.Text = "New Shopping Item";
            this.newShoppingItemButton.UseVisualStyleBackColor = false;
            this.newShoppingItemButton.Click += new System.EventHandler(this.newShoppingItemButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rage Italic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(24, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shopping List";
            // 
            // boughtAndClear
            // 
            this.boughtAndClear.Location = new System.Drawing.Point(32, 429);
            this.boughtAndClear.Name = "boughtAndClear";
            this.boughtAndClear.Size = new System.Drawing.Size(129, 38);
            this.boughtAndClear.TabIndex = 4;
            this.boughtAndClear.Text = "Purchase Items";
            this.boughtAndClear.UseVisualStyleBackColor = true;
            this.boughtAndClear.Click += new System.EventHandler(this.boughtAndClear_Click);
            // 
            // ShoppingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(330, 479);
            this.Controls.Add(this.boughtAndClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newShoppingItemButton);
            this.Controls.Add(this.shoppingList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ShoppingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox shoppingList;
        private System.Windows.Forms.Button newShoppingItemButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boughtAndClear;
    }
}